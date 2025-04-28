namespace OtterQuest
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Program.forms.Add(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Let the pain begin.
            // 1. We will Attach to process "RoboQuest.exe"
            bool pass = WindowsInfo.PopulateProcess();
            if (!pass)
            {
                statusLabel.Text = "ATTACH FAILED";
                statusLabel.ForeColor = Color.Red;
                return;
            }

            /*  Attach Succeeded!
                I realize the word "attach" might be a little misleading to the user.
                This program is entirely external and injects no dlls or anything of that nature. 
                But the word is more pleasing to use than its alternatives.
            */

            // This won't be seen until they go back to the home screen.
            statusLabel.Text = "ATTACH SUCCEEDED";
            statusLabel.ForeColor = Color.Green;
            attachButton.Text = "Menu";
            this.Hide();


            PlayerMenu menuForm = new PlayerMenu();
            WindowsInfo.PopulateHandle();
            menuForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        // Exit Button
        private void button2_Click(object sender, EventArgs e)
        {
            // This will be the first thing I program.
            // Because everything else will give me hell.

            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
