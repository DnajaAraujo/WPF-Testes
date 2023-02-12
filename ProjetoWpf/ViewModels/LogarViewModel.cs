using ProjetoWpf.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWpf.ViewModels
{
    public class LogarViewModel
    {
        public LogarCommand Logar { get; set; }

        public LogarViewModel()
        {
            Logar = new LogarCommand();
        }
    }
}
