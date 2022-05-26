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
    public partial class EditReaderForm : Form
    {
        public ReaderDto Reader { get; set; }
        public EditReaderForm(ReaderDto reader)
        {
            InitializeComponent();
            Reader = reader;
            textBox1.Text = Reader.FirstName;
            textBox2.Text = Reader.LastName;
            textBox3.Text = Reader.PhoneNumber;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
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
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
