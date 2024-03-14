using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        //Converts celsius to farenheit
        public int c2f(int c)
        {
            double x = (32 + (c * 9d / 5));
            return Convert.ToInt32(Math.Round(x)); 
        }

        //converts farenheit to celsius
        public int f2c(int f)
        {
            double y = ((f - 32) * 5d / 9);
            return Convert.ToInt32(Math.Round(y));
        }
        //Sorts the floats from smallest to largest, with comma between each number
        public string sort(string s)
        {
            float f = 0;
            String data = s;
            //try to see if the array can be converted to a float array
            try
            {   
                float[] floatData = Array.ConvertAll(data.Split(' '), float.Parse);
                float temp = 0;

                //sort the float array so it's smallest to largest
                for (int i = 0; i < floatData.Length; i++)
                {

                    for (int j = 0; j < i; j++)
                    {

                        if (floatData[j] > floatData[i])
                        {
                            temp = floatData[i];
                            floatData[i] = floatData[j];
                            floatData[j] = temp;

                        }

                    }
                }

                //Convert it back into a string to be returned
                String sorted = "";
                for (int i = 0; i < floatData.Length; i++)
                {

                    sorted += floatData[i].ToString() + ",";


                }
                //get rid of the last comma
                sorted = sorted.TrimEnd(sorted[sorted.Length - 1]);
                return sorted;
            }
            catch (Exception e) //in the case which there is an exception, return naw
            {

                return "naw";

            }

        }
    }
}
