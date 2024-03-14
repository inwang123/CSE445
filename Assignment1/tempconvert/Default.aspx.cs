using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tempconvert
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CtoF(object sender, EventArgs e)
        {
            TempService.Service1Client piService = new TempService.Service1Client("BasicHttpBinding_IService1");
            String cInput = cBox.Text;

            if (String.IsNullOrWhiteSpace(cInput))
            {

                c2fResult.Text = "No input";
                return;

            }
            if (!String.IsNullOrWhiteSpace(cInput))
            {
                int myInt;

                if (int.TryParse(cInput, out myInt))
                {
                    int Farenheit = piService.c2f(Convert.ToInt32(Math.Round(Double.Parse(cInput))));
                    c2fResult.Text = Farenheit.ToString() + " F";

                }
                else
                {
                    c2fResult.Text = "Incorrect Format";
                }

            }

        }

        protected void FtoC(object sender, EventArgs e)
        {
            TempService.Service1Client piService = new TempService.Service1Client("BasicHttpBinding_IService1");
            String fInput = fBox.Text;

            //Make sure first that there is an input, if not then say no input
            if (!String.IsNullOrWhiteSpace(fInput))
                if (String.IsNullOrWhiteSpace(fInput))
                {

                    f2cResult.Text = "No input";
                    return;
                }
            //Proceed if there is an input
            if (!String.IsNullOrWhiteSpace(fInput))
            {
                int myInt;
                //Make sure that the string can be turned into an integer first
                if (int.TryParse(fInput, out myInt))
                {

                    //Turn the input into integer to manipulate it into celsius
                    int Celsius = piService.f2c(Convert.ToInt32(Math.Round(Double.Parse(fInput))));
                    //Turn the result back into a string to be displayed
                    f2cResult.Text = Celsius.ToString() + " C";

                }
                else
                {
                    f2cResult.Text = "Incorrect Format";
                }

            }

        }
        protected void sortItems(object sender, EventArgs e)
        {

            TempService.Service1Client piService = new TempService.Service1Client("BasicHttpBinding_IService1");
            errBox.Text = "";

                //First check to see if input is empty
                if (String.IsNullOrWhiteSpace(sortBox.Text))
                {
                    errBox.Text = "No input";
                    return; //exit early if it is empty
                }

                String input3 = sortBox.Text;
                
                if (!String.IsNullOrWhiteSpace(input3))
                {
                //Sort it using service
                    String sorted = piService.sort(input3);
                
                //if the input was not in the correct format, service will return "naw"
                if (sorted.Equals("naw"))
                {
                    errBox.Text = "Incorrect Format";
                }
                else //otherwise we will reset the textbox into the sorted version of the floats
                {
                    errBox.Text = sorted;
                }
  
 
                }
        

        }
    }
}