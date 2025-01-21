namespace Car;
using Car;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        private List<Car> cars = new List<Car>();
        
        
        
        foreach (var car in cars)
        {
            Console.WriteLine($"Model: {car.Model}, Wheels: {car.CarWheels}");
        }
    
}
}
