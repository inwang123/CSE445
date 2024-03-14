using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml.Linq;

namespace NaturalHazard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 {    
        public string StateValue(string state)
        {
            try
            {
                // Base URL for the OpenFEMA API
                string baseUrl = "https://www.fema.gov/api/open/v2/DisasterDeclarationsSummaries";

                // Construct the request parameters including filtering by state and specifying JSON format
                string requestParameters = $"?$filter=state eq '{state.ToUpper()}'&$format=json";

                // Combine the base URL and request parameters to form the full URL
                string fullUrl = baseUrl + requestParameters;

                // Create a WebClient instance to perform the HTTP GET request
                using (var client = new WebClient())
                {
                    // Set the Accept header to indicate JSON response
                    client.Headers[HttpRequestHeader.Accept] = "application/json";

                    // Perform the HTTP GET request and store the response in a string
                    string responseJson = client.DownloadString(fullUrl);

                    // Return the raw JSON string
                    return ParseDisasters(responseJson);
                }
            }
            catch (WebException ex)
            {
                // Handle web exceptions (e.g., network issues, server errors)
                Console.WriteLine($"Error accessing the OpenFEMA API: {ex.Message}");
                return null;
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
        public int CountLines(string formattedString)
        {
            string[] lines = formattedString.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            return lines.Length;
        }

        public class DisasterInfo
        {
            public string DeclarationTitle { get; set; }
            public string State { get; set; }
            public int DisasterNumber { get; set; }
            public DateTime DeclarationDate { get; set; }
        }
        public string ParseDisasters(string jsonString)
        {
            StringBuilder formattedString = new StringBuilder();
            HashSet<int> seenDisasterNumbers = new HashSet<int>(); // HashSet to store seen disaster numbers

            JObject jsonObject = JObject.Parse(jsonString);
            JArray disasterArray = (JArray)jsonObject["DisasterDeclarationsSummaries"];

            foreach (JToken token in disasterArray)
            {
                DisasterInfo info = token.ToObject<DisasterInfo>();
                if (!seenDisasterNumbers.Contains(info.DisasterNumber)) // Check if the disaster number is not already seen
                {
                    formattedString.AppendLine($"Declaration Title: {info.DeclarationTitle}, State: {info.State}, Disaster Number: {info.DisasterNumber}, Declaration Date: {info.DeclarationDate.ToShortDateString()}<br>");
                    seenDisasterNumbers.Add(info.DisasterNumber); // Add the disaster number to the set
                }
            }

            return formattedString.ToString();
        }


    }
}

