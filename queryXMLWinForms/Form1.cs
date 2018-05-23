using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        static int x = 0;

        public Form1(string docName)
        {
            InitializeComponent();
            doc = new XmlDocument();
            doc.Load(docName);
            answers = new List<string>();
            name = docName;
            loadQuestions();
            displayQuestion(0);
        }

        private void loadQuestions()
        {
            string question = "";

            XmlReader reader = XmlReader.Create("das.xml");
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
                            questions.Add(new Question(question, answers.ToArray(), answers.Count));
                            flag = false;
                            i = 0;
                            answers.Clear();
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

            lblQuestion.Text = questions[x].getQuestion();

            for (int i = 0; i < questions[x].getAns().Length; i++)
            {
                listView1.Items.Add(questions[x].getAns()[i]);
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
