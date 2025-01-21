using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceRolling
{
    public partial class Form1 : Form
    {
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            button1.Click += BtnRollDice_Click;
        }

        private void BtnRollDice_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int numberOfRolls) && numberOfRolls > 0)
            {
                for (int i = 0; i < numberOfRolls; i++)
                {
                    int diceResult = random.Next(1, 7);
                    ShowDiceResult(diceResult);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of rolls.");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void ShowDiceResult(int diceResult)
        {
            Form resultForm = new Form
            {
                Size = new Size(200, 200)
            };

            string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"DiceRolling_Images/DiceFace{diceResult}.png");

            if (!System.IO.File.Exists(imagePath))
            {
                MessageBox.Show($"Image file not found: {imagePath}");
                return;
            }

            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(imagePath),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill
            };

            resultForm.Controls.Add(pictureBox);
            resultForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
