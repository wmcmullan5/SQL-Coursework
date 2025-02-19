namespace SQL_Coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EnterBtn1.Show();
            progressBar1.Maximum = 10000000;
        }
        //starts progress bar
        private void EnterBtn1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Random rnd = new Random();
            int i = rnd.Next(1, 3);
            progressBar1.Step = i;
            //increases progress bar, large number to make progress slower
            while (progressBar1.Value != 10000000)
            {
                progressBar1.PerformStep();
            }
            if(progressBar1.Value == 10000000)
            {
                //delays and then opens new form
                Thread.Sleep(500);
                this.Hide();
                Login1 login = new Login1();
                login.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        //switched to highlighted button
        private void SwitchBtn(object sender, EventArgs e)
        {
            EnterBtn1.Image = Properties.Resources.Heading__1_;
        }
        //switches back to regular button
        private void SwitchBtnBack(object sender, EventArgs e)
        {
            EnterBtn1.Image = Properties.Resources.Heading;
        }
        //incrememtns the progress bar and checks whether it is full
        private void timer1_Tick(object sender, EventArgs e)
        {

            
        }
    }
}