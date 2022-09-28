using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordleSolve2
{
    public partial class Form1 : Form
    {
        // Initialise variables
        Puzzle activePuzzle;
        string puzzleGuess;
        string puzzleFeedback;
        bool waitingGuess;
        bool waitingFeedback;
        bool lockedForm = false;
        Color wGrey = Color.FromArgb(40, 40, 40);
        Color wYellow = Color.FromArgb(250, 190, 35);
        Color wGreen = Color.FromArgb(22, 181, 62);
        Color wActive = Color.FromArgb(50, 50, 50);

        // Define list of feedback boxes
        List<Label> feedbackBoxes = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Hide feedback boxes
            HideFeedback();

            // Group feedback boxes
            feedbackBoxes.Add(feedback1);
            feedbackBoxes.Add(feedback2);
            feedbackBoxes.Add(feedback3);
            feedbackBoxes.Add(feedback4);
            feedbackBoxes.Add(feedback5);

            // Begin program
            RunSolver();
        }

        public void RunSolver()
        {
            // Initiate puzzle class
            Puzzle puzzle1 = new Puzzle();
            activePuzzle = puzzle1;

            // Set up UI
            HideFeedback();
            ResetGrid();
            failText.Visible = false;
            enterGuess.Text = "";
            enterGuess.Visible = true;
            enterGuessTitle.Visible = true;
            enterGuessTitle.Text = "Type your guess:";
            wordsLeft.Text = "5758 words remaining";

            // Print starting word suggestions
            suggestedWords.Text = puzzle1.GetStartSuggestions();

            // Waiting for guess
            waitingGuess = true;
            waitingFeedback = false;
    }

        private void EnterPress()
        {
            // Check we are waiting for a text input
            if (waitingGuess == true)
            {
                // Data validation checks
                if (enterGuess.Text.Length == 5 && enterGuess.Text.All(Char.IsLetter))
                {
                    // No longer waiting for a guess, waiting for feedback
                    waitingGuess = false;
                    waitingFeedback = true;
                    enterGuess.Visible = false;
                    //e.SuppressKeyPress = true;
                    //e.Handled = true;

                    // Update guess and seek feedback
                    puzzleGuess = enterGuess.Text;
                    ShowFeedback();
                }
            }

            // Else, we are waiting for feedback input
            else if (waitingFeedback == true)
            {
                // No longer waiting for feedback
                waitingFeedback = false;
                HideFeedback();

                // Clear & update feedback
                puzzleFeedback = "";
                foreach (Label l in feedbackBoxes)
                {
                    if (l.BackColor == wGrey)
                    {
                        puzzleFeedback += "b";
                    }
                    else if (l.BackColor == wYellow)
                    {
                        puzzleFeedback += "y";
                    }
                    else
                    {
                        puzzleFeedback += "g";
                    }
                }

                // Perform guess
                activePuzzle.Guess(puzzleGuess.ToLower(), puzzleFeedback);

                // Update grid
                UpdateGrid(activePuzzle.guessNum + 1, puzzleGuess, puzzleFeedback);

                // Get new suggestions
                suggestedWords.Text = activePuzzle.GetSuggestions()[0];
                wordsLeft.Text = activePuzzle.GetSuggestions()[1];
                if (Int32.Parse(activePuzzle.GetSuggestions()[1]) == 1)
                {
                    wordsLeft.Text += " word remaining";
                }
                else
                {
                    wordsLeft.Text += " words remaining";
                }

                // Seek next guess
                if (activePuzzle.guessNum != 5)
                {
                    waitingGuess = true;
                    enterGuess.Text = "";
                    enterGuess.Visible = true;
                    enterGuessTitle.Text = "Type your guess:";
                }
                else
                {
                    enterGuessTitle.Visible = false;
                    failText.Visible = true;
                }
            }
        }

        private void ShowFeedback()
        {
            // Update instructional text
            enterGuessTitle.Text = "Click tiles to select colours:";

            // Show and update feedback tiles
            feedback1.Visible = true;
            feedback1.Text = Char.ToString(enterGuess.Text[0]);
            feedback1.BackColor = Color.FromArgb(40, 40, 40);

            feedback2.Visible = true;
            feedback2.Text = Char.ToString(enterGuess.Text[1]);
            feedback2.BackColor = Color.FromArgb(40, 40, 40);

            feedback3.Visible = true;
            feedback3.Text = Char.ToString(enterGuess.Text[2]);
            feedback3.BackColor = Color.FromArgb(40, 40, 40);

            feedback4.Visible = true;
            feedback4.Text = Char.ToString(enterGuess.Text[3]);
            feedback4.BackColor = Color.FromArgb(40, 40, 40);

            feedback5.Visible = true;
            feedback5.Text = Char.ToString(enterGuess.Text[4]);
            feedback5.BackColor = Color.FromArgb(40, 40, 40);

        }

        private void HideFeedback()
        {
            feedback1.Visible = false;
            feedback2.Visible = false;
            feedback3.Visible = false;
            feedback4.Visible = false;
            feedback5.Visible = false;
        }

        private void ResetGrid()
        {
            // Clear colour and text from whole grid
            foreach (Label l in gamePanel.Controls.Cast<Control>().OrderBy(c => c.TabIndex))
            {
                l.Text = "";
                l.BackColor = Color.FromArgb(40, 40, 40);
            }

            // Set first row to 'active' colour
            grid11.BackColor = Color.FromArgb(50, 50, 50);
            grid12.BackColor = Color.FromArgb(50, 50, 50);
            grid13.BackColor = Color.FromArgb(50, 50, 50);
            grid14.BackColor = Color.FromArgb(50, 50, 50);
            grid15.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void UpdateGrid(int row, string guess, string feedback)
        {
            if (row == 1)
            {
                // Update grid text
                grid11.Text = guess[0].ToString();
                grid12.Text = guess[1].ToString();
                grid13.Text = guess[2].ToString();
                grid14.Text = guess[3].ToString();
                grid15.Text = guess[4].ToString();

                // Update grid colour
                SetColour(grid11, feedback[0].ToString());
                SetColour(grid12, feedback[1].ToString());
                SetColour(grid13, feedback[2].ToString());
                SetColour(grid14, feedback[3].ToString());
                SetColour(grid15, feedback[4].ToString());

                // Set next row to active
                SetColour(grid21, "a");
                SetColour(grid22, "a");
                SetColour(grid23, "a");
                SetColour(grid24, "a");
                SetColour(grid25, "a");
            }
            else if (row == 2)
            {
                // Update grid text
                grid21.Text = guess[0].ToString();
                grid22.Text = guess[1].ToString();
                grid23.Text = guess[2].ToString();
                grid24.Text = guess[3].ToString();
                grid25.Text = guess[4].ToString();

                // Update grid colour
                SetColour(grid21, feedback[0].ToString());
                SetColour(grid22, feedback[1].ToString());
                SetColour(grid23, feedback[2].ToString());
                SetColour(grid24, feedback[3].ToString());
                SetColour(grid25, feedback[4].ToString());

                // Set next row to active
                SetColour(grid31, "a");
                SetColour(grid32, "a");
                SetColour(grid33, "a");
                SetColour(grid34, "a");
                SetColour(grid35, "a");
            }
            else if (row == 3)
            {
                // Update grid text
                grid31.Text = guess[0].ToString();
                grid32.Text = guess[1].ToString();
                grid33.Text = guess[2].ToString();
                grid34.Text = guess[3].ToString();
                grid35.Text = guess[4].ToString();

                // Update grid colour
                SetColour(grid31, feedback[0].ToString());
                SetColour(grid32, feedback[1].ToString());
                SetColour(grid33, feedback[2].ToString());
                SetColour(grid34, feedback[3].ToString());
                SetColour(grid35, feedback[4].ToString());

                // Set next row to active
                SetColour(grid41, "a");
                SetColour(grid42, "a");
                SetColour(grid43, "a");
                SetColour(grid44, "a");
                SetColour(grid45, "a");
            }
            else if (row == 4)
            {
                // Update grid text
                grid41.Text = guess[0].ToString();
                grid42.Text = guess[1].ToString();
                grid43.Text = guess[2].ToString();
                grid44.Text = guess[3].ToString();
                grid45.Text = guess[4].ToString();

                // Update grid colour
                SetColour(grid41, feedback[0].ToString());
                SetColour(grid42, feedback[1].ToString());
                SetColour(grid43, feedback[2].ToString());
                SetColour(grid44, feedback[3].ToString());
                SetColour(grid45, feedback[4].ToString());

                // Set next row to active
                SetColour(grid51, "a");
                SetColour(grid52, "a");
                SetColour(grid53, "a");
                SetColour(grid54, "a");
                SetColour(grid55, "a");
            }
            else if (row == 5)
            {
                // Update grid text
                grid51.Text = guess[0].ToString();
                grid52.Text = guess[1].ToString();
                grid53.Text = guess[2].ToString();
                grid54.Text = guess[3].ToString();
                grid55.Text = guess[4].ToString();

                // Update grid colour
                SetColour(grid51, feedback[0].ToString());
                SetColour(grid52, feedback[1].ToString());
                SetColour(grid53, feedback[2].ToString());
                SetColour(grid54, feedback[3].ToString());
                SetColour(grid55, feedback[4].ToString());

                // Set next row to active
                SetColour(grid61, "a");
                SetColour(grid62, "a");
                SetColour(grid63, "a");
                SetColour(grid64, "a");
                SetColour(grid65, "a");
            }
            else
            {
                // Update grid text
                grid61.Text = guess[0].ToString();
                grid62.Text = guess[1].ToString();
                grid63.Text = guess[2].ToString();
                grid64.Text = guess[3].ToString();
                grid65.Text = guess[4].ToString();

                // Update grid colour
                SetColour(grid61, feedback[0].ToString());
                SetColour(grid62, feedback[1].ToString());
                SetColour(grid63, feedback[2].ToString());
                SetColour(grid64, feedback[3].ToString());
                SetColour(grid65, feedback[4].ToString());
            }
        }

        private string CycleColour(Color feedback)
        {
            // Grey to yellow
            if (feedback == wGrey)
            {
                return("y");
            }

            // Yellow to green
            else if (feedback == wYellow)
            {
                return("g");
            }

            // Green to grey
            else
            {
                return("b");
            }
        }

        private void SetColour(Label l, string colour)
        {
            if (colour == "g")
            {
                l.BackColor = wGreen;
            }
            else if (colour == "y")
            {
                l.BackColor = wYellow;
            }
            else if (colour == "b")
            {
                l.BackColor = wGrey;
            }
            else
            {
                l.BackColor = wActive;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && waitingFeedback == true)
            {
                EnterPress();
                e.SuppressKeyPress = true;
            }
        }

        private void enterGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter && waitingGuess == true) || (e.KeyCode == Keys.Enter && waitingFeedback == true))
            {
                EnterPress();
                e.SuppressKeyPress = true;
            }
        }

        private void resetButton_MouseEnter(object sender, EventArgs e)
        {
            resetButton.ForeColor = Color.White;
            resetButton.BackColor = wActive;
        }

        private void resetButton_MouseLeave(object sender, EventArgs e)
        {
            resetButton.ForeColor = Color.LightGray;
            resetButton.BackColor = wGrey;
        }

        private void resetButton_MouseDown(object sender, MouseEventArgs e)
        {
            RunSolver();
        }

        private void feedback1_MouseDown(object sender, MouseEventArgs e)
        {
            // Cycle through tile colours on click
            SetColour(feedback1, CycleColour(feedback1.BackColor));
        }

        private void feedback2_MouseDown(object sender, MouseEventArgs e)
        {
            // Cycle through tile colours on click
            SetColour(feedback2, CycleColour(feedback2.BackColor));
        }

        private void feedback3_MouseDown(object sender, MouseEventArgs e)
        {
            // Cycle through tile colours on click
            SetColour(feedback3, CycleColour(feedback3.BackColor));
        }

        private void feedback4_MouseDown(object sender, MouseEventArgs e)
        {
            // Cycle through tile colours on click
            SetColour(feedback4, CycleColour(feedback4.BackColor));
        }

        private void feedback5_MouseDown(object sender, MouseEventArgs e)
        {
            // Cycle through tile colours on click
            SetColour(feedback5, CycleColour(feedback5.BackColor));
        }

        private void enterButton_MouseEnter(object sender, EventArgs e)
        {
            enterButton.ForeColor = Color.White;
            enterButton.BackColor = wActive;
        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            enterButton.ForeColor = Color.LightGray;
            enterButton.BackColor = wGrey;
        }

        private void enterButton_MouseDown(object sender, MouseEventArgs e)
        {
            EnterPress();
        }

        private void quitButton_MouseEnter(object sender, EventArgs e)
        {
            quitButton.BackColor = Color.Brown;
        }

        private void quitButton_MouseLeave(object sender, EventArgs e)
        {
            quitButton.BackColor = wGrey;
        }

        private void minButton_MouseEnter(object sender, EventArgs e)
        {
            minButton.BackColor = Color.FromArgb(60, 60, 60);
        }

        private void minButton_MouseLeave(object sender, EventArgs e)
        {
            minButton.BackColor = wGrey;
        }

        // Required for window dragging
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            // Allows window to be dragged
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lockButton_MouseEnter_1(object sender, EventArgs e)
        {
            if (lockedForm == false)
            {
                lockButton.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void lockButton_MouseLeave_1(object sender, EventArgs e)
        {
            if (lockedForm == false)
            {
                lockButton.BackColor = wGrey;
            }
        }

        private void lockButton_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (lockedForm == false)
            {
                lockedForm = true;
                Form.ActiveForm.TopMost = true;
                lockButton.BackColor = Color.Brown;
            }
            else
            {
                lockedForm = false;
                Form.ActiveForm.TopMost = false;
                lockButton.BackColor = Color.FromArgb(60, 60, 60);
            }
        }
    }
}