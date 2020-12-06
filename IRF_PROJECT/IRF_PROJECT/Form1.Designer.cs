namespace IRF_PROJECT
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.jelszoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Belepo_button = new System.Windows.Forms.Button();
            this.Elfelejtett_jelszo = new System.Windows.Forms.Button();
            this.felhasznalocomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bejelentkezés";
            // 
            // jelszoTextBox
            // 
            this.jelszoTextBox.Location = new System.Drawing.Point(297, 171);
            this.jelszoTextBox.Name = "jelszoTextBox";
            this.jelszoTextBox.Size = new System.Drawing.Size(195, 22);
            this.jelszoTextBox.TabIndex = 2;
            this.jelszoTextBox.TextChanged += new System.EventHandler(this.jelszoTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Felhasználó";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jelszó";
            // 
            // Belepo_button
            // 
            this.Belepo_button.Location = new System.Drawing.Point(181, 256);
            this.Belepo_button.Name = "Belepo_button";
            this.Belepo_button.Size = new System.Drawing.Size(121, 47);
            this.Belepo_button.TabIndex = 5;
            this.Belepo_button.Text = "Belépés";
            this.Belepo_button.UseVisualStyleBackColor = true;
            this.Belepo_button.Click += new System.EventHandler(this.Belepo_button_Click);
            // 
            // Elfelejtett_jelszo
            // 
            this.Elfelejtett_jelszo.Location = new System.Drawing.Point(371, 256);
            this.Elfelejtett_jelszo.Name = "Elfelejtett_jelszo";
            this.Elfelejtett_jelszo.Size = new System.Drawing.Size(121, 47);
            this.Elfelejtett_jelszo.TabIndex = 6;
            this.Elfelejtett_jelszo.Text = "Elfelejtett jelszó";
            this.Elfelejtett_jelszo.UseVisualStyleBackColor = true;
            // 
            // felhasznalocomboBox
            // 
            this.felhasznalocomboBox.FormattingEnabled = true;
            this.felhasznalocomboBox.Location = new System.Drawing.Point(297, 115);
            this.felhasznalocomboBox.Name = "felhasznalocomboBox";
            this.felhasznalocomboBox.Size = new System.Drawing.Size(195, 24);
            this.felhasznalocomboBox.TabIndex = 7;
            this.felhasznalocomboBox.SelectedIndexChanged += new System.EventHandler(this.felhasznalocomboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.felhasznalocomboBox);
            this.Controls.Add(this.Elfelejtett_jelszo);
            this.Controls.Add(this.Belepo_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jelszoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jelszoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Belepo_button;
        private System.Windows.Forms.Button Elfelejtett_jelszo;
        private System.Windows.Forms.ComboBox felhasznalocomboBox;
    }
}

