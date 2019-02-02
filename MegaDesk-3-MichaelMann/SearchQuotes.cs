using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MichaelMann
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            List<Desk.SurfaceMaterials> listMaterials = Enum.GetValues(typeof(Desk.SurfaceMaterials)).Cast<Desk.SurfaceMaterials>().ToList();
            cmbMaterial.DataSource = listMaterials;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string material = cmbMaterial.Text;
            lbQuotes.Items.Clear();

            List<List<string>> groups = new List<List<string>>();
            List<string> current = null;
            foreach (var line in System.IO.File.ReadAllLines(@"quote.txt"))
            {
                if (line.Contains(material) && current == null)
                {
                    string formattedQuote = String.Empty;
                    string[] arrQuote = line.Split(',');
                    int fieldCounter = 0;
                    foreach (string thisField in arrQuote)
                    {
                        switch (fieldCounter)
                        {
                            case 0:
                                formattedQuote += "Date: " + thisField;
                                break;
                            case 1:
                                formattedQuote += ", Name: " + thisField;
                                break;
                            case 2:
                                formattedQuote += ", Width: " + thisField;
                                break;
                            case 3:
                                formattedQuote += ", Depth: " + thisField;
                                break;
                            case 4:
                                formattedQuote += ", # of Drawers: " + thisField;
                                break;
                            case 5:
                                formattedQuote += ", Surface Material: " + thisField;
                                break;
                            case 6:
                                formattedQuote += ", Build Time: " + thisField;
                                break;
                            case 7:
                                formattedQuote += ", Quote: $" + thisField;
                                break;
                        }
                        fieldCounter++;
                    }
                    lbQuotes.Items.Add(formattedQuote);
                }
            }
        }
    }
}
