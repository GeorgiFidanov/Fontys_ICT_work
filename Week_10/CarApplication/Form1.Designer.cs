namespace CarApplication
{
    partial class Form1
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
            car1InfoLabel = new Label();
            car1AccelerateButton = new Button();
            car1BrakeButton = new Button();
            car2InfoLabel = new Label();
            car2AccelerateButton = new Button();
            car2BrakeButton = new Button();
            SuspendLayout();
            // 
            // car1InfoLabel
            // 
            car1InfoLabel.AutoSize = true;
            car1InfoLabel.Location = new Point(15, 15);
            car1InfoLabel.Margin = new Padding(4, 0, 4, 0);
            car1InfoLabel.Name = "car1InfoLabel";
            car1InfoLabel.Size = new Size(29, 15);
            car1InfoLabel.TabIndex = 0;
            car1InfoLabel.Text = "car1";
            // 
            // car1AccelerateButton
            // 
            car1AccelerateButton.Location = new Point(19, 58);
            car1AccelerateButton.Margin = new Padding(4, 3, 4, 3);
            car1AccelerateButton.Name = "car1AccelerateButton";
            car1AccelerateButton.Size = new Size(88, 27);
            car1AccelerateButton.TabIndex = 1;
            car1AccelerateButton.Text = "Accelerate";
            car1AccelerateButton.UseVisualStyleBackColor = true;
            car1AccelerateButton.Click += car1AccelerateButton_Click;
            // 
            // car1BrakeButton
            // 
            car1BrakeButton.Location = new Point(113, 58);
            car1BrakeButton.Margin = new Padding(4, 3, 4, 3);
            car1BrakeButton.Name = "car1BrakeButton";
            car1BrakeButton.Size = new Size(88, 27);
            car1BrakeButton.TabIndex = 2;
            car1BrakeButton.Text = "Brake";
            car1BrakeButton.UseVisualStyleBackColor = true;
            car1BrakeButton.Click += car1BrakeButton_Click;
            // 
            // car2InfoLabel
            // 
            car2InfoLabel.AutoSize = true;
            car2InfoLabel.Location = new Point(15, 115);
            car2InfoLabel.Margin = new Padding(4, 0, 4, 0);
            car2InfoLabel.Name = "car2InfoLabel";
            car2InfoLabel.Size = new Size(38, 15);
            car2InfoLabel.TabIndex = 3;
            car2InfoLabel.Text = "car2";
            // 
            // car2AccelerateButton
            // 
            car2AccelerateButton.Location = new Point(19, 158);
            car2AccelerateButton.Margin = new Padding(4, 3, 4, 3);
            car2AccelerateButton.Name = "car2AccelerateButton";
            car2AccelerateButton.Size = new Size(88, 27);
            car2AccelerateButton.TabIndex = 4;
            car2AccelerateButton.Text = "Accelerate";
            car2AccelerateButton.UseVisualStyleBackColor = true;
            car2AccelerateButton.Click += car2AccelerateButton_Click;
            // 
            // car2BrakeButton
            // 
            car2BrakeButton.Location = new Point(113, 158);
            car2BrakeButton.Margin = new Padding(4, 3, 4, 3);
            car2BrakeButton.Name = "car2BrakeButton";
            car2BrakeButton.Size = new Size(88, 27);
            car2BrakeButton.TabIndex = 5;
            car2BrakeButton.Text = "Brake";
            car2BrakeButton.UseVisualStyleBackColor = true;
            car2BrakeButton.Click += car2BrakeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 301);
            Controls.Add(car2BrakeButton);
            Controls.Add(car2AccelerateButton);
            Controls.Add(car2InfoLabel);
            Controls.Add(car1BrakeButton);
            Controls.Add(car1AccelerateButton);
            Controls.Add(car1InfoLabel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Car Simulation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label car1InfoLabel;
        private System.Windows.Forms.Button car1AccelerateButton;
        private System.Windows.Forms.Button car1BrakeButton;
        private System.Windows.Forms.Label car2InfoLabel;
        private System.Windows.Forms.Button car2AccelerateButton;
        private System.Windows.Forms.Button car2BrakeButton;
    }
}