using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_MIFTA_SETYA_PRATAMA
{
    internal class Helper
    {
        public static void OpenContent(Panel p, UserControl us)
        {
            us.Dock = DockStyle.Fill;
            p.Controls.Clear();
            p.Controls.Add(us);
            us.BringToFront();
        }
    }
}
