namespace Grocery_List
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBox1;
        private Button addButton;
        private Button clearButton;
        private ListView listView1;

        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            addButton = new Button();
            clearButton = new Button();
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.RosyBrown;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 18);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 28);
            comboBox1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Salmon;
            addButton.Location = new Point(293, 15);
            addButton.Margin = new Padding(4, 5, 4, 5);
            addButton.Name = "addButton";
            addButton.Size = new Size(100, 35);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.IndianRed;
            clearButton.Location = new Point(400, 15);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 35);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.DarkRed;
            listView1.Location = new Point(16, 62);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(479, 306);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkRed;
            pictureBox1.Location = new Point(313, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 160);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(512, 402);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(comboBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Grocery List";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private PictureBox pictureBox1;
    }
}
