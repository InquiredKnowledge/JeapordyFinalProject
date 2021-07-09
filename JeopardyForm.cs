using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using JeopardyFinal.DAL;
using System.Collections;
/// <summary>
/// Isaac Kirk
/// 12/10/2020
/// CIS-151-101
/// Final Hands On: Jeopardy
/// </summary>

namespace JeopardyFinal
{
    public partial class JeopardyInterface : Form
    {
        // Variables
        private int splashScreenCounter = 100;

        // General Info Held for Players and Game
        private TextBox[] generatedTxtBx;
        private Label[,] generatedPlayerUI;
        private Player[] currentPlayersInfo = new Player[1];
        private QuestionButton[] currentQuestionBtns;

        // Questions pulled from xml file and previous games from serialized info stored in database
        private List<QuestionInfo> jeopardyQuestions;
        private ArrayList gamesArrayLst;
        
        // Holds who already answered
        private List<int> cantAnswerAgainLst;

        //Holds current question info
        private string currentAnswer;
        private int currentValue;

        public JeopardyInterface()
        {
            InitializeComponent();
        }

        // Set up on load
        private void JeopardyInterface_Load(object sender, EventArgs e)
        {
            InsertPreviousGames();
            SetPanelLocations();
            currentPlayersInfo[0] = new Player("Player #1");
            CreatePlayerInfoUI();
            PossiblePlayerAnsweringLock();
            jeopardyQuestions = DataAdapter.LoadCategoriesXML();
        }

        /// <summary>
        /// Sets panel locations at start of form, IF YOU WANT TO SEE THEM, EXPAND THE FORM SIZE ON THE DESIGN TAB
        /// </summary>
        private void SetPanelLocations()
        {
            splashPanel.Location = new System.Drawing.Point(0, 0);
            mainMenuPanel.Location = new System.Drawing.Point(0, 85);
            optionsPanel.Location = new System.Drawing.Point(0, 85);
            gameBoardPanel.Location = new System.Drawing.Point(0, 85);
            questionAnswerPanel.Location = new System.Drawing.Point(0, 85);
            resultsPanel.Location = new System.Drawing.Point(0, 85);
        }

        /// <summary>
        /// Main Menu Buttons & Functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void optionsBtn_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            optionsPanel.Visible = true;
        }

        private void resultsBtn_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Visible = false;
            resultsPanel.Visible = true;
        }

        // Creates a brand new game board and reset player info
        private void playBtn_Click(object sender, EventArgs e)
        {
            SetPlayerScoreDefault();
            CreateGameBoard();
            mainMenuPanel.Visible = false;
            gameBoardPanel.Visible = true;
        }

        /// <summary>
        /// Option Menu Buttons & Functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackOptionsBtn_Click(object sender, EventArgs e)
        {
            optionsPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        //Set number of players and let users name the players
        private void playerAmtSelectedBtn_Click(object sender, EventArgs e)
        {
            BackOptionsBtn.Visible = false;
            optionsPlayerAmtPanel.Visible = false;

            // Creates size of current player array
            currentPlayersInfo = new Player[Convert.ToInt32(playerNumSelector.Value)];
            CreatePlayerNamesTxt(Convert.ToInt32(playerNumSelector.Value));

            // Reveals panel to name players
            instructLbl.Text = "Name your players!";
            confirmPlayerNamesBtn.Visible = true;
            namePlayersPanel.Visible = true;
        }

        // Sets the names of the players the users gave them and returns to the default answer panel
        private void confirmPlayerNamesBtn_Click(object sender, EventArgs e)
        {
            optionsPlayerAmtPanel.Visible = true;

            SubmitPlayerNames(Convert.ToInt32(playerNumSelector.Value));
            CreatePlayerInfoUI();
            PossiblePlayerAnsweringLock();

            instructLbl.Text = "Rules:                                                                         Player gets a specified amount of time to answer. If answer is incorrect, value is deducted from score. (Can go negative).  Game is over when all questions have been asked.";
            confirmPlayerNamesBtn.Visible = false;
            namePlayersPanel.Visible = false;
            BackOptionsBtn.Visible = true;
        }

        // Creates the text boxes that the users will use to name their players depending on the amount of players they selected
        private void CreatePlayerNamesTxt(int value)
        {
            int pointX = 50;
            int pointY = 60;
            generatedTxtBx = new TextBox[value];
            namePlayersPanel.Controls.Clear();
            for (int i = 0; i < value; i++)
            {
                TextBox text = new TextBox();
                text.Location = new Point(pointX + 10, pointY);
                text.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                text.Name = $"playerName{i + 1}SelectTxt";

                Label label = new Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(pointX, pointY - 50);
                label.Name = $"playerName{i + 1}SelectLbl";
                label.Text = $"Player {i + 1} name";

                generatedTxtBx[i] = text;
                namePlayersPanel.Controls.Add(text);
                namePlayersPanel.Controls.Add(label);
                pointX += 200;
            }
        }

        // Creates new player class objects with new names from CreatePlayerNamesTxt method
        private void SubmitPlayerNames(int value)
        {
            for (int i = 0; i < value; i++)
            {
                currentPlayersInfo[i] = new Player(generatedTxtBx[i].Text);
            }
        }

        /// <summary>
        /// Player Display Panel Functionality
        /// </summary>
        //Creates new labels to display player info at the top, generated after user names their players.
        private void CreatePlayerInfoUI()
        {
            int pointX = 20;
            int pointY = 0;
            playerInfoDisplayPanel.Controls.Clear();
            generatedPlayerUI = new Label[currentPlayersInfo.Length, 3];

            for (int i = 0; i < currentPlayersInfo.Length; i++)
            {
                Label playerNumLbl = new Label();
                playerNumLbl.AutoSize = true;
                playerNumLbl.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                playerNumLbl.Location = new System.Drawing.Point(pointX, pointY);
                playerNumLbl.Name = $"playerNumber{i + 1}Lbl";
                playerNumLbl.Text = $"Player {i + 1}";

                Label playerNameLbl = new Label();
                playerNameLbl.AutoSize = true;
                playerNameLbl.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                playerNameLbl.Location = new System.Drawing.Point(pointX, pointY + 30);
                playerNameLbl.Name = $"playerNumber{i + 1}NameLbl";
                playerNameLbl.Text = $"{currentPlayersInfo[i].PlayerName}";

                Label playerScoreLbl = new Label();
                playerScoreLbl.AutoSize = true;
                playerScoreLbl.Font = new System.Drawing.Font("Impact", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                playerScoreLbl.Location = new System.Drawing.Point(pointX, pointY + 55);
                playerScoreLbl.Name = $"playerNumber{i + 1}ScoreLbl";
                playerScoreLbl.Text = $"${currentPlayersInfo[i].Score}";

                pointX += 200;
                generatedPlayerUI[i, 0] = playerNumLbl;
                generatedPlayerUI[i, 1] = playerNameLbl;
                generatedPlayerUI[i, 2] = playerScoreLbl;

                playerInfoDisplayPanel.Controls.Add(playerNumLbl);
                playerInfoDisplayPanel.Controls.Add(playerNameLbl);
                playerInfoDisplayPanel.Controls.Add(playerScoreLbl);
            }
        }

        // Reset the score of the player at start of new game.
        public void SetPlayerScoreDefault()
        {
            for (int i = 0; i < currentPlayersInfo.Length; i++)
            {
                currentPlayersInfo[i].Score = 0;
                generatedPlayerUI[i, 2].Text = $"${currentPlayersInfo[i].Score}";
            }
        }

        /// <summary>
        /// GameBoard Buttons & Functionality
        /// </summary>
        // Generates new question buttons and categories for the gameboardpanel at start of a new game
        private void CreateGameBoard()
        {
            currentQuestionBtns = new QuestionButton[30];
            gameBoardTable.Controls.Clear();
            int counter = 0;

            for (int i = 0; i < 6; i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Name = $"category{i + 1}Lbl";
                label.Text = $"{jeopardyQuestions[i*5].CategoryTitle}";

                gameBoardTable.Controls.Add(label);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    QuestionButton button = new QuestionButton();
                    button.Text = (200 * (i + 1)).ToString();
                    button.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button.Size = new System.Drawing.Size(300, 300);
                    button.questionInfo = jeopardyQuestions[i + (5 * j)];
                    button.Click += new EventHandler(questionButton_Clicked);

                    currentQuestionBtns[counter] = button;
                    gameBoardTable.Controls.Add(button);
                    counter++;
                }
            }
        }

        // Sends questionButton info to Q&A form and then disables itself since it has been clicked
        private void questionButton_Clicked(object sender, EventArgs e)
        {
            gameBoardPanel.Visible = false;
            QuestionButton questionButton = (QuestionButton) sender;
            questionAskLbl.Text = questionButton.questionInfo.Question;
            valueLbl.Text = $"Value: ${questionButton.questionInfo.Value}";
            currentAnswer = questionButton.questionInfo.Answer;
            currentValue = questionButton.questionInfo.Value;
            questionButton.Clicked = true;
            questionButton.Enabled = false;
            questionButton.Text = "Answered!";
            cantAnswerAgainLst = new List<int>();
            questionAnswerPanel.Visible = true;
        }

        // Lets you exit game early, score is not recorded in database
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            winnerDisplayLbl.Text = "A fun friendly game for all ages! Just make sure you pick the right answers to also be the coolest!";
            SetPlayerScoreDefault();
            gameBoardPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        /// <summary>
        /// Q&A Buttons & Functionality
        /// </summary>
        // Checks if all buttons have been clicked and displays a winner and enters data into database
        public void IsGameOver()
        {
            foreach (QuestionButton button in currentQuestionBtns)
            {
                if (button.Clicked == false)
                {
                    gameBoardPanel.Visible = true;
                    return;
                }
            }
            DisplayWinner();
            InsertNewGame();
            DataAdapter.InsertGameData(currentPlayersInfo);
            mainMenuPanel.Visible = true;
        }

        // Finds the player with the highest current score or say if there is a tie and display the results
        public void DisplayWinner() 
        {
            Player playerWinner = currentPlayersInfo[0];

            foreach(Player player in currentPlayersInfo)
            {
                if (player.Score > playerWinner.Score)
                {
                    playerWinner = player;
                }
            }

            foreach (Player player in currentPlayersInfo)
            {
                if (playerWinner.Score == player.Score && player != playerWinner)
                {
                    winnerDisplayLbl.Text = "There was a tie! That means the people with the tie wins! Perhaps play another round?";
                    return;
                }
            }

            winnerDisplayLbl.Text = $"The winner is {playerWinner.PlayerName}!";
        }

        // Sends player's input for the answer to answerPanel
        private void answerConfirmBtn_Click(object sender, EventArgs e)
        {
            // Stops player's input from going through if they already attempted
            foreach (int value in cantAnswerAgainLst)
            {
                if (value == Convert.ToInt32(playerAnsweringUpDownBx.Value))
                {
                    cantAnswerLbl.Visible = true;
                    return;
                }
            }
            cantAnswerLbl.Visible = false;
            answerRevealLbl.Text = $"The Answer Was: {currentAnswer}";
            playersGivenAnswerLbl.Text = $"{currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].PlayerName}'s Answer Was: {answerTxtBx.Text}";
            
            answerTxtBx.Text = "";
            answerPanel.Visible = true;
        }

        // Subtracts points from user who attempted to answer and got it wrong. If there is more then one player, allows for other players to steal.
        private void answerWrongBtn_Click(object sender, EventArgs e)
        {
            cantAnswerAgainLst.Add(Convert.ToInt32(playerAnsweringUpDownBx.Value));
            currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score -= currentValue;

            //Allows players to steal if there is more than one player and all 3 players havent attempted yet
            if (currentPlayersInfo.Length > 1 && cantAnswerAgainLst.Count < 3)
            {
                if (currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score < 0)
                {
                    generatedPlayerUI[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1), 2].Text = $"-${Math.Abs(currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score)}";
                }
                else
                {
                    generatedPlayerUI[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1), 2].Text = $"${currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score}";
                }

                stealBtn.Visible = true;
                noStealBtn.Visible = true;

            }
            else
            {
                AnswerTypePicked();
            }
        }

        // Allows different player to answer
        private void stealBtn_Click(object sender, EventArgs e)
        {
            answerTxtBx.Text = "";
            answerPanel.Visible = false;

            stealBtn.Visible = false;
            noStealBtn.Visible = false;
        }

        // Continues the game if no player wants to steal
        private void noStealBtn_Click(object sender, EventArgs e)
        {
            AnswerTypePicked();
        }

        // Increases the score of the player who answered the question and continues the game
        private void answerRightBtn_Click(object sender, EventArgs e)
        {
            currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score += currentValue;

            AnswerTypePicked();
        }

        // Updates the score visually then checks if all questions have been answered
        private void AnswerTypePicked()
        {
            if (currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score < 0)
            {
                generatedPlayerUI[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1), 2].Text = $"-${Math.Abs(currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score)}";
            }
            else
            {
                generatedPlayerUI[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1), 2].Text = $"${currentPlayersInfo[Convert.ToInt32(playerAnsweringUpDownBx.Value - 1)].Score}";
            }

            stealBtn.Visible = false;
            noStealBtn.Visible = false;

            answerPanel.Visible = false;
            questionAnswerPanel.Visible = false;

            IsGameOver();
        }
    

        // Locks the range of players you can pick when selecting the player who is answering the question
        public void PossiblePlayerAnsweringLock()
        {
            playerAnsweringUpDownBx.Maximum = currentPlayersInfo.Length;
        }

        /// <summary>
        /// Results Panel Functionality
        /// </summary>
        // Inserts previous completed games score into results form from database
        private void InsertPreviousGames()
        {
            gamesArrayLst = DataAdapter.GetAllGames();

            for (int i = 0; i < gamesArrayLst.Count; i++)
            {
                previousGamesLstBx.Items.Add($"Game {i + 1}");
            }           
        }
        
        // Inserts a game just completed into the results form
        private void InsertNewGame()
        {
            gamesArrayLst.Add(currentPlayersInfo);
            previousGamesLstBx.Items.Add($"Game {gamesArrayLst.Count}");
        }

        // Heads back to main menu from results form
        private void resultsBackBtn_Click(object sender, EventArgs e)
        {
            resultsPanel.Visible = false;
            mainMenuPanel.Visible = true;
        }

        // Displays the players in a game selected. Dynamically creates labels depending on how many players were in that stored game
        private void previousGamesLstBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player[] Game = (Player[]) gamesArrayLst[previousGamesLstBx.SelectedIndex];
            
            if (Game != null)
            {
                int pointX = 20;
                int pointY = 0;

                previousGameInfoPanel.Controls.Clear();
                for (int i = 0; i < Game.Length; i++)
                {

                    Label playerNameLbl = new Label();
                    playerNameLbl.AutoSize = true;
                    playerNameLbl.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    playerNameLbl.Location = new System.Drawing.Point(pointX, pointY);
                    playerNameLbl.Name = $"previousPlayer{i + 1}NameLbl";
                    playerNameLbl.Text = $"Player Name: {Game[i].PlayerName}";

                    Label playerScoreLbl = new Label();
                    playerScoreLbl.AutoSize = true;
                    playerScoreLbl.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    playerScoreLbl.Location = new System.Drawing.Point(pointX, pointY + 30);
                    playerScoreLbl.Name = $"player{i + 1}ScoreLbl";
                    playerScoreLbl.Text = $"Player's Score: {Game[i].Score}";

                    pointY += 80;

                    previousGameInfoPanel.Controls.Add(playerNameLbl);
                    previousGameInfoPanel.Controls.Add(playerScoreLbl);
                }
            }
        }
        /// <summary>
        /// Splash Screen eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // Splash Screen Animations and Timer
        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            if (jeopardyIconSplashImgBx.Location.X > 380)
            {
                jeopardyIconSplashImgBx.Location = new Point(jeopardyIconSplashImgBx.Location.X - 3, 25);
                creatorImgBx.Location = new Point(66, creatorImgBx.Location.Y - 3);
            }
            else if (splashScreenCounter > 0)
            {
                splashScreenCounter--;
            }
            else
            {
                splashPanel.Visible = false;
                mainMenuPanel.Visible = true;
                splashScreenTimer.Stop();
            }
        }
    }
}
