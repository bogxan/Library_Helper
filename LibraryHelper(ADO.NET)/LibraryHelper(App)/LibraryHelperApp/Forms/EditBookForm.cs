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
    public partial class EditBookForm : Form
    {
        public BookDto Book { get; set; }
        public EditBookForm(BookDto book)
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
            try
            {
                Book.Name = textBox1.Text;
                if (Book.Name == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the name of book!");
            }
            try
            {
                Book.Authors = textBox2.Text;
                if (Book.Authors == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter authors!");

            }
            try
            {
                Book.Genre = textBox3.Text;
                if (Book.Genre == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter the genre of book!");
            }
            try
            {

                if (int.TryParse(textBox4.Text, out int count) == true && count >= 1)
                {
                    Book.CountPages = count;
                }
                if (Book.CountPages < 1 || int.TryParse(textBox4.Text, out count) == false)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter count of pages of book!");
            }
            try
            {
                Book.PublishOffice = textBox9.Text;
                if (Book.PublishOffice == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter publishing office of book!");
            }
            try
            {
                if (int.TryParse(textBox10.Text, out int year) == true)
                {
                    Book.PublishDate = year;
                }
                if (Book.PublishDate < 0 || int.TryParse(textBox4.Text, out year) == false)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter publishing date of book!");
            }
            if (Book.Name != "" && Book.Authors != "" && Book.Genre != "" && Book.CountPages >= 1 && Book.PublishOffice != "" && Book.PublishDate >= 0)
            {
                Book.IsLendedOut = false;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
