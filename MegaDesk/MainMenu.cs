using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote AddQuoteForm = new AddQuote { Tag = this };
            AddQuoteForm.Show(this);
            this.Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes { Tag = this };
            searchQuotesForm.Show(this);
            Hide();
        }

        private void ViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotes = new ViewAllQuotes { Tag = this };
            viewAllQuotes.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Click OK to confirm Exit.", "Exit MegaDesk", MessageBoxButtons.OKCancel);
            //Console.WriteLine(dr);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}
