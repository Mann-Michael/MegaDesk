using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            try
            {
                //check if file exists
                if (File.Exists(@"quotes.json"))
                {
                    //set initialJson to the text within the file
                    var initialJson = File.ReadAllText(@"quotes.json");

                    //parses file contents to a JArray named "array"
                    var array = JArray.Parse(initialJson);

                    foreach (JObject quote in array)
                    {
                        //create DeskQuote object from this record in the array
                        DeskQuote dq = quote.ToObject<DeskQuote>();
                        
                        //if it has the selected surface material, format a string and add to list box
                        if (dq.QuotedDesk.SurfaceMaterial == material)
                        {
                            string formattedString = "Date: " + dq.QuoteDate;
                            formattedString += " Name: " + dq.SelectedCustomerName;
                            formattedString += " Width: " + dq.QuotedDesk.Width;
                            formattedString += " Depth: " + dq.QuotedDesk.Depth;
                            formattedString += " # of Drawers: " + dq.QuotedDesk.CountDrawer;
                            formattedString += " Material: " + dq.QuotedDesk.SurfaceMaterial;
                            formattedString += " Build Time: " + dq.SelectedBuildOption + " days";
                            formattedString += " Quote: $" + dq.QuotedFinalCost;
                            lbQuotes.Items.Add(formattedString);
                        }
                    }
                }
                else
                {
                    //if the file does nto exist, show the message box
                    MessageBox.Show(@"You have no quotes saved!");
                }
            }
            catch (Exception ex)
            {
                //if there is an exception, show the error message
                MessageBox.Show(@"Failed to find quotes!" + "\n" + ex.Message);
            }
        }
    }
}
