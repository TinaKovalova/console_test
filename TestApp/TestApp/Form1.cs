using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        

        Dictionary<string, Action<RichTextBox>> editMethods =
            new Dictionary<string, Action<RichTextBox>>();
        public Form1()
        {
            InitializeComponent();
                       
        }
      
        private void button_Click(object sender, EventArgs e)
        {
            string text = (sender as Button).Text;
            editMethods[text](richTextBox2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button item in groupBox1.Controls)
                item.Click += button_Click;

            editMethods.Add("Color", (tBox) => tBox.SelectionColor = Color.Red);
            editMethods.Add("BackColor", (tBox) => tBox.SelectionBackColor = Color.Green);

        }
    }
}
