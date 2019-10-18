using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            MaterialComboBox.DataSource = materials;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchResultsListView.Clear();
            string MaterialSelected = MaterialComboBox.SelectedItem.ToString();

            try
            {
                if (File.Exists(@"quotes.json")) { 
                    using (StreamReader sr = new StreamReader(@"quotes.json"))
                    {
                        string jsonData = sr.ReadToEnd();
                        var listData = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);


                                   
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}
