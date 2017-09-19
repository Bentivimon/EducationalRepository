using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrismLab_1.Managers;

namespace PrismLab_1_Test
{
    [TestClass]
    public class AnswerCheckManagerTest
    {
        [TestMethod]
        public void CheckAnswerTest()
        {

            AnswerCheckManager _answerCheckManager = new AnswerCheckManager();
            String correctAnswer = "Львів";
            String userAnswer = "Львів";

            Assert.IsTrue(_answerCheckManager.CheckAnswer(correctAnswer, userAnswer));
        }

        [TestMethod]
        public void CodingWordTest()
        {
            AnswerCheckManager _answerCheckManager = new AnswerCheckManager();
            string word = "Кипіння";
            string rightCodeWord = "*******";
            string codeWord = _answerCheckManager.CodingWord(word);

            Assert.AreEqual(rightCodeWord, codeWord);
        }

        [TestMethod]
        public void CheckLetterTest()
        {
            AnswerCheckManager _answerCheckManager = new AnswerCheckManager();
            object[] rightArray = { "Ба*аба*", 2 };
            object[] array = _answerCheckManager.CheckLetter('б', "Барабан", "*а*а*а*");

            Assert.AreEqual(rightArray[0], array[0]);
            Assert.AreEqual(rightArray[1], array[1]);
        }
    }
}
