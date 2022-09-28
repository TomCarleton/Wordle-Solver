namespace WordleSolve2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topPanel = new System.Windows.Forms.Panel();
            this.wordleSolve = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.failText = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Label();
            this.feedback5 = new System.Windows.Forms.Label();
            this.feedback4 = new System.Windows.Forms.Label();
            this.feedback1 = new System.Windows.Forms.Label();
            this.feedback2 = new System.Windows.Forms.Label();
            this.feedback3 = new System.Windows.Forms.Label();
            this.enterGuess = new System.Windows.Forms.TextBox();
            this.enterGuessTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wordsLeft = new System.Windows.Forms.Label();
            this.suggestedWords = new System.Windows.Forms.Label();
            this.suggestedWordsTitle = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.grid65 = new System.Windows.Forms.Label();
            this.grid64 = new System.Windows.Forms.Label();
            this.grid61 = new System.Windows.Forms.Label();
            this.grid62 = new System.Windows.Forms.Label();
            this.grid63 = new System.Windows.Forms.Label();
            this.grid55 = new System.Windows.Forms.Label();
            this.grid54 = new System.Windows.Forms.Label();
            this.grid51 = new System.Windows.Forms.Label();
            this.grid52 = new System.Windows.Forms.Label();
            this.grid53 = new System.Windows.Forms.Label();
            this.grid45 = new System.Windows.Forms.Label();
            this.grid44 = new System.Windows.Forms.Label();
            this.grid41 = new System.Windows.Forms.Label();
            this.grid42 = new System.Windows.Forms.Label();
            this.grid43 = new System.Windows.Forms.Label();
            this.grid35 = new System.Windows.Forms.Label();
            this.grid34 = new System.Windows.Forms.Label();
            this.grid31 = new System.Windows.Forms.Label();
            this.grid32 = new System.Windows.Forms.Label();
            this.grid33 = new System.Windows.Forms.Label();
            this.grid25 = new System.Windows.Forms.Label();
            this.grid24 = new System.Windows.Forms.Label();
            this.grid21 = new System.Windows.Forms.Label();
            this.grid22 = new System.Windows.Forms.Label();
            this.grid23 = new System.Windows.Forms.Label();
            this.grid15 = new System.Windows.Forms.Label();
            this.grid14 = new System.Windows.Forms.Label();
            this.grid11 = new System.Windows.Forms.Label();
            this.grid12 = new System.Windows.Forms.Label();
            this.grid13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lockButton = new System.Windows.Forms.PictureBox();
            this.minButton = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lockButton)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topPanel.Controls.Add(this.wordleSolve);
            this.topPanel.Location = new System.Drawing.Point(0, 28);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(500, 64);
            this.topPanel.TabIndex = 1;
            // 
            // wordleSolve
            // 
            this.wordleSolve.BackColor = System.Drawing.Color.Transparent;
            this.wordleSolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.wordleSolve.Font = new System.Drawing.Font("Segoe UI Light", 32F);
            this.wordleSolve.ForeColor = System.Drawing.Color.White;
            this.wordleSolve.Location = new System.Drawing.Point(0, 0);
            this.wordleSolve.Name = "wordleSolve";
            this.wordleSolve.Size = new System.Drawing.Size(500, 61);
            this.wordleSolve.TabIndex = 0;
            this.wordleSolve.Text = "WordleSolve";
            this.wordleSolve.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.failText);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.feedback5);
            this.panel1.Controls.Add(this.feedback4);
            this.panel1.Controls.Add(this.feedback1);
            this.panel1.Controls.Add(this.feedback2);
            this.panel1.Controls.Add(this.feedback3);
            this.panel1.Controls.Add(this.enterGuess);
            this.panel1.Controls.Add(this.enterGuessTitle);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 143);
            this.panel1.TabIndex = 2;
            // 
            // failText
            // 
            this.failText.BackColor = System.Drawing.Color.Transparent;
            this.failText.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.failText.ForeColor = System.Drawing.Color.IndianRed;
            this.failText.Location = new System.Drawing.Point(0, 31);
            this.failText.Name = "failText";
            this.failText.Size = new System.Drawing.Size(500, 44);
            this.failText.TabIndex = 4;
            this.failText.Text = "No guesses remaining.";
            this.failText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.failText.Visible = false;
            // 
            // enterButton
            // 
            this.enterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.enterButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12.5F);
            this.enterButton.ForeColor = System.Drawing.Color.LightGray;
            this.enterButton.Location = new System.Drawing.Point(265, 102);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(158, 28);
            this.enterButton.TabIndex = 9;
            this.enterButton.Text = "Enter";
            this.enterButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enterButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.enterButton_MouseDown);
            this.enterButton.MouseEnter += new System.EventHandler(this.enterButton_MouseEnter);
            this.enterButton.MouseLeave += new System.EventHandler(this.enterButton_MouseLeave);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.resetButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resetButton.Font = new System.Drawing.Font("Segoe UI Semilight", 12.5F);
            this.resetButton.ForeColor = System.Drawing.Color.LightGray;
            this.resetButton.Location = new System.Drawing.Point(73, 102);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(160, 28);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resetButton_MouseDown);
            this.resetButton.MouseEnter += new System.EventHandler(this.resetButton_MouseEnter);
            this.resetButton.MouseLeave += new System.EventHandler(this.resetButton_MouseLeave);
            // 
            // feedback5
            // 
            this.feedback5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feedback5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.feedback5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedback5.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.feedback5.ForeColor = System.Drawing.Color.White;
            this.feedback5.Location = new System.Drawing.Point(382, 34);
            this.feedback5.Name = "feedback5";
            this.feedback5.Size = new System.Drawing.Size(56, 56);
            this.feedback5.TabIndex = 8;
            this.feedback5.Text = "W";
            this.feedback5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.feedback5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedback5_MouseDown);
            // 
            // feedback4
            // 
            this.feedback4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feedback4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.feedback4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedback4.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.feedback4.ForeColor = System.Drawing.Color.White;
            this.feedback4.Location = new System.Drawing.Point(302, 34);
            this.feedback4.Name = "feedback4";
            this.feedback4.Size = new System.Drawing.Size(56, 56);
            this.feedback4.TabIndex = 7;
            this.feedback4.Text = "W";
            this.feedback4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.feedback4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedback4_MouseDown);
            // 
            // feedback1
            // 
            this.feedback1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feedback1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.feedback1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedback1.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.feedback1.ForeColor = System.Drawing.Color.White;
            this.feedback1.Location = new System.Drawing.Point(62, 34);
            this.feedback1.Name = "feedback1";
            this.feedback1.Size = new System.Drawing.Size(56, 56);
            this.feedback1.TabIndex = 6;
            this.feedback1.Text = "W";
            this.feedback1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.feedback1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedback1_MouseDown);
            // 
            // feedback2
            // 
            this.feedback2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feedback2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.feedback2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedback2.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.feedback2.ForeColor = System.Drawing.Color.White;
            this.feedback2.Location = new System.Drawing.Point(142, 34);
            this.feedback2.Name = "feedback2";
            this.feedback2.Size = new System.Drawing.Size(56, 56);
            this.feedback2.TabIndex = 5;
            this.feedback2.Text = "W";
            this.feedback2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.feedback2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedback2_MouseDown);
            // 
            // feedback3
            // 
            this.feedback3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.feedback3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.feedback3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedback3.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.feedback3.ForeColor = System.Drawing.Color.White;
            this.feedback3.Location = new System.Drawing.Point(222, 34);
            this.feedback3.Name = "feedback3";
            this.feedback3.Size = new System.Drawing.Size(56, 56);
            this.feedback3.TabIndex = 4;
            this.feedback3.Text = "W";
            this.feedback3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.feedback3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.feedback3_MouseDown);
            // 
            // enterGuess
            // 
            this.enterGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.enterGuess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enterGuess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.enterGuess.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterGuess.ForeColor = System.Drawing.Color.White;
            this.enterGuess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enterGuess.Location = new System.Drawing.Point(73, 37);
            this.enterGuess.MaxLength = 5;
            this.enterGuess.Name = "enterGuess";
            this.enterGuess.Size = new System.Drawing.Size(350, 50);
            this.enterGuess.TabIndex = 1;
            this.enterGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterGuess_KeyDown);
            // 
            // enterGuessTitle
            // 
            this.enterGuessTitle.BackColor = System.Drawing.Color.Transparent;
            this.enterGuessTitle.Font = new System.Drawing.Font("Segoe UI Light", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterGuessTitle.ForeColor = System.Drawing.Color.White;
            this.enterGuessTitle.Location = new System.Drawing.Point(0, 3);
            this.enterGuessTitle.Name = "enterGuessTitle";
            this.enterGuessTitle.Size = new System.Drawing.Size(500, 30);
            this.enterGuessTitle.TabIndex = 0;
            this.enterGuessTitle.Text = "Type your guess:";
            this.enterGuessTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Controls.Add(this.wordsLeft);
            this.panel2.Controls.Add(this.suggestedWords);
            this.panel2.Controls.Add(this.suggestedWordsTitle);
            this.panel2.Location = new System.Drawing.Point(0, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 101);
            this.panel2.TabIndex = 3;
            // 
            // wordsLeft
            // 
            this.wordsLeft.BackColor = System.Drawing.Color.Transparent;
            this.wordsLeft.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Italic);
            this.wordsLeft.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.wordsLeft.Location = new System.Drawing.Point(0, 76);
            this.wordsLeft.Name = "wordsLeft";
            this.wordsLeft.Size = new System.Drawing.Size(500, 19);
            this.wordsLeft.TabIndex = 3;
            this.wordsLeft.Text = "5758 words remaining";
            this.wordsLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // suggestedWords
            // 
            this.suggestedWords.BackColor = System.Drawing.Color.Transparent;
            this.suggestedWords.Font = new System.Drawing.Font("Segoe UI Light", 24F);
            this.suggestedWords.ForeColor = System.Drawing.Color.Gainsboro;
            this.suggestedWords.Location = new System.Drawing.Point(0, 28);
            this.suggestedWords.Name = "suggestedWords";
            this.suggestedWords.Size = new System.Drawing.Size(500, 44);
            this.suggestedWords.TabIndex = 2;
            this.suggestedWords.Text = "words, words, words, words, words";
            this.suggestedWords.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // suggestedWordsTitle
            // 
            this.suggestedWordsTitle.BackColor = System.Drawing.Color.Transparent;
            this.suggestedWordsTitle.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.suggestedWordsTitle.ForeColor = System.Drawing.Color.White;
            this.suggestedWordsTitle.Location = new System.Drawing.Point(0, 4);
            this.suggestedWordsTitle.Name = "suggestedWordsTitle";
            this.suggestedWordsTitle.Size = new System.Drawing.Size(500, 30);
            this.suggestedWordsTitle.TabIndex = 1;
            this.suggestedWordsTitle.Text = "Suggested guesses:";
            this.suggestedWordsTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.grid65);
            this.gamePanel.Controls.Add(this.grid64);
            this.gamePanel.Controls.Add(this.grid61);
            this.gamePanel.Controls.Add(this.grid62);
            this.gamePanel.Controls.Add(this.grid63);
            this.gamePanel.Controls.Add(this.grid55);
            this.gamePanel.Controls.Add(this.grid54);
            this.gamePanel.Controls.Add(this.grid51);
            this.gamePanel.Controls.Add(this.grid52);
            this.gamePanel.Controls.Add(this.grid53);
            this.gamePanel.Controls.Add(this.grid45);
            this.gamePanel.Controls.Add(this.grid44);
            this.gamePanel.Controls.Add(this.grid41);
            this.gamePanel.Controls.Add(this.grid42);
            this.gamePanel.Controls.Add(this.grid43);
            this.gamePanel.Controls.Add(this.grid35);
            this.gamePanel.Controls.Add(this.grid34);
            this.gamePanel.Controls.Add(this.grid31);
            this.gamePanel.Controls.Add(this.grid32);
            this.gamePanel.Controls.Add(this.grid33);
            this.gamePanel.Controls.Add(this.grid25);
            this.gamePanel.Controls.Add(this.grid24);
            this.gamePanel.Controls.Add(this.grid21);
            this.gamePanel.Controls.Add(this.grid22);
            this.gamePanel.Controls.Add(this.grid23);
            this.gamePanel.Controls.Add(this.grid15);
            this.gamePanel.Controls.Add(this.grid14);
            this.gamePanel.Controls.Add(this.grid11);
            this.gamePanel.Controls.Add(this.grid12);
            this.gamePanel.Controls.Add(this.grid13);
            this.gamePanel.Location = new System.Drawing.Point(0, 332);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(500, 468);
            this.gamePanel.TabIndex = 39;
            // 
            // grid65
            // 
            this.grid65.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid65.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid65.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid65.ForeColor = System.Drawing.Color.White;
            this.grid65.Location = new System.Drawing.Point(356, 377);
            this.grid65.Name = "grid65";
            this.grid65.Size = new System.Drawing.Size(56, 56);
            this.grid65.TabIndex = 68;
            this.grid65.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid64
            // 
            this.grid64.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid64.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid64.ForeColor = System.Drawing.Color.White;
            this.grid64.Location = new System.Drawing.Point(289, 377);
            this.grid64.Name = "grid64";
            this.grid64.Size = new System.Drawing.Size(56, 56);
            this.grid64.TabIndex = 67;
            this.grid64.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid61
            // 
            this.grid61.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid61.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid61.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid61.ForeColor = System.Drawing.Color.White;
            this.grid61.Location = new System.Drawing.Point(88, 377);
            this.grid61.Name = "grid61";
            this.grid61.Size = new System.Drawing.Size(56, 56);
            this.grid61.TabIndex = 66;
            this.grid61.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid62
            // 
            this.grid62.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid62.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid62.ForeColor = System.Drawing.Color.White;
            this.grid62.Location = new System.Drawing.Point(155, 377);
            this.grid62.Name = "grid62";
            this.grid62.Size = new System.Drawing.Size(56, 56);
            this.grid62.TabIndex = 65;
            this.grid62.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid63
            // 
            this.grid63.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid63.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid63.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid63.ForeColor = System.Drawing.Color.White;
            this.grid63.Location = new System.Drawing.Point(222, 377);
            this.grid63.Name = "grid63";
            this.grid63.Size = new System.Drawing.Size(56, 56);
            this.grid63.TabIndex = 64;
            this.grid63.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid55
            // 
            this.grid55.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid55.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid55.ForeColor = System.Drawing.Color.White;
            this.grid55.Location = new System.Drawing.Point(356, 310);
            this.grid55.Name = "grid55";
            this.grid55.Size = new System.Drawing.Size(56, 56);
            this.grid55.TabIndex = 63;
            this.grid55.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid54
            // 
            this.grid54.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid54.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid54.ForeColor = System.Drawing.Color.White;
            this.grid54.Location = new System.Drawing.Point(289, 310);
            this.grid54.Name = "grid54";
            this.grid54.Size = new System.Drawing.Size(56, 56);
            this.grid54.TabIndex = 62;
            this.grid54.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid51
            // 
            this.grid51.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid51.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid51.ForeColor = System.Drawing.Color.White;
            this.grid51.Location = new System.Drawing.Point(88, 310);
            this.grid51.Name = "grid51";
            this.grid51.Size = new System.Drawing.Size(56, 56);
            this.grid51.TabIndex = 61;
            this.grid51.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid52
            // 
            this.grid52.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid52.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid52.ForeColor = System.Drawing.Color.White;
            this.grid52.Location = new System.Drawing.Point(155, 310);
            this.grid52.Name = "grid52";
            this.grid52.Size = new System.Drawing.Size(56, 56);
            this.grid52.TabIndex = 60;
            this.grid52.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid53
            // 
            this.grid53.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid53.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid53.ForeColor = System.Drawing.Color.White;
            this.grid53.Location = new System.Drawing.Point(222, 310);
            this.grid53.Name = "grid53";
            this.grid53.Size = new System.Drawing.Size(56, 56);
            this.grid53.TabIndex = 59;
            this.grid53.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid45
            // 
            this.grid45.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid45.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid45.ForeColor = System.Drawing.Color.White;
            this.grid45.Location = new System.Drawing.Point(356, 243);
            this.grid45.Name = "grid45";
            this.grid45.Size = new System.Drawing.Size(56, 56);
            this.grid45.TabIndex = 58;
            this.grid45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid44
            // 
            this.grid44.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid44.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid44.ForeColor = System.Drawing.Color.White;
            this.grid44.Location = new System.Drawing.Point(289, 243);
            this.grid44.Name = "grid44";
            this.grid44.Size = new System.Drawing.Size(56, 56);
            this.grid44.TabIndex = 57;
            this.grid44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid41
            // 
            this.grid41.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid41.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid41.ForeColor = System.Drawing.Color.White;
            this.grid41.Location = new System.Drawing.Point(88, 243);
            this.grid41.Name = "grid41";
            this.grid41.Size = new System.Drawing.Size(56, 56);
            this.grid41.TabIndex = 56;
            this.grid41.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid42
            // 
            this.grid42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid42.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid42.ForeColor = System.Drawing.Color.White;
            this.grid42.Location = new System.Drawing.Point(155, 243);
            this.grid42.Name = "grid42";
            this.grid42.Size = new System.Drawing.Size(56, 56);
            this.grid42.TabIndex = 55;
            this.grid42.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid43
            // 
            this.grid43.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid43.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid43.ForeColor = System.Drawing.Color.White;
            this.grid43.Location = new System.Drawing.Point(222, 243);
            this.grid43.Name = "grid43";
            this.grid43.Size = new System.Drawing.Size(56, 56);
            this.grid43.TabIndex = 54;
            this.grid43.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid35
            // 
            this.grid35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid35.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid35.ForeColor = System.Drawing.Color.White;
            this.grid35.Location = new System.Drawing.Point(356, 176);
            this.grid35.Name = "grid35";
            this.grid35.Size = new System.Drawing.Size(56, 56);
            this.grid35.TabIndex = 53;
            this.grid35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid34
            // 
            this.grid34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid34.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid34.ForeColor = System.Drawing.Color.White;
            this.grid34.Location = new System.Drawing.Point(289, 176);
            this.grid34.Name = "grid34";
            this.grid34.Size = new System.Drawing.Size(56, 56);
            this.grid34.TabIndex = 52;
            this.grid34.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid31
            // 
            this.grid31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid31.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid31.ForeColor = System.Drawing.Color.White;
            this.grid31.Location = new System.Drawing.Point(88, 176);
            this.grid31.Name = "grid31";
            this.grid31.Size = new System.Drawing.Size(56, 56);
            this.grid31.TabIndex = 51;
            this.grid31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid32
            // 
            this.grid32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid32.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid32.ForeColor = System.Drawing.Color.White;
            this.grid32.Location = new System.Drawing.Point(155, 176);
            this.grid32.Name = "grid32";
            this.grid32.Size = new System.Drawing.Size(56, 56);
            this.grid32.TabIndex = 50;
            this.grid32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid33
            // 
            this.grid33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid33.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid33.ForeColor = System.Drawing.Color.White;
            this.grid33.Location = new System.Drawing.Point(222, 176);
            this.grid33.Name = "grid33";
            this.grid33.Size = new System.Drawing.Size(56, 56);
            this.grid33.TabIndex = 49;
            this.grid33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid25
            // 
            this.grid25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid25.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid25.ForeColor = System.Drawing.Color.White;
            this.grid25.Location = new System.Drawing.Point(356, 109);
            this.grid25.Name = "grid25";
            this.grid25.Size = new System.Drawing.Size(56, 56);
            this.grid25.TabIndex = 48;
            this.grid25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid24
            // 
            this.grid24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid24.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid24.ForeColor = System.Drawing.Color.White;
            this.grid24.Location = new System.Drawing.Point(289, 109);
            this.grid24.Name = "grid24";
            this.grid24.Size = new System.Drawing.Size(56, 56);
            this.grid24.TabIndex = 47;
            this.grid24.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid21
            // 
            this.grid21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid21.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid21.ForeColor = System.Drawing.Color.White;
            this.grid21.Location = new System.Drawing.Point(88, 109);
            this.grid21.Name = "grid21";
            this.grid21.Size = new System.Drawing.Size(56, 56);
            this.grid21.TabIndex = 46;
            this.grid21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid22
            // 
            this.grid22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid22.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid22.ForeColor = System.Drawing.Color.White;
            this.grid22.Location = new System.Drawing.Point(155, 109);
            this.grid22.Name = "grid22";
            this.grid22.Size = new System.Drawing.Size(56, 56);
            this.grid22.TabIndex = 45;
            this.grid22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid23
            // 
            this.grid23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.grid23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid23.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid23.ForeColor = System.Drawing.Color.White;
            this.grid23.Location = new System.Drawing.Point(222, 109);
            this.grid23.Name = "grid23";
            this.grid23.Size = new System.Drawing.Size(56, 56);
            this.grid23.TabIndex = 44;
            this.grid23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid15
            // 
            this.grid15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grid15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid15.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid15.ForeColor = System.Drawing.Color.White;
            this.grid15.Location = new System.Drawing.Point(356, 42);
            this.grid15.Name = "grid15";
            this.grid15.Size = new System.Drawing.Size(56, 56);
            this.grid15.TabIndex = 43;
            this.grid15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid14
            // 
            this.grid14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grid14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid14.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid14.ForeColor = System.Drawing.Color.White;
            this.grid14.Location = new System.Drawing.Point(289, 42);
            this.grid14.Name = "grid14";
            this.grid14.Size = new System.Drawing.Size(56, 56);
            this.grid14.TabIndex = 42;
            this.grid14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid11
            // 
            this.grid11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grid11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid11.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid11.ForeColor = System.Drawing.Color.White;
            this.grid11.Location = new System.Drawing.Point(88, 42);
            this.grid11.Name = "grid11";
            this.grid11.Size = new System.Drawing.Size(56, 56);
            this.grid11.TabIndex = 41;
            this.grid11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid12
            // 
            this.grid12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grid12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid12.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid12.ForeColor = System.Drawing.Color.White;
            this.grid12.Location = new System.Drawing.Point(155, 42);
            this.grid12.Name = "grid12";
            this.grid12.Size = new System.Drawing.Size(56, 56);
            this.grid12.TabIndex = 40;
            this.grid12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grid13
            // 
            this.grid13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grid13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.grid13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid13.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.grid13.ForeColor = System.Drawing.Color.White;
            this.grid13.Location = new System.Drawing.Point(222, 42);
            this.grid13.Name = "grid13";
            this.grid13.Size = new System.Drawing.Size(56, 56);
            this.grid13.TabIndex = 39;
            this.grid13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel3.Controls.Add(this.lockButton);
            this.panel3.Controls.Add(this.minButton);
            this.panel3.Controls.Add(this.quitButton);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 28);
            this.panel3.TabIndex = 40;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // lockButton
            // 
            this.lockButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.lockButton.Image = global::WordleSolve2.Properties.Resources.Lock;
            this.lockButton.Location = new System.Drawing.Point(0, 0);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(50, 28);
            this.lockButton.TabIndex = 69;
            this.lockButton.TabStop = false;
            this.lockButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lockButton_MouseClick_1);
            this.lockButton.MouseEnter += new System.EventHandler(this.lockButton_MouseEnter_1);
            this.lockButton.MouseLeave += new System.EventHandler(this.lockButton_MouseLeave_1);
            // 
            // minButton
            // 
            this.minButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minButton.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.Color.White;
            this.minButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minButton.Location = new System.Drawing.Point(400, 0);
            this.minButton.Margin = new System.Windows.Forms.Padding(0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(50, 28);
            this.minButton.TabIndex = 1;
            this.minButton.Text = "-";
            this.minButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            this.minButton.MouseEnter += new System.EventHandler(this.minButton_MouseEnter);
            this.minButton.MouseLeave += new System.EventHandler(this.minButton_MouseLeave);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.quitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.quitButton.Font = new System.Drawing.Font("Lucida Console", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.quitButton.Location = new System.Drawing.Point(450, 0);
            this.quitButton.Margin = new System.Windows.Forms.Padding(0);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(50, 28);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "X";
            this.quitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseEnter += new System.EventHandler(this.quitButton_MouseEnter);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Wordle Solve";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gamePanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lockButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label wordleSolve;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox enterGuess;
        private System.Windows.Forms.Label enterGuessTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label wordsLeft;
        private System.Windows.Forms.Label suggestedWords;
        private System.Windows.Forms.Label suggestedWordsTitle;
        private System.Windows.Forms.Label feedback5;
        private System.Windows.Forms.Label feedback4;
        private System.Windows.Forms.Label feedback1;
        private System.Windows.Forms.Label feedback2;
        private System.Windows.Forms.Label feedback3;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label grid65;
        private System.Windows.Forms.Label grid64;
        private System.Windows.Forms.Label grid61;
        private System.Windows.Forms.Label grid62;
        private System.Windows.Forms.Label grid63;
        private System.Windows.Forms.Label grid55;
        private System.Windows.Forms.Label grid54;
        private System.Windows.Forms.Label grid51;
        private System.Windows.Forms.Label grid52;
        private System.Windows.Forms.Label grid53;
        private System.Windows.Forms.Label grid45;
        private System.Windows.Forms.Label grid44;
        private System.Windows.Forms.Label grid41;
        private System.Windows.Forms.Label grid42;
        private System.Windows.Forms.Label grid43;
        private System.Windows.Forms.Label grid35;
        private System.Windows.Forms.Label grid34;
        private System.Windows.Forms.Label grid31;
        private System.Windows.Forms.Label grid32;
        private System.Windows.Forms.Label grid33;
        private System.Windows.Forms.Label grid25;
        private System.Windows.Forms.Label grid24;
        private System.Windows.Forms.Label grid21;
        private System.Windows.Forms.Label grid22;
        private System.Windows.Forms.Label grid23;
        private System.Windows.Forms.Label grid15;
        private System.Windows.Forms.Label grid14;
        private System.Windows.Forms.Label grid11;
        private System.Windows.Forms.Label grid12;
        private System.Windows.Forms.Label grid13;
        private System.Windows.Forms.Label resetButton;
        private System.Windows.Forms.Label enterButton;
        private System.Windows.Forms.Label failText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label quitButton;
        private System.Windows.Forms.Label minButton;
        private System.Windows.Forms.PictureBox lockButton;
    }
}

