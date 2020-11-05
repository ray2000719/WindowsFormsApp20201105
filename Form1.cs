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
        Poker p = null;
        List<int> x;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 5; i++)
            {
                string resourceName = i.ToString();
                string resourceNum = "a" + resourceName;
                Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(resourceNum);
                picture.Add(bmp);
                p = new Poker();
                x = p.GetPoker(4);



            }
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        int i = 0;
        private void Btnpump_Click(object sender, EventArgs e)
        {
            if (i<4)
            {
                
                pbshow.Image = picture[x[i]];
                rtbshow.Text += x[i] + 1 + ",";
                i = i + 1;
            }
            
        }
    }
}
