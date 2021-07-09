namespace JeopardyFinal
{
    partial class JeopardyInterface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JeopardyInterface));
            this.splashPanel = new System.Windows.Forms.Panel();
            this.gameTitleLbl = new System.Windows.Forms.Label();
            this.jeopardyIconSplashImgBx = new System.Windows.Forms.PictureBox();
            this.creatorImgBx = new System.Windows.Forms.PictureBox();
            this.creatorInfoLbl = new System.Windows.Forms.Label();
            this.copyRightLbl = new System.Windows.Forms.Label();
            this.splashScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.jeopardyIconImgBx = new System.Windows.Forms.PictureBox();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.resultsBtn = new System.Windows.Forms.Button();
            this.jeopardyIconMainMenuImgBx = new System.Windows.Forms.PictureBox();
            this.winnerDisplayLbl = new System.Windows.Forms.Label();
            this.playBtn = new System.Windows.Forms.Button();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.namePlayersPanel = new System.Windows.Forms.Panel();
            this.confirmPlayerNamesBtn = new System.Windows.Forms.Button();
            this.instructLbl = new System.Windows.Forms.Label();
            this.optionsPlayerAmtPanel = new System.Windows.Forms.Panel();
            this.playerAmtSelectedBtn = new System.Windows.Forms.Button();
            this.playerAmtSelectLbl = new System.Windows.Forms.Label();
            this.playerNumSelector = new System.Windows.Forms.NumericUpDown();
            this.BackOptionsBtn = new System.Windows.Forms.Button();
            this.playerInfoDisplayPanel = new System.Windows.Forms.Panel();
            this.gameBoardPanel = new System.Windows.Forms.Panel();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.gameBoardTable = new System.Windows.Forms.TableLayoutPanel();
            this.questionAnswerPanel = new System.Windows.Forms.Panel();
            this.valueLbl = new System.Windows.Forms.Label();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.answerWrongBtn = new System.Windows.Forms.Button();
            this.answerRightBtn = new System.Windows.Forms.Button();
            this.playersGivenAnswerLbl = new System.Windows.Forms.Label();
            this.answerRevealLbl = new System.Windows.Forms.Label();
            this.playerAnsweringLbl = new System.Windows.Forms.Label();
            this.answerBxLbl = new System.Windows.Forms.Label();
            this.playerAnsweringUpDownBx = new System.Windows.Forms.NumericUpDown();
            this.answerConfirmBtn = new System.Windows.Forms.Button();
            this.answerTxtBx = new System.Windows.Forms.TextBox();
            this.questionAskLbl = new System.Windows.Forms.Label();
            this.resultsPanel = new System.Windows.Forms.Panel();
            this.previousGameInfoPanel = new System.Windows.Forms.Panel();
            this.previousGamesLstBx = new System.Windows.Forms.ListBox();
            this.resultsBackBtn = new System.Windows.Forms.Button();
            this.stealBtn = new System.Windows.Forms.Button();
            this.noStealBtn = new System.Windows.Forms.Button();
            this.cantAnswerLbl = new System.Windows.Forms.Label();
            this.splashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jeopardyIconSplashImgBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorImgBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeopardyIconImgBx)).BeginInit();
            this.mainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jeopardyIconMainMenuImgBx)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.optionsPlayerAmtPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumSelector)).BeginInit();
            this.gameBoardPanel.SuspendLayout();
            this.questionAnswerPanel.SuspendLayout();
            this.answerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAnsweringUpDownBx)).BeginInit();
            this.resultsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashPanel
            // 
            this.splashPanel.Controls.Add(this.gameTitleLbl);
            this.splashPanel.Controls.Add(this.jeopardyIconSplashImgBx);
            this.splashPanel.Controls.Add(this.creatorImgBx);
            this.splashPanel.Controls.Add(this.creatorInfoLbl);
            this.splashPanel.Controls.Add(this.copyRightLbl);
            this.splashPanel.Location = new System.Drawing.Point(1831, 471);
            this.splashPanel.Name = "splashPanel";
            this.splashPanel.Size = new System.Drawing.Size(916, 530);
            this.splashPanel.TabIndex = 0;
            // 
            // gameTitleLbl
            // 
            this.gameTitleLbl.AutoSize = true;
            this.gameTitleLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameTitleLbl.Location = new System.Drawing.Point(59, 37);
            this.gameTitleLbl.Name = "gameTitleLbl";
            this.gameTitleLbl.Size = new System.Drawing.Size(184, 39);
            this.gameTitleLbl.TabIndex = 4;
            this.gameTitleLbl.Text = "Final Project:";
            // 
            // jeopardyIconSplashImgBx
            // 
            this.jeopardyIconSplashImgBx.Image = global::JeopardyFinal.Properties.Resources.JeopardyLogopng;
            this.jeopardyIconSplashImgBx.Location = new System.Drawing.Point(900, 25);
            this.jeopardyIconSplashImgBx.Name = "jeopardyIconSplashImgBx";
            this.jeopardyIconSplashImgBx.Size = new System.Drawing.Size(484, 192);
            this.jeopardyIconSplashImgBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jeopardyIconSplashImgBx.TabIndex = 2;
            this.jeopardyIconSplashImgBx.TabStop = false;
            // 
            // creatorImgBx
            // 
            this.creatorImgBx.Image = global::JeopardyFinal.Properties.Resources.Isaac1;
            this.creatorImgBx.Location = new System.Drawing.Point(66, 800);
            this.creatorImgBx.Name = "creatorImgBx";
            this.creatorImgBx.Size = new System.Drawing.Size(264, 228);
            this.creatorImgBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.creatorImgBx.TabIndex = 3;
            this.creatorImgBx.TabStop = false;
            // 
            // creatorInfoLbl
            // 
            this.creatorInfoLbl.AutoSize = true;
            this.creatorInfoLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorInfoLbl.Location = new System.Drawing.Point(374, 267);
            this.creatorInfoLbl.Name = "creatorInfoLbl";
            this.creatorInfoLbl.Size = new System.Drawing.Size(302, 39);
            this.creatorInfoLbl.TabIndex = 1;
            this.creatorInfoLbl.Text = "Created by Isaac Kirk!";
            // 
            // copyRightLbl
            // 
            this.copyRightLbl.AutoSize = true;
            this.copyRightLbl.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyRightLbl.Location = new System.Drawing.Point(649, 496);
            this.copyRightLbl.Name = "copyRightLbl";
            this.copyRightLbl.Size = new System.Drawing.Size(254, 26);
            this.copyRightLbl.TabIndex = 0;
            this.copyRightLbl.Text = "Copyright 2020 © Isaac Kirk";
            // 
            // splashScreenTimer
            // 
            this.splashScreenTimer.Enabled = true;
            this.splashScreenTimer.Interval = 10;
            this.splashScreenTimer.Tick += new System.EventHandler(this.splashScreenTimer_Tick);
            // 
            // jeopardyIconImgBx
            // 
            this.jeopardyIconImgBx.Image = global::JeopardyFinal.Properties.Resources.JeopardyLogopng;
            this.jeopardyIconImgBx.Location = new System.Drawing.Point(12, 1);
            this.jeopardyIconImgBx.Name = "jeopardyIconImgBx";
            this.jeopardyIconImgBx.Size = new System.Drawing.Size(178, 87);
            this.jeopardyIconImgBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jeopardyIconImgBx.TabIndex = 5;
            this.jeopardyIconImgBx.TabStop = false;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.resultsBtn);
            this.mainMenuPanel.Controls.Add(this.jeopardyIconMainMenuImgBx);
            this.mainMenuPanel.Controls.Add(this.winnerDisplayLbl);
            this.mainMenuPanel.Controls.Add(this.playBtn);
            this.mainMenuPanel.Controls.Add(this.optionsBtn);
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 85);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(916, 446);
            this.mainMenuPanel.TabIndex = 6;
            this.mainMenuPanel.Visible = false;
            // 
            // resultsBtn
            // 
            this.resultsBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.resultsBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultsBtn.Location = new System.Drawing.Point(96, 352);
            this.resultsBtn.Name = "resultsBtn";
            this.resultsBtn.Size = new System.Drawing.Size(240, 60);
            this.resultsBtn.TabIndex = 12;
            this.resultsBtn.Text = "Results";
            this.resultsBtn.UseVisualStyleBackColor = false;
            this.resultsBtn.Click += new System.EventHandler(this.resultsBtn_Click);
            // 
            // jeopardyIconMainMenuImgBx
            // 
            this.jeopardyIconMainMenuImgBx.Image = global::JeopardyFinal.Properties.Resources.JeopardyLogopng;
            this.jeopardyIconMainMenuImgBx.Location = new System.Drawing.Point(394, 21);
            this.jeopardyIconMainMenuImgBx.Name = "jeopardyIconMainMenuImgBx";
            this.jeopardyIconMainMenuImgBx.Size = new System.Drawing.Size(491, 215);
            this.jeopardyIconMainMenuImgBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jeopardyIconMainMenuImgBx.TabIndex = 9;
            this.jeopardyIconMainMenuImgBx.TabStop = false;
            // 
            // winnerDisplayLbl
            // 
            this.winnerDisplayLbl.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerDisplayLbl.Location = new System.Drawing.Point(4, 30);
            this.winnerDisplayLbl.Name = "winnerDisplayLbl";
            this.winnerDisplayLbl.Size = new System.Drawing.Size(351, 228);
            this.winnerDisplayLbl.TabIndex = 11;
            this.winnerDisplayLbl.Text = "A fun friendly game for all ages! Just make sure you pick the right answers to al" +
    "so be the coolest!";
            // 
            // playBtn
            // 
            this.playBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.playBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playBtn.Location = new System.Drawing.Point(515, 261);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(240, 60);
            this.playBtn.TabIndex = 3;
            this.playBtn.Text = "Play!";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // optionsBtn
            // 
            this.optionsBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.optionsBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optionsBtn.Location = new System.Drawing.Point(515, 355);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(240, 57);
            this.optionsBtn.TabIndex = 2;
            this.optionsBtn.Text = "Options + Info";
            this.optionsBtn.UseVisualStyleBackColor = false;
            this.optionsBtn.Click += new System.EventHandler(this.optionsBtn_Click);
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.namePlayersPanel);
            this.optionsPanel.Controls.Add(this.confirmPlayerNamesBtn);
            this.optionsPanel.Controls.Add(this.instructLbl);
            this.optionsPanel.Controls.Add(this.optionsPlayerAmtPanel);
            this.optionsPanel.Controls.Add(this.BackOptionsBtn);
            this.optionsPanel.Location = new System.Drawing.Point(945, 1);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(916, 446);
            this.optionsPanel.TabIndex = 7;
            this.optionsPanel.Visible = false;
            // 
            // namePlayersPanel
            // 
            this.namePlayersPanel.Location = new System.Drawing.Point(33, 68);
            this.namePlayersPanel.Name = "namePlayersPanel";
            this.namePlayersPanel.Size = new System.Drawing.Size(834, 263);
            this.namePlayersPanel.TabIndex = 9;
            this.namePlayersPanel.Visible = false;
            // 
            // confirmPlayerNamesBtn
            // 
            this.confirmPlayerNamesBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.confirmPlayerNamesBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPlayerNamesBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.confirmPlayerNamesBtn.Location = new System.Drawing.Point(709, 365);
            this.confirmPlayerNamesBtn.Name = "confirmPlayerNamesBtn";
            this.confirmPlayerNamesBtn.Size = new System.Drawing.Size(124, 56);
            this.confirmPlayerNamesBtn.TabIndex = 10;
            this.confirmPlayerNamesBtn.Text = "Done!";
            this.confirmPlayerNamesBtn.UseVisualStyleBackColor = false;
            this.confirmPlayerNamesBtn.Visible = false;
            this.confirmPlayerNamesBtn.Click += new System.EventHandler(this.confirmPlayerNamesBtn_Click);
            // 
            // instructLbl
            // 
            this.instructLbl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLbl.Location = new System.Drawing.Point(27, 33);
            this.instructLbl.Name = "instructLbl";
            this.instructLbl.Size = new System.Drawing.Size(484, 322);
            this.instructLbl.TabIndex = 8;
            this.instructLbl.Text = resources.GetString("instructLbl.Text");
            // 
            // optionsPlayerAmtPanel
            // 
            this.optionsPlayerAmtPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.optionsPlayerAmtPanel.Controls.Add(this.playerAmtSelectedBtn);
            this.optionsPlayerAmtPanel.Controls.Add(this.playerAmtSelectLbl);
            this.optionsPlayerAmtPanel.Controls.Add(this.playerNumSelector);
            this.optionsPlayerAmtPanel.Location = new System.Drawing.Point(616, 33);
            this.optionsPlayerAmtPanel.Name = "optionsPlayerAmtPanel";
            this.optionsPlayerAmtPanel.Size = new System.Drawing.Size(246, 231);
            this.optionsPlayerAmtPanel.TabIndex = 6;
            // 
            // playerAmtSelectedBtn
            // 
            this.playerAmtSelectedBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.playerAmtSelectedBtn.Font = new System.Drawing.Font("Calibri", 20F);
            this.playerAmtSelectedBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.playerAmtSelectedBtn.Location = new System.Drawing.Point(38, 165);
            this.playerAmtSelectedBtn.Name = "playerAmtSelectedBtn";
            this.playerAmtSelectedBtn.Size = new System.Drawing.Size(162, 44);
            this.playerAmtSelectedBtn.TabIndex = 7;
            this.playerAmtSelectedBtn.Text = "This Many!";
            this.playerAmtSelectedBtn.UseVisualStyleBackColor = false;
            this.playerAmtSelectedBtn.Click += new System.EventHandler(this.playerAmtSelectedBtn_Click);
            // 
            // playerAmtSelectLbl
            // 
            this.playerAmtSelectLbl.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAmtSelectLbl.Location = new System.Drawing.Point(7, 22);
            this.playerAmtSelectLbl.Name = "playerAmtSelectLbl";
            this.playerAmtSelectLbl.Size = new System.Drawing.Size(236, 85);
            this.playerAmtSelectLbl.TabIndex = 5;
            this.playerAmtSelectLbl.Text = "Select the amount of players you want!";
            // 
            // playerNumSelector
            // 
            this.playerNumSelector.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNumSelector.Location = new System.Drawing.Point(51, 110);
            this.playerNumSelector.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.playerNumSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerNumSelector.Name = "playerNumSelector";
            this.playerNumSelector.Size = new System.Drawing.Size(135, 33);
            this.playerNumSelector.TabIndex = 0;
            this.playerNumSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BackOptionsBtn
            // 
            this.BackOptionsBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackOptionsBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackOptionsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BackOptionsBtn.Location = new System.Drawing.Point(33, 358);
            this.BackOptionsBtn.Name = "BackOptionsBtn";
            this.BackOptionsBtn.Size = new System.Drawing.Size(197, 63);
            this.BackOptionsBtn.TabIndex = 1;
            this.BackOptionsBtn.Text = "Main Menu";
            this.BackOptionsBtn.UseVisualStyleBackColor = false;
            this.BackOptionsBtn.Click += new System.EventHandler(this.BackOptionsBtn_Click);
            // 
            // playerInfoDisplayPanel
            // 
            this.playerInfoDisplayPanel.Location = new System.Drawing.Point(199, 1);
            this.playerInfoDisplayPanel.Name = "playerInfoDisplayPanel";
            this.playerInfoDisplayPanel.Size = new System.Drawing.Size(717, 78);
            this.playerInfoDisplayPanel.TabIndex = 8;
            // 
            // gameBoardPanel
            // 
            this.gameBoardPanel.Controls.Add(this.QuitBtn);
            this.gameBoardPanel.Controls.Add(this.gameBoardTable);
            this.gameBoardPanel.Location = new System.Drawing.Point(0, 539);
            this.gameBoardPanel.Name = "gameBoardPanel";
            this.gameBoardPanel.Size = new System.Drawing.Size(916, 446);
            this.gameBoardPanel.TabIndex = 7;
            this.gameBoardPanel.Visible = false;
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.QuitBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.QuitBtn.Location = new System.Drawing.Point(756, 385);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(138, 58);
            this.QuitBtn.TabIndex = 12;
            this.QuitBtn.Text = "Quit";
            this.QuitBtn.UseVisualStyleBackColor = false;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // gameBoardTable
            // 
            this.gameBoardTable.ColumnCount = 6;
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.gameBoardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.gameBoardTable.Location = new System.Drawing.Point(27, 20);
            this.gameBoardTable.Name = "gameBoardTable";
            this.gameBoardTable.RowCount = 6;
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.gameBoardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.gameBoardTable.Size = new System.Drawing.Size(867, 357);
            this.gameBoardTable.TabIndex = 5;
            // 
            // questionAnswerPanel
            // 
            this.questionAnswerPanel.Controls.Add(this.answerPanel);
            this.questionAnswerPanel.Controls.Add(this.playerAnsweringLbl);
            this.questionAnswerPanel.Controls.Add(this.answerBxLbl);
            this.questionAnswerPanel.Controls.Add(this.playerAnsweringUpDownBx);
            this.questionAnswerPanel.Controls.Add(this.answerConfirmBtn);
            this.questionAnswerPanel.Controls.Add(this.answerTxtBx);
            this.questionAnswerPanel.Controls.Add(this.questionAskLbl);
            this.questionAnswerPanel.Controls.Add(this.cantAnswerLbl);
            this.questionAnswerPanel.Controls.Add(this.valueLbl);
            this.questionAnswerPanel.Location = new System.Drawing.Point(931, 539);
            this.questionAnswerPanel.Name = "questionAnswerPanel";
            this.questionAnswerPanel.Size = new System.Drawing.Size(916, 446);
            this.questionAnswerPanel.TabIndex = 8;
            this.questionAnswerPanel.Visible = false;
            // 
            // valueLbl
            // 
            this.valueLbl.AutoSize = true;
            this.valueLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLbl.Location = new System.Drawing.Point(623, 20);
            this.valueLbl.Name = "valueLbl";
            this.valueLbl.Size = new System.Drawing.Size(102, 39);
            this.valueLbl.TabIndex = 13;
            this.valueLbl.Text = "Value: ";
            // 
            // answerPanel
            // 
            this.answerPanel.Controls.Add(this.noStealBtn);
            this.answerPanel.Controls.Add(this.stealBtn);
            this.answerPanel.Controls.Add(this.answerWrongBtn);
            this.answerPanel.Controls.Add(this.answerRightBtn);
            this.answerPanel.Controls.Add(this.playersGivenAnswerLbl);
            this.answerPanel.Controls.Add(this.answerRevealLbl);
            this.answerPanel.Location = new System.Drawing.Point(27, 20);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(867, 404);
            this.answerPanel.TabIndex = 10;
            this.answerPanel.Visible = false;
            // 
            // answerWrongBtn
            // 
            this.answerWrongBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.answerWrongBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerWrongBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answerWrongBtn.Location = new System.Drawing.Point(458, 320);
            this.answerWrongBtn.Name = "answerWrongBtn";
            this.answerWrongBtn.Size = new System.Drawing.Size(240, 57);
            this.answerWrongBtn.TabIndex = 12;
            this.answerWrongBtn.Text = "Was Wrong";
            this.answerWrongBtn.UseVisualStyleBackColor = false;
            this.answerWrongBtn.Click += new System.EventHandler(this.answerWrongBtn_Click);
            // 
            // answerRightBtn
            // 
            this.answerRightBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.answerRightBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRightBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answerRightBtn.Location = new System.Drawing.Point(135, 320);
            this.answerRightBtn.Name = "answerRightBtn";
            this.answerRightBtn.Size = new System.Drawing.Size(240, 57);
            this.answerRightBtn.TabIndex = 4;
            this.answerRightBtn.Text = "Was Correct!";
            this.answerRightBtn.UseVisualStyleBackColor = false;
            this.answerRightBtn.Click += new System.EventHandler(this.answerRightBtn_Click);
            // 
            // playersGivenAnswerLbl
            // 
            this.playersGivenAnswerLbl.AutoSize = true;
            this.playersGivenAnswerLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersGivenAnswerLbl.Location = new System.Drawing.Point(45, 163);
            this.playersGivenAnswerLbl.Name = "playersGivenAnswerLbl";
            this.playersGivenAnswerLbl.Size = new System.Drawing.Size(368, 39);
            this.playersGivenAnswerLbl.TabIndex = 11;
            this.playersGivenAnswerLbl.Text = "Player BLANKS answer was:";
            // 
            // answerRevealLbl
            // 
            this.answerRevealLbl.AutoSize = true;
            this.answerRevealLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerRevealLbl.Location = new System.Drawing.Point(45, 46);
            this.answerRevealLbl.Name = "answerRevealLbl";
            this.answerRevealLbl.Size = new System.Drawing.Size(236, 39);
            this.answerRevealLbl.TabIndex = 11;
            this.answerRevealLbl.Text = "The Answer Was:";
            // 
            // playerAnsweringLbl
            // 
            this.playerAnsweringLbl.AutoSize = true;
            this.playerAnsweringLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAnsweringLbl.Location = new System.Drawing.Point(516, 220);
            this.playerAnsweringLbl.Name = "playerAnsweringLbl";
            this.playerAnsweringLbl.Size = new System.Drawing.Size(378, 39);
            this.playerAnsweringLbl.TabIndex = 9;
            this.playerAnsweringLbl.Text = "Answering Player\'s Number:";
            // 
            // answerBxLbl
            // 
            this.answerBxLbl.AutoSize = true;
            this.answerBxLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBxLbl.Location = new System.Drawing.Point(25, 220);
            this.answerBxLbl.Name = "answerBxLbl";
            this.answerBxLbl.Size = new System.Drawing.Size(119, 39);
            this.answerBxLbl.TabIndex = 8;
            this.answerBxLbl.Text = "Answer:";
            // 
            // playerAnsweringUpDownBx
            // 
            this.playerAnsweringUpDownBx.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAnsweringUpDownBx.Location = new System.Drawing.Point(524, 278);
            this.playerAnsweringUpDownBx.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerAnsweringUpDownBx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerAnsweringUpDownBx.Name = "playerAnsweringUpDownBx";
            this.playerAnsweringUpDownBx.Size = new System.Drawing.Size(188, 33);
            this.playerAnsweringUpDownBx.TabIndex = 7;
            this.playerAnsweringUpDownBx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // answerConfirmBtn
            // 
            this.answerConfirmBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.answerConfirmBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerConfirmBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.answerConfirmBtn.Location = new System.Drawing.Point(363, 363);
            this.answerConfirmBtn.Name = "answerConfirmBtn";
            this.answerConfirmBtn.Size = new System.Drawing.Size(147, 49);
            this.answerConfirmBtn.TabIndex = 6;
            this.answerConfirmBtn.Text = "Answer!";
            this.answerConfirmBtn.UseVisualStyleBackColor = false;
            this.answerConfirmBtn.Click += new System.EventHandler(this.answerConfirmBtn_Click);
            // 
            // answerTxtBx
            // 
            this.answerTxtBx.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTxtBx.Location = new System.Drawing.Point(32, 277);
            this.answerTxtBx.Name = "answerTxtBx";
            this.answerTxtBx.Size = new System.Drawing.Size(251, 33);
            this.answerTxtBx.TabIndex = 6;
            // 
            // questionAskLbl
            // 
            this.questionAskLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionAskLbl.Location = new System.Drawing.Point(25, 20);
            this.questionAskLbl.Name = "questionAskLbl";
            this.questionAskLbl.Size = new System.Drawing.Size(566, 155);
            this.questionAskLbl.TabIndex = 5;
            this.questionAskLbl.Text = "Question:";
            // 
            // resultsPanel
            // 
            this.resultsPanel.Controls.Add(this.previousGameInfoPanel);
            this.resultsPanel.Controls.Add(this.previousGamesLstBx);
            this.resultsPanel.Controls.Add(this.resultsBackBtn);
            this.resultsPanel.Location = new System.Drawing.Point(12, 536);
            this.resultsPanel.Name = "resultsPanel";
            this.resultsPanel.Size = new System.Drawing.Size(916, 446);
            this.resultsPanel.TabIndex = 13;
            this.resultsPanel.Visible = false;
            // 
            // previousGameInfoPanel
            // 
            this.previousGameInfoPanel.Location = new System.Drawing.Point(503, 23);
            this.previousGameInfoPanel.Name = "previousGameInfoPanel";
            this.previousGameInfoPanel.Size = new System.Drawing.Size(370, 407);
            this.previousGameInfoPanel.TabIndex = 14;
            // 
            // previousGamesLstBx
            // 
            this.previousGamesLstBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousGamesLstBx.FormattingEnabled = true;
            this.previousGamesLstBx.ItemHeight = 20;
            this.previousGamesLstBx.Location = new System.Drawing.Point(44, 23);
            this.previousGamesLstBx.Name = "previousGamesLstBx";
            this.previousGamesLstBx.Size = new System.Drawing.Size(409, 304);
            this.previousGamesLstBx.TabIndex = 13;
            this.previousGamesLstBx.SelectedIndexChanged += new System.EventHandler(this.previousGamesLstBx_SelectedIndexChanged);
            // 
            // resultsBackBtn
            // 
            this.resultsBackBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.resultsBackBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsBackBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resultsBackBtn.Location = new System.Drawing.Point(44, 377);
            this.resultsBackBtn.Name = "resultsBackBtn";
            this.resultsBackBtn.Size = new System.Drawing.Size(138, 58);
            this.resultsBackBtn.TabIndex = 12;
            this.resultsBackBtn.Text = "Back";
            this.resultsBackBtn.UseVisualStyleBackColor = false;
            this.resultsBackBtn.Click += new System.EventHandler(this.resultsBackBtn_Click);
            // 
            // stealBtn
            // 
            this.stealBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.stealBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stealBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stealBtn.Location = new System.Drawing.Point(135, 320);
            this.stealBtn.Name = "stealBtn";
            this.stealBtn.Size = new System.Drawing.Size(240, 57);
            this.stealBtn.TabIndex = 13;
            this.stealBtn.Text = "Steal";
            this.stealBtn.UseVisualStyleBackColor = false;
            this.stealBtn.Visible = false;
            this.stealBtn.Click += new System.EventHandler(this.stealBtn_Click);
            // 
            // noStealBtn
            // 
            this.noStealBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.noStealBtn.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noStealBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.noStealBtn.Location = new System.Drawing.Point(458, 320);
            this.noStealBtn.Name = "noStealBtn";
            this.noStealBtn.Size = new System.Drawing.Size(240, 57);
            this.noStealBtn.TabIndex = 14;
            this.noStealBtn.Text = "No Steal";
            this.noStealBtn.UseVisualStyleBackColor = false;
            this.noStealBtn.Visible = false;
            this.noStealBtn.Click += new System.EventHandler(this.noStealBtn_Click);
            // 
            // cantAnswerLbl
            // 
            this.cantAnswerLbl.AutoSize = true;
            this.cantAnswerLbl.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantAnswerLbl.Location = new System.Drawing.Point(517, 324);
            this.cantAnswerLbl.Name = "cantAnswerLbl";
            this.cantAnswerLbl.Size = new System.Drawing.Size(345, 39);
            this.cantAnswerLbl.TabIndex = 14;
            this.cantAnswerLbl.Text = "Player Already Attempted";
            this.cantAnswerLbl.Visible = false;
            // 
            // JeopardyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(915, 530);
            this.Controls.Add(this.resultsPanel);
            this.Controls.Add(this.splashPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Controls.Add(this.questionAnswerPanel);
            this.Controls.Add(this.gameBoardPanel);
            this.Controls.Add(this.playerInfoDisplayPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.jeopardyIconImgBx);
            this.Name = "JeopardyInterface";
            this.Text = "Jeopardy";
            this.Load += new System.EventHandler(this.JeopardyInterface_Load);
            this.splashPanel.ResumeLayout(false);
            this.splashPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jeopardyIconSplashImgBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creatorImgBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jeopardyIconImgBx)).EndInit();
            this.mainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jeopardyIconMainMenuImgBx)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.optionsPlayerAmtPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playerNumSelector)).EndInit();
            this.gameBoardPanel.ResumeLayout(false);
            this.questionAnswerPanel.ResumeLayout(false);
            this.questionAnswerPanel.PerformLayout();
            this.answerPanel.ResumeLayout(false);
            this.answerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerAnsweringUpDownBx)).EndInit();
            this.resultsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel splashPanel;
        private System.Windows.Forms.Label copyRightLbl;
        private System.Windows.Forms.PictureBox jeopardyIconSplashImgBx;
        private System.Windows.Forms.Label creatorInfoLbl;
        private System.Windows.Forms.PictureBox creatorImgBx;
        private System.Windows.Forms.Label gameTitleLbl;
        private System.Windows.Forms.Timer splashScreenTimer;
        private System.Windows.Forms.PictureBox jeopardyIconImgBx;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel optionsPanel;
        private System.Windows.Forms.Button BackOptionsBtn;
        private System.Windows.Forms.NumericUpDown playerNumSelector;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Label playerAmtSelectLbl;
        private System.Windows.Forms.Label instructLbl;
        private System.Windows.Forms.Panel optionsPlayerAmtPanel;
        private System.Windows.Forms.Button playerAmtSelectedBtn;
        private System.Windows.Forms.Panel namePlayersPanel;
        private System.Windows.Forms.Button confirmPlayerNamesBtn;
        private System.Windows.Forms.Panel playerInfoDisplayPanel;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Panel gameBoardPanel;
        private System.Windows.Forms.TableLayoutPanel gameBoardTable;
        private System.Windows.Forms.Panel questionAnswerPanel;
        private System.Windows.Forms.Label questionAskLbl;
        private System.Windows.Forms.Label playerAnsweringLbl;
        private System.Windows.Forms.Label answerBxLbl;
        private System.Windows.Forms.NumericUpDown playerAnsweringUpDownBx;
        private System.Windows.Forms.Button answerConfirmBtn;
        private System.Windows.Forms.TextBox answerTxtBx;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.Button answerRightBtn;
        private System.Windows.Forms.Label playersGivenAnswerLbl;
        private System.Windows.Forms.Label answerRevealLbl;
        private System.Windows.Forms.PictureBox jeopardyIconMainMenuImgBx;
        private System.Windows.Forms.Label winnerDisplayLbl;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button answerWrongBtn;
        private System.Windows.Forms.Label valueLbl;
        private System.Windows.Forms.Panel resultsPanel;
        private System.Windows.Forms.ListBox previousGamesLstBx;
        private System.Windows.Forms.Button resultsBackBtn;
        private System.Windows.Forms.Button resultsBtn;
        private System.Windows.Forms.Panel previousGameInfoPanel;
        private System.Windows.Forms.Button noStealBtn;
        private System.Windows.Forms.Button stealBtn;
        private System.Windows.Forms.Label cantAnswerLbl;
    }
}

