namespace CarApplication
{
    public partial class Form1 : Form
    {
        private Car car1;
        private Car car2;

        public Form1()
        {
            InitializeComponent();
            car1 = new Car();
            car1.SetBrand("Ferrari");
            car1.SetMaxSpeed(300);

            car2 = new Car();
            car2.SetBrand("Fiat Panda");
            car2.SetMaxSpeed(160);

            UpdateCarInfo();
        }

        private void UpdateCarInfo()
        {
            car1InfoLabel.Text = car1.GetInfo();
            car2InfoLabel.Text = car2.GetInfo();
        }

        private void car1AccelerateButton_Click(object sender, EventArgs e)
        {
            car1.SpeedUp();
            UpdateCarInfo();
        }

        private void car1BrakeButton_Click(object sender, EventArgs e)
        {
            car1.SlowDown();
            UpdateCarInfo();
        }

        private void car2AccelerateButton_Click(object sender, EventArgs e)
        {
            car2.SpeedUp();
            UpdateCarInfo();
        }

        private void car2BrakeButton_Click(object sender, EventArgs e)
        {
            car2.SlowDown();
            UpdateCarInfo();
        }
    }
}
