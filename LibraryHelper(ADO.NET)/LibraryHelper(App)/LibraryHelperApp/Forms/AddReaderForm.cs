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
    public partial class AddReaderForm : Form
    {
        public ReaderDto Reader { get; set; }
        public AddReaderForm(ReaderDto reader)
        {
            InitializeComponent();
            Reader = reader;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Reader.FirstName = textBox1.Text;
                if (Reader.FirstName == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a firstname of reader!");
            }
            try
            {
                Reader.LastName = textBox2.Text;
                if (Reader.LastName == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a lastname of reader!");
            }
            try
            {
                Reader.PhoneNumber = textBox3.Text;
                if (Reader.PhoneNumber == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a phone number of reader!");
            }
            if (Reader.FirstName != "" && Reader.LastName != "" && Reader.PhoneNumber != "")
            {
                Reader.LendBooks = new List<LendBookDto>();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
