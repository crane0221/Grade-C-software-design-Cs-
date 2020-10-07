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
using System.Collections;
using System.Text;
using System.Drawing.Drawing2D;

namespace 撲克牌比大小
{
    public partial class Form1 : Form
    {
        int rno = 0;
        int[] d = new int[100];
        int cishu;
        ArrayList card = new ArrayList();
        ArrayList pf = new ArrayList();
        ArrayList pn = new ArrayList();
        ArrayList bn = new ArrayList();
        ArrayList bf = new ArrayList();
        ArrayList pn1 = new ArrayList();
        ArrayList bn1 = new ArrayList();

        string[] suit = new string[4];
        StreamReader file = new StreamReader(@"D:\C#\丙設\test\1060307.sm");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdata();
            sp1();
            sp2();
            sp3();
            wdata();
        }

        public void rdata()
        { 
            cishu = int.Parse(file.ReadLine());
            double[] f = new double[100];
            string[] str = new string[100];
            rno = 0;
            while((str[rno] = file.ReadLine()) != null)
            {
                f[rno] = float.Parse(str[rno]);
                d[rno] = (int)(Math.Floor(f[rno]*52));
                rno += 1;
            }
            file.Close();
        }
        public void sp1()
        {
            suit[0] = "♠";
            suit[1] = "♥";
            suit[2] = "◆";
            suit[3] = "♣";
        }
        public void sp2()
        {
            for (int i = 1;i<=rno;i++)
            {
                if (!card.Contains(d[i]))
                    card.Add(d[i]);
            }
        }
        public void sp3()
        {
           for(int i = 0;i <= cishu*2-1;i++)
            {
                int zx = (Convert.ToInt32(card[i]) + 1) / 13;
                int n = Convert.ToInt32(card[i]) % 13 + 1;
                string[] Num = { "*", "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
                string n1 = Num[n];
                if (n == 1)
                    n += 13;
                if (i % 2 == 0)
                {
                    pf.Add(zx);
                    pn.Add(n);
                    pn1.Add(n1);
                }
                else
                {
                    bf.Add(zx);
                    bn.Add(n); 
                    bn1.Add(n1);
                }
            }
        }
        public void wdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("序號");
            dt.Columns.Add("玩家");
            dt.Columns.Add("莊家");
            dt.Columns.Add("結果");
            for(int i = 0;i<=cishu-1;i++)
            {
                DataRow dr = dt.NewRow();
                int x = Convert.ToInt32(pf[i]);
                int y = Convert.ToInt32(pn[i]);
                int z = Convert.ToInt32(bn[i]);
                dr[0] = i + 1;
                dr[1] = $"{suit[x]}{pn1[i]}"; 
                dr[2] = $"{suit[x]}{bn1[i]}";
                //pn = y   bn = z
                if (y > z)
                    dr[3] = "玩家贏";
                if (y == z)
                    dr[3] = "平手";
                if (y < z)
                    dr[3] = "莊家贏";
                dt.Rows.Add(dr);
            }
            dgv.DataSource = dt;
        }
    }
}
