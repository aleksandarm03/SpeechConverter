namespace Speech_Converter
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
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.buttonPokreni = new System.Windows.Forms.Button();
            this.buttonNastaviPauziraj = new System.Windows.Forms.Button();
            this.buttonZaustavi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(0, 28);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(551, 228);
            this.richTextBoxText.TabIndex = 0;
            this.richTextBoxText.Text = "";
            // 
            // buttonPokreni
            // 
            this.buttonPokreni.Location = new System.Drawing.Point(49, 273);
            this.buttonPokreni.Name = "buttonPokreni";
            this.buttonPokreni.Size = new System.Drawing.Size(75, 23);
            this.buttonPokreni.TabIndex = 1;
            this.buttonPokreni.Text = "Pokreni";
            this.buttonPokreni.UseVisualStyleBackColor = true;
            this.buttonPokreni.Click += new System.EventHandler(this.Pokreni);
            // 
            // buttonNastaviPauziraj
            // 
            this.buttonNastaviPauziraj.Location = new System.Drawing.Point(235, 273);
            this.buttonNastaviPauziraj.Name = "buttonNastaviPauziraj";
            this.buttonNastaviPauziraj.Size = new System.Drawing.Size(75, 23);
            this.buttonNastaviPauziraj.TabIndex = 1;
            this.buttonNastaviPauziraj.Text = "Pauziraj";
            this.buttonNastaviPauziraj.UseVisualStyleBackColor = true;
            this.buttonNastaviPauziraj.Click += new System.EventHandler(this.PauzirajNastavi);
            // 
            // buttonZaustavi
            // 
            this.buttonZaustavi.Location = new System.Drawing.Point(429, 273);
            this.buttonZaustavi.Name = "buttonZaustavi";
            this.buttonZaustavi.Size = new System.Drawing.Size(75, 23);
            this.buttonZaustavi.TabIndex = 1;
            this.buttonZaustavi.Text = "Zaustavi";
            this.buttonZaustavi.UseVisualStyleBackColor = true;
            this.buttonZaustavi.Click += new System.EventHandler(this.Zaustavi);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesite tekst:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(552, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZaustavi);
            this.Controls.Add(this.buttonNastaviPauziraj);
            this.Controls.Add(this.buttonPokreni);
            this.Controls.Add(this.richTextBoxText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Button buttonPokreni;
        private System.Windows.Forms.Button buttonNastaviPauziraj;
        private System.Windows.Forms.Button buttonZaustavi;
        private System.Windows.Forms.Label label1;
    }
}

