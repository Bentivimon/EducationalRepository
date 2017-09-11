using System;
using Prism.Commands;
using Prism.Mvvm;
using PrismLab_1.Abstractions;
using PrismLab_1.Model;
using Prism.Interactivity.InteractionRequest;
using System.Windows;

namespace PrismLab_1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand BtnAnswerCommand { get; set; }
        public DelegateCommand CheckLetterCommand { get; set; }


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

        public int UserScore
        {
            get { return _userScore; }
            set { SetProperty(ref _userScore, value); }
        }

        public String CodeAnswer
        {
            get { return _codeAnswer; }
            set { SetProperty(ref _codeAnswer, value); }
        }
 
        public Char PotentialLetter
        {
            get { return _potentialLetter; }
            set { SetProperty(ref _potentialLetter, value); }
        }

        public MainWindowViewModel(IAnswerCheckManager answerCheckManager)
        {
            _answerCheckManager = answerCheckManager;
            PotentialLetter = ' ';
            BtnAnswerCommand = new DelegateCommand(CheckAnswer);
            CheckLetterCommand = new DelegateCommand(CheckLetter);
            TestQuestion = new Task() { Question = "Столиця України?", Answer = "Київ" };
            _question = TestQuestion.Question;
            foreach (var letter in TestQuestion.Answer)
                CodeAnswer += "*";
            UserScore = 0;
        }

        private void CheckLetter()
        {
            var arrayOfObject =_answerCheckManager.CheckLetter(_potentialLetter, TestQuestion.Answer, _codeAnswer);
            var coutOfPoint = Convert.ToInt32(arrayOfObject[1]);

            if(CodeAnswer == Convert.ToString(arrayOfObject[0]))
                return;

            CodeAnswer = Convert.ToString(arrayOfObject[0]);

            if(CodeAnswer.IndexOf('*') == -1)
            {
                UserScore = 100 + coutOfPoint;
                CodeAnswer = "*****";
            }

            if (coutOfPoint == 0)
                UserScore -= 1;
            else
                UserScore += coutOfPoint;
        }

        private void CheckAnswer()
        {
            if (_answerCheckManager.CheckAnswer(TestQuestion.Answer, _userAnswer))
            {
                MessageBox.Show("True","Congr");
                UserScore += 100;
                UserAnswer = "";
            }
            else
            {
                MessageBox.Show("false", "Failed");
                UserScore -= 100;
                UserAnswer = "";
            }
        }

        private Char _potentialLetter;
        private String _codeAnswer;
        private int _userScore;
        private Task TestQuestion;
        private string _title = "Prism Unity Application";
        private string _question;
        private String _userAnswer;
        private IAnswerCheckManager _answerCheckManager;
    }
}
