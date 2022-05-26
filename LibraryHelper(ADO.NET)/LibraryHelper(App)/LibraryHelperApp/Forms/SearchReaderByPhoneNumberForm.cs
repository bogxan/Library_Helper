using LibraryHelperBLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryHelperUI.Forms
{
    public partial class SearchReaderByPhoneNumberForm : Form
    {
        public ReadersService ReadersService { get; set; }
        public SearchReaderByPhoneNumberForm(ReadersService readersService)
        {
            InitializeComponent();
            ReadersService = readersService;
        }

        private async void BtnSrch_Click(object sender, EventArgs e)
        {
            lstReaders.DataSource = null;
            if (textBox1.Text != "")
            {
                lstReaders.DataSource = await ReadersService.SearchReaderByPhoneNumber(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Enter phone number!");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
