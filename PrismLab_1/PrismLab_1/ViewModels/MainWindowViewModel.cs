using Prism.Mvvm;

namespace PrismLab_1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public string Question
        {
            get { return _question; }
            set { SetProperty(ref _question, value); }
        }
        public MainWindowViewModel()
        {

        }

        private string _title = "Prism Unity Application";
        private string _question = "Test Text";

    }
}
