using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace Sudoku
{
    public partial class Game : Form
    {
        private Action Update;
        public int time = 0;
        public Game()
        {
            InitializeComponent();
            TimerCallback callback = new TimerCallback(UpdateTime);
            Timer timer = new Timer(callback, 0, 0, 2000);
            Update=new Action(UpdateMethod);
        }

        public void UpdateMethod()
        {

            labelTime.Text = time.ToString();
        }
        public void UpdateTime(Object source)
        {
            ++time;
            Game game = this;
            game.Invoke(game.Update);
        }
        private void Game_Load(object sender, EventArgs e)
        {
            SudokuGraund graund = new SudokuGraund();
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    Button but = new Button();
                    but.Size = new Size(40, 40);
                    but.Location = new Point(j * 40, i * 40);
                    but.Visible = true;
                    Random random = new Random();
                    int rand = random.Next(10);
                    if (rand > 2 && rand < 9)
                    {
                        but.Text = graund.graund[i, j].ToString();
                        but.Enabled = false;
                        but.BackColor = Color.White;
                    }
                    else
                    {
                        but.Click += buttonPole_Click;
                    }
                    Thread.Sleep(13);
                    this.Controls.Add(but);
                }
            }
        }

        private void buttonPole_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            FormVariants variants = new FormVariants();
            int variant = variants.variantStart();
            but.Text = variant.ToString();
        }
    }
}
