using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Controls;
using System.Windows.Input;

namespace PoCReportGenerationUI
{
    class MainWindowViewModel : BindableBase
    {
        public ICommand GenerateCommand { get; set; }
        public string Text { get; set; }

        public MainWindowViewModel()
        {
            GenerateCommand = new DelegateCommand(() => Execute());
            Text = "text";
        }

        private void Execute()
        {

        }
    }
}
