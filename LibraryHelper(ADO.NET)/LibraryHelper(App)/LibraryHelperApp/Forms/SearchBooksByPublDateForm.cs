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
    public partial class SearchBooksByPublDateForm : Form
    {
        public BooksService BooksService { get; set; }
        public SearchBooksByPublDateForm(BooksService booksService)
        {
            InitializeComponent();
            BooksService = booksService;
        }

        private async void BtnSrch_Click(object sender, EventArgs e)
        {
            lstBooks.DataSource = null;
            if (textBox1.Text != "")
            {
                try
                {
                    if (int.TryParse(textBox1.Text, out int year) == true && year >= 0)
                    {
                        lstBooks.DataSource = await BooksService.SearchBooksByPublDate(year);
                    }
                    if (year < 0 || int.TryParse(textBox1.Text, out year) == false)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Publishing date can`t be less 0!");
                }

            }
        }

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
