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
    public partial class FormVariants : Form
    {
        private int num = 0 ;
        public FormVariants()
        {
            InitializeComponent();
        }

        public int variantStart()
        {
            this.ShowDialog();
            while(num==0)
            return num;
            return num;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            num = Convert.ToInt32( but.Tag);
            this.Close();
        }
    }
}
