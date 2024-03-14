using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http;
// NOTE: this is all three of my services stemming, natural hazard and sudoku combined

namespace Pokemon
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        // Method to get data for a specific Pokémon by its name

        private static readonly Random random = new Random();
        //generate a random pokemon by their ID from 1 to 899
        public int GetRandomPokemonId()
        {
            return random.Next(1, 899);
        }
        public string GetPokemonImageUrl(int pokemonIndex)
        {
            return $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{pokemonIndex}.png";
        }

        public string GetPokemonInfo(int pokemonId)
        {
            try
            {
                // Construct the API request URL with the provided Pokémon ID
                string apiUrl = $"https://pokeapi.co/api/v2/pokemon/{pokemonId}";

                // Make an HTTP GET request to the Pokémon API
                using (var client = new WebClient())
                {
                    // Perform the HTTP GET request and store the response in a string
                    string responseJson = client.DownloadString(apiUrl);

                    // Parse the JSON response
                    JObject pokemonData = JObject.Parse(responseJson);

                    // Extract the desired information about the Pokémon (e.g., name, height, weight)
                    string pokemonName = pokemonData["name"].ToString();
                    int height = int.Parse(pokemonData["height"].ToString());
                    int weight = int.Parse(pokemonData["weight"].ToString());

                    // Return the information about the Pokémon including its ID
                    return $"Name: {pokemonName}, Height: {height}, Weight: {weight}, ID: {pokemonId}";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
        public string GetSudokuPuzzle()
        {
            string apiUrl = "https://sudoku-game-and-api.netlify.app/api/sudoku";

            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync(apiUrl).Result;
                    response.EnsureSuccessStatusCode(); // Throw on error code.

                    return response.Content.ReadAsStringAsync().Result;
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Request error: {e.Message}");
                    return null;
                }
            }
        }
        private string GetMatrixString(JToken matrixToken)
        {
            // Convert the matrix token to a 2D array
            int[][] matrix = matrixToken.ToObject<int[][]>();

            // Convert the 2D array to a string representation
            string matrixString = "[" + string.Join(",", matrix.Select(row => $"[{string.Join(",", row)}]")) + "]";

            return matrixString;
        }
        public string[] GetMatrices(string jsonString, int difficulty)
        {
            // Parse the JSON string
            JObject jsonObject = JObject.Parse(jsonString);

            // Initialize string arrays to store the matrices
            string[] matrices = new string[2];

            // Extract the matrices based on the difficulty level
            switch (difficulty)
            {
                case 1: // Easy
                    matrices[0] = GetMatrixString(jsonObject["data"]);
                    matrices[1] = GetMatrixString(jsonObject["easy"]);
                    break;
                case 2: // Medium
                    matrices[0] = GetMatrixString(jsonObject["data"]);
                    matrices[1] = GetMatrixString(jsonObject["medium"]);
                    break;
                case 3: // Hard
                    matrices[0] = GetMatrixString(jsonObject["data"]);
                    matrices[1] = GetMatrixString(jsonObject["hard"]);
                    break;
                default:
                    // Invalid difficulty level
                    break;
            }

            return matrices;
        }
        public string[] ParseStringToArray(string input)
        {
            // Remove the outer brackets
            input = input.Trim('[', ']');

            // Split the string by commas
            string[] numbers = input.Split(',');

            // Remove any non-digit characters from each number and store them in the result array
            string[] result = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = Regex.Replace(numbers[i], "[^0-9]", "");
            }

            return result;
        }
        public string ArrayToString(string[] array)
        {
            if (array == null)
            {
                return null;
            }

            return string.Join(",", array);
        }
        public string FormatSudoku(string sudokuString)
        {
            // Validate input string length
            if (sudokuString.Length != 81)
            {
                throw new ArgumentException("Input string must have exactly 81 characters");
            }

            // Initialize a StringBuilder to construct the formatted Sudoku string
            StringBuilder formattedSudoku = new StringBuilder();

            // Iterate over the characters of the input string
            for (int i = 0; i < 81; i++)
            {
                // Append the character to the formatted string
                formattedSudoku.Append(sudokuString[i]);

                // Add line breaks to separate rows
                if ((i + 1) % 9 == 0)
                {
                    formattedSudoku.AppendLine();
                }
                else
                {
                    // Add space between every 3 characters to separate columns within a row
                    if ((i + 1) % 3 == 0)
                    {
                        formattedSudoku.Append(" ");
                    }
                }
            }

            // Return the formatted Sudoku string
            return formattedSudoku.ToString();
        }
        public string StemText(string textToStem)
        {
            // Build the data to be sent in the POST request
            string postData = $"text={WebUtility.UrlEncode(textToStem)}";

            // Specify the URL of the API endpoint
            string apiUrl = "http://text-processing.com/api/stem/";

            // Create a WebClient instance to send the POST request
            using (var client = new WebClient())
            {
                // Set the content type for form-urlencoded data
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

                try
                {
                    // Send the POST request and receive the response
                    byte[] responseBytes = client.UploadData(apiUrl, Encoding.UTF8.GetBytes(postData));
                    string responseJson = Encoding.UTF8.GetString(responseBytes);

                    // Parse the JSON response
                    dynamic jsonResponse = Newtonsoft.Json.JsonConvert.DeserializeObject(responseJson);

                    // Get the stemmed text from the response
                    string stemmedText = jsonResponse.text;

                    return stemmedText;
                }
                catch (WebException ex)
                {
                    // Handle any exceptions
                    return $"Error: {ex.Message}";
                }
            }
        }
    }
}
