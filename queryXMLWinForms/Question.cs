using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queryXMLWinForms
{
    public class Question
    {
        private string question;
        private string[] answers;
        private string[] correctAnswers;
        private int howManyAnswers;
        public Question(string question, string[] answers, string[] correctAnswers, int howManyAnswers)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswers = correctAnswers;
            this.howManyAnswers = howManyAnswers;
        }
        public string getQuestion()
        {
            return question;
        }
        public string[] getAnswers()
        {
            return answers;
        }
        public string getAnswer(int i)
        {
            return answers[i];
        }
        public string[] getCorrectAnswers()
        {
            return correctAnswers;
        }
        public int getHowManyAnswers()
        {
            return howManyAnswers;
        }
    }
}
