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
    public partial class SearchBooksByPublOfficeForm : Form
    {
        public BooksService BooksService { get; set; }
        public SearchBooksByPublOfficeForm(BooksService booksService)
        {
            InitializeComponent();
            BooksService = booksService;
        }

        private async void BtnSrch_Click(object sender, EventArgs e)
        {
            lstBooks.DataSource = null;
            if (textBox1.Text != "")
            {
                lstBooks.DataSource = await BooksService.SearchBooksByPublOffice(textBox1.Text);
            }
        }

        private void BtnCLose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
