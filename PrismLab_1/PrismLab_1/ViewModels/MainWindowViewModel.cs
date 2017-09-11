using System;
using Prism.Commands;
using Prism.Mvvm;
using PrismLab_1.Abstractions;
using PrismLab_1.Model;
using Prism.Interactivity.InteractionRequest;
using System.Windows;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

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

        public List<Task> ListOfTasks { get; set; }

        public MainWindowViewModel(IAnswerCheckManager answerCheckManager)
        {
            _answerCheckManager = answerCheckManager;
            PotentialLetter = new char();
            BtnAnswerCommand = new DelegateCommand(CheckAnswer);
            CheckLetterCommand = new DelegateCommand(CheckLetter);
            GetQuestions();
            _questionNumber = -1;
            SetQuestion();
            UserScore = 0;
        }

        private void SetQuestion()
        {
            _questionNumber++;
            Question = ListOfTasks[_questionNumber].Question;
            CodeAnswer = "";
            foreach (var letter in ListOfTasks[_questionNumber].Answer)
                CodeAnswer += "*";
        }

        private void GetQuestions()
        {
            ListOfTasks = new List<Task>();
            try
            {
                var stringText = File.ReadAllText("questionJson.txt");
                ListOfTasks = JsonConvert.DeserializeObject<List<Task>>(stringText);
            }
            catch(Exception ex) { }
        }

        private void CheckLetter()
        {
            var arrayOfObject =_answerCheckManager.CheckLetter(PotentialLetter, ListOfTasks[_questionNumber].Answer, _codeAnswer);
            var coutOfPoint = Convert.ToInt32(arrayOfObject[1]);

            //if(CodeAnswer == Convert.ToString(arrayOfObject[0]))
            //    return;

            CodeAnswer = Convert.ToString(arrayOfObject[0]);

            if(CodeAnswer.IndexOf('*') == -1)
            {
                MessageBox.Show("Вітаю, ви вгадали слово", "Вітаю");
                UserScore = 100 + coutOfPoint;
                SetQuestion();
            }

            if (coutOfPoint == 0)
            {
                UserScore -= 1;
                MessageBox.Show("Нажаль, ви помилились :(", "Оу((");
            }
            else
            {
                UserScore += coutOfPoint;
                MessageBox.Show("Вітаю, ви вгадали букву", "Вітаю");
            }
            PotentialLetter = new char();
        }

        private void CheckAnswer()
        {
            if (_answerCheckManager.CheckAnswer(ListOfTasks[_questionNumber].Answer, _userAnswer))
            {
                MessageBox.Show("Вітаю, ви вгадали слово", "Вітаю");
                UserScore += 100;
                UserAnswer = "";
                SetQuestion();
            }
            else
            {
                MessageBox.Show("Нажаль, ви помилились :(", "Оу((");
                UserScore -= 100;
                UserAnswer = "";
            }
        }

        private int _questionNumber;
        private Char _potentialLetter;
        private String _codeAnswer;
        private int _userScore;
        private string _title = "Prism Unity Application";
        private string _question;
        private String _userAnswer;
        private IAnswerCheckManager _answerCheckManager;
    }
}
