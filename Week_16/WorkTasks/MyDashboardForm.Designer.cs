namespace WorkTasks
{
    partial class MyDashboardForm
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
            editTaskLbael = new Label();
            myTasksListBox = new ListBox();
            SuspendLayout();
            // 
            // editTaskLbael
            // 
            editTaskLbael.AutoSize = true;
            editTaskLbael.Location = new Point(12, 10);
            editTaskLbael.Name = "editTaskLbael";
            editTaskLbael.Size = new Size(231, 15);
            editTaskLbael.TabIndex = 3;
            editTaskLbael.Text = "Pick a task to update (double click to edit) ";
            // 
            // myTasksListBox
            // 
            myTasksListBox.FormattingEnabled = true;
            myTasksListBox.ItemHeight = 15;
            myTasksListBox.Location = new Point(12, 39);
            myTasksListBox.Margin = new Padding(3, 2, 3, 2);
            myTasksListBox.Name = "myTasksListBox";
            myTasksListBox.Size = new Size(381, 169);
            myTasksListBox.TabIndex = 2;
            myTasksListBox.SelectedIndexChanged += myTasksListBox_SelectedIndexChanged;
            // 
            // MyDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 218);
            Controls.Add(editTaskLbael);
            Controls.Add(myTasksListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MyDashboardForm";
            Text = "MyDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label editTaskLbael;
        private ListBox myTasksListBox;
    }
}