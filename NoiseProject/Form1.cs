using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoiseProject
{
    public partial class Form1 : Form
    {
        Gradient gradient;
        int[,] map;
        int[,] blur;
        int variance = 100;
        int[,] matrix = new int[5,5];
        string grad1 = @"0.0.147.0|0.59.188.78|0.111.255.99|205.171.0.111|243.228.0.121|0.120.28.131|144.193.0.188|74.208.75.255|";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadGradient(grad1);
            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 5; x++)
                {
                    matrix[y, x] = 1;
                }
            }
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button14.Text = "";
            button15.Text = "";
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";
            button20.Text = "";
            button21.Text = "";
            button22.Text = "";
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            map = NoiseMap.GetNotSmoothedNoise(100, 100, variance);
            UpdateNoise();
        }

        private void UpdateNoise()
        {
            pictureBox1.Image = map.ToBitmap();
        }
        private void UpdateBlur()
        {
            blur = map.ApplyMatrix(matrix, SelectionMethod.Mean);
            pictureBox2.Image = blur.ToBitmap();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;
            Button cur = button1;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int c = matrix[0, 1];
            Button cur = button2;
            if (c == 0)
            {
                matrix[0, 1] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[0, 1] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 0;
            Button cur = button3;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 0;
            Button cur = button4;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 0;
            Button cur = button5;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 1;
            Button cur = button6;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            Button cur = button7;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 1;
            Button cur = button8;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 1;
            Button cur = button9;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 1;
            Button cur = button10;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 2;
            Button cur = button11;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 2;
            Button cur = button12;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 2;
            Button cur = button13;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 2;
            Button cur = button14;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 2;
            Button cur = button15;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 3;
            Button cur = button16;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 3;
            Button cur = button17;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 3;
            Button cur = button18;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 3;
            Button cur = button19;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 3;
            Button cur = button20;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 4;
            Button cur = button21;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 4;
            Button cur = button22;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            int x = 2;
            int y = 4;
            Button cur = button23;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button24_Click(object sender, EventArgs e)
        {
            int x = 3;
            int y = 4;
            Button cur = button24;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            int x = 4;
            int y = 4;
            Button cur = button25;
            int c = matrix[y, x];
            if (c == 0)
            {
                matrix[y, x] = 1;
                cur.BackColor = Color.Black;
                cur.Text = "";
                UpdateBlur();
            }
            else
            {
                matrix[y, x] = 0;
                cur.BackColor = Color.White;
                cur.Text = "";
                UpdateBlur();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            map = NoiseMap.GetNotSmoothedNoise(100, 100, variance);
            UpdateNoise();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            UpdateBlur();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            blur.ToBitmap().Save(@"C:\Users\usagi\Desktop\thing.png");
        }

        private void loadGradient(string gs)
        {
            List<int> indices = new List<int>();
            List<Color> colors = new List<Color>();
            gradient = new Gradient();
            string[] grads = gs.Split('|');
            for (int i = 0; i < grads.Length; i++)
            {
                if (grads[i] != "")
                {
                    string[] dtl = grads[i].Split('.');
                    int R = Int32.Parse(dtl[0]);
                    int G = Int32.Parse(dtl[1]);
                    int B = Int32.Parse(dtl[2]);
                    int I = Int32.Parse(dtl[3]);
                    indices.Add(I);
                    colors.Add(Color.FromArgb(R, G, B));
                }
            }
            gradient.background = Color.Black;
            for (int i = 0; i < colors.Count; i++)
            {
                gradient.SetColor(indices[i], colors[i]);
            }
        }
    }
}
