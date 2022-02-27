
namespace Bibliotekapplikationen
{
    partial class AddBookForm
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
            this.NovelCheckBox = new System.Windows.Forms.CheckBox();
            this.ShortStoryCheckBox = new System.Windows.Forms.CheckBox();
            this.JournalCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateBookButton = new System.Windows.Forms.Button();
            this.TitelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Författare = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PublishedYearTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NovelCheckBox
            // 
            this.NovelCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.NovelCheckBox.AutoSize = true;
            this.NovelCheckBox.BackColor = System.Drawing.Color.Black;
            this.NovelCheckBox.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NovelCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NovelCheckBox.Location = new System.Drawing.Point(12, 12);
            this.NovelCheckBox.Name = "NovelCheckBox";
            this.NovelCheckBox.Size = new System.Drawing.Size(92, 40);
            this.NovelCheckBox.TabIndex = 0;
            this.NovelCheckBox.Text = "Roman";
            this.NovelCheckBox.UseVisualStyleBackColor = false;
            this.NovelCheckBox.CheckedChanged += new System.EventHandler(this.NovelCheckBox_CheckedChanged);
            // 
            // ShortStoryCheckBox
            // 
            this.ShortStoryCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ShortStoryCheckBox.AutoSize = true;
            this.ShortStoryCheckBox.BackColor = System.Drawing.Color.Black;
            this.ShortStoryCheckBox.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShortStoryCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShortStoryCheckBox.Location = new System.Drawing.Point(110, 12);
            this.ShortStoryCheckBox.Name = "ShortStoryCheckBox";
            this.ShortStoryCheckBox.Size = new System.Drawing.Size(87, 40);
            this.ShortStoryCheckBox.TabIndex = 1;
            this.ShortStoryCheckBox.Text = "Novell";
            this.ShortStoryCheckBox.UseVisualStyleBackColor = false;
            this.ShortStoryCheckBox.CheckedChanged += new System.EventHandler(this.ShortStoryCheckBox_CheckedChanged);
            // 
            // JournalCheckBox
            // 
            this.JournalCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.JournalCheckBox.AutoSize = true;
            this.JournalCheckBox.BackColor = System.Drawing.Color.Black;
            this.JournalCheckBox.Font = new System.Drawing.Font("Segoe UI", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.JournalCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.JournalCheckBox.Location = new System.Drawing.Point(203, 12);
            this.JournalCheckBox.Name = "JournalCheckBox";
            this.JournalCheckBox.Size = new System.Drawing.Size(105, 40);
            this.JournalCheckBox.TabIndex = 2;
            this.JournalCheckBox.Text = "Tidskrift";
            this.JournalCheckBox.UseVisualStyleBackColor = false;
            this.JournalCheckBox.CheckedChanged += new System.EventHandler(this.JournalCheckBox_CheckedChanged);
            // 
            // CreateBookButton
            // 
            this.CreateBookButton.BackColor = System.Drawing.Color.Black;
            this.CreateBookButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateBookButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateBookButton.Location = new System.Drawing.Point(12, 253);
            this.CreateBookButton.Name = "CreateBookButton";
            this.CreateBookButton.Size = new System.Drawing.Size(292, 73);
            this.CreateBookButton.TabIndex = 3;
            this.CreateBookButton.Text = "Skapa Bok";
            this.CreateBookButton.UseVisualStyleBackColor = false;
            this.CreateBookButton.Click += new System.EventHandler(this.CreateBookButton_Click);
            // 
            // TitelTextBox
            // 
            this.TitelTextBox.Location = new System.Drawing.Point(12, 98);
            this.TitelTextBox.Name = "TitelTextBox";
            this.TitelTextBox.Size = new System.Drawing.Size(292, 27);
            this.TitelTextBox.TabIndex = 4;
            this.TitelTextBox.TextChanged += new System.EventHandler(this.TitelTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titel";
            // 
            // Författare
            // 
            this.Författare.AutoSize = true;
            this.Författare.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Författare.Location = new System.Drawing.Point(12, 128);
            this.Författare.Name = "Författare";
            this.Författare.Size = new System.Drawing.Size(100, 28);
            this.Författare.TabIndex = 6;
            this.Författare.Text = "Författare";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(12, 159);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(292, 27);
            this.AuthorTextBox.TabIndex = 7;
            this.AuthorTextBox.TextChanged += new System.EventHandler(this.AuthorTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Utgivningsår";
            // 
            // PublishedYearTextBox
            // 
            this.PublishedYearTextBox.Location = new System.Drawing.Point(12, 220);
            this.PublishedYearTextBox.Name = "PublishedYearTextBox";
            this.PublishedYearTextBox.Size = new System.Drawing.Size(292, 27);
            this.PublishedYearTextBox.TabIndex = 9;
            this.PublishedYearTextBox.TextChanged += new System.EventHandler(this.PublishedYearTextBox_TextChanged);
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(316, 339);
            this.Controls.Add(this.PublishedYearTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.Författare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitelTextBox);
            this.Controls.Add(this.CreateBookButton);
            this.Controls.Add(this.JournalCheckBox);
            this.Controls.Add(this.ShortStoryCheckBox);
            this.Controls.Add(this.NovelCheckBox);
            this.Name = "AddBookForm";
            this.Text = "Lägg till bok";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NovelCheckBox;
        private System.Windows.Forms.CheckBox ShortStoryCheckBox;
        private System.Windows.Forms.CheckBox JournalCheckBox;
        private System.Windows.Forms.Button CreateBookButton;
        private System.Windows.Forms.TextBox TitelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Författare;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PublishedYearTextBox;
    }
}