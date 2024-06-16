using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int _currentIndex = 0;
        private readonly List<Question> _questions;
        private int _rightAnswer = 0;

        public Form1()
        {
            InitializeComponent();

            _questions = new List<Question>()
            {
                new Question()
                {
                    Text = "як сп≥ймати тигра в кл≥тку?",
                    Answer = "Next",
                    Status = false
                },
                new Question()
                {
                    Text = "’то зможе запросто пересунути слона?",
                    Answer = "Ўах≥ст",
                    Status = false
                },
                new Question()
                {
                    Text = "—к≥льки штук €Їць людина може з'њсти натщесерце?",
                    Answer = "1",
                    Status = false
                },
                new Question()
                {
                    Text = "ўо 100% належить вам, але ≥нш≥ люди чомусь користуютьс€ ним част≥ше?",
                    Answer = "≤м'€",
                    Status = false
                },
                new Question()
                {
                    Text = "яких не буваЇ камен≥в у мор≥?",
                    Answer = "—ухих",
                    Status = false
                },
                new Question()
                {
                    Text = "ƒе вперше ви€вили картоплю?",
                    Answer = "¬ земл≥",
                    Status = false
                },
                new Question()
                {
                    Text = "яка рослина знаЇ все на св≥т≥?",
                    Answer = "’р≥н",
                    Status = false
                },
                new Question()
                {
                    Text = "я вода ≥ плаваю теж по вод≥. ўо €?",
                    Answer = " рижина",
                    Status = false
                },
                new Question()
                {
                    Text = "’то н≥коли не намочить волосс€ п≥д дощем?",
                    Answer = "Ћисий",
                    Status = false
                },
                new Question()
                {
                    Text = "ўо не пом≥ститьс€ нав≥ть у найб≥льшу каструлю?",
                    Answer = " ришка",
                    Status = false
                },
            };
            QuestionLabel.Text = "Ќапиш≥ть ≥ натисн≥ть 'Next' дл€ початку тесту";
        }
        private void DisplayCurrentQuestion()
        {
            if (_currentIndex < _questions.Count)
            {
                var currentQuestion = _questions[_currentIndex];
                QuestionLabel.Text = currentQuestion.Text;
            }
            else
            {
                MessageBox.Show($"¬и в≥дпов≥ли правильно на {_rightAnswer} з {_questions.Count} питань.");
                Expansion_btn.Visible = true;
            }
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (_currentIndex < _questions.Count)
            {
                if (!string.IsNullOrWhiteSpace(AnswerBox.Text))
                {
                    var currentQuestion = _questions[_currentIndex];

                    if (AnswerBox.Text.Equals(currentQuestion.Answer))
                    {
                        _rightAnswer++;
                        currentQuestion.Status = true;
                    }
                    else
                    {
                        currentQuestion.Status = false;
                    }

                    AnswerBox.Clear();
                    _currentIndex++;
                    DisplayCurrentQuestion();
                }
                else
                {
                    MessageBox.Show("ѕоле в≥дпов≥д≥ не може бути порожн≥м. Ѕудь ласка, введ≥ть в≥дпов≥дь.");
                }
            }

        }
        private void Finish_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Expansion_btn_Click(object sender, EventArgs e)
        {
            foreach(var question in _questions)
            {
                if (question.Status == false)
                {
                    MessageBox.Show($"Ќа питанн€ '{question.Text}' правильна в≥дпов≥дь була '{question.Answer}'");
                }
            }
        }
    }
}
