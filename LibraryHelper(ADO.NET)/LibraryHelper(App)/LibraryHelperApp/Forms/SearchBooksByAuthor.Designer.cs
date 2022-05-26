
namespace LibraryHelperUI.Forms
{
    partial class SearchBooksByAuthor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBooksByAuthor));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSrch = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnCLose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.Location = new System.Drawing.Point(385, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(690, 33);
            this.textBox1.TabIndex = 1;
            // 
            // btnSrch
            // 
            this.btnSrch.BackColor = System.Drawing.Color.Bisque;
            this.btnSrch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrch.Location = new System.Drawing.Point(1214, 27);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(142, 53);
            this.btnSrch.TabIndex = 2;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = false;
            this.btnSrch.Click += new System.EventHandler(this.BtnSrch_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.Color.OldLace;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 20;
            this.lstBooks.Location = new System.Drawing.Point(385, 137);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(690, 324);
            this.lstBooks.TabIndex = 3;
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Bisque;
            this.btnCLose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCLose.Location = new System.Drawing.Point(658, 467);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(131, 52);
            this.btnCLose.TabIndex = 4;
            this.btnCLose.Text = "Ok";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.BtnCLose_Click);
            // 
            // SearchBooksByAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryHelper_App_.Properties.Resources.fon_pyatna_temnyy_91678_300x168;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1481, 551);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnSrch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1499, 598);
            this.MinimumSize = new System.Drawing.Size(1499, 598);
            this.Name = "SearchBooksByAuthor";
            this.Text = "Search books by author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnCLose;
    }
}