using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Team
    {
        private string name;
        private int point = 0;
        private int w = 0;
        private int l = 0;
        private int d = 0;
        private int p = 0;
        private decimal sm;

        public void Name(Label l1)
        {
            name = l1.Text;
        }
        public void Points(int p)
        {
            point += p;
        }
        public void ScoreMissedGoal(decimal s, decimal m)
        {
            sm += s - m;
        }
        public void Wins(int win)
        {
            w += win;
        }
        public void Draws(int dr)
        {
            d += dr;
        }
        public void Loses(int los)
        {
            l += los;
        }
        public string GetName()
        {
            return name;
        }
        public int GetPoints()
        {
            return point;
        }
        public decimal GetGoals()
        {
            return sm;
        }
        public int GetW()
        {
            return w;
        }
        public int GetDraws()
        {
            return d;
        }
        public int GetLoses()
        {
            return l;
        }
        public void Position(int pos)
        {
            p = pos;
        }
        public int GetPosition()
        {
            return p;
        }
    }

    class PointsT
    {
        private decimal sc1, sc2;
        public void Results(NumericUpDown hometeam, NumericUpDown visitors, int ho, int vo, Team t1, Team t2)
        {
            sc1 = hometeam.Value;
            sc2 = visitors.Value;
            t1.ScoreMissedGoal(sc1, sc2);
            t2.ScoreMissedGoal(sc2, sc1);
            if (sc1 == sc2)
            {
                ho += 1;
                vo += 1;
                t1.Draws(1);
                t2.Draws(1);
            }
            else if (sc1 > sc2)
            {
                ho += 3;
                vo += 0;
                t1.Wins(1);
                t2.Loses(1);
            }
            else if (sc1 < sc2)
            {
                ho += 0;
                vo += 3;
                t1.Loses(1);
                t2.Wins(1);
            }
            t1.Points(ho);
            t2.Points(vo);
        }
    }

    class Table
    {
        private int[] arr = new int[4];
        public int k1, k2, k3, k4; //= 3, k2 = 3, k3 = 3, k4 = 3;


        public void WriteTable(DataGridView d, Team t, int i)
        {
            d.Rows[i].Cells[0].Value = t.GetName();
            d.Rows[i].Cells[1].Value = t.GetW();
            d.Rows[i].Cells[2].Value = t.GetDraws();
            d.Rows[i].Cells[3].Value = t.GetLoses();
            d.Rows[i].Cells[4].Value = t.GetGoals();
            d.Rows[i].Cells[5].Value = t.GetPoints();
        }
        public void Sortuv(Team t1, Team t2, Team t3, Team t4)
        {
            arr[0] = t1.GetPoints();
            arr[1] = t2.GetPoints();
            arr[2] = t3.GetPoints();
            arr[3] = t4.GetPoints();

            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (arr[i] == t1.GetPoints())
                {
                    k1 = i;
                    t1.Position(i);
                    arr[i] = -1;
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] == t2.GetPoints()) 
                {
                    k2 = i;
                    t2.Position(i);
                    arr[i] = -1;
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] == t3.GetPoints())
                {
                    k3 = i;
                    t3.Position(i);
                    arr[i] = -1;
                    break;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (arr[i] == t4.GetPoints())
                {
                    k4 = i;
                    t4.Position(i);
                    arr[i] = -1;
                    break;
                }
            }
        }
        public void Nul(NumericUpDown n1, NumericUpDown n2, NumericUpDown n3, NumericUpDown n4, NumericUpDown n5, NumericUpDown n6, NumericUpDown n7, NumericUpDown n8, NumericUpDown n9, NumericUpDown n10, NumericUpDown n11, NumericUpDown n12, NumericUpDown n13, NumericUpDown n14, NumericUpDown n15, NumericUpDown n16, NumericUpDown n17, NumericUpDown n18, NumericUpDown n19, NumericUpDown n20, NumericUpDown n21, NumericUpDown n22, NumericUpDown n23, NumericUpDown n24)
        {
            n1.Value = 0;
            n2.Value = 0;
            n3.Value = 0;
            n4.Value = 0;
            n5.Value = 0;
            n6.Value = 0;
            n7.Value = 0;
            n8.Value = 0;
            n9.Value = 0;
            n10.Value = 0;
            n11.Value = 0;
            n12.Value = 0;
            n13.Value = 0;
            n14.Value = 0;
            n15.Value = 0;
            n16.Value = 0;
            n17.Value = 0;
            n18.Value = 0;
            n19.Value = 0;
            n20.Value = 0;
            n21.Value = 0;
            n22.Value = 0;
            n23.Value = 0;
            n24.Value = 0;
        }

        public void Save(decimal[] mas, NumericUpDown n1, NumericUpDown n2, NumericUpDown n3, NumericUpDown n4, NumericUpDown n5, NumericUpDown n6, NumericUpDown n7, NumericUpDown n8, NumericUpDown n9, NumericUpDown n10, NumericUpDown n11, NumericUpDown n12, NumericUpDown n13, NumericUpDown n14, NumericUpDown n15, NumericUpDown n16, NumericUpDown n17, NumericUpDown n18, NumericUpDown n19, NumericUpDown n20, NumericUpDown n21, NumericUpDown n22, NumericUpDown n23, NumericUpDown n24)
        {
            mas[0] = n1.Value;
            mas[1] = n2.Value;
            mas[2] = n3.Value;
            mas[3] = n4.Value;
            mas[4] = n5.Value;
            mas[5] = n6.Value;
            mas[6] = n7.Value;
            mas[7] = n8.Value;
            mas[8] = n9.Value;
            mas[9] = n10.Value;
            mas[10] = n11.Value;
            mas[11] = n12.Value;
            mas[12] = n13.Value;
            mas[13] = n14.Value;
            mas[14] = n15.Value;
            mas[15] = n16.Value;
            mas[16] = n17.Value;
            mas[17] = n18.Value;
            mas[18] = n19.Value;
            mas[19] = n20.Value;
            mas[20] = n21.Value;
            mas[21] = n22.Value;
            mas[22] = n23.Value;
            mas[23] = n24.Value;
        }
        public void ShowRes(decimal[] mas, NumericUpDown n1, NumericUpDown n2, NumericUpDown n3, NumericUpDown n4, NumericUpDown n5, NumericUpDown n6, NumericUpDown n7, NumericUpDown n8, NumericUpDown n9, NumericUpDown n10, NumericUpDown n11, NumericUpDown n12, NumericUpDown n13, NumericUpDown n14, NumericUpDown n15, NumericUpDown n16, NumericUpDown n17, NumericUpDown n18, NumericUpDown n19, NumericUpDown n20, NumericUpDown n21, NumericUpDown n22, NumericUpDown n23, NumericUpDown n24)
        {
            n1.Value = mas[0];
            n2.Value = mas[1];
            n3.Value = mas[2];
            n4.Value = mas[3];
            n5.Value = mas[4];
            n6.Value = mas[5];
            n7.Value = mas[6];
            n8.Value = mas[7];
            n9.Value = mas[8];
            n10.Value = mas[9];
            n11.Value = mas[10];
            n12.Value = mas[11];
            n13.Value = mas[12];
            n14.Value = mas[13];
            n15.Value = mas[14];
            n16.Value = mas[15];
            n17.Value = mas[16];
            n18.Value = mas[17];
            n19.Value = mas[18];
            n20.Value = mas[19];
            n21.Value = mas[20];
            n22.Value = mas[21];
            n23.Value = mas[22];
            n24.Value = mas[23];
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
