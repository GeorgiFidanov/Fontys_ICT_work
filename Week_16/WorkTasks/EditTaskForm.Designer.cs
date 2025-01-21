namespace WorkTasks
{
    partial class EditTaskForm
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
            assignToLabel = new Label();
            byLabel = new Label();
            deadlineLabel = new Label();
            statusLabel = new Label();
            descriptionLabel = new Label();
            departmentLabel = new Label();
            taskLabel = new Label();
            saveBtn = new Button();
            byCheckedListBox = new CheckedListBox();
            editTaskFormGroupBox = new GroupBox();
            departmentCheckedListBox = new CheckedListBox();
            deadlineDateTimePicker = new DateTimePicker();
            descriptionTextBox = new TextBox();
            statusComboBox = new ComboBox();
            nameTextBox = new TextBox();
            assignToCheckedListBox = new CheckedListBox();
            editTaskFormGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // assignToLabel
            // 
            assignToLabel.AutoSize = true;
            assignToLabel.Location = new Point(6, 326);
            assignToLabel.Name = "assignToLabel";
            assignToLabel.Size = new Size(56, 15);
            assignToLabel.TabIndex = 34;
            assignToLabel.Text = "Assign to";
            // 
            // byLabel
            // 
            byLabel.AutoSize = true;
            byLabel.Location = new Point(6, 245);
            byLabel.Name = "byLabel";
            byLabel.Size = new Size(20, 15);
            byLabel.TabIndex = 24;
            byLabel.Text = "By";
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Location = new Point(6, 217);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(53, 15);
            deadlineLabel.TabIndex = 23;
            deadlineLabel.Text = "Deadline";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(6, 126);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 22;
            statusLabel.Text = "Status";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(6, 153);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 21;
            descriptionLabel.Text = "Description";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new Point(6, 46);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(70, 15);
            departmentLabel.TabIndex = 20;
            departmentLabel.Text = "Department";
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(6, 19);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(29, 15);
            taskLabel.TabIndex = 19;
            taskLabel.Text = "Task";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(101, 416);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(210, 22);
            saveBtn.TabIndex = 36;
            saveBtn.Text = "Save changes";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // byCheckedListBox
            // 
            byCheckedListBox.FormattingEnabled = true;
            byCheckedListBox.Location = new Point(101, 255);
            byCheckedListBox.Name = "byCheckedListBox";
            byCheckedListBox.Size = new Size(210, 76);
            byCheckedListBox.TabIndex = 45;
            // 
            // editTaskFormGroupBox
            // 
            editTaskFormGroupBox.Controls.Add(taskLabel);
            editTaskFormGroupBox.Controls.Add(departmentLabel);
            editTaskFormGroupBox.Controls.Add(statusLabel);
            editTaskFormGroupBox.Controls.Add(descriptionLabel);
            editTaskFormGroupBox.Controls.Add(deadlineLabel);
            editTaskFormGroupBox.Controls.Add(byLabel);
            editTaskFormGroupBox.Controls.Add(assignToLabel);
            editTaskFormGroupBox.Location = new Point(14, 10);
            editTaskFormGroupBox.Name = "editTaskFormGroupBox";
            editTaskFormGroupBox.Size = new Size(81, 428);
            editTaskFormGroupBox.TabIndex = 44;
            editTaskFormGroupBox.TabStop = false;
            editTaskFormGroupBox.Text = "Task details";
            // 
            // departmentCheckedListBox
            // 
            departmentCheckedListBox.FormattingEnabled = true;
            departmentCheckedListBox.Location = new Point(101, 56);
            departmentCheckedListBox.Margin = new Padding(3, 2, 3, 2);
            departmentCheckedListBox.Name = "departmentCheckedListBox";
            departmentCheckedListBox.Size = new Size(210, 76);
            departmentCheckedListBox.TabIndex = 42;
            // 
            // deadlineDateTimePicker
            // 
            deadlineDateTimePicker.Location = new Point(101, 227);
            deadlineDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            deadlineDateTimePicker.Size = new Size(210, 23);
            deadlineDateTimePicker.TabIndex = 40;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(101, 163);
            descriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(210, 60);
            descriptionTextBox.TabIndex = 39;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(101, 136);
            statusComboBox.Margin = new Padding(3, 2, 3, 2);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(210, 23);
            statusComboBox.TabIndex = 38;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(101, 29);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(210, 23);
            nameTextBox.TabIndex = 37;
            // 
            // assignToCheckedListBox
            // 
            assignToCheckedListBox.FormattingEnabled = true;
            assignToCheckedListBox.Location = new Point(101, 336);
            assignToCheckedListBox.Margin = new Padding(3, 2, 3, 2);
            assignToCheckedListBox.Name = "assignToCheckedListBox";
            assignToCheckedListBox.Size = new Size(210, 76);
            assignToCheckedListBox.TabIndex = 43;
            // 
            // EditTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 452);
            Controls.Add(byCheckedListBox);
            Controls.Add(editTaskFormGroupBox);
            Controls.Add(departmentCheckedListBox);
            Controls.Add(deadlineDateTimePicker);
            Controls.Add(descriptionTextBox);
            Controls.Add(statusComboBox);
            Controls.Add(nameTextBox);
            Controls.Add(assignToCheckedListBox);
            Controls.Add(saveBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "EditTaskForm";
            Text = "EditTaskForm";
            editTaskFormGroupBox.ResumeLayout(false);
            editTaskFormGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label assignToLabel;
        private Label byLabel;
        private Label deadlineLabel;
        private Label statusLabel;
        private Label descriptionLabel;
        private Label departmentLabel;
        private Label taskLabel;
        private Button saveBtn;
        private CheckedListBox byCheckedListBox;
        private GroupBox editTaskFormGroupBox;
        private CheckedListBox departmentCheckedListBox;
        private DateTimePicker deadlineDateTimePicker;
        private TextBox descriptionTextBox;
        private ComboBox statusComboBox;
        private TextBox nameTextBox;
        private CheckedListBox assignToCheckedListBox;
    }
}