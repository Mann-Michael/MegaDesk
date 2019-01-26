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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }


        private void nudWidth_Validating(object sender,
                 System.ComponentModel.CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidWidth(Convert.ToInt32(nudWidth.Value), out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                nudWidth.Select(0, Convert.ToInt32(nudWidth.Value));

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(nudWidth, errorMsg);
            }
        }

        private void nudWidth_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(nudWidth, "");
        }

        public bool ValidWidth(int width, out string errorMessage)
        {
            // Confirm that the width is not empty.
            if (nudWidth.Text == "")
            {
                errorMessage = "Width is required.";
                return false;
            }

            // Confirm that the value is between 24 and 96
            if (nudWidth.Value <= 96 && nudWidth.Value >= 24)
            {
                errorMessage = "";
                return true;
            }

            errorMessage = "The width must be set between 24 inches and 96 inches.";
            return false;
        }

        private void nudDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            //check isControl False  and isdigit true
            if (Char.IsControl(e.KeyChar) || !Char.IsDigit(e.KeyChar))
            {
                this.errorProvider2.SetError(nudDepth, "Depth must be a number.");
            }
            else
            {
                this.errorProvider2.SetError(nudDepth, "");
            }
        }

    }
}
