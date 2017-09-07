using PrismLab_1.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismLab_1.Model;


namespace PrismLab_1.Managers
{
    class AnswerCheckManager : IAnswerCheckManager
    {
        public Boolean CheckAnswer(String correctAnswer, String userAnswer)
        {
            if (correctAnswer == userAnswer)
                return true;
            else
                return false;
        }
    }
}
