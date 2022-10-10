using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    internal static class UI // пользовательский уровень
    {
        public static void ShowGameOver(TextBox gameOverText, string msg, int score, int enemiesLeft) // метод типа
        {
            msg += Environment.NewLine +
                "Total score: " + score + Environment.NewLine +
                "Enemies Left: " + enemiesLeft + Environment.NewLine +
                "Press Enter to restart.";
            gameOverText.Text = msg;
            gameOverText.Show();
        }

        public static void ShowResults(TextBox textResults, string results)
        {
            textResults.AppendText(results);
        }

        public static void NameError(object sender, EventArgs e)
        {
            MessageBox.Show("Ошибка! Введите никнейм");
        }
    }
}
