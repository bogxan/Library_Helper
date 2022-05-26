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
    public partial class ShowDetailInfoReaderForm : Form
    {
        public ReaderDto Reader { get; set; }
        public ShowDetailInfoReaderForm(ReaderDto reader)
        {
            InitializeComponent();
            Reader = reader;
            textBox1.Text = Reader.FirstName;
            textBox2.Text = Reader.LastName;
            textBox3.Text = Reader.PhoneNumber;
            lstBooks.DataSource = Reader.LendBooks;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
