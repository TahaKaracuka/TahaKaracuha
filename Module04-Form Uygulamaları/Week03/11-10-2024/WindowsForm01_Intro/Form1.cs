namespace WindowsForm01_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            if (productName.Length > 0)
            {
                MessageBox.Show($"{productName} adlý ürün baþarýyla kaydedildi!");
            }
            else
            {
                MessageBox.Show("Lütfen ürün adýný boþ býrakmayýnýz");
            }

        }
    }
}
