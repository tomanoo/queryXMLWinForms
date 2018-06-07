using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

//
//      TO DO
//
//
//      Solve problems listView - setting View property to Details (to display questions one by one in a column
//      instead of a row) instead of List results in not showing listView.Items at all
//

namespace queryXMLWinForms
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question>();
        List<string> answers;
        List<string> correctAnswers;
        private string correctAnswer;
        static int x = 0;
        string currentQuiz;
        string[] userAnswers = new string[100];
        string loadedQuiz;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
            answers = new List<string>();
            correctAnswers = new List<string>();
            for (int i = 0; i < 100; i++)
                userAnswers[i] = "";
            loadQuizes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void quizList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentQuiz = quizList.FocusedItem.Text;
        }

        private void loadQuizes()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] quizNames = Directory.GetFiles(currentDirectory, "*.xml");
            string quizName;
            foreach (string f in quizNames)
            {
                quizName = Path.GetFileName(f);
                quizList.Items.Add(quizName);
            }
        }
        private void loadQuiz_Click(object sender, EventArgs e)
        {
            if (loadedQuiz != currentQuiz)
            {
                try
                {
                    x = 0;
                    lblQuestion.Text = "";
                    answerList.Clear();
                    answerList.Items.Clear();
                    questions.Clear();
                    loadQuestions();
                    displayQuestion(x);
                    loadedQuiz = currentQuiz;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please, choose one of the quizes!");
                }
            }
        }

        private void loadQuestions()
        {
            string question = "";
            answerList.Clear();
            answerList.Items.Clear();
            lblQuestion.Text = "";

            XmlReader reader = XmlReader.Create(currentQuiz);
            bool flag = false;
            bool correctFlag = false;
            int i = 0;

            //ReadInnerXml to teksty

            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    if (reader.Name == "Question")
                    {
                        

                        reader.Read();
                        reader.Read();

                        if (reader.Name == "Text")
                        {
                            question = reader.ReadInnerXml();
                        }
                    }
                    else if (reader.Name == "Answer")
                    {
                        if (reader.GetAttribute("Correct") == "True")
                        {
                            correctFlag = true;
                        }
                        reader.Read();
                        reader.Read();

                        if (reader.Name == "Text")
                        {
                            answers.Add((char)(i+97) + ") " + reader.ReadInnerXml());
                            if (correctFlag)
                            {
                                correctAnswer = answers[i];
                            }
                            correctFlag = false;
                            i++;
                            flag = true;
                        }
                    }
                }
                else if (reader.Name == "Question")
                {
                    if (flag)
                    {
                        questions.Add(new Question(question, answers.ToArray(), correctAnswer, answers.Count));
                        flag = false;
                        correctFlag = false;
                        i = 0;
                        answers.Clear();
                        correctAnswers.Clear();
                    }
                }
            }
            reader.Close();
        }

        private void displayQuestion(int x)
        {
            answerList.Items.Clear();
            lblQuestion.Text = "";
            answerList.Clear();

            lblQuestion.Text = x + 1 + ". " + questions[x].getQuestion();

            for (int i = 0; i < questions[x].getAnswers().Length; i++)
            {
                answerList.Items.Add(questions[x].getAnswers()[i]);
            }
        }
        

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            if (x + 1 < questions.Count)
            {
                displayQuestion(++x);
            }
        }

        private void previousQuestion_Click(object sender, EventArgs e)
        {
            if (x - 1 >= 0)
            {
                displayQuestion(--x);
            }
        }

        private void checkAnswers_Click(object sender, EventArgs e)
        {
            answerList.Items.Clear();
            lblQuestion.Text = "You scored: " + score + "/" + questions.Count;
            for (int i = 0; i < questions.Count; i++)
            {
                answerList.Items.Add(i+1 + ". " + questions[i].getQuestion());
                answerList.Items.Add("Your answer: " + userAnswers[i]);
                answerList.Items.Add("Correct answer: " + questions[i].getCorrectAnswer());
                answerList.Items.Add("\n");
            }
        }

        private void answerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            userAnswers[x] = answerList.FocusedItem.Text;
        }

    }
}
