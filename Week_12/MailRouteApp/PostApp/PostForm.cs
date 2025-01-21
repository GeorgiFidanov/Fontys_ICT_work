namespace PostApp
{
    public partial class PostForm : Form
    {

        public int numbers = 0;


        public PostForm()
        {
            InitializeComponent();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            numbers = Convert.ToInt32(textBoxNumber.Text);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            listBoxNumbers.Items.Clear();

            for (int i = 1; i <= numbers; i += 2)
            {
                listBoxNumbers.Items.Add(i);
            }

            if (numbers % 2 != 0)
            {
                numbers--;
            }

            for (int i = numbers; i > 1; i -= 2)
            {
                listBoxNumbers.Items.Add(i);
            }

        }
    }
}