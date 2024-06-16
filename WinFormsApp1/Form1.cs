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
                    Text = "Як спіймати тигра в клітку?",
                    Answer = "Далі",
                    Status = false
                },
                new Question()
                {
                    Text = "Хто зможе запросто пересунути слона?",
                    Answer = "Шахіст",
                    Status = false
                },
                new Question()
                {
                    Text = "Скільки штук яєць людина може з'їсти натщесерце?",
                    Answer = "1",
                    Status = false
                },
                new Question()
                {
                    Text = "Що 100% належить вам, але інші люди чомусь користуються ним частіше?",
                    Answer = "Ім'я",
                    Status = false
                },
                new Question()
                {
                    Text = "Яких не буває каменів у морі?",
                    Answer = "Сухих",
                    Status = false
                },
                new Question()
                {
                    Text = "Де вперше виявили картоплю?",
                    Answer = "В землі",
                    Status = false
                },
                new Question()
                {
                    Text = "Яка рослина знає все на світі?",
                    Answer = "Хрін",
                    Status = false
                },
                new Question()
                {
                    Text = "Я вода і плаваю теж по воді. Що я?",
                    Answer = "Крижина",
                    Status = false
                },
                new Question()
                {
                    Text = "Хто ніколи не намочить волосся під дощем?",
                    Answer = "Лисий",
                    Status = false
                },
                new Question()
                {
                    Text = "Що не поміститься навіть у найбільшу каструлю?",
                    Answer = "Кришка",
                    Status = false
                },
            };
            QuestionLabel.Text = "Напишіть 'Далі' і натисніть 'Next' для початку тесту";
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
                MessageBox.Show($"Ви відповіли правильно на {_rightAnswer} з {_questions.Count} питань.");
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
                    MessageBox.Show("Поле відповіді не може бути порожнім. Будь ласка, введіть відповідь.");
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
                    MessageBox.Show($"На питання '{question.Text}' правильна відповідь була '{question.Answer}'");
                }
            }
        }
    }
}
