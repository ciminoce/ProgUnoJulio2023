using System.Windows.Forms;

namespace POOPersonas2023.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, System.EventArgs e)
        {
            frmPersonasAE frm=new frmPersonasAE();
            frm.ShowDialog();   
        }
    }
}
