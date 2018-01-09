using System;
using System.Windows.Forms;
using PixelMagic.Helpers;

namespace PixelMagic.GUI
{
    public partial class frmLicenseAgreement : Form
    {
        public frmLicenseAgreement()
        {
            InitializeComponent();
        }

        private void frmLicenseAgreement_Load(object sender, EventArgs e)
        {
            ConfigFile.LicenseAccepted = false;
        }

        private void cmdDecline_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdAgree_Click(object sender, EventArgs e)
        {   
           ConfigFile.LicenseAccepted = true;
           Close();
        }
    }
}