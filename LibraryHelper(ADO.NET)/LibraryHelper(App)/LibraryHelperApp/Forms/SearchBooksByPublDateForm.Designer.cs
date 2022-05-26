
namespace LibraryHelperUI.Forms
{
    partial class SearchBooksByPublDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchBooksByPublDateForm));
            this.btnCLose = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnSrch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Bisque;
            this.btnCLose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCLose.Location = new System.Drawing.Point(677, 448);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(133, 69);
            this.btnCLose.TabIndex = 24;
            this.btnCLose.Text = "Ok";
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.BtnCLose_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.Color.OldLace;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 20;
            this.lstBooks.Location = new System.Drawing.Point(401, 105);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(689, 324);
            this.lstBooks.TabIndex = 23;
            // 
            // btnSrch
            // 
            this.btnSrch.BackColor = System.Drawing.Color.Bisque;
            this.btnSrch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSrch.Location = new System.Drawing.Point(1192, 9);
            this.btnSrch.Name = "btnSrch";
            this.btnSrch.Size = new System.Drawing.Size(183, 45);
            this.btnSrch.TabIndex = 22;
            this.btnSrch.Text = "Search";
            this.btnSrch.UseVisualStyleBackColor = false;
            this.btnSrch.Click += new System.EventHandler(this.BtnSrch_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.Location = new System.Drawing.Point(401, 9);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(689, 45);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Publishing date:";
            // 
            // SearchBooksByPublDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryHelper_App_.Properties.Resources.fon_pyatna_temnyy_91678_300x168;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 553);
            this.Controls.Add(this.btnCLose);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.btnSrch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 600);
            this.MinimumSize = new System.Drawing.Size(1500, 600);
            this.Name = "SearchBooksByPublDateForm";
            this.Text = "Search books by publishing date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCLose;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnSrch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}