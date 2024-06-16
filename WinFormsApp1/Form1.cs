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
                    Text = "�� ������� ����� � �����?",
                    Answer = "���",
                    Status = false
                },
                new Question()
                {
                    Text = "��� ����� �������� ���������� �����?",
                    Answer = "������",
                    Status = false
                },
                new Question()
                {
                    Text = "������ ���� ���� ������ ���� �'���� ����������?",
                    Answer = "1",
                    Status = false
                },
                new Question()
                {
                    Text = "�� 100% �������� ���, ��� ���� ���� ������ ������������ ��� ������?",
                    Answer = "��'�",
                    Status = false
                },
                new Question()
                {
                    Text = "���� �� ���� ������ � ���?",
                    Answer = "�����",
                    Status = false
                },
                new Question()
                {
                    Text = "�� ������ ������� ��������?",
                    Answer = "� ����",
                    Status = false
                },
                new Question()
                {
                    Text = "��� ������� ��� ��� �� ���?",
                    Answer = "���",
                    Status = false
                },
                new Question()
                {
                    Text = "� ���� � ������ ��� �� ���. �� �?",
                    Answer = "�������",
                    Status = false
                },
                new Question()
                {
                    Text = "��� ����� �� �������� ������� �� �����?",
                    Answer = "�����",
                    Status = false
                },
                new Question()
                {
                    Text = "�� �� ���������� ����� � �������� ��������?",
                    Answer = "������",
                    Status = false
                },
            };
            QuestionLabel.Text = "�������� '���' � �������� 'Next' ��� ������� �����";
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
                MessageBox.Show($"�� ������� ��������� �� {_rightAnswer} � {_questions.Count} ������.");
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

                    currentQuestion.UsersAnswers = AnswerBox.Text;
                    AnswerBox.Clear();
                    _currentIndex++;
                    DisplayCurrentQuestion();
                }
                else
                {
                    MessageBox.Show("���� ������ �� ���� ���� �������. ���� �����, ������ �������.");
                }
            }

        }
        private void Finish_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string answerFilter()
        {
            string message = "";
            foreach (var question in _questions)
            {
                if (question.Status == false)
                {
                    message += $"�� ������� '{question.Text}' ���� ������� - '{question.UsersAnswers}' - ���� �����\n";
                }
            }
            return message;
        }

        private void Expansion_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{answerFilter()}");
        }
    }
}
