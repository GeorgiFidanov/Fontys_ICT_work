namespace WorkTasks
{
    partial class RemoveTasksForm
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
            availableTasksListBox = new ListBox();
            removeTaskbtn = new Button();
            SuspendLayout();
            // 
            // availableTasksListBox
            // 
            availableTasksListBox.FormattingEnabled = true;
            availableTasksListBox.ItemHeight = 15;
            availableTasksListBox.Location = new Point(12, 11);
            availableTasksListBox.Margin = new Padding(3, 2, 3, 2);
            availableTasksListBox.Name = "availableTasksListBox";
            availableTasksListBox.Size = new Size(381, 169);
            availableTasksListBox.TabIndex = 0;
            // 
            // removeTaskbtn
            // 
            removeTaskbtn.Location = new Point(12, 185);
            removeTaskbtn.Margin = new Padding(3, 2, 3, 2);
            removeTaskbtn.Name = "removeTaskbtn";
            removeTaskbtn.Size = new Size(381, 22);
            removeTaskbtn.TabIndex = 1;
            removeTaskbtn.Text = "Remove selected task";
            removeTaskbtn.UseVisualStyleBackColor = true;
            removeTaskbtn.Click += removeTaskbtn_Click;
            // 
            // RemoveTasksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 218);
            Controls.Add(removeTaskbtn);
            Controls.Add(availableTasksListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RemoveTasksForm";
            Text = "RemoveTasksForm";
            ResumeLayout(false);
        }

        #endregion

        private ListBox availableTasksListBox;
        private Button removeTaskbtn;
    }
}