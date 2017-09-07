using System;
using Prism.Commands;
using Prism.Mvvm;
using PrismLab_1.Abstractions;
using PrismLab_1.Model;
using Prism.Interactivity.InteractionRequest;

namespace PrismLab_1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand BtnAnswerCommand { get; set; }

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
        
        public String UserAnswer
        {
            get { return _userAnswer; }
            set { SetProperty(ref _userAnswer, value); }
        }

        public MainWindowViewModel(IAnswerCheckManager answerCheckManager)
        {
            _answerCheckManager = answerCheckManager;
            BtnAnswerCommand = new DelegateCommand(CheckAnswer);
            TestQuestion = new Task() { Question = "Столиця України?", Answer = "Київ" };
            _question = TestQuestion.Question;
        }

        private void CheckAnswer()
        {
            if (_answerCheckManager.CheckAnswer(TestQuestion.Answer, _userAnswer))
            {

            }
            else
            {
             
            }
        }

        private Task TestQuestion;
        private string _title = "Prism Unity Application";
        private string _question;
        private String _userAnswer;
        private IAnswerCheckManager _answerCheckManager;
    }
}
