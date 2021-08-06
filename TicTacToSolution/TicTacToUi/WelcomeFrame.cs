using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToGameDll;

namespace TicTacToUi
{
    class WelcomeFrame : Form
    {
        private Label _label1;
        private TextBox _player1Name;
        private TextBox _player2Name;
        private Button _submitBtn;
        private Label _label3;
        private TextBox _noOfPlayers;
        private Label _label2;

        public WelcomeFrame()
        {
            InitializeComponent();
        }
        public void InitializeComponent()
        {
            this._label1 = new System.Windows.Forms.Label();
            this._label2 = new System.Windows.Forms.Label();
            this._player1Name = new System.Windows.Forms.TextBox();
            this._player2Name = new System.Windows.Forms.TextBox();
            this._submitBtn = new System.Windows.Forms.Button();
            this._label3 = new System.Windows.Forms.Label();
            this._noOfPlayers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _label1
            // 
            this._label1.AutoSize = true;
            this._label1.Location = new System.Drawing.Point(151, 49);
            this._label1.Name = "_label1";
            this._label1.Size = new System.Drawing.Size(101, 17);
            this._label1.TabIndex = 0;
            this._label1.Text = "Player1 Name:";
            // 
            // _label2
            // 
            this._label2.AutoSize = true;
            this._label2.Location = new System.Drawing.Point(151, 87);
            this._label2.Name = "_label2";
            this._label2.Size = new System.Drawing.Size(101, 17);
            this._label2.TabIndex = 1;
            this._label2.Text = "Player2 Name:";
            // 
            // _player1Name
            // 
            this._player1Name.Location = new System.Drawing.Point(270, 49);
            this._player1Name.Name = "_player1Name";
            this._player1Name.Size = new System.Drawing.Size(122, 22);
            this._player1Name.TabIndex = 2;
            // 
            // _player2Name
            // 
            this._player2Name.Location = new System.Drawing.Point(270, 87);
            this._player2Name.Name = "_player2Name";
            this._player2Name.Size = new System.Drawing.Size(122, 22);
            this._player2Name.TabIndex = 3;
            // 
            // _submitBtn
            // 
            this._submitBtn.Location = new System.Drawing.Point(228, 171);
            this._submitBtn.Name = "_submitBtn";
            this._submitBtn.Size = new System.Drawing.Size(75, 23);
            this._submitBtn.TabIndex = 4;
            this._submitBtn.Text = "Submit";
            this._submitBtn.UseVisualStyleBackColor = true;
            this._submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // _label3
            // 
            this._label3.AutoSize = true;
            this._label3.Location = new System.Drawing.Point(124, 125);
            this._label3.Name = "_label3";
            this._label3.Size = new System.Drawing.Size(93, 17);
            this._label3.TabIndex = 5;
            this._label3.Text = "Size of Board";
            // 
            // _noOfPlayers
            // 
            this._noOfPlayers.Location = new System.Drawing.Point(270, 125);
            this._noOfPlayers.Name = "_noOfPlayers";
            this._noOfPlayers.Size = new System.Drawing.Size(122, 22);
            this._noOfPlayers.TabIndex = 6;
            // 
            // WelcomeFrame
            // 
            this.ClientSize = new System.Drawing.Size(526, 266);
            this.Controls.Add(this._noOfPlayers);
            this.Controls.Add(this._label3);
            this.Controls.Add(this._submitBtn);
            this.Controls.Add(this._player2Name);
            this.Controls.Add(this._player1Name);
            this.Controls.Add(this._label2);
            this.Controls.Add(this._label1);
            this.Name = "WelcomeFrame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(player1Name.Text);
            Board board = new Board(int.Parse(_noOfPlayers.Text));
            String pName1 = _player1Name.Text;
            String pName2 = _player2Name.Text;
            Player player1 = new Player(pName1, Mark.X);
            Player player2 = new Player(pName2, Mark.O);
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);
            Game game = new Game(resultAnalyzer, player1, player2, board);

            GameFrame GameFrame = new GameFrame(game);
            GameFrame.Show();
            this.Hide();
        }

    }
}
