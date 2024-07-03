using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _6._2.VirusStrategy;

namespace _6._2
{
    internal class NormalExperimentStrategy : IExperimentStrategy
    {
        public void Execute(ExperimentForm context)
        {
            context.Hide();
            ExperimentForm experimentForm2 = new ExperimentForm();
            experimentForm2.ShowDialog();
        }
    }
}
