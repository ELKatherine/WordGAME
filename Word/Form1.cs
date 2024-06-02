using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] words;
        List<string> selectedWords;
        int index = 0, score = 0;
        Random random = new Random();
        int numberOfWordsToDisplay = 10; 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            index = 0;
            score = 0;
            label_result.Text = "Result";
            label_result.BackColor = System.Drawing.Color.Peru;
            label_score.Text = "00";
            selectedWords = words.OrderBy(x => random.Next()).Take(numberOfWordsToDisplay).ToList(); 
            displayWord();
            button_next.Enabled = true;
            button_start.Enabled = false;
            label_score.Visible = true;
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            checkWord();
            if (index < selectedWords.Count - 1)
            {
                index++;
                displayWord();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWordsFromFile(@"C:\Users\lipch\source\repos\Word\Word\words.txt");
            EnsureMinimumWords(100);
            label_score.Visible = true;

        }

        private void LoadWordsFromFile(string filePath)
        {
            try
            {
                words = File.ReadAllLines(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading words from file: " + ex.Message);
            }
        }

        private void EnsureMinimumWords(int minWords)
        {
            if (words.Length < minWords)
            {
                var defaultWords = new List<string>
                {
                    "table", "house", "chair", "water", "plant", "beach", "apple", "snake", "truck", "mouse",
                    "bird", "clock", "train", "light", "earth", "bread", "smile", "river", "queen", "horse"
                };

                var additionalWords = defaultWords.Take(minWords - words.Length);
                File.AppendAllLines(@"C:\Users\lipch\source\repos\Word\Word\words.txt", additionalWords);
                words = File.ReadAllLines(@"C:\Users\lipch\source\repos\Word\Word\words.txt");
            }
        }

        public void displayWord()
        {
            if (index >= selectedWords.Count) return;

            string word = selectedWords[index];
            char[] wordArray = word.ToCharArray();
            for (int i = 0; i < 3; i++)
            {
                int pos = random.Next(word.Length);
                wordArray[pos] = '_';
            }
            label_word.Text = new string(wordArray);
        }

        public void checkWord()
        {
            if (textBox_guess.Text.ToLower().Equals(selectedWords[index]))
            {
                label_result.Text = "Correct";
                label_result.BackColor = System.Drawing.Color.Green;
                score++;
            }
            else
            {
                label_result.Text = "Wrong";
                label_result.BackColor = System.Drawing.Color.Red;
            }
            if (index == selectedWords.Count - 1)
            {
                button_start.Enabled = true;
                button_next.Enabled = false;
            }
            textBox_guess.Text = "";
            label_score.Text = $"{score} / {selectedWords.Count}";
        }

        private void button_setNumberOfWords_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_numberOfWords.Text, out int number))
            {
                numberOfWordsToDisplay = Math.Min(number, words.Length);
                MessageBox.Show($"Number of words to display set to {numberOfWordsToDisplay}");
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
