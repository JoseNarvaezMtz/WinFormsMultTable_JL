namespace WinFormsMultTable_JL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richtextboxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void showTable()
        {
            int num = Convert.ToInt32(this.textBoxNum.Text);

            string tabla = "";

            for (int i = 1; i <= 10; i++)
            {
                tabla += num + "*" + i + "=" + num * i + "\n\n";
            }

            this.richtextboxRes.Text = tabla;
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            this.showTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
