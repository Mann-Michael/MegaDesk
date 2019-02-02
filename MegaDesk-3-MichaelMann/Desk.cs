using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_MichaelMann
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int CountDrawer { get; set; }
        public string SurfaceMaterial { get; set; }

        public enum SurfaceMaterials { Oak, Laminate, Pine, Rosewood, Veneer }

    }
}
