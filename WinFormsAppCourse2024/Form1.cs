namespace WinFormsAppCourse2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPow frm = new FormPow();
            frm.ShowDialog();
        }

        private void buttonDH_Click(object sender, EventArgs e)
        {
            FormDH frm = new FormDH();
            frm.ShowDialog();
        }

        private void buttonRSA_Click(object sender, EventArgs e)
        {
            FormRSA frm = new FormRSA();
            frm.ShowDialog();
        }

        private void buttonHash_Click(object sender, EventArgs e)
        {
            FormHash frm = new FormHash();
            frm.ShowDialog();
        }

        private void buttonDES_Click(object sender, EventArgs e)
        {
            FormDES frm = new FormDES();   
            frm.ShowDialog();   
        }
    }
}
