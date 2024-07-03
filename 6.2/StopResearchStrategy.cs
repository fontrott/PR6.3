using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _6._2.VirusStrategy;

namespace _6._2
{
    internal class StopResearchStrategy : IResearchStrategy
    {
        public void Execute(ResearchForm context)
        {
            if (MessageBox.Show("Вы уверены, что хотите прекратить исследование?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (MessageBox.Show("Вы точно уверены в своем решении!?", "Предупреждение!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Зря вы это сделали...", "Wasted", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
    }
}
