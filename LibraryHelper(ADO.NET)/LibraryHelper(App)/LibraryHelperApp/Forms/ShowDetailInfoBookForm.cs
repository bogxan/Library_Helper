using LibraryHelperBLL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryHelperUI.Forms
{
    public partial class ShowDetailInfoBookForm : Form
    {
        public BookDto Book { get; set; }
        public ShowDetailInfoBookForm(BookDto book)
        {
            InitializeComponent();
            Book = book;
            textBox1.Text = Book.Name;
            textBox2.Text = Book.Authors;
            textBox3.Text = Book.Genre;
            textBox4.Text = Book.CountPages.ToString();
            textBox9.Text = Book.PublishOffice;
            textBox10.Text = Book.PublishDate.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
