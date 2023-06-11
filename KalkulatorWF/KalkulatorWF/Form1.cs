namespace KalkulatorWF
{
    public partial class KalkulatorWindow : Form
    {
        public KalkulatorWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ResultWindow.Text == "0")
            {
                ResultWindow.Text = "";
                ResultWindow.Text = ResultWindow.Text + "1";
            }
            else
            {
                ResultWindow.Text = ResultWindow.Text + "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = ResultWindow.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (ResultWindow.Text != "0")
            {
                ResultWindow.Text = ResultWindow.Text + "0";
            };
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = "";
        }
    }
}