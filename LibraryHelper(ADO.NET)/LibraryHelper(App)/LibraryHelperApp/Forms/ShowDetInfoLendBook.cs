using LibraryHelperBLL.DTO;
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
    public partial class ShowDetInfoLendBook : Form
    {
        public LendBookDto LendBook { get; set; }
        public ReadersService Readers { get; set; }
        public int ReaderId { get; set; }
        public BookDto Book { get; set; }
        public ShowDetInfoLendBook(LendBookDto lendBook, BookDto book, int readerId, ReadersService readers)
        {
            InitializeComponent();
            LendBook = lendBook;
            Readers = readers;
            ReaderId = readerId;
            Book = book;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void ShowDetInfoLendBook_Load(object sender, EventArgs e)
        {
            LendBook.BookId = Book.Id;
            LendBook.Reader = await Readers.Get(ReaderId);
            textBox1.Text = LendBook.Book.Name;
            textBox2.Text = LendBook.Book.Authors;
            textBox3.Text = LendBook.Book.Genre;
            textBox4.Text = LendBook.Book.CountPages.ToString();
            textBox5.Text = LendBook.Reader.FirstName;
            textBox6.Text = LendBook.Reader.LastName;
            textBox8.Text = LendBook.DateLendingFrom.ToString();
            textBox7.Text = LendBook.DateLendingTo.ToString();
            textBox9.Text = LendBook.Book.PublishOffice;
            textBox10.Text = LendBook.Book.PublishDate.ToString();
            textBox11.Text = LendBook.Reader.PhoneNumber;
        }
    }
}
