using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ivy_s_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        //Action event for the addition button on the calculator
        private void Add(object sender, EventArgs e)
        {
            //Make sure there is an input
            if(!String.IsNullOrWhiteSpace(mathInput1.Text) && !String.IsNullOrWhiteSpace(mathInput2.Text))
            {
                //convert it to a float from a string
                float a = (float) Convert.ToDouble(mathInput1.Text);
                float b = (float)Convert.ToDouble(mathInput2.Text);
                //perform calculation
                float c = a + b;
                //turn it back to a string and display result
                mathResult.Text = c.ToString();


            }
        }

        //action event for subtraction button
        private void Sub(object sender, EventArgs e)
        {  
            //Make sure there is an input
            if (!String.IsNullOrWhiteSpace(mathInput1.Text) && !String.IsNullOrWhiteSpace(mathInput2.Text))
            {
                //convert it to a float from a string
                float a = (float)Convert.ToDouble(mathInput1.Text);
                float b = (float)Convert.ToDouble(mathInput2.Text);
                //perform calculation
                float c = a - b;
                //turn it back to a string and display result
                mathResult.Text = c.ToString();


            }
        }
        //action event for multiplication button
        private void Mult(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(mathInput1.Text) && !String.IsNullOrWhiteSpace(mathInput2.Text))
            {
                //convert it to a float from a string
                float a = (float)Convert.ToDouble(mathInput1.Text);
                float b = (float)Convert.ToDouble(mathInput2.Text);
                //perform calculation
                float c = a * b;
                //turn it back to a string and display result
                mathResult.Text = c.ToString();


            }
        }
        //action event for division button
        private void Div(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(mathInput1.Text)  && !String.IsNullOrWhiteSpace(mathInput2.Text))
            {
                //convert it to a float from a string
                float a = (float)Convert.ToDouble(mathInput1.Text);
                float b = (float)Convert.ToDouble(mathInput2.Text);
                //perform calculation
                float c = a/b;
                //turn it back to a string and display result
                mathResult.Text = c.ToString();


            }
        }
        //swap inputs for calulator between first and second textbox
        private void Switch(object sender, EventArgs e)
        {
            String s = "";
            s += mathInput1.Text;
            mathInput1.Text = mathInput2.Text;
            mathInput2.Text = s;

        }

        //Encrypt a message from textbox
        private void Encrypt(object sender, EventArgs e)
        {


            EncryptionService.ServiceClient encryptionService = new EncryptionService.ServiceClient("BasicHttpsBinding_IService1");

            try
            { 
                //make sure there is an input
                if (!String.IsNullOrWhiteSpace(encryptInput.Text))
                {

                    //call to service to encrypt the string and set the label to display the value
                    String s = encryptionService.Encrypt(encryptInput.Text);
                    encryptResult.Text = s;

                }
                else
                {
                    encryptResult.Text = "No input";

                }
            }
            catch (Exception except){
                //if there is an error show it at the error label
                encryptResult.Text = except.Message.ToString();
            }
        }
        //decrypt the message from the textbox
        private void Decrypt(object sender, EventArgs e)
        {

            EncryptionService.ServiceClient encryptionService = new EncryptionService.ServiceClient("BasicHttpsBinding_IService1");

            try //see if it will throw any errors
            {
                //check to make sure there is input
                if (decryptInput.Text != null && !String.IsNullOrWhiteSpace(decryptInput.Text))
                {


                    String s = encryptionService.Decrypt(decryptInput.Text);
                    decryptResult.Text = s;

                }
                else
                {
                    decryptResult.Text = "No input";

                }

            }
            catch (Exception except) //if the message cannot be decrypted it is incorrect
            {

                decryptResult.Text = "Incorrect Encrypted Message";

            }
           
        }

    }
}
