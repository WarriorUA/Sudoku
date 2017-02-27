using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonPrecept_Click(object sender, EventArgs e)
        {
          FormPrecept precept = new FormPrecept();
            precept.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Выйти?","Вы действительно хотите закончить игру?",MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Game game = new Game();
            game.Show();
        }
    }
}
