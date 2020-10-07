using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace 分數加_減_乘_除
{
    
    public partial class Form1 : Form
    {
        int rno;
        StreamReader file = new StreamReader(@"D:\C#\丙設\test\1060308.sm");
        string[,] d = new string[100, 6];
        int m1, m2;
        string m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdata();
            sp1();
            wdata();
        }

        private void rdata()
        {
            string[] num;
            rno = 0;
            string str;

            while((str = file.ReadLine()) != null)
            {
                rno += 1;
                for (int i = 0; i <= 4; i++)
                {
                    num = str.Split(',');
                    d[rno, i] = num[i];
                }

            }
        }

        private void sp1()
        {
            for(int i=1;i<=rno;i++)
            {
                int a = int.Parse(d[i, 1]);
                int b = int.Parse(d[i, 0]);
                int x = int.Parse(d[i, 4]);
                int y = int.Parse(d[i, 3]);
                switch(d[i,2])
                {
                    case "+":
                        m1 = b * x + a * y;
                        m2 = a * x;
                        break;
                    case "-":
                        m1 = b * x - a * y;
                        m2 = a * x;
                        break;
                    case "*":
                        m1 = b * y;
                        m2 = a * x;
                        break;
                    case "/":
                        m1 = b * x;
                        m2 = a * y;
                        break;
                    default:
                        break;
                }
                for(int j = 2;j<=m1;j++)
                {
                    while(m1 % j == 0 && m2 % j == 0)
                    {
                        m1 = m1 / j;
                        m2 = m2 / j;
                    }    
                }
                m3 = $"{m1}/{m2}";
                if (m1 == 0)
                    m3 = "0";
                if (m2 == 1)
                    m3 = Convert.ToString(m1);

                d[i, 5] = m3;
            }
            
        }

        private void wdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("VALUE1");
            dt.Columns.Add("OP");
            dt.Columns.Add("VALUE2");
            dt.Columns.Add("ANSWER");
            for(int i = 1;i<=rno;i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = $"{d[i, 0]}/{d[i, 1]}";
                dr[1] = d[i, 2];
                dr[2] = $"{d[i, 3]}/{d[i, 4]}";
                dr[3] = d[i, 5];
                dt.Rows.Add(dr);
            }
            dgv.DataSource = dt;
        }
    }
}
