using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6._2.VirusStrategy;

namespace _6._2
{
    internal class DangerousVirusStrategy : IVirusResearchStrategy
    {
        public void Execute(StartResearchForm context)
        {
            MessageBox.Show("Вирус оказался слишком смертелен!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }
    }
}
