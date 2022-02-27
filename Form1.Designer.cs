
namespace Bibliotekapplikationen
{
    partial class Form1
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
            this.AddBookButton = new System.Windows.Forms.Button();
            this.WelcomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListAllBooks = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EraseBooksButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RandomBookButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchForBookButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(12, 294);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(144, 144);
            this.AddBookButton.TabIndex = 1;
            this.AddBookButton.Text = "Lägg till bok";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // WelcomeText
            // 
            this.WelcomeText.AutoSize = true;
            this.WelcomeText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WelcomeText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WelcomeText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WelcomeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomeText.Location = new System.Drawing.Point(205, 9);
            this.WelcomeText.Name = "WelcomeText";
            this.WelcomeText.Size = new System.Drawing.Size(413, 43);
            this.WelcomeText.TabIndex = 2;
            this.WelcomeText.Text = "Välkommen Till Biblioteket!";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lägg till bok";
            // 
            // ListAllBooks
            // 
            this.ListAllBooks.Location = new System.Drawing.Point(162, 294);
            this.ListAllBooks.Name = "ListAllBooks";
            this.ListAllBooks.Size = new System.Drawing.Size(144, 144);
            this.ListAllBooks.TabIndex = 4;
            this.ListAllBooks.Text = "Skriv ut alla böcker";
            this.ListAllBooks.UseVisualStyleBackColor = true;
            this.ListAllBooks.Click += new System.EventHandler(this.ListAllBooks_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(162, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 60);
            this.label2.TabIndex = 5;
            this.label2.Text = "Skriv ut alla böcker";
            // 
            // EraseBooksButton
            // 
            this.EraseBooksButton.Location = new System.Drawing.Point(312, 294);
            this.EraseBooksButton.Name = "EraseBooksButton";
            this.EraseBooksButton.Size = new System.Drawing.Size(144, 144);
            this.EraseBooksButton.TabIndex = 6;
            this.EraseBooksButton.Text = "Radera böcker";
            this.EraseBooksButton.UseVisualStyleBackColor = true;
            this.EraseBooksButton.Click += new System.EventHandler(this.EraseBooksButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(312, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 60);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radera alla böcker";
            // 
            // RandomBookButton
            // 
            this.RandomBookButton.Location = new System.Drawing.Point(462, 294);
            this.RandomBookButton.Name = "RandomBookButton";
            this.RandomBookButton.Size = new System.Drawing.Size(144, 144);
            this.RandomBookButton.TabIndex = 8;
            this.RandomBookButton.Text = "Tips Bok";
            this.RandomBookButton.UseVisualStyleBackColor = true;
            this.RandomBookButton.Click += new System.EventHandler(this.RandomBookButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(462, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 60);
            this.label4.TabIndex = 9;
            this.label4.Text = "Få tips om en bok";
            // 
            // SearchForBookButton
            // 
            this.SearchForBookButton.Location = new System.Drawing.Point(612, 294);
            this.SearchForBookButton.Name = "SearchForBookButton";
            this.SearchForBookButton.Size = new System.Drawing.Size(144, 144);
            this.SearchForBookButton.TabIndex = 10;
            this.SearchForBookButton.Text = "Sök efter bok";
            this.SearchForBookButton.UseVisualStyleBackColor = true;
            this.SearchForBookButton.Click += new System.EventHandler(this.SearchForBookButton_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(612, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 60);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sök efter bok";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SearchForBookButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RandomBookButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EraseBooksButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListAllBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeText);
            this.Controls.Add(this.AddBookButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Label WelcomeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ListAllBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EraseBooksButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RandomBookButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SearchForBookButton;
        private System.Windows.Forms.Label label5;
    }
}

