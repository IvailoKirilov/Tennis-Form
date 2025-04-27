using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_Score_App
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }

        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UpdatePlayers();

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }


        private void UpdatePlayers()
        {
            FirstPlayer = (FirstPlayerTextBox.Text.Trim(), (int)FirstPlayerNumericUpDown.Value);
            SecondPlayer = (SecondPlayerTextBox.Text.Trim(), (int)SecondPlayerNumericUpDown.Value);
        }


        private bool CheckIfInputsAreValid() => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreEmpty() => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);

        private bool CheckIfPlayerNamesAreSame() => this.FirstPlayer.Item1 == this.SecondPlayer.Item1;

        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            UpdatePlayers();

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessage(textBox);
                ShowErrorOnSameNames();
            }
        }


        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if (textBox == this.FirstPlayerTextBox)
            {
                this.firstPlaterNameErrorProvider.SetError(textBox, errorText);
                this.labelErrorMessageFirstNameTextBox.Text = "First " + errorText;
            }
            else if (textBox == this.SecondPlayerTextBox)
            {
                this.secondPlaterNameErrorProvider.SetError(textBox, errorText);
                this.labelErrorMessageSecondNameTextBox.Text = "Second " + errorText;
            }
        }

        private void RemoveErrorMessage(TextBox textBox)
        {
            if (textBox == this.FirstPlayerTextBox)
            {
                this.firstPlaterNameErrorProvider.SetError(textBox, "");
                this.labelErrorMessageFirstNameTextBox.Text = string.Empty;
            }
            else if (textBox == this.SecondPlayerTextBox)
            {
                this.secondPlaterNameErrorProvider.SetError(textBox, "");
                this.labelErrorMessageSecondNameTextBox.Text = string.Empty;
            }
        }

        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                this.labelSameNamesErrorMessage.Text = "First Player name should not be same as Second Player name!";
            }
            else
            {
                this.labelSameNamesErrorMessage.Text = string.Empty;
            }
        }
    }
}







