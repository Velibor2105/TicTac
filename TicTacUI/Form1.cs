using System;
using System.Windows.Forms;
using TicTac3;

namespace TicTacUI
{
    public partial class Form1 : Form
    {

        private Game ticTac;
        private IWinningSet winnSet;
        private IMove moveManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewGame();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewGame();
            ResetUi();

        }

        private void mark_Click(object sender, EventArgs e)
        {
            Field f = (Field)sender;
            f.Enabled = false;
            f.label.Text = moveManager.Next();
            resLbl.Text = ticTac.CheckWinner(new TicTac3.Field(f.Id, f.label.Text));
            FreezUi(resLbl.Text);
        }


        private void NewGame()
        {
            moveManager = new Play(new Sequncer(),9);
            winnSet = new WinningSet();
            ticTac = new Game(winnSet, moveManager);

        }

        private void ResetUi()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(Field))
                {
                    var f = item as Field;
                    f.label.Text = "";
                    f.Enabled = true;
                }
            }
            resLbl.Text = "DRAW";
        }

        private void FreezUi(string arg)
        {
            if (arg != "DRAW")
            {
                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(Field))
                    {
                        var f = item as Field;
                        f.Enabled = false;
                    }
                }
            }
        }

    
    }
}
