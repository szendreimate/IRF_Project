namespace IRF_PROJECT
{
    partial class tevékenység
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
            this.Lekérdezőbutton = new System.Windows.Forms.Button();
            this.Hozzáadóbutton = new System.Windows.Forms.Button();
            this.Törlőbutton = new System.Windows.Forms.Button();
            this.ListazocheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.KeresotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lekérdezőbutton
            // 
            this.Lekérdezőbutton.Location = new System.Drawing.Point(45, 62);
            this.Lekérdezőbutton.Name = "Lekérdezőbutton";
            this.Lekérdezőbutton.Size = new System.Drawing.Size(136, 58);
            this.Lekérdezőbutton.TabIndex = 0;
            this.Lekérdezőbutton.Text = "Cikkszám lekérdezése";
            this.Lekérdezőbutton.UseVisualStyleBackColor = true;
            // 
            // Hozzáadóbutton
            // 
            this.Hozzáadóbutton.Location = new System.Drawing.Point(280, 62);
            this.Hozzáadóbutton.Name = "Hozzáadóbutton";
            this.Hozzáadóbutton.Size = new System.Drawing.Size(136, 58);
            this.Hozzáadóbutton.TabIndex = 1;
            this.Hozzáadóbutton.Text = "Cikkszám hozzáadása";
            this.Hozzáadóbutton.UseVisualStyleBackColor = true;
            // 
            // Törlőbutton
            // 
            this.Törlőbutton.Location = new System.Drawing.Point(528, 62);
            this.Törlőbutton.Name = "Törlőbutton";
            this.Törlőbutton.Size = new System.Drawing.Size(136, 58);
            this.Törlőbutton.TabIndex = 2;
            this.Törlőbutton.Text = "Cikkszám törlése";
            this.Törlőbutton.UseVisualStyleBackColor = true;
            // 
            // ListazocheckedListBox
            // 
            this.ListazocheckedListBox.FormattingEnabled = true;
            this.ListazocheckedListBox.Location = new System.Drawing.Point(262, 176);
            this.ListazocheckedListBox.Name = "ListazocheckedListBox";
            this.ListazocheckedListBox.Size = new System.Drawing.Size(180, 276);
            this.ListazocheckedListBox.TabIndex = 3;
            // 
            // KeresotextBox
            // 
            this.KeresotextBox.Location = new System.Drawing.Point(262, 148);
            this.KeresotextBox.Name = "KeresotextBox";
            this.KeresotextBox.Size = new System.Drawing.Size(180, 22);
            this.KeresotextBox.TabIndex = 4;
            // 
            // tevékenység
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeresotextBox);
            this.Controls.Add(this.ListazocheckedListBox);
            this.Controls.Add(this.Törlőbutton);
            this.Controls.Add(this.Hozzáadóbutton);
            this.Controls.Add(this.Lekérdezőbutton);
            this.Name = "tevékenység";
            this.Text = "tevékenység";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Lekérdezőbutton;
        private System.Windows.Forms.Button Hozzáadóbutton;
        private System.Windows.Forms.Button Törlőbutton;
        private System.Windows.Forms.CheckedListBox ListazocheckedListBox;
        private System.Windows.Forms.TextBox KeresotextBox;
    }
}