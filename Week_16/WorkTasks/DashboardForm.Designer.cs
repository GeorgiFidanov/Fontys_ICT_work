namespace WorkTasks
{
    partial class DashboardForm
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
            allTaskListBox = new ListBox();
            filterTextBox = new TextBox();
            statusFilterComboBox = new ComboBox();
            departmentFilterComboBox = new ComboBox();
            applyFiltersButton = new Button();
            clearFiltersButton = new Button();
            SuspendLayout();
            // 
            // allTaskListBox
            // 
            allTaskListBox.FormattingEnabled = true;
            allTaskListBox.ItemHeight = 15;
            allTaskListBox.Location = new Point(12, 9);
            allTaskListBox.Margin = new Padding(3, 2, 3, 2);
            allTaskListBox.Name = "allTaskListBox";
            allTaskListBox.Size = new Size(1144, 139);
            allTaskListBox.TabIndex = 0;
            // 
            // filterTextBox
            // 
            filterTextBox.Location = new Point(492, 185);
            filterTextBox.Margin = new Padding(3, 2, 3, 2);
            filterTextBox.Name = "filterTextBox";
            filterTextBox.PlaceholderText = "Filter";
            filterTextBox.Size = new Size(288, 23);
            filterTextBox.TabIndex = 1;
            // 
            // statusFilterComboBox
            // 
            statusFilterComboBox.FormattingEnabled = true;
            statusFilterComboBox.Location = new Point(786, 185);
            statusFilterComboBox.Name = "statusFilterComboBox";
            statusFilterComboBox.Size = new Size(112, 23);
            statusFilterComboBox.TabIndex = 3;
            statusFilterComboBox.Text = "Status";
            // 
            // departmentFilterComboBox
            // 
            departmentFilterComboBox.FormattingEnabled = true;
            departmentFilterComboBox.Location = new Point(904, 185);
            departmentFilterComboBox.Name = "departmentFilterComboBox";
            departmentFilterComboBox.Size = new Size(112, 23);
            departmentFilterComboBox.TabIndex = 4;
            departmentFilterComboBox.Text = "Department";
            // 
            // applyFiltersButton
            // 
            applyFiltersButton.Location = new Point(1022, 184);
            applyFiltersButton.Name = "applyFiltersButton";
            applyFiltersButton.Size = new Size(64, 23);
            applyFiltersButton.TabIndex = 5;
            applyFiltersButton.Text = "Search";
            applyFiltersButton.UseVisualStyleBackColor = true;
            applyFiltersButton.Click += applyFiltersButton_Click;
            // 
            // clearFiltersButton
            // 
            clearFiltersButton.Location = new Point(1092, 184);
            clearFiltersButton.Name = "clearFiltersButton";
            clearFiltersButton.Size = new Size(64, 23);
            clearFiltersButton.TabIndex = 6;
            clearFiltersButton.Text = "Clear";
            clearFiltersButton.UseVisualStyleBackColor = true;
            clearFiltersButton.Click += clearFiltersButton_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 218);
            Controls.Add(clearFiltersButton);
            Controls.Add(applyFiltersButton);
            Controls.Add(departmentFilterComboBox);
            Controls.Add(statusFilterComboBox);
            Controls.Add(filterTextBox);
            Controls.Add(allTaskListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "DashboardForm";
            Text = "DashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox allTaskListBox;
        private TextBox filterTextBox;
        private ComboBox statusFilterComboBox;
        private ComboBox departmentFilterComboBox;
        private Button applyFiltersButton;
        private Button clearFiltersButton;
    }
}