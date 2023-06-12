using System.Linq.Expressions;

namespace KalkulatorWF
{
    public partial class KalkulatorWindow : Form
    {
        private const int maxResultLength = 16;
        private float previousValue = 0;
        private float laterValue = 0;
        private float result = 0;
        private string operatingChar = "";

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
            previousValue = 0;
            laterValue = 0;
            result = 0;
            operatingChar = "";

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!ResultWindow.Text.Contains(","))
            {
                ResultWindow.Text += ",";
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (ResultWindow.Text.Contains("-") && ResultWindow.Text != "0")
            {
                ResultWindow.Text = ResultWindow.Text.Trim('-');
            }
            else if (ResultWindow.Text != "0")
            {
                ResultWindow.Text = "-" + ResultWindow.Text;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultWindow.Text) && ResultWindow.Text != "0")
            {
                ResultWindow.Text = ResultWindow.Text.Remove(ResultWindow.Text.Length - 1);
                if (ResultWindow.Text == "")
                {
                    ResultWindow.Text = "0";
                }
            }
            else
            {
                ResultWindow.Text = "0";
            }
        }

        private void buttonOperating_Click(object sender, EventArgs e)
        {

            previousValue = Convert.ToSingle(ResultWindow.Text);
            ResultWindow.Text = "0";
            Button button = (Button)sender;
            operatingChar = button.Text;

           
            
        }

        public void buttonEqual_Click(object sender, EventArgs e)
        {
            laterValue = Convert.ToSingle(ResultWindow.Text);
            if (operatingChar == "+")
            {
                result = previousValue + laterValue;
            }
            else if (operatingChar == "-")
            {
                result = previousValue - laterValue;
            }
            else if (operatingChar == "×")
            {
                result = previousValue * laterValue;
            }
            else if (operatingChar == "÷")
            {
                if (laterValue != 0)
                {
                    result = previousValue / laterValue;
                }
                else
                {
                    ResultWindow.Text = "Nie dzielimy przez 0";
                }
            }
            else if (operatingChar == "%")
            {
                result = previousValue % laterValue;
            }
            ResultWindow.Text = result.ToString();
        }
    }

}
