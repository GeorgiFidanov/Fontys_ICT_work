namespace WorkTasks
{
    partial class UpdateTaskForm
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
            allTasksListBox = new ListBox();
            editTaskLbael = new Label();
            SuspendLayout();
            // 
            // allTasksListBox
            // 
            allTasksListBox.FormattingEnabled = true;
            allTasksListBox.ItemHeight = 15;
            allTasksListBox.Location = new Point(12, 38);
            allTasksListBox.Margin = new Padding(3, 2, 3, 2);
            allTasksListBox.Name = "allTasksListBox";
            allTasksListBox.Size = new Size(381, 169);
            allTasksListBox.TabIndex = 0;
            allTasksListBox.SelectedIndexChanged += allTasksListBox_SelectedIndexChanged;
            // 
            // editTaskLbael
            // 
            editTaskLbael.AutoSize = true;
            editTaskLbael.Location = new Point(12, 9);
            editTaskLbael.Name = "editTaskLbael";
            editTaskLbael.Size = new Size(231, 15);
            editTaskLbael.TabIndex = 1;
            editTaskLbael.Text = "Pick a task to update (double click to edit) ";
            // 
            // UpdateTaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 218);
            Controls.Add(editTaskLbael);
            Controls.Add(allTasksListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "UpdateTaskForm";
            Text = "UpdateTaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox allTasksListBox;
        private Label editTaskLbael;
    }
}