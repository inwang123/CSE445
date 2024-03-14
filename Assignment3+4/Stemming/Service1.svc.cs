using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Stemming
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
      
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
