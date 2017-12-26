using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conformity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Exit();
            ifrm.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
                Form ifrm = new SymbolConformity();
                ifrm.ShowDialog();
            Close();
              


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new ter();
            ifrm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Autors();
            ifrm.Show();
        }
    }
}
