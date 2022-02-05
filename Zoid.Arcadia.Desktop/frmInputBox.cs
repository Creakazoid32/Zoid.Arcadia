using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoid.Arcadia.Desktop
{
    public partial class FrmInputBox : Form
    {
        public FrmInputBox()
        {
            InitializeComponent();
        }

        private void FrmInputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            else if (e.KeyValue.Equals(13)) //ENTER
            {
                MessageBox.Show("Não implementado");
                //DefinePlayer();
            }

        }
    }
}
