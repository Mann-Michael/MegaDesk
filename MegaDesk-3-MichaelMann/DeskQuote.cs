using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MichaelMann
{
    class DeskQuote
    {
        #region Object member variables
        private string selectedCustomerName;
        private DateTime quoteDate;
        private Desk newDesk = new Desk();
        private int selectedBuildOption;
        private int calculatedSurfaceArea;
        #endregion

        #region constants
        private const int BASE_COST = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int DRAWER_COST = 50;
        #endregion

        public static List<int> ShippingOptionsList = new List<int> { 3, 5, 7, 14 };

        public DeskQuote(int width, int depth, int countDrawer, string material, int buildOption, string customerName)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
            newDesk.CountDrawer = countDrawer;
            newDesk.SurfaceMaterial = material;
            selectedBuildOption = buildOption;
            calculatedSurfaceArea = CalcSurfaceArea();
            selectedCustomerName = customerName;
            quoteDate = DateTime.Now;
            
        }

        public void SaveQuote(int finalQuote)
        {
            try
            {
                string[] quote = { quoteDate + "," + selectedCustomerName + "," + newDesk.Width + "," + newDesk.Depth + "," + newDesk.CountDrawer + "," + newDesk.SurfaceMaterial + "," + selectedBuildOption + "," + finalQuote + "\n" };
                //System.IO.File.WriteAllLines(@"quote.txt", quote);
                //C:\Users\unoma\source\repos\MegaDesk-3-MichaelMann\MegaDesk-3-MichaelMann\bin\Debug
                System.IO.File.AppendAllLines(@"quote.txt", quote);
                string displayString = "Date: " + quoteDate + "\nName: " + selectedCustomerName + "\nWidth: " + newDesk.Width + "\nWidth: " + newDesk.Depth + "\n# of Drawers: " + newDesk.CountDrawer + "\nMaterial: " + newDesk.SurfaceMaterial + "\nBuild Time: " + selectedBuildOption + " days" + "\nYour MegaDesk price quote is : $" + finalQuote + "!";
            System.Windows.Forms.MessageBox.Show(@"You successfully saved your quote!" + "\n" + displayString);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(@"Failed to save quote:" + "\n" + ex.Message);
            }

        }

        public int CalcFinalQuote()
        {
            int finalQuote = 0;
            int baseMaterialCost = CalcBaseMaterialCost();
            int drawerCost = CalcDrawerCost();
            int shippingCost = CalcShippingCost();

            finalQuote = baseMaterialCost + drawerCost + shippingCost;
            return finalQuote;
        }

        private int CalcSurfaceArea()
        {
            return newDesk.Width * newDesk.Depth;
        }

        private int CalcDrawerCost()
        {
            return newDesk.CountDrawer * DRAWER_COST;
        }

        private int CalcShippingCost()
        {
            /* 
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

            switch (selectedBuildOption)
            {
                case 3:
                    if (calculatedSurfaceArea < 1000)
                    {
                        shippingCost = 60;
                    }
                    else if (calculatedSurfaceArea >= 1000 && calculatedSurfaceArea <= 2000)
                    {
                        shippingCost = 70;
                    }
                    else if (calculatedSurfaceArea > 2000)
                    {
                        shippingCost = 80;
                    }
                        break;
                case 5:
                    if (calculatedSurfaceArea < 1000)
                    {
                        shippingCost = 40;
                    }
                    else if (calculatedSurfaceArea >= 1000 && calculatedSurfaceArea <= 2000)
                    {
                        shippingCost = 50;
                    }
                    else if (calculatedSurfaceArea > 2000)
                    {
                        shippingCost = 60;
                    }
                    break;
                case 7:
                    if (calculatedSurfaceArea < 1000)
                    {
                        shippingCost = 30;
                    }
                    else if (calculatedSurfaceArea >= 1000 && calculatedSurfaceArea <= 2000)
                    {
                        shippingCost = 35;
                    }
                    else if (calculatedSurfaceArea > 2000)
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
            int surfaceMaterialCost = 0;
            switch (newDesk.SurfaceMaterial)
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

            if (CalcSurfaceArea() > SIZE_THRESHOLD)
            {
                surfaceMaterialCost += CalcSurfaceArea() - SIZE_THRESHOLD;
            }

            return BASE_COST + surfaceMaterialCost;
        }
    }
}



