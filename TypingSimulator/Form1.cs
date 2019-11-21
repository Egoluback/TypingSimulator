using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.IO;
using System.Diagnostics;


namespace TypingSimulator
{
    public partial class MainForm : Form
    {
        List<string> tasks = new List<string>();
        bool isEnd = false;
        string correctText;

        Stopwatch time = new Stopwatch();

        Random random = new Random();
        public MainForm()
        {
            GenerateText generator = new GenerateText(1);

            for (int iterator = 0; iterator < 10; iterator++)
            {
                tasks.Add(generator.Generate());
            }

            InitializeComponent();

            correctText = tasks[random.Next(0, tasks.Count - 1)];
            correctTextLabel.Text = correctText;
        }

        private void Answer(bool isCorrect, string key = "")
        {
            if (!isCorrect)
            {
                SoundPlayer audio = new SoundPlayer(TypingSimulator.Properties.Resources.error);

                audio.Play();

                labelError.Text = "Неверно!";
                labelError.ForeColor = Color.Red;
            }
            else
            {
                labelError.Text = "Печатайте...";
                labelError.ForeColor = Color.SlateGray;

                userTextLabel.Text += key;

                if (userTextLabel.Text.Length <= correctText.Length - 1)
                {
                    string keyToShow = correctText[userTextLabel.Text.Length].ToString();

                    if (keyToShow == " ") labelKey.Text = "*Пробел*";
                    else labelKey.Text = keyToShow;
                }
            }
        }

        private async void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isEnd) return;

            string key = e.KeyChar.ToString();


            if (!correctText.Contains(userTextLabel.Text + key) && userTextLabel.Text.Length != 0)
            {
                Answer(false);
            }
            else if (userTextLabel.Text.Length != 0)
            {
                Answer(true, key);
            }
            else
            {
                if (key == correctText[0].ToString()) Answer(true, key);
                else Answer(false);
                time.Start();
            }

            if (userTextLabel.Text == correctText)
            {
                SoundPlayer audio = new SoundPlayer(TypingSimulator.Properties.Resources.complete);

                audio.Play();

                time.Stop();
                labelTime.Text = time.Elapsed.TotalSeconds.ToString();

                if (tasks.Count <= 1)
                {
                    labelError.Text = "Все уровни пройдены.";
                    labelError.ForeColor = Color.ForestGreen;

                    isEnd = true;

                    return;
                }
                else
                {
                    labelError.Text = "Уровень пройден!";
                    labelError.ForeColor = Color.ForestGreen;
                }

                labelKey.Text = "";

                await Task.Delay(3000);

                labelError.Text = "Печатайте...";
                labelError.ForeColor = Color.SlateGray;

                tasks.Remove(correctText);

                string newText;
                do
                {
                    newText = tasks[random.Next(0, tasks.Count - 1)];
                } while (newText == correctText);

                correctText = newText;

                userTextLabel.Text = "";
                labelTime.Text = "";
                correctTextLabel.Text = correctText;
            }
        }
    }
}
