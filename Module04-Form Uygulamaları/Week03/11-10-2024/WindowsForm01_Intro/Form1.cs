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
                MessageBox.Show($"{productName} adl� �r�n ba�ar�yla kaydedildi!");
            }
            else
            {
                MessageBox.Show("L�tfen �r�n ad�n� bo� b�rakmay�n�z");
            }

        }
    }
}
