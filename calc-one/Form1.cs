namespace calc_one
{
    public partial class Form1 : Form
    {
        static Dictionary<string, int> numberSystem = new Dictionary<string, int> {
            { "zero", 0},
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void calculationWindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            rest_content_window_value("one");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            rest_content_window_value("two");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            rest_content_window_value("three");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            rest_content_window_value("four");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            rest_content_window_value("five");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            rest_content_window_value("six");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            rest_content_window_value("seven");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            rest_content_window_value("eight");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            rest_content_window_value("nine");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            rest_content_window_value("zero");
        }

        private void rest_content_window_value(string number)
        {
            if (calculationWindow.Text == "0") return;


            calculationWindow.Text = numberSystem[number].ToString();
        }
    }
}
