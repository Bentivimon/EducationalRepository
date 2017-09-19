using System;
using PrismLab_1.Managers;
using NUnit.Framework;

namespace AnswerCheckManagerTest
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
