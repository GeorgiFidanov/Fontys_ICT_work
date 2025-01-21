namespace WorkTasks
{
    partial class MainForm
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
            newTaskBtn = new Button();
            removeTasksBtn = new Button();
            updateTaskBtn = new Button();
            dashboardBtn = new Button();
            downloadBtn = new Button();
            uploadBtn = new Button();
            loginBtn = new Button();
            optionsGroupBox = new GroupBox();
            mainLabel = new Label();
            optionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // newTaskBtn
            // 
            newTaskBtn.Location = new Point(5, 20);
            newTaskBtn.Margin = new Padding(3, 2, 3, 2);
            newTaskBtn.Name = "newTaskBtn";
            newTaskBtn.Size = new Size(152, 22);
            newTaskBtn.TabIndex = 0;
            newTaskBtn.Text = "Create new task";
            newTaskBtn.UseVisualStyleBackColor = true;
            newTaskBtn.Click += newTaskBtn_Click;
            // 
            // removeTasksBtn
            // 
            removeTasksBtn.Location = new Point(5, 46);
            removeTasksBtn.Margin = new Padding(3, 2, 3, 2);
            removeTasksBtn.Name = "removeTasksBtn";
            removeTasksBtn.Size = new Size(152, 22);
            removeTasksBtn.TabIndex = 1;
            removeTasksBtn.Text = "Remove task(s)";
            removeTasksBtn.UseVisualStyleBackColor = true;
            removeTasksBtn.Click += removeTasksBtn_Click;
            // 
            // updateTaskBtn
            // 
            updateTaskBtn.Location = new Point(5, 72);
            updateTaskBtn.Margin = new Padding(3, 2, 3, 2);
            updateTaskBtn.Name = "updateTaskBtn";
            updateTaskBtn.Size = new Size(152, 22);
            updateTaskBtn.TabIndex = 2;
            updateTaskBtn.Text = "Update tasks";
            updateTaskBtn.UseVisualStyleBackColor = true;
            updateTaskBtn.Click += updateTaskBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.Location = new Point(5, 98);
            dashboardBtn.Margin = new Padding(3, 2, 3, 2);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(152, 22);
            dashboardBtn.TabIndex = 3;
            dashboardBtn.Text = "Dashboard";
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // downloadBtn
            // 
            downloadBtn.Location = new Point(5, 124);
            downloadBtn.Margin = new Padding(3, 2, 3, 2);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(152, 22);
            downloadBtn.TabIndex = 4;
            downloadBtn.Text = "Save data";
            downloadBtn.UseVisualStyleBackColor = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // uploadBtn
            // 
            uploadBtn.Location = new Point(5, 151);
            uploadBtn.Margin = new Padding(3, 2, 3, 2);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(152, 22);
            uploadBtn.TabIndex = 5;
            uploadBtn.Text = "Load data";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(5, 177);
            loginBtn.Margin = new Padding(3, 2, 3, 2);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(152, 22);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // optionsGroupBox
            // 
            optionsGroupBox.Controls.Add(newTaskBtn);
            optionsGroupBox.Controls.Add(loginBtn);
            optionsGroupBox.Controls.Add(removeTasksBtn);
            optionsGroupBox.Controls.Add(uploadBtn);
            optionsGroupBox.Controls.Add(updateTaskBtn);
            optionsGroupBox.Controls.Add(downloadBtn);
            optionsGroupBox.Controls.Add(dashboardBtn);
            optionsGroupBox.Location = new Point(10, 9);
            optionsGroupBox.Margin = new Padding(3, 2, 3, 2);
            optionsGroupBox.Name = "optionsGroupBox";
            optionsGroupBox.Padding = new Padding(3, 2, 3, 2);
            optionsGroupBox.Size = new Size(168, 206);
            optionsGroupBox.TabIndex = 7;
            optionsGroupBox.TabStop = false;
            optionsGroupBox.Text = "Available options";
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.Location = new Point(226, 97);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(140, 15);
            mainLabel.TabIndex = 8;
            mainLabel.Text = "Task Management Studio";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 218);
            Controls.Add(mainLabel);
            Controls.Add(optionsGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Options window";
            optionsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button newTaskBtn;
        private Button removeTasksBtn;
        private Button updateTaskBtn;
        private Button dashboardBtn;
        private Button downloadBtn;
        private Button uploadBtn;
        private Button loginBtn;
        protected GroupBox optionsGroupBox;
        private Label mainLabel;
    }
}
