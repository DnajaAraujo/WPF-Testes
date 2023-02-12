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
            return true;
        }

        public void Execute(object parameter)
        {
            string senha = (parameter as PasswordBox).Password;
            MessageBox.Show("Sua senha é: " + senha);
        }
    }
}
