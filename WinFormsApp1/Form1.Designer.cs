namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Next_btn = new Button();
            Quiz = new Label();
            QuestionLabel = new Label();
            AnswerBox = new TextBox();
            Finish_btn = new Button();
            Expansion_btn = new Button();
            SuspendLayout();
            // 
            // Next_btn
            // 
            Next_btn.Location = new Point(220, 193);
            Next_btn.Name = "Next_btn";
            Next_btn.Size = new Size(193, 29);
            Next_btn.TabIndex = 0;
            Next_btn.Text = "Next";
            Next_btn.UseVisualStyleBackColor = true;
            Next_btn.Click += Next_btn_Click;
            // 
            // Quiz
            // 
            Quiz.AutoSize = true;
            Quiz.BackColor = SystemColors.Control;
            Quiz.Font = new Font("Snap ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quiz.ForeColor = SystemColors.ControlText;
            Quiz.Location = new Point(341, 31);
            Quiz.Name = "Quiz";
            Quiz.Size = new Size(148, 36);
            Quiz.TabIndex = 3;
            Quiz.Text = "Вікторина";
            // 
            // QuestionLabel
            // 
            QuestionLabel.AutoSize = true;
            QuestionLabel.Location = new Point(236, 92);
            QuestionLabel.Name = "QuestionLabel";
            QuestionLabel.Size = new Size(353, 20);
            QuestionLabel.TabIndex = 4;
            QuestionLabel.Text = "Що не поміститься навіть у найбільшу каструлю?";
            // 
            // AnswerBox
            // 
            AnswerBox.AcceptsReturn = true;
            AnswerBox.AcceptsTab = true;
            AnswerBox.Location = new Point(220, 135);
            AnswerBox.Name = "AnswerBox";
            AnswerBox.Size = new Size(400, 27);
            AnswerBox.TabIndex = 5;
            // 
            // Finish_btn
            // 
            Finish_btn.Location = new Point(427, 193);
            Finish_btn.Name = "Finish_btn";
            Finish_btn.Size = new Size(193, 29);
            Finish_btn.TabIndex = 6;
            Finish_btn.Text = "Finish";
            Finish_btn.UseVisualStyleBackColor = true;
            Finish_btn.Click += Finish_btn_Click;
            // 
            // Expansion_btn
            // 
            Expansion_btn.Location = new Point(372, 228);
            Expansion_btn.Name = "Expansion_btn";
            Expansion_btn.Size = new Size(94, 29);
            Expansion_btn.TabIndex = 7;
            Expansion_btn.Text = "Expansion";
            Expansion_btn.UseVisualStyleBackColor = true;
            Expansion_btn.Visible = false;
            Expansion_btn.Click += Expansion_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 379);
            Controls.Add(Expansion_btn);
            Controls.Add(Finish_btn);
            Controls.Add(AnswerBox);
            Controls.Add(QuestionLabel);
            Controls.Add(Quiz);
            Controls.Add(Next_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Next_btn;
        private Label Quiz;
        private Label QuestionLabel;
        private TextBox AnswerBox;
        private Button Finish_btn;
        private Button Expansion_btn;
    }
}
