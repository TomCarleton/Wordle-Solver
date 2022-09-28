using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WordleSolve2
{
    public class Puzzle
    {
        // Initialise variables
        List<string> tries = new List<string>();
        List<string> feedback = new List<string>();
        List<string> wordList = new List<string>();
        public int guessNum = -1;  // Will be set to 0 on first guess

        public Puzzle()
        {
            // Import sortedwords.txt
            wordList = new List<string>(global::WordleSolve2.Properties.Resources.sortedwords.Split(new string[] { Environment.NewLine }, StringSplitOptions.None));
        }

        public void Guess(string word, string result)
        {
            tries.Add(word);
            feedback.Add(result);
            guessNum++;

            // Iterate over each letter
            for (int i = 0; i <= 4; i++)
            {
                // Green tile removes all words without correct letter in position
                if (feedback[guessNum][i] == 'g')
                {
                    int gSubtract = 0;
                    int listCount = wordList.Count;
                    for (int g = 0; g < listCount; g++)
                    {
                        if (wordList[g - gSubtract][i] != tries[guessNum][i])
                        {
                            wordList.RemoveAt(g - gSubtract);
                            gSubtract++;
                        }
                    }
                }

                // Yellow tile removes all words with this letter in this position
                else if (feedback[guessNum][i] == 'y')
                {
                    // Removes words with letter in this position
                    int ySubtract = 0;
                    int listCount = wordList.Count;
                    for (int y = 0; y < listCount; y++)
                    {
                        if (wordList[y - ySubtract][i] == tries[guessNum][i])
                        {
                            wordList.RemoveAt(y - ySubtract);
                            ySubtract++;
                        }
                    }

                    // Removes all words that do not contain this letter
                    ySubtract = 0;
                    listCount = wordList.Count;
                    for (int y = 0; y < listCount; y++)
                    {
                        bool wordSafe = false;
                        for (int k = 0; k <= 4; k++)
                        {
                            if (wordList[y - ySubtract][k] == tries[guessNum][i])
                            {
                                wordSafe = true;
                            }
                        }
                        if (wordSafe == false)
                        {
                            wordList.RemoveAt(y - ySubtract);
                            ySubtract++;
                        }
                    }
                }

                // Black tile removes all words with this letter in any position (w/ exceptions)
                else if (feedback[guessNum][i] == 'b')
                {
                    bool allDone = false;

                    // Check for clashes with a matching green tile
                    for (int j = 0; j <= 4; j++)
                    {
                        if (feedback[guessNum][j] == 'g' &&
                            tries[guessNum][j] == tries[guessNum][i])
                        {
                            int bSubtract = 0;
                            int listCount = wordList.Count;
                            for (int b = 0; b < listCount; b++)
                            {
                                if (wordList[b - bSubtract][i] == tries[guessNum][i])
                                {
                                    wordList.RemoveAt(b - bSubtract);
                                    bSubtract++;
                                }
                            }
                            allDone = true;
                            break;
                        }
                    }

                    // Check for clashes with a matching green tile
                    if (allDone == false)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            if (feedback[guessNum][j] == 'y' &&
                                tries[guessNum][j] == tries[guessNum][i])
                            {
                                int bSubtract = 0;
                                int listCount = wordList.Count;
                                for (int b = 0; b < listCount; b++)
                                {
                                    if (wordList[b - bSubtract][i] == tries[guessNum][i])
                                    {
                                        wordList.RemoveAt(b - bSubtract);
                                        bSubtract++;
                                    }
                                }
                                allDone = true;
                                break;
                            }
                        }
                    }

                    // Remove all words with this letter in any position
                    if (allDone == false)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            int bSubtract = 0;
                            int listCount = wordList.Count;
                            for (int b = 0; b < listCount; b++)
                            {
                                if (wordList[b - bSubtract][j] == tries[guessNum][i])
                                {
                                    wordList.RemoveAt(b - bSubtract);
                                    bSubtract++;
                                }
                            }
                        }
                    }

                }


            }
        }

        public void PrintBoard()
        {
            for (int p = 0; p < feedback.Count; p++)
            {
                string gameDisplay = "";
                for (int q = 0; q <= 4; q++)
                {
                    if (feedback[p][q] == 'g')
                    {
                        gameDisplay += "[0]";
                    }
                    else if (feedback[p][q] == 'y')
                    {
                        gameDisplay += "[.]";
                    }
                    else if (feedback[p][q] == 'b')
                    {
                        gameDisplay += "[ ]";
                    }
                }
                Console.WriteLine(gameDisplay);
            }
        }

        public string[] GetSuggestions()
        {
            string suggWords = "";
            int possWords = wordList.Count;
            int numSuggest = Math.Min(possWords, 5);
            for (int i = 0; i < numSuggest; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    suggWords += wordList[i][j]; // Can probs be more efficient
                }
                if (i != numSuggest - 1)
                {
                    suggWords += ", ";
                }
            }
            string[] output = { suggWords, possWords.ToString() };
            return output;
        }

        public string GetStartSuggestions()
        {
            string startWords = "";
            int randSample;
            Random rnd = new Random();

            // Generate 3 random numbers <= 50
            for (int i = 0; i <= 4; i++)
            {
                randSample = rnd.Next(51);
                for (int j = 0; j <= 4; j++)
                {
                    startWords += wordList[randSample][j];
                }
                if (i != 4)
                {
                    startWords += ", ";
                }
            }
            return startWords;
        }
    }
}
