
namespace LibraryHelperUI.Forms
{
    partial class ShowDetailInfoReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowDetailInfoReaderForm));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.Location = new System.Drawing.Point(666, 163);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(562, 34);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.Location = new System.Drawing.Point(666, 97);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(562, 34);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.Location = new System.Drawing.Point(666, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(562, 34);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(204, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 46);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(204, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lastname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Firstname: ";
            // 
            // lstBooks
            // 
            this.lstBooks.BackColor = System.Drawing.Color.OldLace;
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 20;
            this.lstBooks.Location = new System.Drawing.Point(204, 237);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(594, 304);
            this.lstBooks.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Bisque;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(1015, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 87);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Ok";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ShowDetailInfoReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryHelper_App_.Properties.Resources.fon_pyatna_temnyy_91678_300x168;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 553);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1500, 600);
            this.MinimumSize = new System.Drawing.Size(1500, 600);
            this.Name = "ShowDetailInfoReaderForm";
            this.Text = "Show details about reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnClose;
    }
}