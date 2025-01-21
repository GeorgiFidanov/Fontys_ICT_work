
namespace TestEFITThursday
{
    partial class FormNetherlands
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
            this.buttonCapital = new System.Windows.Forms.Button();
            this.buttonPrimeMinister = new System.Windows.Forms.Button();
            this.buttonEindhoven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCapital
            // 
            this.buttonCapital.Location = new System.Drawing.Point(87, 38);
            this.buttonCapital.Name = "buttonCapital";
            this.buttonCapital.Size = new System.Drawing.Size(184, 44);
            this.buttonCapital.TabIndex = 0;
            this.buttonCapital.Text = "Capital";
            this.buttonCapital.UseVisualStyleBackColor = true;
            this.buttonCapital.Click += new System.EventHandler(this.buttonCapital_Click);
            // 
            // buttonPrimeMinister
            // 
            this.buttonPrimeMinister.Location = new System.Drawing.Point(87, 108);
            this.buttonPrimeMinister.Name = "buttonPrimeMinister";
            this.buttonPrimeMinister.Size = new System.Drawing.Size(184, 44);
            this.buttonPrimeMinister.TabIndex = 1;
            this.buttonPrimeMinister.Text = "Prime Minister";
            this.buttonPrimeMinister.UseVisualStyleBackColor = true;
            this.buttonPrimeMinister.Click += new System.EventHandler(this.buttonPrimeMinister_Click);
            // 
            // buttonEindhoven
            // 
            this.buttonEindhoven.Location = new System.Drawing.Point(87, 178);
            this.buttonEindhoven.Name = "buttonEindhoven";
            this.buttonEindhoven.Size = new System.Drawing.Size(184, 44);
            this.buttonEindhoven.TabIndex = 2;
            this.buttonEindhoven.Text = "Eindhoven";
            this.buttonEindhoven.UseVisualStyleBackColor = true;
            this.buttonEindhoven.Click += new System.EventHandler(this.buttonEindhoven_Click);
            // 
            // FormNetherlands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 262);
            this.Controls.Add(this.buttonEindhoven);
            this.Controls.Add(this.buttonPrimeMinister);
            this.Controls.Add(this.buttonCapital);
            this.Name = "FormNetherlands";
            this.Text = "The Netherlands";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCapital;
        private System.Windows.Forms.Button buttonPrimeMinister;
        private System.Windows.Forms.Button buttonEindhoven;
    }
}

