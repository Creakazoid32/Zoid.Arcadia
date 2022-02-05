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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            FrmInputBox frmInputBox = new FrmInputBox();
            Button btn = (sender as Button);
            frmInputBox.Location = new Point(btn.Location.X + Location.X + 10, btn.Location.Y + Location.Y + 25);

            frmInputBox.Show();
        }
    }
}
