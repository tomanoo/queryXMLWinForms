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
            this.listView1 = new System.Windows.Forms.ListView();
            this.previousQuestion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.lblQuestion.Text = "lblQuestion";
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
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.Location = new System.Drawing.Point(122, 104);
            this.listView1.MinimumSize = new System.Drawing.Size(400, 250);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 250);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(422, 360);
            this.button1.MinimumSize = new System.Drawing.Size(100, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.previousQuestion);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button previousQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView quizList;
        private System.Windows.Forms.Button loadQuiz;
    }
}

