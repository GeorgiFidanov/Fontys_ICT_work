namespace Grocery_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBox();
            InitializePictureBox();
        }

        private void PopulateComboBox()
        {
            comboBox1.Items.AddRange(new string[] { "Apples", "Bananas", "Carrots", "Bread", "Milk", "Computer Skills", "Leprechaun" });
        }

        private void InitializePictureBox()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listView1.Items.Add(comboBox1.SelectedItem.ToString());
            }

            int leprechaunCount = listView1.Items.Cast<ListViewItem>().Count(item => item.Text == "Leprechaun");

            if (leprechaunCount == 3)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile("leprechaun.png");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            pictureBox1.Image = null; // Clear the image when the list is cleared
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
