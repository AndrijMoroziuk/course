using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2),
                (ScreenHeight / 2) - (this.Height / 2));

            dataGridView1.RowCount = 4;
            dataGridView2.RowCount = 4;
            dataGridView3.RowCount = 4;
            dataGridView4.RowCount = 4;
            dataGridView5.RowCount = 4;
            dataGridView6.RowCount = 4;
            dataGridView7.RowCount = 4;
            dataGridView8.RowCount = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        public decimal[] mas1 = new decimal[24];
        public decimal[] mas2 = new decimal[24];
        public decimal[] mas3 = new decimal[24];
        public decimal[] mas4 = new decimal[24];
        public decimal[] mas5 = new decimal[24];
        public decimal[] mas6 = new decimal[24];
        public decimal[] mas7 = new decimal[24];
        public decimal[] mas8 = new decimal[24];

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Team Porto = new Team();
            Porto.Name(label1);
            Team DynamoZ = new Team();
            DynamoZ.Name(label2);
            Team DynamoK = new Team();
            DynamoK.Name(label3);
            Team PSG = new Team();
            PSG.Name(label4);
            for (int i = 0; i < 24; i++)
            {
                mas1[i] = 0;
                mas2[i] = 0;
                mas3[i] = 0;
                mas4[i] = 0;
                mas5[i] = 0;
                mas6[i] = 0;
                mas7[i] = 0;
                mas8[i] = 0;

            }

           
            PointsT t = new PointsT();
            int[] p = new int[4];
            t.Results(numericUpDown2, numericUpDown1, p[0], p[1],DynamoZ,Porto);
            t.Results(numericUpDown4, numericUpDown3, p[2], p[3], PSG, DynamoK);
            t.Results(numericUpDown6, numericUpDown5, p[3], p[0], DynamoK, DynamoZ);
            t.Results(numericUpDown8, numericUpDown7, p[1], p[2], Porto, PSG);
            t.Results(numericUpDown10, numericUpDown9, p[1], p[3], Porto, DynamoK);
            t.Results(numericUpDown12, numericUpDown11, p[0], p[2], DynamoZ, PSG);
            t.Results(numericUpDown14, numericUpDown13, p[3], p[1], DynamoK, Porto);
            t.Results(numericUpDown16, numericUpDown15, p[2], p[0], PSG, DynamoZ);
            t.Results(numericUpDown18, numericUpDown17, p[3], p[2], DynamoK, PSG);
            t.Results(numericUpDown20, numericUpDown19, p[1], p[0], Porto, DynamoZ);
            t.Results(numericUpDown22, numericUpDown21, p[0], p[3], DynamoZ, DynamoK);
            t.Results(numericUpDown24, numericUpDown23, p[2], p[1], PSG, Porto);

            Table a = new Table();
            //public decimal[] mas = new decimal[24];
            

            if (label1.Text == "Порту")
            {
                
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                dataGridView1.Rows[1].Cells[0].Value = Porto.GetPosition();
                dataGridView1.Rows[1].Cells[1].Value = DynamoZ.GetPosition();
                dataGridView1.Rows[1].Cells[2].Value = DynamoK.GetPosition();
                dataGridView1.Rows[1].Cells[3].Value = PSG.GetPosition();
                /*a.WriteTable(dataGridView1, Porto, Porto.GetPosition());               //а.к прив'язати до команди
                a.WriteTable(dataGridView1, DynamoZ, DynamoZ.GetPosition());
                a.WriteTable(dataGridView1, DynamoK, DynamoK.GetPosition());
                a.WriteTable(dataGridView1, PSG, PSG.GetPosition());*/
                a.Save(mas1, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
            else if (label1.Text == "Монпельє")
            {
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                a.WriteTable(dataGridView2, Porto, a.k1);
                a.WriteTable(dataGridView2, DynamoZ, a.k2);
                a.WriteTable(dataGridView2, DynamoK, a.k3);
                a.WriteTable(dataGridView2, PSG, a.k4);
                a.Save(mas2, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
            else if (label1.Text == "Зеніт")
            {
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                a.WriteTable(dataGridView3, Porto, a.k1);
                a.WriteTable(dataGridView3, DynamoZ, a.k2);
                a.WriteTable(dataGridView3, DynamoK, a.k3);
                a.WriteTable(dataGridView3, PSG, a.k4);
                a.Save(mas3, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
            else if (label1.Text == "Аякс")
            {
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                a.WriteTable(dataGridView4, Porto, a.k1);
                a.WriteTable(dataGridView4, DynamoZ, a.k2);
                a.WriteTable(dataGridView4, DynamoK, a.k3);
                a.WriteTable(dataGridView4, PSG, a.k4);
                a.Save(mas4, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
            else if (label1.Text == "Нордшелланд")
            {
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                a.WriteTable(dataGridView5, Porto, a.k1);
                a.WriteTable(dataGridView5, DynamoZ, a.k2);
                a.WriteTable(dataGridView5, DynamoK, a.k3);
                a.WriteTable(dataGridView5, PSG, a.k4);
                a.Save(mas5, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
            else if (label1.Text == "БАТЕ")
            {
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                a.WriteTable(dataGridView6, Porto, a.k1);
                a.WriteTable(dataGridView6, DynamoZ, a.k2);
                a.WriteTable(dataGridView6, DynamoK, a.k3);
                a.WriteTable(dataGridView6, PSG, a.k4);
                a.Save(mas6, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
            else if (label1.Text == "Спартак М.")
            {
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                a.WriteTable(dataGridView7, Porto, a.k1);
                a.WriteTable(dataGridView7, DynamoZ, a.k2);
                a.WriteTable(dataGridView7, DynamoK, a.k3);
                a.WriteTable(dataGridView7, PSG, a.k4);
                a.Save(mas7, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
            else if (label1.Text == "Галатасарай")
            {
                a.Sortuv(Porto, DynamoZ, DynamoK, PSG);
                a.WriteTable(dataGridView8, Porto, a.k1);
                a.WriteTable(dataGridView8, DynamoZ, a.k2);
                a.WriteTable(dataGridView8, DynamoK, a.k3);
                a.WriteTable(dataGridView8, PSG, a.k4);
                a.Save(mas8, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas1, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "Порту";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Динамо З.";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Динамо К.";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "ПСЖ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas2, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "Монпельє";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Арсенал";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Олімпіакос";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "Шальке";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas3, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "Зеніт";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Малага";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Андерлехт";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "Мілан";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas4, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "Аякс";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Борусія Д.";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Манчестер Сіті";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "Реал Мадрид";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas5, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "Нордшелланд";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Шахтар";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Ювентус";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "Челсі";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas6, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "БАТЕ";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Лілль";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Валенсія";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "Баварія";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas7, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "Спартак М.";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Барселона";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Бенфіка";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "Селтік";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Table a = new Table();
            a.Nul(numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            a.ShowRes(mas8, numericUpDown1, numericUpDown2, numericUpDown3, numericUpDown4, numericUpDown5, numericUpDown6, numericUpDown7, numericUpDown8, numericUpDown9, numericUpDown10, numericUpDown11, numericUpDown12, numericUpDown13, numericUpDown14, numericUpDown15, numericUpDown16, numericUpDown17, numericUpDown18, numericUpDown19, numericUpDown20, numericUpDown21, numericUpDown22, numericUpDown23, numericUpDown24);
            label8.Text = label1.Text = label10.Text = label13.Text = label20.Text = label23.Text = "Галатасарай";
            label5.Text = label2.Text = label12.Text = label15.Text = label19.Text = label22.Text = "Ман. Юнайтед";
            label6.Text = label3.Text = label9.Text = label14.Text = label18.Text = label21.Text = "Клуж";
            label7.Text = label4.Text = label11.Text = label16.Text = label17.Text = label24.Text = "Брага";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }

        
    }
}
