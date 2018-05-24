namespace queryXMLWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.nextQuestion = new System.Windows.Forms.Button();
            this.answerList = new System.Windows.Forms.ListView();
            this.previousQuestion = new System.Windows.Forms.Button();
            this.checkAnswers = new System.Windows.Forms.Button();
            this.quizList = new System.Windows.Forms.ListView();
            this.loadQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuestion.Location = new System.Drawing.Point(122, 21);
            this.lblQuestion.MinimumSize = new System.Drawing.Size(400, 70);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(400, 70);
            this.lblQuestion.TabIndex = 0;
            // 
            // nextQuestion
            // 
            this.nextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextQuestion.Location = new System.Drawing.Point(203, 360);
            this.nextQuestion.MinimumSize = new System.Drawing.Size(75, 40);
            this.nextQuestion.Name = "nextQuestion";
            this.nextQuestion.Size = new System.Drawing.Size(75, 40);
            this.nextQuestion.TabIndex = 5;
            this.nextQuestion.Text = ">>>";
            this.nextQuestion.UseVisualStyleBackColor = true;
            this.nextQuestion.Click += new System.EventHandler(this.nextQuestion_Click);
            // 
            // answerList
            // 
            this.answerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.answerList.Location = new System.Drawing.Point(122, 104);
            this.answerList.MinimumSize = new System.Drawing.Size(400, 250);
            this.answerList.Name = "answerList";
            this.answerList.Size = new System.Drawing.Size(400, 250);
            this.answerList.TabIndex = 7;
            this.answerList.UseCompatibleStateImageBehavior = false;
            this.answerList.View = System.Windows.Forms.View.List;
            this.answerList.SelectedIndexChanged += new System.EventHandler(this.answerList_SelectedIndexChanged);
            // 
            // previousQuestion
            // 
            this.previousQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previousQuestion.Location = new System.Drawing.Point(122, 360);
            this.previousQuestion.MinimumSize = new System.Drawing.Size(75, 40);
            this.previousQuestion.Name = "previousQuestion";
            this.previousQuestion.Size = new System.Drawing.Size(75, 40);
            this.previousQuestion.TabIndex = 8;
            this.previousQuestion.Text = "<<<";
            this.previousQuestion.UseVisualStyleBackColor = true;
            this.previousQuestion.Click += new System.EventHandler(this.previousQuestion_Click);
            // 
            // checkAnswers
            // 
            this.checkAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkAnswers.Location = new System.Drawing.Point(422, 360);
            this.checkAnswers.MinimumSize = new System.Drawing.Size(100, 40);
            this.checkAnswers.Name = "checkAnswers";
            this.checkAnswers.Size = new System.Drawing.Size(100, 40);
            this.checkAnswers.TabIndex = 9;
            this.checkAnswers.Text = "Finish";
            this.checkAnswers.UseVisualStyleBackColor = true;
            this.checkAnswers.Click += new System.EventHandler(this.checkAnswers_Click);
            // 
            // quizList
            // 
            this.quizList.Location = new System.Drawing.Point(12, 12);
            this.quizList.Name = "quizList";
            this.quizList.Size = new System.Drawing.Size(100, 300);
            this.quizList.TabIndex = 10;
            this.quizList.UseCompatibleStateImageBehavior = false;
            // 
            // loadQuiz
            // 
            this.loadQuiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadQuiz.Location = new System.Drawing.Point(12, 318);
            this.loadQuiz.MinimumSize = new System.Drawing.Size(100, 40);
            this.loadQuiz.Name = "loadQuiz";
            this.loadQuiz.Size = new System.Drawing.Size(100, 40);
            this.loadQuiz.TabIndex = 11;
            this.loadQuiz.Text = "Load";
            this.loadQuiz.UseVisualStyleBackColor = true;
            this.loadQuiz.Click += new System.EventHandler(this.loadQuiz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.loadQuiz);
            this.Controls.Add(this.quizList);
            this.Controls.Add(this.checkAnswers);
            this.Controls.Add(this.previousQuestion);
            this.Controls.Add(this.answerList);
            this.Controls.Add(this.nextQuestion);
            this.Controls.Add(this.lblQuestion);
            this.MinimumSize = new System.Drawing.Size(550, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button nextQuestion;
        private System.Windows.Forms.ListView answerList;
        private System.Windows.Forms.Button previousQuestion;
        private System.Windows.Forms.Button checkAnswers;
        private System.Windows.Forms.ListView quizList;
        private System.Windows.Forms.Button loadQuiz;
    }
}

