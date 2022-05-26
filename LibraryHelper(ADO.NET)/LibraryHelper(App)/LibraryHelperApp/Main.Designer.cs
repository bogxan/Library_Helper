
namespace LibraryHelper
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstAllBooks = new System.Windows.Forms.ListBox();
            this.lstLendedBooks = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnSrchByName = new System.Windows.Forms.Button();
            this.btnSrchByGenre = new System.Windows.Forms.Button();
            this.btnSrchByAuthor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnShowDetInfoLendBook = new System.Windows.Forms.Button();
            this.btnShowDetInfoBook = new System.Windows.Forms.Button();
            this.SrchBooksByPublOffice = new System.Windows.Forms.Button();
            this.SrchBooksByPublishDate = new System.Windows.Forms.Button();
            this.btnShowBooksMustBeReturnedToday = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstReader = new System.Windows.Forms.ListBox();
            this.btnShowReader = new System.Windows.Forms.Button();
            this.btnEditReader = new System.Windows.Forms.Button();
            this.btnRemoveReader = new System.Windows.Forms.Button();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnSrchByPhoneNumb = new System.Windows.Forms.Button();
            this.btnSrchByNameSurname = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAllBooks
            // 
            this.lstAllBooks.BackColor = System.Drawing.Color.OldLace;
            this.lstAllBooks.FormattingEnabled = true;
            this.lstAllBooks.ItemHeight = 20;
            this.lstAllBooks.Location = new System.Drawing.Point(121, 80);
            this.lstAllBooks.Name = "lstAllBooks";
            this.lstAllBooks.Size = new System.Drawing.Size(726, 244);
            this.lstAllBooks.TabIndex = 1;
            // 
            // lstLendedBooks
            // 
            this.lstLendedBooks.BackColor = System.Drawing.Color.OldLace;
            this.lstLendedBooks.FormattingEnabled = true;
            this.lstLendedBooks.ItemHeight = 20;
            this.lstLendedBooks.Location = new System.Drawing.Point(633, 579);
            this.lstLendedBooks.Name = "lstLendedBooks";
            this.lstLendedBooks.Size = new System.Drawing.Size(646, 284);
            this.lstLendedBooks.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Bisque;
            this.btnAdd.Location = new System.Drawing.Point(263, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Bisque;
            this.btnRemove.Location = new System.Drawing.Point(463, 331);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(91, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Bisque;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(361, 331);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 29);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnLend
            // 
            this.btnLend.BackColor = System.Drawing.Color.Bisque;
            this.btnLend.Location = new System.Drawing.Point(561, 331);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(96, 29);
            this.btnLend.TabIndex = 6;
            this.btnLend.Text = "Lend out";
            this.btnLend.UseVisualStyleBackColor = false;
            this.btnLend.Click += new System.EventHandler(this.BtnLend_Click);
            // 
            // btnSrchByName
            // 
            this.btnSrchByName.BackColor = System.Drawing.Color.Khaki;
            this.btnSrchByName.Location = new System.Drawing.Point(263, 459);
            this.btnSrchByName.Name = "btnSrchByName";
            this.btnSrchByName.Size = new System.Drawing.Size(194, 51);
            this.btnSrchByName.TabIndex = 7;
            this.btnSrchByName.Text = "Search books by name";
            this.btnSrchByName.UseVisualStyleBackColor = false;
            this.btnSrchByName.Click += new System.EventHandler(this.BtnSrchByName_Click);
            // 
            // btnSrchByGenre
            // 
            this.btnSrchByGenre.BackColor = System.Drawing.Color.Khaki;
            this.btnSrchByGenre.Location = new System.Drawing.Point(463, 424);
            this.btnSrchByGenre.Name = "btnSrchByGenre";
            this.btnSrchByGenre.Size = new System.Drawing.Size(194, 29);
            this.btnSrchByGenre.TabIndex = 8;
            this.btnSrchByGenre.Text = "Search books by genre";
            this.btnSrchByGenre.UseVisualStyleBackColor = false;
            this.btnSrchByGenre.Click += new System.EventHandler(this.BtnSrchByGenre_Click);
            // 
            // btnSrchByAuthor
            // 
            this.btnSrchByAuthor.BackColor = System.Drawing.Color.Khaki;
            this.btnSrchByAuthor.Location = new System.Drawing.Point(263, 424);
            this.btnSrchByAuthor.Name = "btnSrchByAuthor";
            this.btnSrchByAuthor.Size = new System.Drawing.Size(194, 29);
            this.btnSrchByAuthor.TabIndex = 9;
            this.btnSrchByAuthor.Text = "Search books by author";
            this.btnSrchByAuthor.UseVisualStyleBackColor = false;
            this.btnSrchByAuthor.Click += new System.EventHandler(this.BtnSrchByAuthor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(396, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "All books";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(854, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 46);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lended books";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Bisque;
            this.btnReturn.Location = new System.Drawing.Point(793, 891);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(322, 36);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnShowDetInfoLendBook
            // 
            this.btnShowDetInfoLendBook.BackColor = System.Drawing.Color.SandyBrown;
            this.btnShowDetInfoLendBook.Location = new System.Drawing.Point(961, 929);
            this.btnShowDetInfoLendBook.Name = "btnShowDetInfoLendBook";
            this.btnShowDetInfoLendBook.Size = new System.Drawing.Size(322, 53);
            this.btnShowDetInfoLendBook.TabIndex = 13;
            this.btnShowDetInfoLendBook.Text = "Show detail information about choosen lended book";
            this.btnShowDetInfoLendBook.UseVisualStyleBackColor = false;
            this.btnShowDetInfoLendBook.Click += new System.EventHandler(this.BtnShowDetInfoLendBook_Click);
            // 
            // btnShowDetInfoBook
            // 
            this.btnShowDetInfoBook.BackColor = System.Drawing.Color.SandyBrown;
            this.btnShowDetInfoBook.Location = new System.Drawing.Point(361, 365);
            this.btnShowDetInfoBook.Name = "btnShowDetInfoBook";
            this.btnShowDetInfoBook.Size = new System.Drawing.Size(194, 53);
            this.btnShowDetInfoBook.TabIndex = 14;
            this.btnShowDetInfoBook.Text = "Show detail information about choosen book";
            this.btnShowDetInfoBook.UseVisualStyleBackColor = false;
            this.btnShowDetInfoBook.Click += new System.EventHandler(this.BtnShowDetInfoBook_Click);
            // 
            // SrchBooksByPublOffice
            // 
            this.SrchBooksByPublOffice.BackColor = System.Drawing.Color.Khaki;
            this.SrchBooksByPublOffice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SrchBooksByPublOffice.Location = new System.Drawing.Point(463, 459);
            this.SrchBooksByPublOffice.Name = "SrchBooksByPublOffice";
            this.SrchBooksByPublOffice.Size = new System.Drawing.Size(194, 51);
            this.SrchBooksByPublOffice.TabIndex = 15;
            this.SrchBooksByPublOffice.Text = "Search books by publish office";
            this.SrchBooksByPublOffice.UseVisualStyleBackColor = false;
            this.SrchBooksByPublOffice.Click += new System.EventHandler(this.BtnSrchBooksByPublOffice_Click);
            // 
            // SrchBooksByPublishDate
            // 
            this.SrchBooksByPublishDate.BackColor = System.Drawing.Color.Khaki;
            this.SrchBooksByPublishDate.Location = new System.Drawing.Point(361, 516);
            this.SrchBooksByPublishDate.Name = "SrchBooksByPublishDate";
            this.SrchBooksByPublishDate.Size = new System.Drawing.Size(194, 53);
            this.SrchBooksByPublishDate.TabIndex = 16;
            this.SrchBooksByPublishDate.Text = "Search books by publish date";
            this.SrchBooksByPublishDate.UseVisualStyleBackColor = false;
            this.SrchBooksByPublishDate.Click += new System.EventHandler(this.BtnSrchBooksByPublishDate_Click);
            // 
            // btnShowBooksMustBeReturnedToday
            // 
            this.btnShowBooksMustBeReturnedToday.BackColor = System.Drawing.Color.SandyBrown;
            this.btnShowBooksMustBeReturnedToday.Location = new System.Drawing.Point(633, 929);
            this.btnShowBooksMustBeReturnedToday.Name = "btnShowBooksMustBeReturnedToday";
            this.btnShowBooksMustBeReturnedToday.Size = new System.Drawing.Size(322, 53);
            this.btnShowBooksMustBeReturnedToday.TabIndex = 17;
            this.btnShowBooksMustBeReturnedToday.Text = "Show books that must be returned today";
            this.btnShowBooksMustBeReturnedToday.UseVisualStyleBackColor = false;
            this.btnShowBooksMustBeReturnedToday.Click += new System.EventHandler(this.BtnShowBooksMustBeReturnedToday_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1371, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "Readers";
            // 
            // lstReader
            // 
            this.lstReader.FormattingEnabled = true;
            this.lstReader.ItemHeight = 20;
            this.lstReader.Location = new System.Drawing.Point(1074, 80);
            this.lstReader.Name = "lstReader";
            this.lstReader.Size = new System.Drawing.Size(698, 244);
            this.lstReader.TabIndex = 19;
            // 
            // btnShowReader
            // 
            this.btnShowReader.BackColor = System.Drawing.Color.SandyBrown;
            this.btnShowReader.Location = new System.Drawing.Point(1285, 365);
            this.btnShowReader.Name = "btnShowReader";
            this.btnShowReader.Size = new System.Drawing.Size(293, 53);
            this.btnShowReader.TabIndex = 23;
            this.btnShowReader.Text = "Show detail information about choosen reader";
            this.btnShowReader.UseVisualStyleBackColor = false;
            this.btnShowReader.Click += new System.EventHandler(this.BtnShowReader_Click);
            // 
            // btnEditReader
            // 
            this.btnEditReader.BackColor = System.Drawing.Color.Bisque;
            this.btnEditReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditReader.Location = new System.Drawing.Point(1383, 331);
            this.btnEditReader.Name = "btnEditReader";
            this.btnEditReader.Size = new System.Drawing.Size(96, 29);
            this.btnEditReader.TabIndex = 22;
            this.btnEditReader.Text = "Edit";
            this.btnEditReader.UseVisualStyleBackColor = false;
            this.btnEditReader.Click += new System.EventHandler(this.BtnEditReader_Click);
            // 
            // btnRemoveReader
            // 
            this.btnRemoveReader.BackColor = System.Drawing.Color.Bisque;
            this.btnRemoveReader.Location = new System.Drawing.Point(1485, 331);
            this.btnRemoveReader.Name = "btnRemoveReader";
            this.btnRemoveReader.Size = new System.Drawing.Size(91, 29);
            this.btnRemoveReader.TabIndex = 21;
            this.btnRemoveReader.Text = "Remove";
            this.btnRemoveReader.UseVisualStyleBackColor = false;
            this.btnRemoveReader.Click += new System.EventHandler(this.BtnRemoveReader_Click);
            // 
            // btnAddReader
            // 
            this.btnAddReader.BackColor = System.Drawing.Color.Bisque;
            this.btnAddReader.Location = new System.Drawing.Point(1285, 331);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(91, 29);
            this.btnAddReader.TabIndex = 20;
            this.btnAddReader.Text = "Add";
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.BtnAddReader_Click);
            // 
            // btnSrchByPhoneNumb
            // 
            this.btnSrchByPhoneNumb.BackColor = System.Drawing.Color.Khaki;
            this.btnSrchByPhoneNumb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrchByPhoneNumb.Location = new System.Drawing.Point(1285, 481);
            this.btnSrchByPhoneNumb.Name = "btnSrchByPhoneNumb";
            this.btnSrchByPhoneNumb.Size = new System.Drawing.Size(293, 51);
            this.btnSrchByPhoneNumb.TabIndex = 25;
            this.btnSrchByPhoneNumb.Text = "Search readers by phone number";
            this.btnSrchByPhoneNumb.UseVisualStyleBackColor = false;
            this.btnSrchByPhoneNumb.Click += new System.EventHandler(this.BtnSrchByPhoneNumb_Click);
            // 
            // btnSrchByNameSurname
            // 
            this.btnSrchByNameSurname.BackColor = System.Drawing.Color.Khaki;
            this.btnSrchByNameSurname.Location = new System.Drawing.Point(1285, 424);
            this.btnSrchByNameSurname.Name = "btnSrchByNameSurname";
            this.btnSrchByNameSurname.Size = new System.Drawing.Size(293, 51);
            this.btnSrchByNameSurname.TabIndex = 24;
            this.btnSrchByNameSurname.Text = "Search readers by firstname and lastname";
            this.btnSrchByNameSurname.UseVisualStyleBackColor = false;
            this.btnSrchByNameSurname.Click += new System.EventHandler(this.BtnSrchByNameSurname_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::LibraryHelper_App_.Properties.Resources.fon_pyatna_temnyy_91678_300x168;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnSrchByPhoneNumb);
            this.Controls.Add(this.btnSrchByNameSurname);
            this.Controls.Add(this.btnShowReader);
            this.Controls.Add(this.btnEditReader);
            this.Controls.Add(this.btnRemoveReader);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.lstReader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowBooksMustBeReturnedToday);
            this.Controls.Add(this.SrchBooksByPublishDate);
            this.Controls.Add(this.SrchBooksByPublOffice);
            this.Controls.Add(this.btnShowDetInfoBook);
            this.Controls.Add(this.btnShowDetInfoLendBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSrchByAuthor);
            this.Controls.Add(this.btnSrchByGenre);
            this.Controls.Add(this.btnSrchByName);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstLendedBooks);
            this.Controls.Add(this.lstAllBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Library";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstAllBooks;
        private System.Windows.Forms.ListBox lstLendedBooks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnSrchByName;
        private System.Windows.Forms.Button btnSrchByGenre;
        private System.Windows.Forms.Button btnSrchByAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnShowDetInfoLendBook;
        private System.Windows.Forms.Button btnShowDetInfoBook;
        private System.Windows.Forms.Button SrchBooksByPublOffice;
        private System.Windows.Forms.Button SrchBooksByPublishDate;
        private System.Windows.Forms.Button btnShowBooksMustBeReturnedToday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstReader;
        private System.Windows.Forms.Button btnShowReader;
        private System.Windows.Forms.Button btnEditReader;
        private System.Windows.Forms.Button btnRemoveReader;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnSrchByPhoneNumb;
        private System.Windows.Forms.Button btnSrchByNameSurname;
    }
}

