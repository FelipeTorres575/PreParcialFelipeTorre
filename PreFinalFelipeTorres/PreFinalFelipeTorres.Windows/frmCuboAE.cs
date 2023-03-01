using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreFinalFelipeTorres.Windows
{
    public partial class frmCuboAE : Form
    {
        public frmCuboAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboColor();
        }

        private void CargarDatosComboColor()
        {
            //RellenoComboBox.DataSource = Enum.GetValues(typeof(Color));
            //RellenoComboBox.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
          
        }
        
        
    }
}
