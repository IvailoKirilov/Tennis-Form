namespace Tennis_Score_App
{
    partial class TennisAppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TennisScoreLabel = new Label();
            RankingLabel = new Label();
            LatestGamesLabel = new Label();
            RankingListView = new ListView();
            PlayerName = new ColumnHeader();
            Game = new ColumnHeader();
            NewGameButton = new Button();
            label1 = new Label();
            LatestGamesListVie = new ListView();
            FirstPlayer = new ColumnHeader();
            SecondPlayer = new ColumnHeader();
            Winner = new ColumnHeader();
            Score = new ColumnHeader();
            SuspendLayout();
            // 
            // TennisScoreLabel
            // 
            TennisScoreLabel.Anchor = AnchorStyles.Top;
            TennisScoreLabel.AutoSize = true;
            TennisScoreLabel.Font = new Font("Segoe UI", 35F);
            TennisScoreLabel.Location = new Point(227, 9);
            TennisScoreLabel.Name = "TennisScoreLabel";
            TennisScoreLabel.Size = new Size(355, 78);
            TennisScoreLabel.TabIndex = 0;
            TennisScoreLabel.Text = "Tennis Score";
            TennisScoreLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // RankingLabel
            // 
            RankingLabel.Anchor = AnchorStyles.Top;
            RankingLabel.AutoSize = true;
            RankingLabel.Font = new Font("Segoe UI", 13F);
            RankingLabel.Location = new Point(59, 82);
            RankingLabel.Name = "RankingLabel";
            RankingLabel.Size = new Size(90, 30);
            RankingLabel.TabIndex = 1;
            RankingLabel.Text = "Ranking";
            // 
            // LatestGamesLabel
            // 
            LatestGamesLabel.Anchor = AnchorStyles.Top;
            LatestGamesLabel.AutoSize = true;
            LatestGamesLabel.Font = new Font("Segoe UI", 13F);
            LatestGamesLabel.Location = new Point(59, 268);
            LatestGamesLabel.Name = "LatestGamesLabel";
            LatestGamesLabel.Size = new Size(141, 30);
            LatestGamesLabel.TabIndex = 2;
            LatestGamesLabel.Text = "Latest Games";
            // 
            // RankingListView
            // 
            RankingListView.Anchor = AnchorStyles.Top;
            RankingListView.Columns.AddRange(new ColumnHeader[] { PlayerName, Game });
            RankingListView.Location = new Point(59, 115);
            RankingListView.Name = "RankingListView";
            RankingListView.Size = new Size(669, 121);
            RankingListView.TabIndex = 3;
            RankingListView.UseCompatibleStateImageBehavior = false;
            RankingListView.View = View.Details;
            RankingListView.SelectedIndexChanged += RankingListView_SelectedIndexChanged;
            RankingListView.Click += ViewProfileButtonClick;
            // 
            // PlayerName
            // 
            PlayerName.Text = "Player Name";
            PlayerName.Width = 125;
            // 
            // Game
            // 
            Game.Text = "Score";
            Game.Width = 85;
            // 
            // NewGameButton
            // 
            NewGameButton.Anchor = AnchorStyles.Top;
            NewGameButton.Location = new Point(590, 239);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(138, 29);
            NewGameButton.TabIndex = 4;
            NewGameButton.Text = "Add New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(59, 239);
            label1.Name = "label1";
            label1.Size = new Size(378, 15);
            label1.TabIndex = 5;
            label1.Text = "*click on a player's name to see more information about their matches";
            // 
            // LatestGamesListVie
            // 
            LatestGamesListVie.Anchor = AnchorStyles.Top;
            LatestGamesListVie.Columns.AddRange(new ColumnHeader[] { FirstPlayer, SecondPlayer, Winner, Score });
            LatestGamesListVie.Location = new Point(59, 301);
            LatestGamesListVie.Name = "LatestGamesListVie";
            LatestGamesListVie.Size = new Size(669, 121);
            LatestGamesListVie.TabIndex = 6;
            LatestGamesListVie.UseCompatibleStateImageBehavior = false;
            LatestGamesListVie.View = View.Details;
            LatestGamesListVie.SelectedIndexChanged += LatestGamesListVie_SelectedIndexChanged;
            LatestGamesListVie.Click += ViewProfileButtonClick;
            // 
            // FirstPlayer
            // 
            FirstPlayer.Text = "First Player";
            FirstPlayer.Width = 125;
            // 
            // SecondPlayer
            // 
            SecondPlayer.Text = "Second Player";
            SecondPlayer.Width = 150;
            // 
            // Winner
            // 
            Winner.Text = "Winner";
            Winner.Width = 85;
            // 
            // Score
            // 
            Score.Text = "Score";
            Score.Width = 75;
            // 
            // TennisAppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LatestGamesListVie);
            Controls.Add(label1);
            Controls.Add(NewGameButton);
            Controls.Add(RankingListView);
            Controls.Add(LatestGamesLabel);
            Controls.Add(RankingLabel);
            Controls.Add(TennisScoreLabel);
            Name = "TennisAppForm";
            Text = "Score Form";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TennisScoreLabel;
        private Label RankingLabel;
        private Label LatestGamesLabel;
        private ListView RankingListView;
        private ColumnHeader PlayerName;
        private ColumnHeader Game;
        private Button NewGameButton;
        private Label label1;
        private ListView LatestGamesListVie;
        private ColumnHeader FirstPlayer;
        private ColumnHeader SecondPlayer;
        private ColumnHeader Winner;
        private ColumnHeader Score;
    }
}
