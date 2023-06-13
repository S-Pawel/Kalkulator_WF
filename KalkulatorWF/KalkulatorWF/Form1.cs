using System.Linq.Expressions;

namespace KalkulatorWF
{
    public partial class KalkulatorWindow : Form
    {
        private float previousValue = 0;
        private float laterValue = 0;
        private float result = 0;
        private string operatingChar = "";

        public KalkulatorWindow()
        {
            InitializeComponent();

        }
        private void ChaningResult()
        {
            label1.Text = result.ToString();
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
            ChaningResult();
        }
        private void Button0_Click(object sender, EventArgs e)
        {
            if (ResultWindow.Text != "0")
            {
                ResultWindow.Text = ResultWindow.Text + "0";
            };
            ChaningResult();
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            ResultWindow.Text = "0";
            previousValue = 0;
            laterValue = 0;
            result = 0;
            operatingChar = "";
            ChaningResult();
        }

        private void ButtonComma_Click(object sender, EventArgs e)
        {
            if (!ResultWindow.Text.Contains(","))
            {
                ResultWindow.Text += ",";
            }
            ChaningResult();
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            if (ResultWindow.Text.Contains("-") && ResultWindow.Text != "0")
            {
                ResultWindow.Text = ResultWindow.Text.Trim('-');
            }
            else if (ResultWindow.Text != "0")
            {
                ResultWindow.Text = "-" + ResultWindow.Text;
            }
            ChaningResult();
        }

        private void ButtonC_Click(object sender, EventArgs e)
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
            ChaningResult();
        }


        private void PerformCalculation()
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
            }
            else if (operatingChar == "%")
            {
                result = previousValue % laterValue;
            }
            ChaningResult();
        }

        private void ButtonOperating_Click(object sender, EventArgs e)
        {
            PerformCalculation();
            if (result != 0)
            {
                previousValue = result;
            }
            else
            {
                previousValue = Convert.ToSingle(ResultWindow.Text);
            }

            ResultWindow.Text = "0";
            Button button = (Button)sender;
            operatingChar = button.Text;
            ChaningResult();
        }

        public void ButtonEqual_Click(object sender, EventArgs e)
        {
            PerformCalculation();
            ResultWindow.Text = result.ToString();
            ChaningResult();
        }

    }

}
