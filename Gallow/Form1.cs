using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Gallow
{
    public partial class Form1 : Form
    {
        public Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Работу выполнила Старушкина Маргарита");
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Правила игры \"Виселица\"\nИгроку загадывается русское существительное слово без склонений, которое требуется угадать за 10 ходов. В каждом ходе игроку будет предложено ввести одну букву. При неудаче, количество попыток будет уменьшаться и дорисуется элемент виселицы. Когда попытки будут окончены и виселица дорисована, игра считается законченной с поражением, а игрок - повешанным. Если слово оказывается полностью отгаданным, игрок будет помилован и считается победителем.");
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game();
            game.GenerateGame();
            Render();
            tbLetter.Enabled = true;
            btnSet.Enabled = true;
        }

        public void Render()
        {
            lblWordText.Text = game.GetText(game.progress);
            lblErrorsText.Text = game.GetText(game.errors);
            lblCountText.Text = Convert.ToString(game.count);
            img.Image = Image.FromFile(game.GetImg());
            tbLetter.Text = String.Empty;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[а-я]$");
            if (!regex.IsMatch(tbLetter.Text))
            {
                MessageBox.Show("Введите одну букву русского алфавита!");
            }
            else
            {
                game.nextMove(tbLetter.Text);
                Render();
                if (game.count == 0) game.LastCount();
                if (game.start == false)
                {
                    tbLetter.Enabled = false;
                    btnSet.Enabled = false;
                }
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbLetter.Enabled = false;
            btnSet.Enabled = false;
        }
    }
}