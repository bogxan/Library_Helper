using LibraryHelperBLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHelperUI.Forms
{
    public partial class SearchReaderByNameSurnameForm : Form
    {
        public ReadersService ReadersService { get; set; }
        public SearchReaderByNameSurnameForm(ReadersService readersService)
        {
            InitializeComponent();
            ReadersService = readersService;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnSrch_Click(object sender, EventArgs e)
        {
            lstReaders.DataSource = null;
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    lstReaders.DataSource = await ReadersService.SearchReaderByNameSurname(textBox1.Text, textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Enter  last name!");
                }
            }
            else
            {
                MessageBox.Show("Enter first name!");
            }

        }
    }
}
