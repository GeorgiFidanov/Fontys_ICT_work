namespace WorkTasks
{
    partial class LogInForm
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
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(27, 16);
            usernameTextBox.Margin = new Padding(3, 4, 3, 4);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(159, 27);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(27, 55);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(159, 27);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(231, 55);
            loginBtn.Margin = new Padding(3, 4, 3, 4);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(104, 31);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(231, 16);
            clearBtn.Margin = new Padding(3, 4, 3, 4);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(104, 31);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 101);
            Controls.Add(clearBtn);
            Controls.Add(loginBtn);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LogInForm";
            Text = "LogInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginBtn;
        private Button clearBtn;
    }
}