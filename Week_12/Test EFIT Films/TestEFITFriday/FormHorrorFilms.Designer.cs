
namespace TestEFITFriday
{
    partial class FormHorrorFilms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorrorFilms));
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxMiddle = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonMiddle = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeft.Image")));
            this.pictureBoxLeft.Location = new System.Drawing.Point(28, 31);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(470, 300);
            this.pictureBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeft.TabIndex = 0;
            this.pictureBoxLeft.TabStop = false;
            // 
            // pictureBoxMiddle
            // 
            this.pictureBoxMiddle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMiddle.Image")));
            this.pictureBoxMiddle.Location = new System.Drawing.Point(528, 31);
            this.pictureBoxMiddle.Name = "pictureBoxMiddle";
            this.pictureBoxMiddle.Size = new System.Drawing.Size(470, 300);
            this.pictureBoxMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMiddle.TabIndex = 1;
            this.pictureBoxMiddle.TabStop = false;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRight.Image")));
            this.pictureBoxRight.Location = new System.Drawing.Point(1028, 31);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(470, 300);
            this.pictureBoxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRight.TabIndex = 2;
            this.pictureBoxRight.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(233, 361);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(60, 40);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "?";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonMiddle
            // 
            this.buttonMiddle.Location = new System.Drawing.Point(733, 361);
            this.buttonMiddle.Name = "buttonMiddle";
            this.buttonMiddle.Size = new System.Drawing.Size(60, 40);
            this.buttonMiddle.TabIndex = 4;
            this.buttonMiddle.Text = "?";
            this.buttonMiddle.UseVisualStyleBackColor = true;
            this.buttonMiddle.Click += new System.EventHandler(this.buttonMiddle_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(1233, 361);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(60, 40);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = "?";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // FormHorrorFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 438);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonMiddle);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxMiddle);
            this.Controls.Add(this.pictureBoxLeft);
            this.Name = "FormHorrorFilms";
            this.Text = "Horror films";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxMiddle;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonMiddle;
        private System.Windows.Forms.Button buttonRight;
    }
}

