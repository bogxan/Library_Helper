﻿
namespace LibraryHelperUI.Forms
{
    partial class EditReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReaderForm));
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Bisque;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(536, 383);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(226, 91);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.OldLace;
            this.textBox3.Location = new System.Drawing.Point(691, 232);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(562, 33);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.OldLace;
            this.textBox2.Location = new System.Drawing.Point(691, 165);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(562, 33);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.Location = new System.Drawing.Point(691, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 33);
            this.textBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(229, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 46);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(229, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lastname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Firstname: ";
            // 
            // EditReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryHelper_App_.Properties.Resources.fon_pyatna_temnyy_91678_300x168;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1481, 551);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1499, 598);
            this.MinimumSize = new System.Drawing.Size(1499, 598);
            this.Name = "EditReaderForm";
            this.Text = "Edit reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}