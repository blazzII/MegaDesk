using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text.RegularExpressions;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        //Other Notes
        //    - Can use ErrorProvider control where .SetError takes 2 parameters
        //    - 

        public AddQuote()
        {
            InitializeComponent();
            // erase placeholders on load
            WidthErrorLabel.Text = string.Empty;
            DepthErrorLabel.Text = string.Empty;

            // display the current date ... time?
            DateValueLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");

            // use List<T> to populate a combobox
            List<DesktopMaterial> MaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            MaterialComboBox.DataSource = MaterialList;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var ShowMainMenu = (MainMenu)Tag;
            ShowMainMenu.Show();
            this.Close();
        }

        private void CreateQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DesktopMaterial material = (DesktopMaterial)MaterialComboBox.SelectedValue;

                //DeskQuote newOrder = new DeskQuote(customerName, DateTime.Now);

            }
            catch (Exception)
            {

                throw;
            }

            

        }

        private void DeskSpecLabel_Click(object sender, EventArgs e)
        {

        }
        private void WidthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool validWidthType = int.TryParse(WidthTextBox.Text, out int width);
            if (validWidthType)
            {
                if (width < Desk.MINWIDTH || width > Desk.MAXWIDTH)
                {
                    MessageBox.Show($"Please enter a valid desk width between {Desk.MINWIDTH} and {Desk.MAXWIDTH}.", "Width Input Error");
                    WidthErrorLabel.Text = $"X {Desk.MINWIDTH}-{Desk.MAXWIDTH} inches";
                    WidthTextBox.Text = string.Empty;
                    WidthTextBox.BackColor = Color.MistyRose;
                    WidthTextBox.Focus();
                }
                else
                {
                    WidthTextBox.BackColor = Color.Honeydew;
                }
            }
            else
            {
                MessageBox.Show($"Please enter a valid desk width.", "Width Input Error");
                WidthTextBox.Text = string.Empty;
                WidthTextBox.BackColor = Color.MistyRose;
                WidthTextBox.Focus();
            }
            
        }
        private void DepthTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool validDepthType = int.TryParse(WidthTextBox.Text, out int depth);
            if (validDepthType)
            {
                if (depth < Desk.MINDEPTH || depth > Desk.MAXDEPTH)
                {
                    MessageBox.Show($"Please enter a valid desk width between {Desk.MINDEPTH} and {Desk.MAXDEPTH}.", "Width Input Error");
                    DepthErrorLabel.Text = $"X {Desk.MINDEPTH}-{Desk.MAXDEPTH} inches";
                    DepthTextBox.Text = string.Empty;
                    DepthTextBox.BackColor = Color.MistyRose;
                    DepthTextBox.Focus();
                }
                else
                {
                    DepthTextBox.BackColor = Color.Honeydew;
                }
            }
            else
            {
                MessageBox.Show($"Please enter a valid desk width.", "Width Input Error");
                DepthTextBox.Text = string.Empty;
                DepthTextBox.BackColor = Color.MistyRose;
                DepthTextBox.Focus();
            }
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValidNumber(e);
        }
        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsValidNumber(e);
        }

        private void IsValidNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void CustomerNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex namePattern = new Regex("^[A-Z].[A-Za-z]* [A-Z].[A-Za-z]* *[A-Za-z]*");
            if (!namePattern.IsMatch(CustomerNameTextBox.Text))
            {
                MessageBox.Show($"Please enter a valid customer name.", "Width Input Error");
                CustomerNameTextBox.Text = string.Empty;
                CustomerNameTextBox.BackColor = Color.MistyRose;
                CustomerNameTextBox.Focus();
            }
            else
            {
                CustomerNameTextBox.BackColor = Color.Honeydew;
            }
        }
    }
}
