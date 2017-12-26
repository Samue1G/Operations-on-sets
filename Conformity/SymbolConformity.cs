using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conformity
{
    public partial class SymbolConformity : Form 
    {
        List<Hash> listr = new List<Hash>();
        List<Hash> listr2 = new List<Hash>();
        List<Hash> listr3 = new List<Hash>();
        List<Hash> listr4 = new List<Hash>();

        public SymbolConformity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            char delimetr = ' ';
            string[] substr = str.Split(delimetr);
            listr.Add(new Hash(substr[0], substr[1]));
            textBox1.Clear();
            richTextBox1.Clear();
            for (int i = 0; i < listr.Count; i++)
            {
                
                richTextBox1.Text += "(" + listr[i].v1.ToString() + ", " + listr[i].v2.ToString() + ")" + Environment.NewLine;
            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            char delimetr = ' ';
            string[] substr = str.Split(delimetr);
            listr2.Add(new Hash(substr[0], substr[1]));
            textBox2.Clear();
            richTextBox2.Clear();
            for (int i = 0; i < listr2.Count; i++)
            {
                
                richTextBox2.Text += "(" + listr2[i].v1.ToString() + ", " + listr2[i].v2.ToString() + ")" + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            richTextBox3.Clear();
            richTextBox5.Text = null;
            label5.Text = "А(В):";
            foreach (var key in listr)
            {
                
                foreach (var key2 in listr2)
                {
                    if (key.v2 == key2.v1)
                    {
                        
                        richTextBox3.Text += "(" + key.v1 + ", " + key2.v2 + ")" + Environment.NewLine;
                        richTextBox5.Text += "Берем подходящее первое множество: (" + key.v1 + "," + key.v2 +
                            ") \nИщем первый элемент второго множества,\nравный второму элементу первого множества: " + key.v2 +
                            " = " + key2.v1 + "\n(" + key2.v1 + "," + key2.v2 + ")" + 
                            "\nЕсли находятся такие элементы, то записываем первый элемент первого множества и второй элемент второго множества:\n" +
                            "(" + key.v1 + ", " + key2.v2 + ")" + Environment.NewLine;

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            label5.Text = "B(A):";
            richTextBox3.Clear();
            richTextBox5.Text = null;
            

            foreach (var key in listr2)
            {
                foreach (var key2 in listr)
                {
                    if (key.v2 == key2.v1)
                    {   
                        
                        richTextBox3.Text += "(" + key.v1 + ", " + key2.v2 + ")" + Environment.NewLine;
                        richTextBox5.Text += "Берем подходящее первое множество: (" + key.v1 + "," + key.v2 + ") \nИщем первый элемент второго множества,\nравный второму элементу первого множества: " + key.v2 + " = " + key2.v1 + "\n(" + key2.v1 + "," + key2.v2 + ")" + "\nЕсли находятся такие элементы, то записываем первый элемент первого множества и второй элемент второго множества:\n" + "(" + key.v1 + ", " + key2.v2 + ")" + Environment.NewLine;
                        
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            listr.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            listr2.Clear();
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1_Click(new object(), new EventArgs());
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button2_Click(new object(), new EventArgs());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            label5.Text = "А⋃B = B⋃A:";
            richTextBox3.Clear();
            richTextBox5.Clear();
            var res = listr.Union(listr2).Select(i => new { i.v1, i.v2 })
                 .Distinct().Select(x => new { v1 = x.v1, v2 = x.v2}).ToList();
            foreach (var key in res) 
            {
                richTextBox3.Text += "(" + key.v1 + ", " + key.v2 + ")" + Environment.NewLine;
            }
        }

        private void button9_Click(object sender, EventArgs e) 
        {
            label5.Text = null;
            label5.Text = "А⋂B = B⋂A:";
            richTextBox3.Clear();
            richTextBox5.Clear();
            foreach (var key in listr2)
            {
                foreach (var key2 in listr)
                {
                    if (key.v1 == key2.v1 && key.v2 == key2.v2)
                    {

                        richTextBox3.Text += "(" + key.v1 + ", " + key.v2 + ")" + Environment.NewLine;

                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            listr.Clear();
            listr2.Clear();
            listr3.Clear();
            listr4.Clear();
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox5.Clear();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {

            label5.Text = null;
            label5.Text = "A\\B:";
            richTextBox3.Clear();
            richTextBox3.Text = null;
            richTextBox5.Clear();
            listr3.Clear();
            listr4.Clear();

            
            foreach (var item in listr)
            {
                foreach (var item2 in listr2)
                {
                    if (item.v1 == item2.v1 && item.v2 == item2.v2)
                    {
                        Hash obj = new Hash(item2.v1, item2.v2);
                        if (listr.Contains(obj)) MessageBox.Show("Есть");
                    }
                        
                    //if (item.v1 != item2.v1)
                    //{
                    //    richTextBox3.Text += "(" + item.v1 + ", " + item.v2 + ")" + Environment.NewLine;
                    //}
                    //if (item.v2 != item2.v2)
                    //{
                    //    richTextBox3.Text += "(" + item.v1 + ", " + item.v2 + ")" + Environment.NewLine;
                    //}
                    
                }
            }
            


        }
    }
}