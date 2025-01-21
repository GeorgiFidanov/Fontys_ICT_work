namespace WorkTasks
{
    partial class UploadOptionsForm
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
            optionsLabel = new Label();
            fileBtn = new Button();
            DbBtn = new Button();
            SuspendLayout();
            // 
            // optionsLabel
            // 
            optionsLabel.AutoSize = true;
            optionsLabel.Location = new Point(121, 9);
            optionsLabel.Name = "optionsLabel";
            optionsLabel.Size = new Size(166, 15);
            optionsLabel.TabIndex = 0;
            optionsLabel.Text = "Please pick an upload method";
            // 
            // fileBtn
            // 
            fileBtn.Location = new Point(66, 44);
            fileBtn.Name = "fileBtn";
            fileBtn.Size = new Size(126, 23);
            fileBtn.TabIndex = 1;
            fileBtn.Text = "From file";
            fileBtn.UseVisualStyleBackColor = true;
            fileBtn.Click += fileBtn_Click;
            // 
            // DbBtn
            // 
            DbBtn.Location = new Point(222, 44);
            DbBtn.Name = "DbBtn";
            DbBtn.Size = new Size(126, 23);
            DbBtn.TabIndex = 3;
            DbBtn.Text = "From DB";
            DbBtn.UseVisualStyleBackColor = true;
            DbBtn.Click += DbBtn_Click;
            // 
            // UploadOptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 92);
            Controls.Add(DbBtn);
            Controls.Add(fileBtn);
            Controls.Add(optionsLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "UploadOptionsForm";
            Text = "UploadOptionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label optionsLabel;
        private Button fileBtn;
        private Button DbBtn;
    }
}