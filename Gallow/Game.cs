using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Gallow
{
    public class Game
    {
        public string word;
        public char[] letters;
        public char[] progress;
        public char[] errors;
        public int count;
        public bool start;

        public void GenerateGame()
        {
            word = WordGen();
            letters = word.ToCharArray();
            progress = GetStartChar(letters);
            errors = new char[10];
            count = 10;
            start = true;
            Console.ReadLine();
        }
        
        static string WordGen()
        {
            string word = String.Empty;
            using (StreamReader sr = new StreamReader("words.txt"))
            {
                string text = sr.ReadLine();
                string[] wordArr = GetWordArr(text);
                word = GetWordRandom(wordArr);
                sr.Close();
            }

            return word;
        }
        
        static string[] GetWordArr(string text)
        {
            string[] result = new string[text.Length];
            result = text.ToString().Split(' ');
            return result;
        }
        
        static string GetWordRandom(string[] arr)
        {
            string result = arr[new Random().Next(0, arr.Length)];
            return result;
        }
        
        public char[] GetStartChar(char[] letters)
        {
            char[] progress = new char[letters.Length];
            for (int i = 0; i < progress.Length; i++)
            {
                progress[i] = Convert.ToChar("_");
            }

            return progress;
        }

        public string GetText(char[] elements)
        {
            string result = String.Empty;
            StringBuilder wordText = new StringBuilder();
            for (int i = 0; i < elements.Length; i++)
            {
                wordText.Append(elements[i] + " ");
            }

            result = Convert.ToString(wordText);
            return result;
        }

        public void nextMove(string letter)
        {
            bool errorsCheck = false;
            char letterRound = Convert.ToChar(letter);
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == letterRound)
                {
                    progress[i] = letterRound;
                    errorsCheck = true;
                }
            }

            count = CheckWin();
            if (errorsCheck == false)
            {
                errors[10 - count] = letterRound;
                count--;
            }
        }

        public int CheckWin()
        {
            int result = count;
            int idx = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == progress[i]) idx++;
            }

            if (idx == letters.Length)
            {
                MessageBox.Show("Вы выиграли за " + (10 - count) + " попытки!\nЗагаданное слово: " + word);
                start = false;
            }

            return result;
        }

        public void LastCount()
        {
            if (start == true)
            {
                MessageBox.Show("Попытки окончены, Вы проиграли. Загаданное слово: " + word);
                start = false;
            }
        }

        public string GetImg()
        {
            string result = String.Empty;
            string[] image = new string[11];
            image[0] = "img/Gallow0.jpg";
            image[1] = "img/Gallow1.jpg";
            image[2] = "img/Gallow2.jpg";
            image[3] = "img/Gallow3.jpg";
            image[4] = "img/Gallow4.jpg";
            image[5] = "img/Gallow5.jpg";
            image[6] = "img/Gallow6.jpg";
            image[7] = "img/Gallow7.jpg";
            image[8] = "img/Gallow8.jpg";
            image[9] = "img/Gallow9.jpg";
            image[10] = "img/Gallow10.jpg";
            if (start == true) result = image[count];
            else result = "img/GallowWin.jpg";
            return result;
        }
    }
}