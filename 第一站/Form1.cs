using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 迴文判斷
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"D:\C#\丙設\test\1060301.sm");
            string str = file.ReadToEnd();
            file.Close();
            int num = str.Length;
            for (int i = 0; i <= num / 2; i++)
            {
                if (str[i] != str[num - i - 1])
                {
                    txtShow01.Text = "第一題: " + str + " is not a palindrome.";
                    return;
                }
            }
            txtShow01.Text = "第一題: " + str + " is a palindrome.";
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            StreamReader a = new StreamReader(@"D:\C#\丙設\test\1060302.sm");
            int num = int.Parse(a.ReadToEnd());
            a.Close();
            txtShow02.Text = "第二題: \r\n";
            string s = "";
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    s += j;
                }
                s += "\r\n";
            }
            txtShow02.Text += $"{s}";
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            StreamReader num = new StreamReader(@"D:\C#\丙設\test\1060303.sm");
            int a = int.Parse(num.ReadToEnd());
            num.Close();
            for (int i = 2; i <= a - 1; i++)
            {
                if (a % i == 0)
                {
                    txtShow03.Text = "第三題: " + a + " is not a prime.";
                    return;
                }
            }
            txtShow03.Text = "第三題: " + a + " is a prime.";
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            StreamReader abc = new StreamReader(@"D:\C#\丙設\test\1060304.sm");
            int[] w = new int[3];
            int[] h = new int[3];
            int[] bmi = new int[3];
            string STR;
            string[] str;
            for (int i = 0; i <= 2; i++)
            {
                STR = abc.ReadLine();
                str = STR.Split(',');
                h[i] = int.Parse(str[0]);
                w[i] = int.Parse(str[1]);
                bmi[i] = (w[i]) / (h[i] * h[i] / 10000);
            }
            int s_bmi = bmi[0];
            for (int j = 0; j <= 2; j++)
            {
                if (bmi[j] < s_bmi)
                {
                    s_bmi = bmi[j];
                }
            }
            if (s_bmi < 20 || s_bmi > 25)
            {
                txtShow04.Text += "第四題: 最小BMI值 =" + s_bmi + ", 不正常";
            }
            abc.Close();
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader(@"D:\C#\丙設\test\1060305.sm");
            int[,] a = new int[5, 2];
            int[,] c = new int[2, 2];
            string str = "";
            for (int i=0;i<=3;i++)
            {
                    str = file.ReadLine();
                    string[] s = str.Split(',');
                for (int j = 0; j <= 1; j++)
                {
                    a[i, j] = int.Parse(s[j]);
                }
            }
            c[0, 0] = a[0, 0] + a[2, 0];
            c[0, 1] = a[0, 1] + a[2, 1];
            c[1, 0] = a[1, 0] + a[3, 0];
            c[1, 1] = a[1, 1] + a[3, 1];
            txtShow05.Text +="第五題:"+"\r\n" + $"[{c[0, 0]}" + "        " + $"{c[0, 1]}]" + "\r\n";
            txtShow05.Text += $"[{c[1, 0]}" + "    " + $"{c[1, 1]}]";
            file.Close();
        }
    }
}
