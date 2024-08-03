namespace Servi_o
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int var1, var2, total;

            var1 = int.Parse(txvalor1.Text);
            var2 = int.Parse(txvalor2.Text);
            total = var1 + var2;

            lblResultado.Text = total.ToString();
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            int var1, var2, total;

            var1 = int.Parse(txvalor1.Text);
            var2 = int.Parse(txvalor2.Text);
            total = var1 * var2;

            lblResultado.Text = total.ToString();

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int var1, var2, total;

            var1 = int.Parse(txvalor1.Text);
            var2 = int.Parse (txvalor2.Text);
            total = var1 - var2;

            lblResultado.Text = total.ToString();

        }
    }
}
