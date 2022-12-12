using System.Windows;
using WpfUI.Infrastructure.Commands.Base;

namespace WpfUI.Infrastructure.Commands
{
    internal class CloseAppCommand : Command
    {
        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
