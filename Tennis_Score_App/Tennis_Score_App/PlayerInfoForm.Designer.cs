namespace Tennis_Score_App
{
    partial class PlayerInfoForm
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
            PlayerNameLabel = new Label();
            VictoryLabel = new Label();
            LossLabel = new Label();
            DrawLabel = new Label();
            VictoryListView = new ListView();
            Competitor = new ColumnHeader();
            Score = new ColumnHeader();
            LossListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            DrawListView = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            PlayerNameLabel.Anchor = AnchorStyles.Top;
            PlayerNameLabel.AutoSize = true;
            PlayerNameLabel.Font = new Font("Segoe UI", 35F);
            PlayerNameLabel.Location = new Point(217, 9);
            PlayerNameLabel.Name = "PlayerNameLabel";
            PlayerNameLabel.Size = new Size(363, 78);
            PlayerNameLabel.TabIndex = 0;
            PlayerNameLabel.Text = "Player Name";
            // 
            // VictoryLabel
            // 
            VictoryLabel.Anchor = AnchorStyles.Top;
            VictoryLabel.AutoSize = true;
            VictoryLabel.Font = new Font("Segoe UI", 13F);
            VictoryLabel.Location = new Point(100, 153);
            VictoryLabel.Name = "VictoryLabel";
            VictoryLabel.Size = new Size(96, 30);
            VictoryLabel.TabIndex = 1;
            VictoryLabel.Text = "Victories";
            // 
            // LossLabel
            // 
            LossLabel.Anchor = AnchorStyles.Top;
            LossLabel.AutoSize = true;
            LossLabel.Font = new Font("Segoe UI", 13F);
            LossLabel.Location = new Point(367, 153);
            LossLabel.Name = "LossLabel";
            LossLabel.Size = new Size(75, 30);
            LossLabel.TabIndex = 2;
            LossLabel.Text = "Losses";
            // 
            // DrawLabel
            // 
            DrawLabel.Anchor = AnchorStyles.Top;
            DrawLabel.AutoSize = true;
            DrawLabel.Font = new Font("Segoe UI", 13F);
            DrawLabel.Location = new Point(634, 153);
            DrawLabel.Name = "DrawLabel";
            DrawLabel.Size = new Size(63, 30);
            DrawLabel.TabIndex = 3;
            DrawLabel.Text = "Draw";
            // 
            // VictoryListView
            // 
            VictoryListView.Anchor = AnchorStyles.Top;
            VictoryListView.Columns.AddRange(new ColumnHeader[] { Competitor, Score });
            VictoryListView.Location = new Point(12, 186);
            VictoryListView.Name = "VictoryListView";
            VictoryListView.Size = new Size(244, 228);
            VictoryListView.TabIndex = 4;
            VictoryListView.UseCompatibleStateImageBehavior = false;
            VictoryListView.View = View.Details;
            // 
            // Competitor
            // 
            Competitor.Text = "Competitor";
            // 
            // Score
            // 
            Score.Text = "Score";
            // 
            // LossListView
            // 
            LossListView.Anchor = AnchorStyles.Top;
            LossListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            LossListView.Location = new Point(277, 186);
            LossListView.Name = "LossListView";
            LossListView.Size = new Size(247, 228);
            LossListView.TabIndex = 5;
            LossListView.UseCompatibleStateImageBehavior = false;
            LossListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Competitor";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            // 
            // DrawListView
            // 
            DrawListView.Anchor = AnchorStyles.Top;
            DrawListView.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            DrawListView.Location = new Point(542, 186);
            DrawListView.Name = "DrawListView";
            DrawListView.Size = new Size(246, 228);
            DrawListView.TabIndex = 6;
            DrawListView.UseCompatibleStateImageBehavior = false;
            DrawListView.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Competitor";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Score";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DrawListView);
            Controls.Add(LossListView);
            Controls.Add(VictoryListView);
            Controls.Add(DrawLabel);
            Controls.Add(LossLabel);
            Controls.Add(VictoryLabel);
            Controls.Add(PlayerNameLabel);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerNameLabel;
        private Label VictoryLabel;
        private Label LossLabel;
        private Label DrawLabel;
        private ListView VictoryListView;
        private ColumnHeader Competitor;
        private ColumnHeader Score;
        private ListView LossListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView DrawListView;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}