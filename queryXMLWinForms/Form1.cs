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

namespace queryXMLWinForms
{
    public partial class Form1 : Form
    {
        private XmlDocument doc;
        private XmlNode theQuiz;
        private List<Question> questions = new List<Question>();
        private string name;
        private List<string> labelsText = new List<string>();
        List<string> answers;
        List<string> correctAnswers;
        private string correctAnswer;
        static int x = 0;
        string[] quizes = Directory.GetFiles(Directory.GetCurrentDirectory());
        string currentQuiz;
        string[] userAnswers = new string[100];
        int score = 0;

        public Form1(string docName)
        {
            InitializeComponent();
            doc = new XmlDocument();
            doc.Load(docName);
            answers = new List<string>();
            correctAnswers = new List<string>();
            for (int i = 0; i < 100; i++)
                userAnswers[i] = "";
            name = docName;
            loadQuizes();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            try
            {
                lblQuestion.Text = "";
                answerList.Items.Clear();
                currentQuiz = quizList.FocusedItem.Text;
                loadQuestions();
                x = 0;
                displayQuestion(x);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please, choose one of the quizes!");
            }
        }

        private void loadQuestions()
        {
            string question = "";

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
                        if (flag)
                        {
                            questions.Add(new Question(question, answers.ToArray(), correctAnswer, answers.Count));
                            flag = false;
                            correctFlag = false;
                            i = 0;
                            answers.Clear();
                            correctAnswers.Clear();
                        }

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
            }
        }

        private void displayQuestion(int x)
        {
            answerList.Items.Clear();

            lblQuestion.Text = x + 1 + ". " + questions[x].getQuestion();

            for (int i = 0; i < questions[x].getAnswers().Length; i++)
            {
                answerList.Items.Add(questions[x].getAnswers()[i]);
            }
        }
        

        private void nextQuestion_Click(object sender, EventArgs e)
        {
          //  userAnswers[x] = answerList.FocusedItem.Text;
            if (x + 1 < questions.Count)
            {
                //   userAnswers.Insert(x, answerList.FocusedItem.Text);
                displayQuestion(++x);
            }
        }

        private void previousQuestion_Click(object sender, EventArgs e)
        {
        //    userAnswers[x] = answerList.FocusedItem.Text;
            if (x - 1 >= 0)
            {
            //    userAnswers.Insert(x, answerList.FocusedItem.Text);
                displayQuestion(--x);
            }
        }

        private void checkAnswers_Click(object sender, EventArgs e)
        {
            for (int i=0; i<questions.Count; i++)
            {
                MessageBox.Show(userAnswers[i]);
                MessageBox.Show(questions[i].getCorrectAnswer());
                if (userAnswers[i] == questions[i].getCorrectAnswer())
                {
                    score++;
                }
            }
            MessageBox.Show("Your score: " + score + "/" + questions.Count);
        }
        private void setAnswer()
        {
           // answeros[x]
        }

        private void answerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            userAnswers[x] = answerList.FocusedItem.Text;
        }
    }
}
