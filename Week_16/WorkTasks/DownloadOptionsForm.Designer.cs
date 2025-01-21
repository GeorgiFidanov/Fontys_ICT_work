namespace WorkTasks
{
    partial class DownloadOptionsForm
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
            DbBtn = new Button();
            JSONBtn = new Button();
            CSVBtn = new Button();
            optionsLabel = new Label();
            SuspendLayout();
            // 
            // DbBtn
            // 
            DbBtn.Location = new Point(320, 76);
            DbBtn.Margin = new Padding(3, 4, 3, 4);
            DbBtn.Name = "DbBtn";
            DbBtn.Size = new Size(144, 31);
            DbBtn.TabIndex = 7;
            DbBtn.Text = "DB";
            DbBtn.UseVisualStyleBackColor = true;
            DbBtn.Click += DbBtn_Click;
            // 
            // JSONBtn
            // 
            JSONBtn.Location = new Point(169, 76);
            JSONBtn.Margin = new Padding(3, 4, 3, 4);
            JSONBtn.Name = "JSONBtn";
            JSONBtn.Size = new Size(144, 31);
            JSONBtn.TabIndex = 6;
            JSONBtn.Text = "JSON";
            JSONBtn.UseVisualStyleBackColor = true;
            JSONBtn.Click += JSONBtn_Click;
            // 
            // CSVBtn
            // 
            CSVBtn.Location = new Point(18, 76);
            CSVBtn.Margin = new Padding(3, 4, 3, 4);
            CSVBtn.Name = "CSVBtn";
            CSVBtn.Size = new Size(144, 31);
            CSVBtn.TabIndex = 5;
            CSVBtn.Text = "CSV";
            CSVBtn.UseVisualStyleBackColor = true;
            CSVBtn.Click += CSVBtn_Click;
            // 
            // optionsLabel
            // 
            optionsLabel.AutoSize = true;
            optionsLabel.Location = new Point(152, 33);
            optionsLabel.Name = "optionsLabel";
            optionsLabel.Size = new Size(195, 20);
            optionsLabel.TabIndex = 4;
            optionsLabel.Text = "Please choose a save option";
            // 
            // DownloadOptionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 123);
            Controls.Add(DbBtn);
            Controls.Add(JSONBtn);
            Controls.Add(CSVBtn);
            Controls.Add(optionsLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DownloadOptionsForm";
            Text = "DownloadOptionsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DbBtn;
        private Button JSONBtn;
        private Button CSVBtn;
        private Label optionsLabel;
    }
}