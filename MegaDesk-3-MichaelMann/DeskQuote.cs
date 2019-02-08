using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MegaDesk_3_MichaelMann
{
    class DeskQuote
    {
        #region Object member variables
        public string SelectedCustomerName;
        public DateTime QuoteDate;
        public Desk QuotedDesk = new Desk();
        public int SelectedBuildOption;
        public int CalculatedSurfaceArea;
        public int QuotedFinalCost;
        #endregion

        #region constants
        private const int BASE_COST = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int DRAWER_COST = 50;
        #endregion

        //Array of shipping options
        public static List<int> BuildingOptionsList = new List<int> { 3, 5, 7, 14 };

        //Constructor
        public DeskQuote(int width, int depth, int countDrawer, string material, int buildOption, string customerName)
        {
            //Initializing properties 
            QuotedDesk.Width = width;
            QuotedDesk.Depth = depth;
            QuotedDesk.CountDrawer = countDrawer;
            QuotedDesk.SurfaceMaterial = material;
            SelectedBuildOption = buildOption;
            CalculatedSurfaceArea = CalcSurfaceArea();
            SelectedCustomerName = customerName;
            QuoteDate = DateTime.Now;
            
        }

        public void SaveQuote(string json)
        {
            try
            {
                string jsonOutput;

                //make empty JSON Object
                var initialJson = "[]";

                //check if file exists
                if (File.Exists(@"quotes.json"))
                {
                    //set initialJson to the text within the file
                    initialJson = System.IO.File.ReadAllText(@"quotes.json");
                }

                //parses file contents to a JArray named "array"
                var array = JArray.Parse(initialJson);

                //Parses and adds new quote "json" to JArray
                var quoteToAdd = JObject.Parse(json);
                array.Add(quoteToAdd);

                //Serializes the object to JSON
                jsonOutput = JsonConvert.SerializeObject(array, Formatting.Indented);


                //Writes to Json for output
                using (StreamWriter sw = File.CreateText(@"quotes.json"))
                {
                    sw.WriteLine(jsonOutput);
                }

                //format a string to display in form
                string displayString = "Date: " + QuoteDate;
                displayString += "\nName: " + SelectedCustomerName;
                displayString += "\nWidth: " + QuotedDesk.Width;
                displayString += "\nDepth: " + QuotedDesk.Depth;
                displayString += "\n# of Drawers: " + QuotedDesk.CountDrawer;
                displayString += "\nMaterial: " + QuotedDesk.SurfaceMaterial;
                displayString += "\nBuild Time: " + SelectedBuildOption + " days";
                displayString += "\nYour MegaDesk price quote is : $" + this.QuotedFinalCost + "!";

                //Display the form with the formatted string
                System.Windows.Forms.MessageBox.Show(@"You successfully saved your quote!" + "\n" + displayString);
            }
            catch(Exception ex)
            {
                //Display a window because the quote failed to save
                System.Windows.Forms.MessageBox.Show(@"Failed to save quote:" + "\n" + ex.Message);
            }

        }

        public int CalcFinalQuote()
        {
            //calculates the final quote 
            int finalQuote = 0;
            int baseMaterialCost = CalcBaseMaterialCost();
            int drawerCost = CalcDrawerCost();
            int shippingCost = CalcShippingCost();

            //formula for calculating final quote
            finalQuote = baseMaterialCost + drawerCost + shippingCost;

            //save the final quote in a public string
            this.QuotedFinalCost = finalQuote;

            return finalQuote;
        }

        private int CalcSurfaceArea()
        {
            //calculate the surface area of the desk 
            return QuotedDesk.Width * QuotedDesk.Depth;
        }

        private int CalcDrawerCost()
        {
            //calculate the drawer cost of the desk
            return QuotedDesk.CountDrawer * DRAWER_COST;
        }

        private int CalcShippingCost()
        {
            /*calculate the shipping cost according to design below. 
                Costs per design requirements
                a.  3 days and less than 1000 sq. in.: $60
                b.  3 days and between 1000 sq. in. and 2000 sq. in.: $70
                c.  3 days and greater than 2000 sq. in.: $80
                d.  5 days and less than 1000 sq. in.: $40
                e.  5 days and between 1000 sq. in. and 2000 sq. in.: $50
                f.  5 days and greater than 2000 sq. in.: $60
                g.  7 days and less than 1000 sq. in.: $30
                h.  7 days and between 1000 sq. in. and 2000 sq. in.: $35
                i.  7 days and greater than 2000 sq. in.: $40
            */

            int shippingCost = 0;

            //These details will need to be filled out with a text file per week 5 assignment. 
            switch (SelectedBuildOption)
            {
                case 3:
                    if (CalculatedSurfaceArea < 1000)
                    {
                        shippingCost = 60;
                    }
                    else if (CalculatedSurfaceArea >= 1000 && CalculatedSurfaceArea <= 2000)
                    {
                        shippingCost = 70;
                    }
                    else if (CalculatedSurfaceArea > 2000)
                    {
                        shippingCost = 80;
                    }
                        break;
                case 5:
                    if (CalculatedSurfaceArea < 1000)
                    {
                        shippingCost = 40;
                    }
                    else if (CalculatedSurfaceArea >= 1000 && CalculatedSurfaceArea <= 2000)
                    {
                        shippingCost = 50;
                    }
                    else if (CalculatedSurfaceArea > 2000)
                    {
                        shippingCost = 60;
                    }
                    break;
                case 7:
                    if (CalculatedSurfaceArea < 1000)
                    {
                        shippingCost = 30;
                    }
                    else if (CalculatedSurfaceArea >= 1000 && CalculatedSurfaceArea <= 2000)
                    {
                        shippingCost = 35;
                    }
                    else if (CalculatedSurfaceArea > 2000)
                    {
                        shippingCost = 40;
                    }
                    break;
                default:
                    break;
            }

            return shippingCost;
        }

        private int CalcBaseMaterialCost()
        {
            //calculate the material cost of the desk
            int surfaceMaterialCost = 0;

            //costs based on design doc
            switch (QuotedDesk.SurfaceMaterial)
            {
                case "Oak":
                    surfaceMaterialCost = 200;
                    break;
                case "Laminate":
                    surfaceMaterialCost = 100;
                    break;
                case "Pine":
                    surfaceMaterialCost = 50;
                    break;
                case "Rosewood":
                    surfaceMaterialCost = 300;
                    break;
                case "Veneer":
                    surfaceMaterialCost = 125;
                    break;
            }

            //calculate the "large item" extra cost
            if (CalcSurfaceArea() > SIZE_THRESHOLD)
            {
                surfaceMaterialCost += CalcSurfaceArea() - SIZE_THRESHOLD;
            }

            //calculate and return the base material cost
            return BASE_COST + surfaceMaterialCost;
        }
    }
}



