using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToGameDll;

namespace TicTacToUi
{
    class GameFrame:Form
    {
        private Button _button1, _button2, _button3, _button4, _button5, _button6, _button7, _button8, _button9;

        private Game _game;
        private Board _board;
        private Label currentPlayerName;
        private Label messageLabel;
        private Label devLabel;
        private ResultAnalyzer _resultAnalyzer;

        public GameFrame(Game game)
        {
            _game = game;
            _board = game.GetBoard;
            _resultAnalyzer = game.GetResultAnalyzer;
            InitializeComponent();

        }
        public void InitializeComponent()
        {
            this._button1 = new System.Windows.Forms.Button();
            this._button2 = new System.Windows.Forms.Button();
            this._button3 = new System.Windows.Forms.Button();
            this._button4 = new System.Windows.Forms.Button();
            this._button5 = new System.Windows.Forms.Button();
            this._button6 = new System.Windows.Forms.Button();
            this._button7 = new System.Windows.Forms.Button();
            this._button8 = new System.Windows.Forms.Button();
            this._button9 = new System.Windows.Forms.Button();
            this.currentPlayerName = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.devLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _button1
            // 
            this._button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button1.Location = new System.Drawing.Point(90, 132);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(85, 85);
            this._button1.TabIndex = 0;
            this._button1.Text = "1";
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button2
            // 
            this._button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button2.Location = new System.Drawing.Point(299, 132);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(85, 85);
            this._button2.TabIndex = 1;
            this._button2.Text = "2";
            this._button2.UseVisualStyleBackColor = true;
            this._button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button3
            // 
            this._button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button3.Location = new System.Drawing.Point(521, 132);
            this._button3.Name = "_button3";
            this._button3.Size = new System.Drawing.Size(85, 85);
            this._button3.TabIndex = 2;
            this._button3.Text = "3";
            this._button3.UseVisualStyleBackColor = true;
            this._button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button4
            // 
            this._button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button4.Location = new System.Drawing.Point(90, 308);
            this._button4.Name = "_button4";
            this._button4.Size = new System.Drawing.Size(85, 85);
            this._button4.TabIndex = 3;
            this._button4.Text = "4";
            this._button4.UseVisualStyleBackColor = true;
            this._button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button5
            // 
            this._button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button5.Location = new System.Drawing.Point(299, 308);
            this._button5.Name = "_button5";
            this._button5.Size = new System.Drawing.Size(85, 85);
            this._button5.TabIndex = 4;
            this._button5.Text = "5";
            this._button5.UseVisualStyleBackColor = true;
            this._button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button6
            // 
            this._button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button6.Location = new System.Drawing.Point(521, 308);
            this._button6.Name = "_button6";
            this._button6.Size = new System.Drawing.Size(85, 85);
            this._button6.TabIndex = 5;
            this._button6.Text = "6";
            this._button6.UseVisualStyleBackColor = true;
            this._button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button7
            // 
            this._button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button7.Location = new System.Drawing.Point(90, 481);
            this._button7.Name = "_button7";
            this._button7.Size = new System.Drawing.Size(85, 85);
            this._button7.TabIndex = 6;
            this._button7.Text = "7";
            this._button7.UseVisualStyleBackColor = true;
            this._button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button8
            // 
            this._button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button8.Location = new System.Drawing.Point(299, 481);
            this._button8.Name = "_button8";
            this._button8.Size = new System.Drawing.Size(85, 85);
            this._button8.TabIndex = 7;
            this._button8.Text = "8";
            this._button8.UseVisualStyleBackColor = true;
            this._button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // _button9
            // 
            this._button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._button9.Location = new System.Drawing.Point(521, 481);
            this._button9.Name = "_button9";
            this._button9.Size = new System.Drawing.Size(85, 85);
            this._button9.TabIndex = 8;
            this._button9.Text = "9";
            this._button9.UseVisualStyleBackColor = true;
            this._button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // currentPlayerName
            // 
            this.currentPlayerName.AutoSize = true;
            this.currentPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerName.Location = new System.Drawing.Point(117, 37);
            this.currentPlayerName.Name = "currentPlayerName";
            this.currentPlayerName.Size = new System.Drawing.Size(0, 32);
            this.currentPlayerName.TabIndex = 9;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(293, 597);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 32);
            this.messageLabel.TabIndex = 10;
            // 
            // devLabel
            // 
            this.devLabel.AutoSize = true;
            this.devLabel.Location = new System.Drawing.Point(462, 627);
            this.devLabel.Name = "devLabel";
            this.devLabel.Size = new System.Drawing.Size(77, 17);
            this.devLabel.TabIndex = 11;
            this.devLabel.Text = "Developer:"+ConfigurationManager.AppSettings["developerDetails"];
            // 
            // GameFrame
            // 
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.devLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.currentPlayerName);
            this.Controls.Add(this._button9);
            this.Controls.Add(this._button8);
            this.Controls.Add(this._button7);
            this.Controls.Add(this._button6);
            this.Controls.Add(this._button5);
            this.Controls.Add(this._button4);
            this.Controls.Add(this._button3);
            this.Controls.Add(this._button2);
            this.Controls.Add(this._button1);
            this.Name = "GameFrame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void Button_Click(object sender, EventArgs e)
        {

            String playerName = _game.GetCurrentPlayer().PlayerName;
            Player player = _game.GetCurrentPlayer();
            currentPlayerName.Text = "Current Player: "+playerName;
            Button btn = (Button)sender;
            //MessageBox.Show(btn.Text);
            _game.Play(int.Parse(btn.Text) - 1);
            btn.Text = player.GetMark.ToString();
            if (_resultAnalyzer.FindWinner())
            {
                messageLabel.Text = "Winner is: " + playerName+" !!";
                DisableButtons();
                return;
            }
            if (_board.IsBoardFull())
            {

                messageLabel.Text= "Its a draw!!";
                DisableButtons();
            }

            _game.SwitchPlayer();

        }

        private void DisableButtons()
        {
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
            }
        }
    }
}
