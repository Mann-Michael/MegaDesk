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
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk newDesk = new Desk();
        private int BuildOption;
        private double priceQuote;
        #endregion

        #region constants
        private const int BASE_COST = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int DRAWER_COST = 50;
        #endregion

        public DeskQuote(int width, int depth, int countDrawer, string material, int buildOption)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
            newDesk.CountDrawer = countDrawer;
            newDesk.SurfaceMaterial = material;
        }

        private int CalcSurfaceArea()
        {
            return newDesk.Width * newDesk.Depth;
        }

        private int CalcDrawerCost()
        {
            return newDesk.CountDrawer * DRAWER_COST;
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



