using ProjetoWpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjetoWpf.Commands
{
    public class LogarCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // validação
            return true;
        }

        public void Execute(object parameter)
        {
            var telaPrincipal = new WinPrincipal();
            telaPrincipal.Show();
            Helper.Helpers.FecharTelaLogin();
        }
    }
}
