namespace Tennis_Score_App
{
    partial class NewGameForm
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
            components = new System.ComponentModel.Container();
            NewGameLabel = new Label();
            FirstPlayerLabel = new Label();
            SecondPlayerLabel = new Label();
            PointsLabel1 = new Label();
            PointsLabel2 = new Label();
            FirstPlayerTextBox = new TextBox();
            SecondPlayerTextBox = new TextBox();
            FirstPlayerNumericUpDown = new NumericUpDown();
            SecondPlayerNumericUpDown = new NumericUpDown();
            SaveButton = new Button();
            VsLabel = new Label();
            labelErrorMessageFirstNameTextBox = new Label();
            labelErrorMessageSecondNameTextBox = new Label();
            firstPlaterNameErrorProvider = new ErrorProvider(components);
            secondPlaterNameErrorProvider = new ErrorProvider(components);
            labelSameNamesErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)FirstPlayerNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondPlayerNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstPlaterNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondPlaterNameErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // NewGameLabel
            // 
            NewGameLabel.Anchor = AnchorStyles.Top;
            NewGameLabel.AutoSize = true;
            NewGameLabel.Font = new Font("Segoe UI", 35F);
            NewGameLabel.Location = new Point(246, 9);
            NewGameLabel.Name = "NewGameLabel";
            NewGameLabel.Size = new Size(319, 78);
            NewGameLabel.TabIndex = 0;
            NewGameLabel.Text = "New Game";
            // 
            // FirstPlayerLabel
            // 
            FirstPlayerLabel.Anchor = AnchorStyles.Top;
            FirstPlayerLabel.AutoSize = true;
            FirstPlayerLabel.Font = new Font("Segoe UI", 13F);
            FirstPlayerLabel.Location = new Point(92, 148);
            FirstPlayerLabel.Name = "FirstPlayerLabel";
            FirstPlayerLabel.Size = new Size(118, 30);
            FirstPlayerLabel.TabIndex = 1;
            FirstPlayerLabel.Text = "First Player";
            // 
            // SecondPlayerLabel
            // 
            SecondPlayerLabel.Anchor = AnchorStyles.Top;
            SecondPlayerLabel.AutoSize = true;
            SecondPlayerLabel.Font = new Font("Segoe UI", 13F);
            SecondPlayerLabel.Location = new Point(501, 148);
            SecondPlayerLabel.Name = "SecondPlayerLabel";
            SecondPlayerLabel.Size = new Size(150, 30);
            SecondPlayerLabel.TabIndex = 2;
            SecondPlayerLabel.Text = "Second Player";
            // 
            // PointsLabel1
            // 
            PointsLabel1.Anchor = AnchorStyles.Top;
            PointsLabel1.AutoSize = true;
            PointsLabel1.Font = new Font("Segoe UI", 12F);
            PointsLabel1.Location = new Point(181, 284);
            PointsLabel1.Name = "PointsLabel1";
            PointsLabel1.Size = new Size(65, 28);
            PointsLabel1.TabIndex = 3;
            PointsLabel1.Text = "Points";
            // 
            // PointsLabel2
            // 
            PointsLabel2.Anchor = AnchorStyles.Top;
            PointsLabel2.AutoSize = true;
            PointsLabel2.Font = new Font("Segoe UI", 12F);
            PointsLabel2.Location = new Point(555, 284);
            PointsLabel2.Name = "PointsLabel2";
            PointsLabel2.Size = new Size(65, 28);
            PointsLabel2.TabIndex = 4;
            PointsLabel2.Text = "Points";
            // 
            // FirstPlayerTextBox
            // 
            FirstPlayerTextBox.Anchor = AnchorStyles.Top;
            FirstPlayerTextBox.Location = new Point(92, 197);
            FirstPlayerTextBox.Name = "FirstPlayerTextBox";
            FirstPlayerTextBox.Size = new Size(216, 27);
            FirstPlayerTextBox.TabIndex = 1;
            FirstPlayerTextBox.Validating += ValidatePlayerName;
            // 
            // SecondPlayerTextBox
            // 
            SecondPlayerTextBox.Anchor = AnchorStyles.Top;
            SecondPlayerTextBox.Location = new Point(501, 197);
            SecondPlayerTextBox.Name = "SecondPlayerTextBox";
            SecondPlayerTextBox.Size = new Size(216, 27);
            SecondPlayerTextBox.TabIndex = 2;
            SecondPlayerTextBox.Validating += ValidatePlayerName;
            // 
            // FirstPlayerNumericUpDown
            // 
            FirstPlayerNumericUpDown.Anchor = AnchorStyles.Top;
            FirstPlayerNumericUpDown.Font = new Font("Segoe UI", 11F);
            FirstPlayerNumericUpDown.Location = new Point(191, 336);
            FirstPlayerNumericUpDown.Name = "FirstPlayerNumericUpDown";
            FirstPlayerNumericUpDown.Size = new Size(42, 32);
            FirstPlayerNumericUpDown.TabIndex = 3;
            // 
            // SecondPlayerNumericUpDown
            // 
            SecondPlayerNumericUpDown.Anchor = AnchorStyles.Top;
            SecondPlayerNumericUpDown.Font = new Font("Segoe UI", 11F);
            SecondPlayerNumericUpDown.Location = new Point(565, 336);
            SecondPlayerNumericUpDown.Name = "SecondPlayerNumericUpDown";
            SecondPlayerNumericUpDown.Size = new Size(42, 32);
            SecondPlayerNumericUpDown.TabIndex = 4;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Top;
            SaveButton.Font = new Font("Segoe UI", 15F);
            SaveButton.Location = new Point(345, 368);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(126, 46);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // VsLabel
            // 
            VsLabel.Anchor = AnchorStyles.Top;
            VsLabel.AutoSize = true;
            VsLabel.Font = new Font("Segoe UI", 20F);
            VsLabel.Location = new Point(377, 266);
            VsLabel.Name = "VsLabel";
            VsLabel.Size = new Size(59, 46);
            VsLabel.TabIndex = 6;
            VsLabel.Text = "VS";
            // 
            // labelErrorMessageFirstNameTextBox
            // 
            labelErrorMessageFirstNameTextBox.AutoSize = true;
            labelErrorMessageFirstNameTextBox.Location = new Point(160, 244);
            labelErrorMessageFirstNameTextBox.Name = "labelErrorMessageFirstNameTextBox";
            labelErrorMessageFirstNameTextBox.Size = new Size(0, 20);
            labelErrorMessageFirstNameTextBox.TabIndex = 7;
            // 
            // labelErrorMessageSecondNameTextBox
            // 
            labelErrorMessageSecondNameTextBox.AutoSize = true;
            labelErrorMessageSecondNameTextBox.Location = new Point(515, 244);
            labelErrorMessageSecondNameTextBox.Name = "labelErrorMessageSecondNameTextBox";
            labelErrorMessageSecondNameTextBox.Size = new Size(0, 20);
            labelErrorMessageSecondNameTextBox.TabIndex = 8;
            // 
            // firstPlaterNameErrorProvider
            // 
            firstPlaterNameErrorProvider.ContainerControl = this;
            // 
            // secondPlaterNameErrorProvider
            // 
            secondPlaterNameErrorProvider.ContainerControl = this;
            // 
            // labelSameNamesErrorMessage
            // 
            labelSameNamesErrorMessage.AutoSize = true;
            labelSameNamesErrorMessage.Location = new Point(391, 200);
            labelSameNamesErrorMessage.Name = "labelSameNamesErrorMessage";
            labelSameNamesErrorMessage.Size = new Size(0, 20);
            labelSameNamesErrorMessage.TabIndex = 9;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelSameNamesErrorMessage);
            Controls.Add(labelErrorMessageSecondNameTextBox);
            Controls.Add(labelErrorMessageFirstNameTextBox);
            Controls.Add(VsLabel);
            Controls.Add(SaveButton);
            Controls.Add(SecondPlayerNumericUpDown);
            Controls.Add(FirstPlayerNumericUpDown);
            Controls.Add(SecondPlayerTextBox);
            Controls.Add(FirstPlayerTextBox);
            Controls.Add(PointsLabel2);
            Controls.Add(PointsLabel1);
            Controls.Add(SecondPlayerLabel);
            Controls.Add(FirstPlayerLabel);
            Controls.Add(NewGameLabel);
            Name = "NewGameForm";
            Text = "NewGameForm";
            ((System.ComponentModel.ISupportInitialize)FirstPlayerNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondPlayerNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstPlaterNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondPlaterNameErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NewGameLabel;
        private Label FirstPlayerLabel;
        private Label SecondPlayerLabel;
        private Label PointsLabel1;
        private Label PointsLabel2;
        private TextBox FirstPlayerTextBox;
        private TextBox SecondPlayerTextBox;
        private NumericUpDown FirstPlayerNumericUpDown;
        private NumericUpDown SecondPlayerNumericUpDown;
        private Button SaveButton;
        private Label VsLabel;
        private Label labelErrorMessageFirstNameTextBox;
        private Label labelErrorMessageSecondNameTextBox;
        private ErrorProvider firstPlaterNameErrorProvider;
        private ErrorProvider secondPlaterNameErrorProvider;
        private Label labelSameNamesErrorMessage;
    }
}