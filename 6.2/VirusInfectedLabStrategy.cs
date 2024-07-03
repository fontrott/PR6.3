using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _6._2.VirusStrategy;
using System.Windows.Forms;

namespace _6._2
{
    internal class VirusInfectedLabStrategy : IResearchStrategy
    {
        public void Execute(ResearchForm context)
        {
            MessageBox.Show("В лабораторию проник неизвестный вирус!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Exit();
        }
    }
}
