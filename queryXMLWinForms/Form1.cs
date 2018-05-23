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
        static int x = 0;
        string[] quizes = Directory.GetFiles(Directory.GetCurrentDirectory());
        string currentQuiz;
        int score = 0;

        public Form1(string docName)
        {
            InitializeComponent();
            doc = new XmlDocument();
            doc.Load(docName);
            answers = new List<string>();
            correctAnswers = new List<string>();
            name = docName;
            loadQuizes();
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
            currentQuiz = quizList.FocusedItem.Text;
            loadQuestions();
            x = 0;
            displayQuestion(x);
        }

        private void loadQuestions()
        {
            string question = "";

            XmlReader reader = XmlReader.Create(currentQuiz);
            bool flag = false;
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
                            questions.Add(new Question(question, answers.ToArray(), correctAnswers.ToArray(), answers.Count));
                            flag = false;
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
                        reader.Read();
                        reader.Read();

                        if (reader.Name == "Text")
                        {
                            answers.Add(reader.ReadInnerXml());
                            if (reader.GetAttribute("Correct") == "True")
                            {
                                correctAnswers.Add(answers[i]);
                            }
                            i++;
                            flag = true;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void displayQuestion(int x)
        {
            listView1.Items.Clear();

            lblQuestion.Text = x + 1 + ". " + questions[x].getQuestion();

            for (int i = 0; i < questions[x].getAnswers().Length; i++)
            {
                listView1.Items.Add((char)(i+97) + ") " + questions[x].getAnswers()[i]);
            }
        }
        

        private void nextQuestion_Click(object sender, EventArgs e)
        {
            if (x + 1 < questions.Count)
                displayQuestion(++x);
        }

        private void previousQuestion_Click(object sender, EventArgs e)
        {
            if (x - 1 >= 0)
                displayQuestion(--x);
        }

    }
}
