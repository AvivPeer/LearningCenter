namespace LearningCenter
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stdFormBtn_Click(object sender, EventArgs e)
        {
            Form form = new StudentsForm();
            form.ShowDialog();
        }

        private void stdEditButton_Click(object sender, EventArgs e)
        {
            Form form = new StudentManager();
            form.ShowDialog();
        }

        private void teachersManageBtn_Click(object sender, EventArgs e)
        {
            Form form = new TeacherManager();
            form.ShowDialog();
        }

        private void StatisticsBtn_Click(object sender, EventArgs e)
        {
            Form form = new Statistics();
            form.ShowDialog();
        }
    }
}
