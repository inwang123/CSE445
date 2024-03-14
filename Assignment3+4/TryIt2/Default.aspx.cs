using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace TryIt2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //about page
        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            StemService.Service1Client stemService = new StemService.Service1Client();
            string s = inputBox.Text;
            TextBox2.Text = stemService.StemText(s);
           


        }
        //about
        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            PokeService.Service1Client pokeService = new PokeService.Service1Client();

            int pokeID = pokeService.GetRandomPokemonId();
            string pokeInfo = pokeService.GetPokemonInfo(pokeID);
            string pokeUrl = pokeService.GetPokemonImageUrl(pokeID);
            PokeBall.ImageUrl = pokeUrl;

            resultLabel.Text = pokeInfo;
        }

        public void SetTextBoxes(string[] str)
        {
            if (str.Length != 81)
            {
                // Ensure the input array has exactly 81 elements
                throw new ArgumentException("Input array must have exactly 81 elements");
            }

            // Assuming t1 to t81 are the IDs of your TextBox controls
            TextBox[] textBoxes = new TextBox[81]
            {
        t1, t2, t3, t4, t5, t6, t7, t8, t9,
        t10, t11, t12, t13, t14, t15, t16, t17, t18,
        t19, t20, t21, t22, t23, t24, t25, t26, t27,
        t28, t29, t30, t31, t32, t33, t34, t35, t36,
        t37, t38, t39, t40, t41, t42, t43, t44, t45,
        t46, t47, t48, t49, t50, t51, t52, t53, t54,
        t55, t56, t57, t58, t59, t60, t61, t62, t63,
        t64, t65, t66, t67, t68, t69, t70, t71, t72,
        t73, t74, t75, t76, t77, t78, t79, t80, t81
            };

            for (int i = 0; i < 81; i++)
            {
                textBoxes[i].Text = str[i];
                textBoxes[i].ForeColor = Color.Black;
            }
        }
        public string[] GetTextBoxValues()
        {
            string[] values = new string[81];

            // Assuming t1 to t81 are the IDs of your TextBox controls
            TextBox[] textBoxes = new TextBox[81]
            {
        t1, t2, t3, t4, t5, t6, t7, t8, t9,
        t10, t11, t12, t13, t14, t15, t16, t17, t18,
        t19, t20, t21, t22, t23, t24, t25, t26, t27,
        t28, t29, t30, t31, t32, t33, t34, t35, t36,
        t37, t38, t39, t40, t41, t42, t43, t44, t45,
        t46, t47, t48, t49, t50, t51, t52, t53, t54,
        t55, t56, t57, t58, t59, t60, t61, t62, t63,
        t64, t65, t66, t67, t68, t69, t70, t71, t72,
        t73, t74, t75, t76, t77, t78, t79, t80, t81
            };

            for (int i = 0; i < 81; i++)
            {
                values[i] = textBoxes[i].Text;
            }

            return values;
        }
        public void HighlightDifferentValues(string[] array1, string[] array2)
        {
            // Check if both arrays are null or have length not equal to 81
            if (array1 == null || array2 == null || array1.Length != 81 || array2.Length != 81)
            {
                // Log or handle the error accordingly
                return;
            }

            // Assuming t1 to t81 are the IDs of your TextBox controls
            TextBox[] textBoxes = new TextBox[81]
            {
        t1, t2, t3, t4, t5, t6, t7, t8, t9,
        t10, t11, t12, t13, t14, t15, t16, t17, t18,
        t19, t20, t21, t22, t23, t24, t25, t26, t27,
        t28, t29, t30, t31, t32, t33, t34, t35, t36,
        t37, t38, t39, t40, t41, t42, t43, t44, t45,
        t46, t47, t48, t49, t50, t51, t52, t53, t54,
        t55, t56, t57, t58, t59, t60, t61, t62, t63,
        t64, t65, t66, t67, t68, t69, t70, t71, t72,
        t73, t74, t75, t76, t77, t78, t79, t80, t81
            };

            for (int i = 0; i < 81; i++)
            {
                if (array1[i] == array2[i])
                {
                    textBoxes[i].ForeColor = System.Drawing.Color.Black;
                }
                else if (array1[i] != "0")
                {
                    textBoxes[i].ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        protected void SudokuButton_Click(object sender, EventArgs e)
        {

            SudokuService.Service1Client sudokuService = new SudokuService.Service1Client();
            string puzzle = sudokuService.GetSudokuPuzzle();

            int difficulty = 0;
            if (RadioButton1.Checked)
            {
                difficulty = 1;
            }
            else if (RadioButton2.Checked)
            {
                difficulty = 2;
            }
            else if (RadioButton3.Checked)
            {
                difficulty = 3;
            }
            else
            {
                // None of the radio buttons are selected, handle this scenario if needed
            }

            // Only proceed if a radio button is selected
            if (difficulty != 0)
            {
                //take randomly generated numbers from API for sudoku
                string[] matrices = sudokuService.GetMatrices(puzzle, difficulty);


                string result = matrices[0];
                string challenge = matrices[1];

                //parse it into the answer array and challenge array
                string[] rArr = sudokuService.ParseStringToArray(result);
                string[] cArr = sudokuService.ParseStringToArray(challenge);

                //set the boxes to the challenge
                SetTextBoxes(cArr);
                //store the answer
                resultHolder.ForeColor = Color.White;
                resultHolder.Text = sudokuService.ArrayToString(rArr);
            }

        }

        protected void Unnamed3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click1(object sender, EventArgs e)
        {
            //make incorrect values red
            SudokuService.Service1Client sudokuService = new SudokuService.Service1Client();
            string[] rArr = sudokuService.ParseStringToArray(resultHolder.Text);
            string[] currentArr = GetTextBoxValues();
            HighlightDifferentValues(currentArr, rArr);

        }

        protected void AnswerButton_Click(object sender, EventArgs e)
        {
            //show the correct answers if selected
            SudokuService.Service1Client sudokuService = new SudokuService.Service1Client();
            string[] answer = sudokuService.ParseStringToArray(resultHolder.Text);
            SetTextBoxes(answer);


        }
        //contact

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


        protected void Unnamed5_Click1(object sender, EventArgs e)
        {
            Response.Redirect("http://webstrar101.fulton.asu.edu/index.html");
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

        protected void Unnamed5_Click2(object sender, EventArgs e)
        {
            Response.Redirect("http://webstrar101.fulton.asu.edu/index.html");
        }
    }
}