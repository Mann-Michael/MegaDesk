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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void btnViewQuote_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotesForm = new SearchQuotes();
            viewSearchQuotesForm.Tag = this;
            viewSearchQuotesForm.Show(this);
            Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
