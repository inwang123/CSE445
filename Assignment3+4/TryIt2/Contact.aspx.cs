using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TryIt2
{
    public partial class Contact : Page
    {

        public int CountDisasters(string input)
        {
            // Split the input string by the word "State"
            string[] parts = input.Split(new string[] { "State: " }, StringSplitOptions.RemoveEmptyEntries);

            // The number of occurrences of "State" determines the number of disasters
            return parts.Length - 1;
        }
        public class DisasterInfo
        {
            public string DeclarationTitle { get; set; }
            public string State { get; set; }
            public int DisasterNumber { get; set; }
            public DateTime DeclarationDate { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            try
            {
                // Access the input state from the textbox
                string state = StateBox.Text.Trim().ToUpper();

                string baseUrl = "http://webstrar101.fulton.asu.edu/page1/Service1.svc/"; // Base URL of the service

                // Construct the endpoint URL with the state parameter
                string serviceUrl = $"{baseUrl}StateValue?state={state}";

                // Create a WebClient instance to perform the HTTP GET request
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.Accept] = "application/json";
                    // Perform the HTTP GET request and store the response in a string
                    string responseJson = client.DownloadString(serviceUrl);

                    // Log the JSON response
                    Console.WriteLine(responseJson);

                    // Parse the JSON response and set the text of the OutputLabel
                    OutputLabel.Text = responseJson;

                    countLabel.Text = CountDisasters(responseJson).ToString();

                }
            }
            catch (WebException ex)
            {
                // Handle web exceptions (e.g., network issues, server errors)
                Response.StatusCode = 500;
                Response.StatusDescription = "Internal Server Error";
                Response.Write($"Error accessing the service: {ex.Message}");
                Response.End();
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Response.StatusCode = 500;
                Response.StatusDescription = "Internal Server Error";
                Response.Write($"An error occurred: {ex.Message}");
                Response.End();
            }



        }
    }
}
