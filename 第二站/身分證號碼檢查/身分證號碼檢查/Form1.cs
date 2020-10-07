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

namespace 身分證號碼檢查
{
    public partial class Form1 : Form
    {
        
        static int rno;
        static string ec;
        static string[,] d = new string[100, 4];
        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdata();
            for (int i = 0; i < rno; i++)
            {
                ec = "";
                sp1(i);
                if (ec == "")
                    sp2(i);
                if (ec == "")
                    sp3(i);
                d[i, 3] = ec;
            }
            wdata();
        }

        private void rdata()
        {
            
            StreamReader file = new StreamReader(@"D:\C#\丙設\test\1060306.sm");
            rno = 0;
            string a;
            string[] data;
            while ((a = file.ReadLine()) != null)
            {
                data = a.Split(',');
                d[rno, 0] = data[0];
                d[rno, 1] = data[1];
                d[rno, 2] = data[2];
                rno += 1;
            }
        }

        private static void sp1(int i)
        {
            string str = d[i, 0];
            int m1 = str.Length;
    
            if (m1 != 10)
                ec = "FORMATE ERROR";
            if(str[0] < 'A' || str[0] > 'Z')
                ec = "FORMATE ERROR";
            for(int j = 2;j<=10;j++)
            {
                if(str[j-1] < '0' || str[j-1] > '9')
                    ec = "FORMATE ERROR";
            }
        }

        private static void sp2(int i)
        {
            char x = d[i, 2][0];
            char y = d[i, 0][1];
            string z = $"{y}{x}";
            if (z != "1M" && z != "2F")
                ec = "SEX CODE ERROR";
        }

        private static void sp3(int i)
        {
            char l1 = d[i, 0][0];
            string s26 = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
            int m = s26.IndexOf(l1)+10;
            int x1 = m / 10;
            int x2 = m % 10;
            int[] a = new int[20];
            for(int j=1;j<=9;j++)
            {
                a[j] = (d[i, 0][j] - '0');
            }
            int Y = x1 + 9 * x2 + a[1] * 8 + a[2] * 7 + a[3] * 6 + a[4] * 5 + a[5] * 4 + a[6] * 3 + a[7] * 2 + a[8] + a[9];
            if (Y % 10 != 0)
                ec = "CHECK SUM ERROR";
        }

        private  void wdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("IDNO");
            dt.Columns.Add("NAME");
            dt.Columns.Add("SEX");
            dt.Columns.Add("ERROR");
            for(int j = 1;j<=rno;j++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = d[j, 0];
                dr[1] = d[j, 1];
                dr[2] = d[j, 2];
                dr[3] = d[j, 3];
                dt.Rows.Add(dr);
            }
            dgv.DataSource = dt;
            dgv.Sort(dgv.Columns[0], 0);
        }
    }
}
