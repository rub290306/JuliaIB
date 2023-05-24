using JuliaIB.Properties;

namespace JuliaIB
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmOptions x = new frmOptions();
            x.Show();
        }
    }
}