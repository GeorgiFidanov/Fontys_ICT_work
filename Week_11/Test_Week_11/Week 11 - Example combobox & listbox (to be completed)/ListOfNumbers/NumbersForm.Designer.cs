namespace ListOfNumbers
{
    partial class NumbersForm
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
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.buttonForListing = new System.Windows.Forms.Button();
            this.comboBoxMenu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.ItemHeight = 18;
            this.listBoxNumbers.Location = new System.Drawing.Point(97, 156);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(64, 400);
            this.listBoxNumbers.TabIndex = 0;
            this.listBoxNumbers.SelectedIndexChanged += new System.EventHandler(this.listBoxNumbers_SelectedIndexChanged);
            // 
            // buttonForListing
            // 
            this.buttonForListing.Location = new System.Drawing.Point(25, 32);
            this.buttonForListing.Name = "buttonForListing";
            this.buttonForListing.Size = new System.Drawing.Size(205, 44);
            this.buttonForListing.TabIndex = 1;
            this.buttonForListing.Text = "List now!";
            this.buttonForListing.UseVisualStyleBackColor = true;
            this.buttonForListing.Click += new System.EventHandler(this.buttonForListing_Click);
            // 
            // comboBoxMenu
            // 
            this.comboBoxMenu.FormattingEnabled = true;
            this.comboBoxMenu.Items.AddRange(new object[] {
            "Ascending",
            "Descending",
            "Post delivery from below",
            "Post delivery from above"});
            this.comboBoxMenu.Location = new System.Drawing.Point(25, 103);
            this.comboBoxMenu.Name = "comboBoxMenu";
            this.comboBoxMenu.Size = new System.Drawing.Size(205, 26);
            this.comboBoxMenu.TabIndex = 2;
            this.comboBoxMenu.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // NumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 584);
            this.Controls.Add(this.comboBoxMenu);
            this.Controls.Add(this.buttonForListing);
            this.Controls.Add(this.listBoxNumbers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NumbersForm";
            this.Text = "Numbers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.Button buttonForListing;
        private System.Windows.Forms.ComboBox comboBoxMenu;
    }
}

