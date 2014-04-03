using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnimalQuiz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MessageContainsSomething()
        {
            Question question = new Question();
            question.Message = "test string";
            Assert.IsFalse(string.IsNullOrEmpty(question.Message));
        }

        [TestMethod]
        public void MessageRespondsIsTrue()
        {
            Question question = new Question();
            question.Yes = new Question();
            Assert.AreEqual(question.Yes, question.ProcessResponse(true));
        }

        [TestMethod]
        public void MessageRespondsIsFalse()
        {
            Question question = new Question();
            question.No = new Question();
            Assert.AreEqual(question.No,  question.ProcessResponse(false));
        }

        [TestMethod]
        public void FirstQuestionIsYes()
        {
            Question question = new Question
            {
                Number = 1,
                Message="Is it alive?",
                Yes = new Question {Number=2, Message="Is it humanoid?"},
                No = new Question {Number=3, Message="Is it stationary?"}
            };
            Assert.AreEqual(2, question.Yes.Number);
        }

        [TestMethod]
        public void FirstQuestionIsNo()
        {
            Question question = new Question
            {
                Number = 1,
                Message = "Is it alive?",
                Yes = new Question { Number = 2, Message = "Is it humanoid?" },
                No = new Question { Number = 3, Message = "Is it stationary?" }
            };
            Assert.AreEqual(3, question.No.Number);
        }


    }
}
