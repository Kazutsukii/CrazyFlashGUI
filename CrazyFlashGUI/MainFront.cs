using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyFlashGUI
{
    public partial class MainFront : UserControl
    {
        private static readonly Lazy<MainFront> _instance = new Lazy<MainFront>(() => new MainFront());
        public static MainFront Instance { get { return _instance.Value; } }

        public MainFront()
        {
            InitializeComponent();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            if (!CrazyFlash.Instance.PnlContainer.Controls.ContainsKey("Train"))
            {
                Train train = new Train();
                train.Dock = DockStyle.Fill;
                CrazyFlash.Instance.PnlContainer.Controls.Add(train);
                Console.WriteLine(CrazyFlash.Instance.PnlContainer.Controls.Contains(train));
            }
            CrazyFlash.Instance.PnlContainer.Controls["Train"].BringToFront();
        }
    }
}
