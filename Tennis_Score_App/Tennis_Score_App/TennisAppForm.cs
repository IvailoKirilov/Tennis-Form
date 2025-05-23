namespace Tennis_Score_App
{
    public partial class TennisAppForm : Form
    {
        private static Dictionary<string, int> playersWithPoints = new();
        private static Dictionary<(string, int), List<(string, int)>> games = new();

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }

        private void FillRankingListView()
        {   
            this.RankingListView.Items.Clear();
            foreach (var player in playersWithPoints.OrderByDescending(x => x.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();
                ListViewItem rollInRankingListView = new ListViewItem(player.Key);
                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);
                this.RankingListView.Items.Add(rollInRankingListView);
            }
        }

        private void FillLatestGamesListView()
        {
            this.LatestGamesListVie.Items.Clear();

            foreach (var game in games)
            {
                foreach (var item in game.Value)
                {
                    FillListView(game.Key, item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem item = new ListViewItem(firstPlayer.Item1);
            item.SubItems.Add(secondPlayer.Item1);
            item.SubItems.Add(winner);
            item.SubItems.Add($"{firstPlayer.Item2} - {secondPlayer.Item2}");

            LatestGamesListVie.Items.Add(item);
        }

        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            return firstPlayer.Item2 > secondPlayer.Item2 ? firstPlayer.Item1 : secondPlayer.Item1;
        }

        public TennisAppForm()
        {
            InitializeComponent();
            FillRankingListView();
        }

        private void RankingListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LatestGamesListVie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }

        }

        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);
            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);
            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (!games.ContainsKey(firstPlayer))
            {
                games[firstPlayer] = new List<(string, int)>();
            }
            games[firstPlayer].Add(secondPlayer);
        }

        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints[player.Item1] = player.Item2;
            }
        }



        private void ViewProfileButtonClick(object sender, EventArgs e)
        {
            if (this.RankingListView.SelectedItems.Count == 0)
                return;

            var selectedRow = this.RankingListView.SelectedItems[0];
            string playerName = selectedRow.SubItems[0].Text;

            using var playerInfoForm = new PlayerInfoForm(playerName, games);
            playerInfoForm.ShowDialog();
        }

        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName) => games.Where(x => x.Key.Item1 == playerName|| x.Value.Any(y => y.Item1 == playerName)).ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName || x.Key.Item1 == playerName).ToList());

    }
}