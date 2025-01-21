namespace WorkTasks
{
    partial class NewTaskForm
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
            taskTextBox = new TextBox();
            taskLabel = new Label();
            departmentLabel = new Label();
            descriptionLabel = new Label();
            statusLabel = new Label();
            deadlineLabel = new Label();
            byLabel = new Label();
            statusComboBox = new ComboBox();
            descriptionTextBox = new TextBox();
            deadlineDateTimePicker = new DateTimePicker();
            assignToLabel = new Label();
            saveBtn = new Button();
            departmentCheckedListBox = new CheckedListBox();
            assignToCheckedListBox = new CheckedListBox();
            newTaskFormGroupBox = new GroupBox();
            byCheckedListBox = new CheckedListBox();
            newTaskFormGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(100, 13);
            taskTextBox.Margin = new Padding(3, 2, 3, 2);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(210, 23);
            taskTextBox.TabIndex = 0;
            // 
            // taskLabel
            // 
            taskLabel.AutoSize = true;
            taskLabel.Location = new Point(6, 10);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(29, 15);
            taskLabel.TabIndex = 1;
            taskLabel.Text = "Task";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new Point(6, 34);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(70, 15);
            departmentLabel.TabIndex = 2;
            departmentLabel.Text = "Department";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(6, 141);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(6, 114);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status";
            // 
            // deadlineLabel
            // 
            deadlineLabel.AutoSize = true;
            deadlineLabel.Location = new Point(6, 205);
            deadlineLabel.Name = "deadlineLabel";
            deadlineLabel.Size = new Size(53, 15);
            deadlineLabel.TabIndex = 5;
            deadlineLabel.Text = "Deadline";
            // 
            // byLabel
            // 
            byLabel.AutoSize = true;
            byLabel.Location = new Point(6, 233);
            byLabel.Name = "byLabel";
            byLabel.Size = new Size(20, 15);
            byLabel.TabIndex = 6;
            byLabel.Text = "By";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(100, 120);
            statusComboBox.Margin = new Padding(3, 2, 3, 2);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(210, 23);
            statusComboBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(100, 147);
            descriptionTextBox.Margin = new Padding(3, 2, 3, 2);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(210, 60);
            descriptionTextBox.TabIndex = 13;
            // 
            // deadlineDateTimePicker
            // 
            deadlineDateTimePicker.Location = new Point(100, 211);
            deadlineDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            deadlineDateTimePicker.Size = new Size(210, 23);
            deadlineDateTimePicker.TabIndex = 14;
            // 
            // assignToLabel
            // 
            assignToLabel.AutoSize = true;
            assignToLabel.Location = new Point(6, 314);
            assignToLabel.Name = "assignToLabel";
            assignToLabel.Size = new Size(56, 15);
            assignToLabel.TabIndex = 16;
            assignToLabel.Text = "Assign to";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(100, 400);
            saveBtn.Margin = new Padding(3, 2, 3, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(210, 22);
            saveBtn.TabIndex = 18;
            saveBtn.Text = "Save new task";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // departmentCheckedListBox
            // 
            departmentCheckedListBox.FormattingEnabled = true;
            departmentCheckedListBox.Location = new Point(100, 40);
            departmentCheckedListBox.Margin = new Padding(3, 2, 3, 2);
            departmentCheckedListBox.Name = "departmentCheckedListBox";
            departmentCheckedListBox.Size = new Size(210, 76);
            departmentCheckedListBox.TabIndex = 19;
            // 
            // assignToCheckedListBox
            // 
            assignToCheckedListBox.FormattingEnabled = true;
            assignToCheckedListBox.Location = new Point(100, 320);
            assignToCheckedListBox.Margin = new Padding(3, 2, 3, 2);
            assignToCheckedListBox.Name = "assignToCheckedListBox";
            assignToCheckedListBox.Size = new Size(210, 76);
            assignToCheckedListBox.TabIndex = 22;
            // 
            // newTaskFormGroupBox
            // 
            newTaskFormGroupBox.Controls.Add(taskLabel);
            newTaskFormGroupBox.Controls.Add(departmentLabel);
            newTaskFormGroupBox.Controls.Add(statusLabel);
            newTaskFormGroupBox.Controls.Add(descriptionLabel);
            newTaskFormGroupBox.Controls.Add(assignToLabel);
            newTaskFormGroupBox.Controls.Add(deadlineLabel);
            newTaskFormGroupBox.Controls.Add(byLabel);
            newTaskFormGroupBox.Location = new Point(13, 6);
            newTaskFormGroupBox.Name = "newTaskFormGroupBox";
            newTaskFormGroupBox.Size = new Size(81, 415);
            newTaskFormGroupBox.TabIndex = 23;
            newTaskFormGroupBox.TabStop = false;
            // 
            // byCheckedListBox
            // 
            byCheckedListBox.FormattingEnabled = true;
            byCheckedListBox.Location = new Point(100, 239);
            byCheckedListBox.Name = "byCheckedListBox";
            byCheckedListBox.Size = new Size(210, 76);
            byCheckedListBox.TabIndex = 24;
            // 
            // NewTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 431);
            Controls.Add(byCheckedListBox);
            Controls.Add(newTaskFormGroupBox);
            Controls.Add(departmentCheckedListBox);
            Controls.Add(saveBtn);
            Controls.Add(deadlineDateTimePicker);
            Controls.Add(descriptionTextBox);
            Controls.Add(statusComboBox);
            Controls.Add(taskTextBox);
            Controls.Add(assignToCheckedListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "NewTaskForm";
            Text = "NewTaskForm";
            newTaskFormGroupBox.ResumeLayout(false);
            newTaskFormGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox taskTextBox;
        private Label taskLabel;
        private Label departmentLabel;
        private Label descriptionLabel;
        private Label statusLabel;
        private Label deadlineLabel;
        private Label byLabel;
        private ComboBox statusComboBox;
        private TextBox descriptionTextBox;
        private DateTimePicker deadlineDateTimePicker;
        private Label assignToLabel;
        private Button saveBtn;
        private CheckedListBox departmentCheckedListBox;
        private CheckedListBox assignToCheckedListBox;
        private GroupBox newTaskFormGroupBox;
        private CheckedListBox byCheckedListBox;
    }
}