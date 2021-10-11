using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_And_Sub
{
     public delegate int AddAndSub(int a , int b);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public  int Add(int a , int b)
        {
            return a + b;
        }
        public int Sub(int a , int b)
        {
            return a - b;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddAndSub addAndSub1 = new AddAndSub(Add);
            Answertxt.Text = addAndSub1(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            AddAndSub addAndSub2= new AddAndSub(Sub);
            Answertxt.Text = addAndSub2(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
