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
    public partial class ShowBooksMustBeReturnedTodayForm : Form
    {
        public LendBooksService LendBooksService { get; set; }
        public ShowBooksMustBeReturnedTodayForm(LendBooksService booksService)
        {
            InitializeComponent();
            LendBooksService = booksService;
        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ShowBooksMustBeReturnedTodayForm_Load(object sender, EventArgs e)
        {
            lstBooks.DataSource = await LendBooksService.GetBooksMustBeReturnedToday();
        }
    }
}
