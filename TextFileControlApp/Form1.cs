using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int size = -1;
            String text = "";
            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK) // Test result
            {
                string file = openFile.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    //size = text.Length;
                    
                }
                catch (IOException)
                {
                    
                }

                //create new file name
                String newName = file.Remove(file.Length - 4, 4) + "-statistics.txt";

                //convert to lowercase
                String totalText = text.ToLower();

                //enter each word into an array
                String[] inputArr = totalText.Split(' ');

                //display to user and show text string
                textLower.Text = totalText;
                textLower.Visible = true;

                //check for first and last words alphabetically
                String first = checkFirstandLast(inputArr, 1); //1 for first, 2 for last
                String last = checkFirstandLast(inputArr, 2);

                //display first word
                firstWord.Text = first;
                firstWord.Visible = true;

                //display last word
                lastWord.Text = last;
                lastWord.Visible = true;

                //find longest word
                String longWord = findLongestWord(inputArr);

                //display longest word
                longestWord.Text = longWord;
                longestWord.Visible = true;

                //find word with most vowels
                String vowelsMost = findMostVowels(inputArr);

                //display word with most vowels
                mostVowels.Text = vowelsMost;
                mostVowels.Visible = true;
                
                //save to new file

                //put all into an array to make a single string
                String[] outPut = { "To Lowercase: " + totalText, "First word: " + first, "Last word: " + last,
                    "Longest word: " + longWord, "Word with most vowels: " + vowelsMost };
                
                //make a single string to write to file with line breaks
                String outToFile = "";

                for (int i = 0; i < outPut.Length; i++)
                {
                    outToFile += outPut[i] + "\n";

                }

                //write to file
                File.WriteAllText(newName, outToFile);

            }
            
        }

        private String checkFirstandLast(String[] input, int choice)
        {
            String result = "";

            //set both to the first element and check from there
            String first = input[0];
            String last = input[0];

            //2 for last alphabetically
            if (choice == 1)
            {
                for (int i = 1; i < input.Length; i++)
                { 
                    //compare first string in the file to each and assign first each loop until the end
                    if (String.Compare(first, input[i]) > 0)
                    {
                        first = input[i];
                    }

                }

                result = first;

            }

            //2 for last alphabetically
            if (choice == 2)
            {
                for (int i = 1; i < input.Length; i++)
                {
                    //compare last string in the file to each and assign first each loop until the end
                    if (String.Compare(last, input[i]) < 0)
                    {
                        last = input[i];
                    }
                }

                result = last;
            }

            return result;
        }

        //find longest word
        public String findLongestWord(String[] input)
        {
            String result = input[0];

            //loop through each word and compare length
            for (int i = 1; i < input.Length; i++)
            {
                if (result.Length < input[i].Length)
                {
                    result = input[i];
                }
            }

            return result;
        }

        //find word with most vowels
        public String findMostVowels(String[] input)
        {
            String result = "";
            int count = 0;
            int most = 0;
            char[] checks = { 'a', 'e', 'i', 'o', 'u' }; //we won't count y as a vowel for this exercise 

            //loop through each word from file
            for (int i = 0; i < input.Length; i++)
            {
                //convert the word into a char array
                char[] word = input[i].ToCharArray();

                //loop through the word
                for (int j = 0; j < word.Length; j++)
                { 
                    //loop through the vowels  
                    for (int k = 0; k < checks.Length; k++)
                    {
                        if (word[j].Equals(checks[k]))
                        {
                            count++;
                        }
                    }

                }

                //check if the count of current word is higher than the most so far
                if (count > most)
                {
                    most = count;
                    result = input[i];
                }

                count = 0;
            }

            return result;
        }
    }
}
