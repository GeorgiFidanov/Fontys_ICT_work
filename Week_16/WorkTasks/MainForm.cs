namespace WorkTasks
{
    public partial class MainForm : Form
    {
        private Company company;

        public MainForm()
        {
            InitializeComponent();
            company = new Company();
        }

        private void newTaskBtn_Click(object sender, EventArgs e)
        {
            NewTaskForm newTaskForm = new NewTaskForm(company);
            newTaskForm.ShowDialog();
        }

        private void removeTasksBtn_Click(object sender, EventArgs e)
        {
            RemoveTasksForm removeTasksForm = new RemoveTasksForm(company);
            removeTasksForm.ShowDialog();
        }

        private void updateTaskBtn_Click(object sender, EventArgs e)
        {
            UpdateTaskForm updateTaskForm = new UpdateTaskForm(company);
            updateTaskForm.ShowDialog();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm(company);
            dashboardForm.ShowDialog();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            DownloadOptionsForm downloadOptionsForm = new DownloadOptionsForm(company);
            downloadOptionsForm.ShowDialog();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            UploadOptionsForm uploadOptionsForm = new UploadOptionsForm(company);
            uploadOptionsForm.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm(company);
            logInForm.ShowDialog();
        }
    }
}
