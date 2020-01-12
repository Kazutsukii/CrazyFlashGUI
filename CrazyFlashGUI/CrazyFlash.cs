using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyFlashGUI
{
    public partial class CrazyFlash : Form
    {
        private static readonly Lazy<CrazyFlash> _instance = new Lazy<CrazyFlash>(()=> new CrazyFlash());
        public static CrazyFlash Instance { get { return _instance.Value; } }

        public CrazyFlash()
        {
            InitializeComponent();
        }

        public Panel PnlContainer
        {
            get { return panel2; }
            set { panel2 = value; }
        }
        private void CrazyFlash_Load(object sender, EventArgs e)
        {
            MainFront mainFront = new MainFront();
            mainFront.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(mainFront);
        }

        private void Home_Btn(object sender, EventArgs e)
        {
            PnlContainer.Controls["MainFront"].BringToFront();
        }
    }
}
