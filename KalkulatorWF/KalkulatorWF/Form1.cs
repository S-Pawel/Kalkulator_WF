namespace KalkulatorWF
{
    public partial class KalkulatorWindow : Form
    {
        private const int MaxResultLength = 16;
        public KalkulatorWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {

            if (ResultWindow.Text == "0")
            {
                ResultWindow.Text = "";
            }
            Button button = (Button)sender;
            string number = button.Text;
            ResultWindow.Text += number;
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
            ResultWindow.Text = "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!ResultWindow.Text.Contains("."))
            {
                ResultWindow.Text += ".";
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if(ResultWindow.Text.Contains("-"))
            {
                ResultWindow.Text = ResultWindow.Text.Trim('-');
            }
            else
            {
                ResultWindow.Text = "-" + ResultWindow.Text;
            }
        }
    }
}