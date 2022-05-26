using LibraryHelperBLL.DTO;
using LibraryHelperBLL.Services;
using LibraryHelperDAL.Interfaces;
using LibraryHelperDAL.Repositories;
using LibraryHelperUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHelper
{
    public partial class Main : Form
    {
        static readonly IUnitOfWork uow = new UnitOfWork(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryHelper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        readonly BooksService BooksService;
        readonly LendBooksService LendBooksService;
        readonly ReadersService ReadersService;
        List<BookDto> AllBooks = new List<BookDto>();
        List<LendBookDto> LendBooks = new List<LendBookDto>();
        List<ReaderDto> Readers = new List<ReaderDto>();
        public Main()
        {
            InitializeComponent();
            BooksService = new BooksService(uow);
            LendBooksService = new LendBooksService(uow);
            ReadersService = new ReadersService(uow);
            UpdateListAllBooks();
            UpdateListLendBooks();
            UpdateListReaders();
            UpdateAll();
            lstAllBooks.DataSource = AllBooks;
            lstLendedBooks.DataSource = LendBooks;
            lstReader.DataSource = Readers;
            WindowState = FormWindowState.Maximized;
        }

        private async void UpdateAll()
        {
            AllBooks = await BooksService.GetAll();
            LendBooks = await LendBooksService.GetAll();
            Readers = await ReadersService.GetAll();
        }

        private void UpdateListAllBooks()
        {
            lstAllBooks.DataSource = null;
            lstAllBooks.DataSource = AllBooks;

        }

        private void UpdateListLendBooks()
        {
            lstLendedBooks.DataSource = null;
            lstLendedBooks.DataSource = LendBooks;
        }

        private void UpdateListReaders()
        {
            lstReader.DataSource = null;
            lstReader.DataSource = Readers;
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            BookDto bookDto = new BookDto();
            AddBookForm addBookForm = new AddBookForm(bookDto);
            if (addBookForm.ShowDialog() == DialogResult.OK && AllBooks.Any(p => p.Name == bookDto.Name && p.PublishDate == bookDto.PublishDate && p.Authors == bookDto.Authors && p.CountPages == bookDto.CountPages && p.Genre == bookDto.Genre && p.IsLendedOut == bookDto.IsLendedOut && p.PublishOffice == bookDto.PublishOffice) == false)
            {
                await BooksService.AddBook(bookDto);
                UpdateAll();
                UpdateListAllBooks();
            }
            else if (AllBooks.Any(p => p.Name == bookDto.Name && p.PublishDate == bookDto.PublishDate && p.Authors == bookDto.Authors && p.CountPages == bookDto.CountPages && p.Genre == bookDto.Genre && p.IsLendedOut == bookDto.IsLendedOut && p.PublishOffice == bookDto.PublishOffice) == true)
            {
                MessageBox.Show("Such book has already created");
            }
            else
            {
                MessageBox.Show("You should enter information to add book!");
            }
        }

        private async void BtnRemove_Click(object sender, EventArgs e)
        {
            if (lstAllBooks.SelectedIndex != -1)
            {
                BookDto book = lstAllBooks.Items[lstAllBooks.SelectedIndex] as BookDto;
                if (book.IsLendedOut == true)
                {
                    MessageBox.Show("Choosen book has lended!");
                }
                else
                {
                    await BooksService.DeleteBook(book.Id);
                    UpdateAll();
                    UpdateListAllBooks();
                }
            }
            else
            {
                MessageBox.Show("Choose a book!");
            }
        }

        private async void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lstAllBooks.SelectedIndex != -1)
            {
                BookDto book = lstAllBooks.Items[lstAllBooks.SelectedIndex] as BookDto;
                if (book.IsLendedOut == true)
                {
                    MessageBox.Show("Choosen book has lended!");
                }
                else
                {
                    EditBookForm editBookForm = new EditBookForm(book);
                    if (editBookForm.ShowDialog() == DialogResult.OK)
                    {
                        await BooksService.UpdateBook(book);
                        UpdateAll();
                        UpdateListAllBooks();
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a book!");
            }
        }

        private void BtnShowDetInfoBook_Click(object sender, EventArgs e)
        {
            if (lstAllBooks.SelectedIndex != -1)
            {
                BookDto book = lstAllBooks.Items[lstAllBooks.SelectedIndex] as BookDto;
                ShowDetailInfoBookForm show = new ShowDetailInfoBookForm(book);
                show.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose a book!");
            }
        }

        private async void BtnLend_Click(object sender, EventArgs e)
        {
            if (lstAllBooks.SelectedIndex != -1)
            {
                if (lstReader.SelectedIndex != -1)
                {
                    ReaderDto reader = lstReader.Items[lstReader.SelectedIndex] as ReaderDto;
                    BookDto book = lstAllBooks.Items[lstAllBooks.SelectedIndex] as BookDto;
                    LendBookDto lendBook = new LendBookDto();
                    if (book.IsLendedOut == true)
                    {
                        MessageBox.Show("Choosen book has already lended!");
                    }
                    else
                    {
                        book.LendBook = lendBook;
                        reader.LendBooks.Add(lendBook);
                        lendBook.BookId = book.Id;
                        lendBook.ReaderId = reader.Id;
                        lendBook.DateLendingFrom = DateTime.Today;
                        lendBook.DateLendingTo = DateTime.Today.AddDays(14);
                        book.IsLendedOut = true;
                        await BooksService.UpdateBook(book);
                        await LendBooksService.AddLendBook(lendBook);
                        UpdateAll();
                        UpdateListAllBooks();
                        UpdateListReaders();
                        UpdateListLendBooks();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Choose a reader!");
                }
            }
            else
            {
                MessageBox.Show("Choose a book!");
            }
        }

        private void BtnSrchByAuthor_Click(object sender, EventArgs e)
        {
            SearchBooksByAuthor searchBooks = new SearchBooksByAuthor(BooksService);
            searchBooks.ShowDialog();
        }

        private void BtnSrchByGenre_Click(object sender, EventArgs e)
        {
            SearchBooksByGenre searchBooks = new SearchBooksByGenre(BooksService);
            searchBooks.ShowDialog();
        }

        private void BtnSrchByName_Click(object sender, EventArgs e)
        {
            SearchBooksByName searchBooks = new SearchBooksByName(BooksService);
            searchBooks.ShowDialog();
        }

        private void BtnShowDetInfoLendBook_Click(object sender, EventArgs e)
        {
            if (lstLendedBooks.SelectedIndex != -1)
            {
                LendBookDto lendBook = lstLendedBooks.Items[lstLendedBooks.SelectedIndex] as LendBookDto;
                ShowDetInfoLendBook showDetInfo = new ShowDetInfoLendBook(lendBook, lendBook.Book, lendBook.ReaderId, ReadersService);
                showDetInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose a book!");
            }
        }

        private async void BtnReturn_Click(object sender, EventArgs e)
        {
            if (lstLendedBooks.SelectedIndex != -1)
            {
                LendBookDto lendBook = lstLendedBooks.Items[lstLendedBooks.SelectedIndex] as LendBookDto;
                lendBook.Book.IsLendedOut = false;
                await BooksService.UpdateBook(lendBook.Book);
                await LendBooksService.DeleteLendBook(lendBook.Id);
                UpdateAll();
                UpdateListAllBooks();
                UpdateListLendBooks();
                UpdateListReaders();
            }
            else
            {
                MessageBox.Show("Choose a book!");
            }
        }

        private void BtnShowBooksMustBeReturnedToday_Click(object sender, EventArgs e)
        {
            ShowBooksMustBeReturnedTodayForm showBooks = new ShowBooksMustBeReturnedTodayForm(LendBooksService);
            showBooks.ShowDialog();
        }

        private void BtnSrchBooksByPublOffice_Click(object sender, EventArgs e)
        {
            SearchBooksByPublOfficeForm searchBooks = new SearchBooksByPublOfficeForm(BooksService);
            searchBooks.ShowDialog();
        }

        private void BtnSrchBooksByPublishDate_Click(object sender, EventArgs e)
        {
            SearchBooksByPublDateForm searchBooks = new SearchBooksByPublDateForm(BooksService);
            searchBooks.ShowDialog();
        }

        private async void BtnAddReader_Click(object sender, EventArgs e)
        {
            ReaderDto reader = new ReaderDto();
            AddReaderForm addReader = new AddReaderForm(reader);
            if (addReader.ShowDialog() == DialogResult.OK && await ReadersService.Get(reader.Id) != reader)
            {
                await ReadersService.AddReader(reader);
                UpdateAll();
                UpdateListReaders();
            }
            else if (await ReadersService.Get(reader.Id) == reader)
            {
                MessageBox.Show("Such reader has already created");
            }
            else
            {
                MessageBox.Show("You should enter information to add reader!");
            }
        }

        private async void BtnEditReader_Click(object sender, EventArgs e)
        {
            if (lstReader.SelectedIndex != -1)
            {
                ReaderDto reader = lstReader.Items[lstReader.SelectedIndex] as ReaderDto;
                if (reader.LendBooks.Count >= 1)
                {
                    MessageBox.Show("You can`t edit reader because he lended a book!");
                }
                else
                {
                    EditReaderForm editReader = new EditReaderForm(reader);
                    if (editReader.ShowDialog() == DialogResult.OK)
                    {
                        await ReadersService.UpdateReader(reader);
                        UpdateAll();
                        UpdateListReaders();
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a reader!");
            }
        }

        private async void BtnRemoveReader_Click(object sender, EventArgs e)
        {
            if (lstReader.SelectedIndex != -1)
            {
                ReaderDto reader = lstReader.Items[lstReader.SelectedIndex] as ReaderDto;
                if (reader.LendBooks.Count >= 1)
                {
                    MessageBox.Show("You can`t edit reader because he lended a book!");
                }
                else
                {
                    await ReadersService.DeleteReader(reader.Id);
                    UpdateAll();
                    UpdateListReaders();
                }
            }
            else
            {
                MessageBox.Show("Choose a reader!");
            }
        }

        private void BtnShowReader_Click(object sender, EventArgs e)
        {
            if (lstReader.SelectedIndex != -1)
            {
                ReaderDto reader = lstReader.Items[lstReader.SelectedIndex] as ReaderDto;
                ShowDetailInfoReaderForm showReader = new ShowDetailInfoReaderForm(reader);
                showReader.ShowDialog();
            }
            else
            {
                MessageBox.Show("Choose a reader!");
            }
        }

        private void BtnSrchByNameSurname_Click(object sender, EventArgs e)
        {
            SearchReaderByNameSurnameForm searchReader = new SearchReaderByNameSurnameForm(ReadersService);
            searchReader.ShowDialog();
        }

        private void BtnSrchByPhoneNumb_Click(object sender, EventArgs e)
        {
            SearchReaderByPhoneNumberForm searchReader = new SearchReaderByPhoneNumberForm(ReadersService);
            searchReader.ShowDialog();
        }
    }
}