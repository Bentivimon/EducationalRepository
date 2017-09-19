using NUnit.Framework;
using PrismLab_1.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTests
{
    [TestFixture]
    public class AnswerCheckManagerTest
    {
        [Test]
        public void CheckAnswerTest()
        {
            AnswerCheckManager _answerCheckManager = new AnswerCheckManager();
            String correctAnswer = "Львів";
            String userAnswer = "Львів";

            Assert.That(_answerCheckManager.CheckAnswer(correctAnswer, userAnswer));
        }
    }
}
