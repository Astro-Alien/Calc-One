namespace calc_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculationWindow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            rest_content_window_value();
            calculationWindow.Text += "1";
        }

        private void rest_content_window_value() {
            if (calculationWindow.Text != "0") return;
            
            calculationWindow.Text = "";
        }
        
    }
}
