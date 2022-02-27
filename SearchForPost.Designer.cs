
namespace Bibliotekapplikationen
{
    partial class SearchForPost
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FoundAlternatives = new System.Windows.Forms.ListBox();
            this.CloseFrombutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sök efter bok. Sök genom att skriva in författare, år eller titel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FoundAlternatives
            // 
            this.FoundAlternatives.FormattingEnabled = true;
            this.FoundAlternatives.ItemHeight = 20;
            this.FoundAlternatives.Location = new System.Drawing.Point(0, 64);
            this.FoundAlternatives.Name = "FoundAlternatives";
            this.FoundAlternatives.Size = new System.Drawing.Size(597, 344);
            this.FoundAlternatives.TabIndex = 2;
            this.FoundAlternatives.SelectedIndexChanged += new System.EventHandler(this.FoundAlternatives_SelectedIndexChanged);
            // 
            // CloseFrombutton
            // 
            this.CloseFrombutton.Location = new System.Drawing.Point(0, 414);
            this.CloseFrombutton.Name = "CloseFrombutton";
            this.CloseFrombutton.Size = new System.Drawing.Size(597, 29);
            this.CloseFrombutton.TabIndex = 3;
            this.CloseFrombutton.Text = "Klar";
            this.CloseFrombutton.UseVisualStyleBackColor = true;
            this.CloseFrombutton.Click += new System.EventHandler(this.CloseFrombutton_Click);
            // 
            // SearchForPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 450);
            this.Controls.Add(this.CloseFrombutton);
            this.Controls.Add(this.FoundAlternatives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "SearchForPost";
            this.Text = "SearchForPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FoundAlternatives;
        private System.Windows.Forms.Button CloseFrombutton;
    }
}