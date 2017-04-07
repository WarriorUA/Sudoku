using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Sudoku
{
    public partial class Game : Form
    {

        SudokuGraund graund = new SudokuGraund();
        public int Time;
        public Game()
        {
            InitializeComponent();
            Game_Load();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            ++Time;
            labelTime.Text = Time.ToString();
        }
        private void Game_Load()
        {
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
                    Controls.Add(but);
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

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 2;
            for (int i = 0; i < 9; ++i)
            {
                for (int j = 0; j < 9; ++j)
                {
                    if (graund.graund[i, j].ToString() != this.Controls[num].Text)
                    {
                        MessageBox.Show("OHIBKA", "PORAG");
                        return;                      
                    }
                    else
                    {
                        num++;
                    }
                }
            }
            MessageBox.Show("WIN", "WIN");
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }
    }
}
