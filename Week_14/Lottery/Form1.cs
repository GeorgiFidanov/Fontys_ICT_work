using System.DirectoryServices;

namespace Lottery
{
    public partial class Form1 : Form
    {
        private Lottery? lottery;

        public Form1()
        {
            InitializeComponent();
            drawButton.Enabled = false;
            drawNextButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the Lottery object with default values
            lottery = null;
        }


        private void setLottery()
        {
            drawButton.Text = "Draw all at once";
            if (!int.TryParse(maxValueTextBox.Text, out int maxValue))
            {
                MessageBox.Show("Please enter a valid max value.");
                return;
            }

            if (!int.TryParse(numberOfNumbersTextBox.Text, out int numberOfWantedNumbers))
            {
                MessageBox.Show("Please enter a valid count of wanted numbers.");
                return;
            }

            if (numberOfWantedNumbers > maxValue)
            {
                MessageBox.Show("Number of wanted numbers cannot be greater than the max value.");
                return;
            }

            try
            {
                listBox1.Items.Clear();
                lottery = new Lottery(maxValue, numberOfWantedNumbers);
                drawButton.Enabled = true;
                drawNextButton.Enabled = true;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            drawButton.Text = "Draw all at once";
            if (lottery == null)
            {
                MessageBox.Show("Please set the max value and number of numbers first.");
                return;
            }

            if (lottery.isLotteryFinished())
            {
                MessageBox.Show("Lottery is finished.");
                listBox1.Items.Clear();
                drawButton.Enabled = false;
                drawNextButton.Enabled = false;
                return;
            }

            drawNextButton.Enabled = false;
            listBox1.Items.Clear();

            List<int> drawnNumbers = lottery.DrawAllNumbers();
            foreach (int number in drawnNumbers)
            {
                listBox1.Items.Add(number);
            }

            if (lottery.isLotteryFinished())
            {
                lottery.resetDrawnNumbers();
                drawButton.Enabled = false;
                drawNextButton.Enabled = false;
            }
        }



        private void drawNextButton_Click(object sender, EventArgs e)
        {

            if (lottery == null)
            {
                MessageBox.Show("Please set the max value and number of numbers first.");
                return;
            }

            if (lottery.isLotteryFinished())
            {
                drawButton.Text = "Draw all at once";
                lottery.resetDrawnNumbers();
                MessageBox.Show("Lottery is finished.");
                drawButton.Enabled = false;
                drawNextButton.Enabled = false;
                return;
            }

            else
            {
                drawButton.Text = "Draw the rest";
                int drawnNumber = lottery.DrawNextNumber();
                listBox1.Items.Add(drawnNumber);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (lottery != null)
            {
                lottery.Reset();
                lottery.resetDrawnNumbers();
                lottery = null;
            }

            maxValueTextBox.Text = "";
            numberOfNumbersTextBox.Text = "";
            listBox1.Items.Clear();
            drawButton.Enabled = true;
            drawNextButton.Enabled = true;
            
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            setLottery();
        }
    }
}
