namespace calcutor
{
    public partial class Form1 : Form
    {

        double number = 0, number2 = 0, result;

        int inputNumber;

        enum Operator { none, plus, minus, multiplication, divsion }
        Operator mode = Operator.none;
        bool isequal = false;

        public void calll(int an)
        {
            if (mode == Operator.none)
            {
                number = number * 10 + an;
                labelmode.Text = Convert.ToString(number);
            }
            else
            {
                number2 = number2 * 10 + an;
                labelmode.Text = Convert.ToString(number2);
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void labelbefore_Click(object sender, EventArgs e)
        {

        }

        private void labelmode_Click(object sender, EventArgs e)
        {

        }



        private void num1_Click(object sender, EventArgs e)
        {
            inputNumber = 1;
            calll(inputNumber);

        }

        private void num2_Click(object sender, EventArgs e)
        {
            inputNumber = 2;
            calll(inputNumber);
        }

        private void num3_Click(object sender, EventArgs e)
        {
            inputNumber = 3;
            calll(inputNumber);
        }

        private void num4_Click(object sender, EventArgs e)
        {
            inputNumber = 4;
            calll(inputNumber);
        }

        private void num5_Click(object sender, EventArgs e)
        {
            inputNumber = 5;
            calll(inputNumber);
        }

        private void num6_Click(object sender, EventArgs e)
        {
            inputNumber = 6;
            calll(inputNumber);
        }

        private void num7_Click(object sender, EventArgs e)
        {
            inputNumber = 7;
            calll(inputNumber);
        }

        private void num8_Click(object sender, EventArgs e)
        {
            inputNumber = 8;
            calll(inputNumber);
        }

        

        private void num9_Click(object sender, EventArgs e)
        {
            inputNumber = 9;
            calll(inputNumber);
        }

        private void num0_Click(object sender, EventArgs e)
        {
            inputNumber = 0;
            calll(inputNumber);
        }

        private void clean_Click(object sender, EventArgs e)
        {
            cleanall();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            mode = Operator.plus;
            switchmode();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            mode = Operator.minus;
            switchmode();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            mode = Operator.multiplication;
            switchmode();
        }

        private void division_Click(object sender, EventArgs e)
        {
            mode = Operator.divsion;
            switchmode();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case Operator.plus:
                    result = number + number2;
                    break;
                case Operator.minus:
                    result = number - number2;
                    break;
                case Operator.multiplication:
                    result = number * number2;
                    break;
                case Operator.divsion:
                    result = number / number2;
                    break;
            }
            number = 0;
            number2 = 0;
            isequal = true;
            labelbefore.Text = "";
            labelmode.Text = "";
            labelmode.Text = Convert.ToString(result);

        }

        public void cleanall()
        {
            number = 0;
            number2 = 0;
            labelmode.Text = Convert.ToString(number);
            labelbefore.Text = "";
            labelmode.Text = "";
            isequal = false;
            mode = Operator.none;
        }


        public void switchmode()
        {
            switch (mode)
            {
                case Operator.plus:
                    labelmode.Text = "+";
                    break;
                case Operator.minus:
                    labelmode.Text = "-";
                    break;
                case Operator.multiplication:
                    labelmode.Text = "*";
                    break;
                case Operator.divsion:
                    labelmode.Text = "/";
                    break;
            }
            if (isequal == true)
            {
                number = result;
            }
            labelbefore.Text = Convert.ToString(number);
            labelmode.Text = Convert.ToString(number2);
        }



    }
}