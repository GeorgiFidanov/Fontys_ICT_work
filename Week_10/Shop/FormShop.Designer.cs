namespace Shop
{
    partial class FormShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelName = new Label();
            labelPrice = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            listBoxInformation = new ListBox();
            buttonAdd = new Button();
            buttonShowAll = new Button();
            buttonShowOne = new Button();
            textBoxNameForSearch = new TextBox();
            labelNameForSearch = new Label();
            checkBoxFuture = new CheckBox();
            textBoxInflation = new TextBox();
            labelInflation = new Label();
            textBoxLimit = new TextBox();
            labelLimit = new Label();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(127, 32);
            labelName.Name = "labelName";
            labelName.Size = new Size(66, 25);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(135, 78);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(58, 25);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Price:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(199, 29);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "ex. eggs";
            textBoxName.ScrollBars = ScrollBars.Horizontal;
            textBoxName.Size = new Size(125, 32);
            textBoxName.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(199, 75);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.PlaceholderText = "ex. 3.14";
            textBoxPrice.Size = new Size(125, 32);
            textBoxPrice.TabIndex = 3;
            // 
            // listBoxInformation
            // 
            listBoxInformation.FormattingEnabled = true;
            listBoxInformation.ItemHeight = 25;
            listBoxInformation.Location = new Point(361, 29);
            listBoxInformation.Name = "listBoxInformation";
            listBoxInformation.Size = new Size(271, 579);
            listBoxInformation.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(38, 121);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(286, 43);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "Add product";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(38, 254);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(286, 43);
            buttonShowAll.TabIndex = 6;
            buttonShowAll.Text = "Show all products";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // buttonShowOne
            // 
            buttonShowOne.Location = new Point(38, 439);
            buttonShowOne.Name = "buttonShowOne";
            buttonShowOne.Size = new Size(286, 43);
            buttonShowOne.TabIndex = 7;
            buttonShowOne.Text = "Show one product";
            buttonShowOne.UseVisualStyleBackColor = true;
            buttonShowOne.Click += buttonShowOne_Click;
            // 
            // textBoxNameForSearch
            // 
            textBoxNameForSearch.Location = new Point(199, 394);
            textBoxNameForSearch.Name = "textBoxNameForSearch";
            textBoxNameForSearch.PlaceholderText = "ex. bread";
            textBoxNameForSearch.Size = new Size(125, 32);
            textBoxNameForSearch.TabIndex = 9;
            // 
            // labelNameForSearch
            // 
            labelNameForSearch.AutoSize = true;
            labelNameForSearch.Location = new Point(38, 397);
            labelNameForSearch.Name = "labelNameForSearch";
            labelNameForSearch.Size = new Size(155, 25);
            labelNameForSearch.TabIndex = 8;
            labelNameForSearch.Text = "Name for search:";
            // 
            // checkBoxFuture
            // 
            checkBoxFuture.AutoSize = true;
            checkBoxFuture.Location = new Point(60, 489);
            checkBoxFuture.Name = "checkBoxFuture";
            checkBoxFuture.Size = new Size(245, 29);
            checkBoxFuture.TabIndex = 10;
            checkBoxFuture.Text = "Include analysis of future";
            checkBoxFuture.UseVisualStyleBackColor = true;
            // 
            // textBoxInflation
            // 
            textBoxInflation.Location = new Point(199, 530);
            textBoxInflation.Name = "textBoxInflation";
            textBoxInflation.PlaceholderText = "from 1 to 100";
            textBoxInflation.Size = new Size(125, 32);
            textBoxInflation.TabIndex = 12;
            // 
            // labelInflation
            // 
            labelInflation.AutoSize = true;
            labelInflation.Location = new Point(69, 533);
            labelInflation.Name = "labelInflation";
            labelInflation.Size = new Size(124, 25);
            labelInflation.TabIndex = 11;
            labelInflation.Text = "Inflation rate:";
            // 
            // textBoxLimit
            // 
            textBoxLimit.Location = new Point(199, 575);
            textBoxLimit.Name = "textBoxLimit";
            textBoxLimit.PlaceholderText = "max price";
            textBoxLimit.Size = new Size(125, 32);
            textBoxLimit.TabIndex = 14;
            // 
            // labelLimit
            // 
            labelLimit.AutoSize = true;
            labelLimit.Location = new Point(136, 578);
            labelLimit.Name = "labelLimit";
            labelLimit.Size = new Size(57, 25);
            labelLimit.TabIndex = 13;
            labelLimit.Text = "Limit:";
            // 
            // FormShop
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 640);
            Controls.Add(textBoxLimit);
            Controls.Add(labelLimit);
            Controls.Add(textBoxInflation);
            Controls.Add(labelInflation);
            Controls.Add(checkBoxFuture);
            Controls.Add(textBoxNameForSearch);
            Controls.Add(labelNameForSearch);
            Controls.Add(buttonShowOne);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonAdd);
            Controls.Add(listBoxInformation);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "FormShop";
            Text = "Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelPrice;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private ListBox listBoxInformation;
        private Button buttonAdd;
        private Button buttonShowAll;
        private Button buttonShowOne;
        private TextBox textBoxNameForSearch;
        private Label labelNameForSearch;
        private CheckBox checkBoxFuture;
        private TextBox textBoxInflation;
        private Label labelInflation;
        private TextBox textBoxLimit;
        private Label labelLimit;
    }
}
