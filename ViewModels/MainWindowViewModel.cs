using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfUI.Infrastructure.Commands;
using WpfUI.Infrastructure.Commands.Base;

namespace WpfUI.ViewModels
{
    internal class MainWindowViewModel
    {
        public Command CloseAppCommand { get; }

        public MainWindowViewModel()
        {
            CloseAppCommand = new CloseAppCommand();
        }
    }
}
