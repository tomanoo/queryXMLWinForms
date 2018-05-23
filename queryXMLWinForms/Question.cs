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
        private List<string> answers = new List<string>();
        private string[] ans;
        private int howManyAnswers;
        public Question(string question, string[] answers, int howManyAnswers)
        {
            this.question = question;
            this.ans = answers;
            this.howManyAnswers = howManyAnswers;
        }
        public string getQuestion()
        {
            return question;
        }
        public List<string> getAnswers()
        {
            return answers;
        }
        public string getAnswer(int i)
        {
            return answers[i];
        }
        public int getHowManyAnswers()
        {
            return howManyAnswers;
        }
        public string[] getAns()
        {
            return ans;
        }
        public string getAnss(int i)
        {
            return ans[i];
        }
    }
}
