using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp20201105.Properties;

namespace WindowsFormsApp20201105
{
    public partial class Form1 : Form
    {
        List<Image> picture = new List<Image>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picture.Add(Resources.a1);
            picture.Add(Resources.a2);
            picture.Add(Resources.a3);
            picture.Add(Resources.a4);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Btnpump_Click(object sender, EventArgs e)
        {
            int x = new Random().Next(4);
            pbshow.Image = picture[x];
            int a = x + 1;
            rtbshow.Text = ""+a;
        }
    }
}
