using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Atestat_Vapoare
{
    public partial class Form1 : Form
    {
        int dimensiune_casuta = 25;
        int casute = 10;
        PictureBox[,] tabla1 = new PictureBox[10, 10];
        PictureBox[,] tabla2 = new PictureBox[10, 10];
        int contur = 6;

        int border = 30;
        int border_2 = 390;


        int[,] a = new int[10, 10];
        int[,] b = new int[10, 10];
        int nr_vap = 0, vs = 0, nr_vap_calc = 0, vs_calc = 0, lc, cc;

        public void Deseneaza1()
        {
            int coord_top = 30;
            int coord_left = 30;

            for (int i = 0; i < casute; i++)
            {
                for (int j = 0; j < casute; j++)
                {
                    tabla1[i, j] = new PictureBox();
                    tabla1[i, j].Top = coord_top;
                    tabla1[i, j].Left = coord_left;
                    tabla1[i, j].BackColor = Color.White;
                    tabla1[i, j].Height = tabla1[i, j].Width = dimensiune_casuta;

                    this.Controls.Add(tabla1[i, j]);
                    coord_left += dimensiune_casuta + contur;
                    if (coord_left > this.Width - border)
                        this.Width = coord_left + border + dimensiune_casuta;
                }
                coord_left = border;
                coord_top += dimensiune_casuta + contur;
                if (coord_top > this.Height - border)
                    this.Height = coord_top + border + dimensiune_casuta;
            }
            int border_2 = tabla1[0, casute - 1].Left + border + dimensiune_casuta;
            coord_top = border;
            coord_left = border_2;
            this.tabla1[0, 0].Click += new System.EventHandler(this.tabla1_00_Click);
            this.tabla1[0, 1].Click += new System.EventHandler(this.tabla1_01_Click);
            this.tabla1[0, 2].Click += new System.EventHandler(this.tabla1_02_Click);
            this.tabla1[0, 3].Click += new System.EventHandler(this.tabla1_03_Click);
            this.tabla1[0, 4].Click += new System.EventHandler(this.tabla1_04_Click);
            this.tabla1[0, 5].Click += new System.EventHandler(this.tabla1_05_Click);
            this.tabla1[0, 6].Click += new System.EventHandler(this.tabla1_06_Click);
            this.tabla1[0, 7].Click += new System.EventHandler(this.tabla1_07_Click);
            this.tabla1[0, 8].Click += new System.EventHandler(this.tabla1_08_Click);
            this.tabla1[0, 9].Click += new System.EventHandler(this.tabla1_09_Click);
            this.tabla1[1, 0].Click += new System.EventHandler(this.tabla1_10_Click);
            this.tabla1[1, 1].Click += new System.EventHandler(this.tabla1_11_Click);
            this.tabla1[1, 2].Click += new System.EventHandler(this.tabla1_12_Click);
            this.tabla1[1, 3].Click += new System.EventHandler(this.tabla1_13_Click);
            this.tabla1[1, 4].Click += new System.EventHandler(this.tabla1_14_Click);
            this.tabla1[1, 5].Click += new System.EventHandler(this.tabla1_15_Click);
            this.tabla1[1, 6].Click += new System.EventHandler(this.tabla1_16_Click);
            this.tabla1[1, 7].Click += new System.EventHandler(this.tabla1_17_Click);
            this.tabla1[1, 8].Click += new System.EventHandler(this.tabla1_18_Click);
            this.tabla1[1, 9].Click += new System.EventHandler(this.tabla1_19_Click);
            this.tabla1[2, 0].Click += new System.EventHandler(this.tabla1_20_Click);
            this.tabla1[2, 1].Click += new System.EventHandler(this.tabla1_21_Click);
            this.tabla1[2, 2].Click += new System.EventHandler(this.tabla1_22_Click);
            this.tabla1[2, 3].Click += new System.EventHandler(this.tabla1_23_Click);
            this.tabla1[2, 4].Click += new System.EventHandler(this.tabla1_24_Click);
            this.tabla1[2, 5].Click += new System.EventHandler(this.tabla1_25_Click);
            this.tabla1[2, 6].Click += new System.EventHandler(this.tabla1_26_Click);
            this.tabla1[2, 7].Click += new System.EventHandler(this.tabla1_27_Click);
            this.tabla1[2, 8].Click += new System.EventHandler(this.tabla1_28_Click);
            this.tabla1[2, 9].Click += new System.EventHandler(this.tabla1_29_Click);
            this.tabla1[3, 0].Click += new System.EventHandler(this.tabla1_30_Click);
            this.tabla1[3, 1].Click += new System.EventHandler(this.tabla1_31_Click);
            this.tabla1[3, 2].Click += new System.EventHandler(this.tabla1_32_Click);
            this.tabla1[3, 3].Click += new System.EventHandler(this.tabla1_33_Click);
            this.tabla1[3, 4].Click += new System.EventHandler(this.tabla1_34_Click);
            this.tabla1[3, 5].Click += new System.EventHandler(this.tabla1_35_Click);
            this.tabla1[3, 6].Click += new System.EventHandler(this.tabla1_36_Click);
            this.tabla1[3, 7].Click += new System.EventHandler(this.tabla1_37_Click);
            this.tabla1[3, 8].Click += new System.EventHandler(this.tabla1_38_Click);
            this.tabla1[3, 9].Click += new System.EventHandler(this.tabla1_39_Click);
            this.tabla1[4, 0].Click += new System.EventHandler(this.tabla1_40_Click);
            this.tabla1[4, 1].Click += new System.EventHandler(this.tabla1_41_Click);
            this.tabla1[4, 2].Click += new System.EventHandler(this.tabla1_42_Click);
            this.tabla1[4, 3].Click += new System.EventHandler(this.tabla1_43_Click);
            this.tabla1[4, 4].Click += new System.EventHandler(this.tabla1_44_Click);
            this.tabla1[4, 5].Click += new System.EventHandler(this.tabla1_45_Click);
            this.tabla1[4, 6].Click += new System.EventHandler(this.tabla1_46_Click);
            this.tabla1[4, 7].Click += new System.EventHandler(this.tabla1_47_Click);
            this.tabla1[4, 8].Click += new System.EventHandler(this.tabla1_48_Click);
            this.tabla1[4, 9].Click += new System.EventHandler(this.tabla1_49_Click);
            this.tabla1[5, 0].Click += new System.EventHandler(this.tabla1_50_Click);
            this.tabla1[5, 1].Click += new System.EventHandler(this.tabla1_51_Click);
            this.tabla1[5, 2].Click += new System.EventHandler(this.tabla1_52_Click);
            this.tabla1[5, 3].Click += new System.EventHandler(this.tabla1_53_Click);
            this.tabla1[5, 4].Click += new System.EventHandler(this.tabla1_54_Click);
            this.tabla1[5, 5].Click += new System.EventHandler(this.tabla1_55_Click);
            this.tabla1[5, 6].Click += new System.EventHandler(this.tabla1_56_Click);
            this.tabla1[5, 7].Click += new System.EventHandler(this.tabla1_57_Click);
            this.tabla1[5, 8].Click += new System.EventHandler(this.tabla1_58_Click);
            this.tabla1[5, 9].Click += new System.EventHandler(this.tabla1_59_Click);
            this.tabla1[6, 0].Click += new System.EventHandler(this.tabla1_60_Click);
            this.tabla1[6, 1].Click += new System.EventHandler(this.tabla1_61_Click);
            this.tabla1[6, 2].Click += new System.EventHandler(this.tabla1_62_Click);
            this.tabla1[6, 3].Click += new System.EventHandler(this.tabla1_63_Click);
            this.tabla1[6, 4].Click += new System.EventHandler(this.tabla1_64_Click);
            this.tabla1[6, 5].Click += new System.EventHandler(this.tabla1_65_Click);
            this.tabla1[6, 6].Click += new System.EventHandler(this.tabla1_66_Click);
            this.tabla1[6, 7].Click += new System.EventHandler(this.tabla1_67_Click);
            this.tabla1[6, 8].Click += new System.EventHandler(this.tabla1_68_Click);
            this.tabla1[6, 9].Click += new System.EventHandler(this.tabla1_69_Click);
            this.tabla1[7, 0].Click += new System.EventHandler(this.tabla1_70_Click);
            this.tabla1[7, 1].Click += new System.EventHandler(this.tabla1_71_Click);
            this.tabla1[7, 2].Click += new System.EventHandler(this.tabla1_72_Click);
            this.tabla1[7, 3].Click += new System.EventHandler(this.tabla1_73_Click);
            this.tabla1[7, 4].Click += new System.EventHandler(this.tabla1_74_Click);
            this.tabla1[7, 5].Click += new System.EventHandler(this.tabla1_75_Click);
            this.tabla1[7, 6].Click += new System.EventHandler(this.tabla1_76_Click);
            this.tabla1[7, 7].Click += new System.EventHandler(this.tabla1_77_Click);
            this.tabla1[7, 8].Click += new System.EventHandler(this.tabla1_78_Click);
            this.tabla1[7, 9].Click += new System.EventHandler(this.tabla1_79_Click);
            this.tabla1[8, 0].Click += new System.EventHandler(this.tabla1_80_Click);
            this.tabla1[8, 1].Click += new System.EventHandler(this.tabla1_81_Click);
            this.tabla1[8, 2].Click += new System.EventHandler(this.tabla1_82_Click);
            this.tabla1[8, 3].Click += new System.EventHandler(this.tabla1_83_Click);
            this.tabla1[8, 4].Click += new System.EventHandler(this.tabla1_84_Click);
            this.tabla1[8, 5].Click += new System.EventHandler(this.tabla1_85_Click);
            this.tabla1[8, 6].Click += new System.EventHandler(this.tabla1_86_Click);
            this.tabla1[8, 7].Click += new System.EventHandler(this.tabla1_87_Click);
            this.tabla1[8, 8].Click += new System.EventHandler(this.tabla1_88_Click);
            this.tabla1[8, 9].Click += new System.EventHandler(this.tabla1_89_Click);
            this.tabla1[8, 0].Click += new System.EventHandler(this.tabla1_90_Click);
            this.tabla1[9, 1].Click += new System.EventHandler(this.tabla1_91_Click);
            this.tabla1[9, 2].Click += new System.EventHandler(this.tabla1_92_Click);
            this.tabla1[9, 3].Click += new System.EventHandler(this.tabla1_93_Click);
            this.tabla1[9, 4].Click += new System.EventHandler(this.tabla1_94_Click);
            this.tabla1[9, 5].Click += new System.EventHandler(this.tabla1_95_Click);
            this.tabla1[9, 6].Click += new System.EventHandler(this.tabla1_96_Click);
            this.tabla1[9, 7].Click += new System.EventHandler(this.tabla1_97_Click);
            this.tabla1[9, 8].Click += new System.EventHandler(this.tabla1_98_Click);
            this.tabla1[9, 9].Click += new System.EventHandler(this.tabla1_99_Click);
        }

        public void Deseneaza2()
        {


            int coord_top = border;
            int coord_left = border_2;
            for (int i = 0; i < casute; i++)
            {
                for (int j = 0; j < casute; j++)
                {
                    tabla2[i, j] = new PictureBox();
                    tabla2[i, j].Top = coord_top;
                    tabla2[i, j].Left = coord_left;
                    tabla2[i, j].BackColor = Color.White;
                    tabla2[i, j].Height = tabla2[i, j].Width = dimensiune_casuta;
                    this.Controls.Add(tabla2[i, j]);
                    coord_left += dimensiune_casuta + contur;
                    if (coord_left > this.Width - border)
                        this.Width = coord_left + border + dimensiune_casuta;

                }
                coord_left = border_2;
                coord_top += dimensiune_casuta + contur;
                if (coord_top > this.Height - border)
                    this.Height = coord_top + border + dimensiune_casuta;

            }
            this.tabla2[0, 0].Click += new System.EventHandler(this.tabla2_00_Click);
            this.tabla2[0, 1].Click += new System.EventHandler(this.tabla2_01_Click);
            this.tabla2[0, 2].Click += new System.EventHandler(this.tabla2_02_Click);
            this.tabla2[0, 3].Click += new System.EventHandler(this.tabla2_03_Click);
            this.tabla2[0, 4].Click += new System.EventHandler(this.tabla2_04_Click);
            this.tabla2[0, 5].Click += new System.EventHandler(this.tabla2_05_Click);
            this.tabla2[0, 6].Click += new System.EventHandler(this.tabla2_06_Click);
            this.tabla2[0, 7].Click += new System.EventHandler(this.tabla2_07_Click);
            this.tabla2[0, 8].Click += new System.EventHandler(this.tabla2_08_Click);
            this.tabla2[0, 9].Click += new System.EventHandler(this.tabla2_09_Click);
            this.tabla2[1, 0].Click += new System.EventHandler(this.tabla2_10_Click);
            this.tabla2[1, 1].Click += new System.EventHandler(this.tabla2_11_Click);
            this.tabla2[1, 2].Click += new System.EventHandler(this.tabla2_12_Click);
            this.tabla2[1, 3].Click += new System.EventHandler(this.tabla2_13_Click);
            this.tabla2[1, 4].Click += new System.EventHandler(this.tabla2_14_Click);
            this.tabla2[1, 5].Click += new System.EventHandler(this.tabla2_15_Click);
            this.tabla2[1, 6].Click += new System.EventHandler(this.tabla2_16_Click);
            this.tabla2[1, 7].Click += new System.EventHandler(this.tabla2_17_Click);
            this.tabla2[1, 8].Click += new System.EventHandler(this.tabla2_18_Click);
            this.tabla2[1, 9].Click += new System.EventHandler(this.tabla2_19_Click);
            this.tabla2[2, 0].Click += new System.EventHandler(this.tabla2_20_Click);
            this.tabla2[2, 1].Click += new System.EventHandler(this.tabla2_21_Click);
            this.tabla2[2, 2].Click += new System.EventHandler(this.tabla2_22_Click);
            this.tabla2[2, 3].Click += new System.EventHandler(this.tabla2_23_Click);
            this.tabla2[2, 4].Click += new System.EventHandler(this.tabla2_24_Click);
            this.tabla2[2, 5].Click += new System.EventHandler(this.tabla2_25_Click);
            this.tabla2[2, 6].Click += new System.EventHandler(this.tabla2_26_Click);
            this.tabla2[2, 7].Click += new System.EventHandler(this.tabla2_27_Click);
            this.tabla2[2, 8].Click += new System.EventHandler(this.tabla2_28_Click);
            this.tabla2[2, 9].Click += new System.EventHandler(this.tabla2_29_Click);
            this.tabla2[3, 0].Click += new System.EventHandler(this.tabla2_30_Click);
            this.tabla2[3, 1].Click += new System.EventHandler(this.tabla2_31_Click);
            this.tabla2[3, 2].Click += new System.EventHandler(this.tabla2_32_Click);
            this.tabla2[3, 3].Click += new System.EventHandler(this.tabla2_33_Click);
            this.tabla2[3, 4].Click += new System.EventHandler(this.tabla2_34_Click);
            this.tabla2[3, 5].Click += new System.EventHandler(this.tabla2_35_Click);
            this.tabla2[3, 6].Click += new System.EventHandler(this.tabla2_36_Click);
            this.tabla2[3, 7].Click += new System.EventHandler(this.tabla2_37_Click);
            this.tabla2[3, 8].Click += new System.EventHandler(this.tabla2_38_Click);
            this.tabla2[3, 9].Click += new System.EventHandler(this.tabla2_39_Click);
            this.tabla2[4, 0].Click += new System.EventHandler(this.tabla2_40_Click);
            this.tabla2[4, 1].Click += new System.EventHandler(this.tabla2_41_Click);
            this.tabla2[4, 2].Click += new System.EventHandler(this.tabla2_42_Click);
            this.tabla2[4, 3].Click += new System.EventHandler(this.tabla2_43_Click);
            this.tabla2[4, 4].Click += new System.EventHandler(this.tabla2_44_Click);
            this.tabla2[4, 5].Click += new System.EventHandler(this.tabla2_45_Click);
            this.tabla2[4, 6].Click += new System.EventHandler(this.tabla2_46_Click);
            this.tabla2[4, 7].Click += new System.EventHandler(this.tabla2_47_Click);
            this.tabla2[4, 8].Click += new System.EventHandler(this.tabla2_48_Click);
            this.tabla2[4, 9].Click += new System.EventHandler(this.tabla2_49_Click);
            this.tabla2[5, 0].Click += new System.EventHandler(this.tabla2_50_Click);
            this.tabla2[5, 1].Click += new System.EventHandler(this.tabla2_51_Click);
            this.tabla2[5, 2].Click += new System.EventHandler(this.tabla2_52_Click);
            this.tabla2[5, 3].Click += new System.EventHandler(this.tabla2_53_Click);
            this.tabla2[5, 4].Click += new System.EventHandler(this.tabla2_54_Click);
            this.tabla2[5, 5].Click += new System.EventHandler(this.tabla2_55_Click);
            this.tabla2[5, 6].Click += new System.EventHandler(this.tabla2_56_Click);
            this.tabla2[5, 7].Click += new System.EventHandler(this.tabla2_57_Click);
            this.tabla2[5, 8].Click += new System.EventHandler(this.tabla2_58_Click);
            this.tabla2[5, 9].Click += new System.EventHandler(this.tabla2_59_Click);
            this.tabla2[6, 0].Click += new System.EventHandler(this.tabla2_60_Click);
            this.tabla2[6, 1].Click += new System.EventHandler(this.tabla2_61_Click);
            this.tabla2[6, 2].Click += new System.EventHandler(this.tabla2_62_Click);
            this.tabla2[6, 3].Click += new System.EventHandler(this.tabla2_63_Click);
            this.tabla2[6, 4].Click += new System.EventHandler(this.tabla2_64_Click);
            this.tabla2[6, 5].Click += new System.EventHandler(this.tabla2_65_Click);
            this.tabla2[6, 6].Click += new System.EventHandler(this.tabla2_66_Click);
            this.tabla2[6, 7].Click += new System.EventHandler(this.tabla2_67_Click);
            this.tabla2[6, 8].Click += new System.EventHandler(this.tabla2_68_Click);
            this.tabla2[6, 9].Click += new System.EventHandler(this.tabla2_69_Click);
            this.tabla2[7, 0].Click += new System.EventHandler(this.tabla2_70_Click);
            this.tabla2[7, 1].Click += new System.EventHandler(this.tabla2_71_Click);
            this.tabla2[7, 2].Click += new System.EventHandler(this.tabla2_72_Click);
            this.tabla2[7, 3].Click += new System.EventHandler(this.tabla2_73_Click);
            this.tabla2[7, 4].Click += new System.EventHandler(this.tabla2_74_Click);
            this.tabla2[7, 5].Click += new System.EventHandler(this.tabla2_75_Click);
            this.tabla2[7, 6].Click += new System.EventHandler(this.tabla2_76_Click);
            this.tabla2[7, 7].Click += new System.EventHandler(this.tabla2_77_Click);
            this.tabla2[7, 8].Click += new System.EventHandler(this.tabla2_78_Click);
            this.tabla2[7, 9].Click += new System.EventHandler(this.tabla2_79_Click);
            this.tabla2[8, 0].Click += new System.EventHandler(this.tabla2_80_Click);
            this.tabla2[8, 1].Click += new System.EventHandler(this.tabla2_81_Click);
            this.tabla2[8, 2].Click += new System.EventHandler(this.tabla2_82_Click);
            this.tabla2[8, 3].Click += new System.EventHandler(this.tabla2_83_Click);
            this.tabla2[8, 4].Click += new System.EventHandler(this.tabla2_84_Click);
            this.tabla2[8, 5].Click += new System.EventHandler(this.tabla2_85_Click);
            this.tabla2[8, 6].Click += new System.EventHandler(this.tabla2_86_Click);
            this.tabla2[8, 7].Click += new System.EventHandler(this.tabla2_87_Click);
            this.tabla2[8, 8].Click += new System.EventHandler(this.tabla2_88_Click);
            this.tabla2[8, 9].Click += new System.EventHandler(this.tabla2_89_Click);
            this.tabla2[9, 0].Click += new System.EventHandler(this.tabla2_90_Click);
            this.tabla2[9, 1].Click += new System.EventHandler(this.tabla2_91_Click);
            this.tabla2[9, 2].Click += new System.EventHandler(this.tabla2_92_Click);
            this.tabla2[9, 3].Click += new System.EventHandler(this.tabla2_93_Click);
            this.tabla2[9, 4].Click += new System.EventHandler(this.tabla2_94_Click);
            this.tabla2[9, 5].Click += new System.EventHandler(this.tabla2_95_Click);
            this.tabla2[9, 6].Click += new System.EventHandler(this.tabla2_96_Click);
            this.tabla2[9, 7].Click += new System.EventHandler(this.tabla2_97_Click);
            this.tabla2[9, 8].Click += new System.EventHandler(this.tabla2_98_Click);
            this.tabla2[9, 9].Click += new System.EventHandler(this.tabla2_99_Click);

        }
        public Form1()
        {
            InitializeComponent();


        }
        private void tabla1_00_Click(object sender, EventArgs e)
        {
            tabla1[0, 0].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_01_Click(object sender, EventArgs e)
        {
            tabla1[0, 1].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_02_Click(object sender, EventArgs e)
        {
            tabla1[0, 2].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_03_Click(object sender, EventArgs e)
        {
            tabla1[0, 3].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_04_Click(object sender, EventArgs e)
        {
            tabla1[0, 4].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_05_Click(object sender, EventArgs e)
        {
            tabla1[0, 5].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_06_Click(object sender, EventArgs e)
        {
            tabla1[0, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_07_Click(object sender, EventArgs e)
        {
            tabla1[0, 7].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_08_Click(object sender, EventArgs e)
        {
            tabla1[0, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_09_Click(object sender, EventArgs e)
        {
            tabla1[0, 9].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_10_Click(object sender, EventArgs e)
        {
            tabla1[1, 0].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_11_Click(object sender, EventArgs e)
        {
            tabla1[1, 1].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_12_Click(object sender, EventArgs e)
        {
            tabla1[1, 2].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_13_Click(object sender, EventArgs e)
        {
            tabla1[1, 3].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_14_Click(object sender, EventArgs e)
        {
            tabla1[1, 4].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_15_Click(object sender, EventArgs e)
        {
            tabla1[1, 5].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_16_Click(object sender, EventArgs e)
        {
            tabla1[1, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_17_Click(object sender, EventArgs e)
        {
            tabla1[1, 7].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_18_Click(object sender, EventArgs e)
        {
            tabla1[1, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_19_Click(object sender, EventArgs e)
        {
            tabla1[1, 9].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_20_Click(object sender, EventArgs e)
        {
            tabla1[2, 0].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_21_Click(object sender, EventArgs e)
        {
            tabla1[2, 1].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_22_Click(object sender, EventArgs e)
        {
            tabla1[2, 2].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_23_Click(object sender, EventArgs e)
        {
            tabla1[2, 3].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_24_Click(object sender, EventArgs e)
        {
            tabla1[2, 4].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_25_Click(object sender, EventArgs e)
        {
            tabla1[2, 5].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_26_Click(object sender, EventArgs e)
        {
            tabla1[2, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_27_Click(object sender, EventArgs e)
        {
            tabla1[2, 7].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_28_Click(object sender, EventArgs e)
        {
            tabla1[2, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_29_Click(object sender, EventArgs e)
        {
            tabla1[2, 9].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_30_Click(object sender, EventArgs e)
        {
            tabla1[3, 0].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_31_Click(object sender, EventArgs e)
        {
            tabla1[3, 1].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_32_Click(object sender, EventArgs e)
        {
            tabla1[3, 2].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_33_Click(object sender, EventArgs e)
        {
            tabla1[3, 3].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_34_Click(object sender, EventArgs e)
        {
            tabla1[3, 4].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_35_Click(object sender, EventArgs e)
        {
            tabla1[3, 5].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_36_Click(object sender, EventArgs e)
        {
            tabla1[3, 6].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_37_Click(object sender, EventArgs e)
        {
            tabla1[3, 7].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_38_Click(object sender, EventArgs e)
        {
            tabla1[3, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_39_Click(object sender, EventArgs e)
        {
            tabla1[3, 9].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_40_Click(object sender, EventArgs e)
        {
            tabla1[4, 0].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_41_Click(object sender, EventArgs e)
        {
            tabla1[4, 1].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_42_Click(object sender, EventArgs e)
        {
            tabla1[4, 2].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_43_Click(object sender, EventArgs e)
        {
            tabla1[4, 3].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_44_Click(object sender, EventArgs e)
        {
            tabla1[4, 4].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_45_Click(object sender, EventArgs e)
        {
            tabla1[4, 5].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_46_Click(object sender, EventArgs e)
        {
            tabla1[4, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_47_Click(object sender, EventArgs e)
        {
            tabla1[4, 7].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_48_Click(object sender, EventArgs e)
        {
            tabla1[4, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_49_Click(object sender, EventArgs e)
        {
            tabla1[4, 9].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }

        private void tabla1_50_Click(object sender, EventArgs e)
        {
            tabla1[5, 0].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_51_Click(object sender, EventArgs e)
        {
            tabla1[5, 1].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_52_Click(object sender, EventArgs e)
        {
            tabla1[5, 2].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_53_Click(object sender, EventArgs e)
        {
            tabla1[5, 3].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_54_Click(object sender, EventArgs e)
        {
            tabla1[5, 4].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_55_Click(object sender, EventArgs e)
        {
            tabla1[5, 5].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_56_Click(object sender, EventArgs e)
        {
            tabla1[5, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_57_Click(object sender, EventArgs e)
        {
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;
            tabla1[5, 7].BackColor = Color.Black;


        }
        private void tabla1_58_Click(object sender, EventArgs e)
        {
            tabla1[5, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_59_Click(object sender, EventArgs e)
        {
            tabla1[5, 9].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_60_Click(object sender, EventArgs e)
        {
            tabla1[6, 0].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_61_Click(object sender, EventArgs e)
        {
            tabla1[6, 1].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_62_Click(object sender, EventArgs e)
        {
            tabla1[6, 2].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_63_Click(object sender, EventArgs e)
        {
            tabla1[6, 3].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_64_Click(object sender, EventArgs e)
        {
            tabla1[6, 4].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_65_Click(object sender, EventArgs e)
        {
            tabla1[6, 5].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_66_Click(object sender, EventArgs e)
        {
            tabla1[6, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_67_Click(object sender, EventArgs e)
        {
            tabla1[6, 7].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_68_Click(object sender, EventArgs e)
        {
            tabla1[6, 8].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_69_Click(object sender, EventArgs e)
        {
            tabla1[6, 9].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_70_Click(object sender, EventArgs e)
        {
            tabla1[7, 0].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_71_Click(object sender, EventArgs e)
        {
            tabla1[7, 1].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_72_Click(object sender, EventArgs e)
        {
            tabla1[7, 2].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_73_Click(object sender, EventArgs e)
        {
            tabla1[7, 3].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_74_Click(object sender, EventArgs e)
        {
            tabla1[7, 4].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_75_Click(object sender, EventArgs e)
        {
            tabla1[7, 5].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_76_Click(object sender, EventArgs e)
        {
            tabla1[7, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_77_Click(object sender, EventArgs e)
        {
            tabla1[7, 7].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_78_Click(object sender, EventArgs e)
        {
            tabla1[7, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_79_Click(object sender, EventArgs e)
        {
            tabla1[7, 9].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_80_Click(object sender, EventArgs e)
        {
            tabla1[8, 0].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_81_Click(object sender, EventArgs e)
        {
            tabla1[8, 1].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_82_Click(object sender, EventArgs e)
        {
            tabla1[8, 2].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_83_Click(object sender, EventArgs e)
        {
            tabla1[8, 3].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_84_Click(object sender, EventArgs e)
        {
            tabla1[8, 4].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_85_Click(object sender, EventArgs e)
        {
            tabla1[8, 5].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_86_Click(object sender, EventArgs e)
        {
            tabla1[8, 6].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_87_Click(object sender, EventArgs e)
        {
            tabla1[8, 7].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_88_Click(object sender, EventArgs e)
        {
            tabla1[8, 8].BackColor = Color.Black;


            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_89_Click(object sender, EventArgs e)
        {
            tabla1[8, 9].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_90_Click(object sender, EventArgs e)
        {
            tabla1[9, 0].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_91_Click(object sender, EventArgs e)
        {
            tabla1[9, 1].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_92_Click(object sender, EventArgs e)
        {
            tabla1[9, 2].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_93_Click(object sender, EventArgs e)
        {
            tabla1[9, 3].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_94_Click(object sender, EventArgs e)
        {
            tabla1[9, 4].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_95_Click(object sender, EventArgs e)
        {
            tabla1[9, 5].BackColor = Color.Black;

            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;

        }
        private void tabla1_96_Click(object sender, EventArgs e)
        {
            tabla1[9, 6].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_97_Click(object sender, EventArgs e)
        {
            tabla1[9, 7].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;


        }
        private void tabla1_98_Click(object sender, EventArgs e)
        {
            tabla1[9, 8].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;



        }
        private void tabla1_99_Click(object sender, EventArgs e)
        {
            tabla1[9, 9].BackColor = Color.Black;
            nr_vap++;
            if (nr_vap == 12) for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        tabla1[i, j].Enabled = false;
        }

        private void tabla2_00_Click(object sender, EventArgs e)
        {
            int l = 0, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_01_Click(object sender, EventArgs e)
        {
            int l = 0, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_02_Click(object sender, EventArgs e)
        {
            int l = 0, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_03_Click(object sender, EventArgs e)
        {
            int l = 0, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_04_Click(object sender, EventArgs e)
        {
            int l = 0, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_05_Click(object sender, EventArgs e)
        {
            int l = 0, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_06_Click(object sender, EventArgs e)
        {
            int l = 0, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_07_Click(object sender, EventArgs e)
        {
            int l = 0, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_08_Click(object sender, EventArgs e)
        {
            int l = 0, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_09_Click(object sender, EventArgs e)
        {
            int l = 0, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_10_Click(object sender, EventArgs e)
        {
            int l = 1, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_11_Click(object sender, EventArgs e)
        {
            int l = 1, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_12_Click(object sender, EventArgs e)
        {
            int l = 1, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_13_Click(object sender, EventArgs e)
        {
            int l = 1, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_14_Click(object sender, EventArgs e)
        {
            int l = 1, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_15_Click(object sender, EventArgs e)
        {
            int l = 1, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_16_Click(object sender, EventArgs e)
        {
            int l = 1, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_17_Click(object sender, EventArgs e)
        {
            int l = 1, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_18_Click(object sender, EventArgs e)
        {
            int l = 1, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_19_Click(object sender, EventArgs e)
        {
            int l = 1, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_20_Click(object sender, EventArgs e)
        {
            int l = 2, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;        
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_21_Click(object sender, EventArgs e)
        {
            int l = 2, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_22_Click(object sender, EventArgs e)
        {
            int l = 2, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_23_Click(object sender, EventArgs e)
        {
            int l = 2, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_24_Click(object sender, EventArgs e)
        {
            int l = 2, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_25_Click(object sender, EventArgs e)
        {
            int l = 2, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_26_Click(object sender, EventArgs e)
        {
            int l = 2, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_27_Click(object sender, EventArgs e)
        {
            int l = 2, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_28_Click(object sender, EventArgs e)
        {
            int l = 2, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_29_Click(object sender, EventArgs e)
        {
            int l = 2, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_30_Click(object sender, EventArgs e)
        {
            int l = 3, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_31_Click(object sender, EventArgs e)
        {
            int l = 3, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_32_Click(object sender, EventArgs e)
        {
            int l = 3, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_33_Click(object sender, EventArgs e)
        {
            int l = 3, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_34_Click(object sender, EventArgs e)
        {
            int l = 3, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_35_Click(object sender, EventArgs e)
        {
            int l = 3, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_36_Click(object sender, EventArgs e)
        {
            int l = 3, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_37_Click(object sender, EventArgs e)
        {
            int l = 3, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_38_Click(object sender, EventArgs e)
        {
            int l = 3, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_39_Click(object sender, EventArgs e)
        {
            int l = 3, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_40_Click(object sender, EventArgs e)
        {
            int l = 4, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_41_Click(object sender, EventArgs e)
        {
            int l = 4, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_42_Click(object sender, EventArgs e)
        {
            int l = 4, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_43_Click(object sender, EventArgs e)
        {
            int l = 4, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_44_Click(object sender, EventArgs e)
        {
            int l = 4, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_45_Click(object sender, EventArgs e)
        {
            int l = 4, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_46_Click(object sender, EventArgs e)
        {
            int l = 4, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_47_Click(object sender, EventArgs e)
        {
            int l = 4, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_48_Click(object sender, EventArgs e)
        {
            int l = 4, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_49_Click(object sender, EventArgs e)
        {
            int l = 4, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_50_Click(object sender, EventArgs e)
        {
            int l = 5, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_51_Click(object sender, EventArgs e)
        {
            int l = 5, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_52_Click(object sender, EventArgs e)
        {
            int l = 5, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_53_Click(object sender, EventArgs e)
        {
            int l = 5, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_54_Click(object sender, EventArgs e)
        {
            int l = 5, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_55_Click(object sender, EventArgs e)
        {
            int l = 5, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_56_Click(object sender, EventArgs e)
        {
            int l = 5, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_57_Click(object sender, EventArgs e)
        {
            int l = 5, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_58_Click(object sender, EventArgs e)
        {
            int l = 5, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_59_Click(object sender, EventArgs e)
        {
            int l = 5, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_60_Click(object sender, EventArgs e)
        {
            int l = 6, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_61_Click(object sender, EventArgs e)
        {
            int l = 6, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_62_Click(object sender, EventArgs e)
        {
            int l = 6, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_63_Click(object sender, EventArgs e)
        {
            int l = 6, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_64_Click(object sender, EventArgs e)
        {
            int l = 6, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_65_Click(object sender, EventArgs e)
        {
            int l = 6, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_66_Click(object sender, EventArgs e)
        {
            int l = 6, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_67_Click(object sender, EventArgs e)
        {
            int l = 6, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_68_Click(object sender, EventArgs e)
        {
            int l = 6, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; ;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_69_Click(object sender, EventArgs e)
        {
            int l = 6, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_70_Click(object sender, EventArgs e)
        {
            int l = 7, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_71_Click(object sender, EventArgs e)
        {
            int l = 7, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_72_Click(object sender, EventArgs e)
        {
            int l = 7, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_73_Click(object sender, EventArgs e)
        {
            int l = 7, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_74_Click(object sender, EventArgs e)
        {
            int l = 7, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_75_Click(object sender, EventArgs e)
        {
            int l = 7, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_76_Click(object sender, EventArgs e)
        {
            int l = 7, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_77_Click(object sender, EventArgs e)
        {
            int l = 7, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_78_Click(object sender, EventArgs e)
        {
            int l = 7, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_79_Click(object sender, EventArgs e)
        {
            int l = 7, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 2, c] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_80_Click(object sender, EventArgs e)
        {
            int l = 8, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_81_Click(object sender, EventArgs e)
        {
            int l = 8, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_82_Click(object sender, EventArgs e)
        {
            int l = 8, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_83_Click(object sender, EventArgs e)
        {
            int l = 8, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_84_Click(object sender, EventArgs e)
        {
            int l = 8, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; ; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_85_Click(object sender, EventArgs e)
        {
            int l = 8, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_86_Click(object sender, EventArgs e)
        {
            int l = 8, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_87_Click(object sender, EventArgs e)
        {
            int l = 8, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_88_Click(object sender, EventArgs e)
        {
            int l = 8, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l + 1, c + 1] == 2) ct++; if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_89_Click(object sender, EventArgs e)
        {
            int l = 8, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l + 1, c - 1] == 2) ct++;
                if (b[l + 1, c] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_90_Click(object sender, EventArgs e)
        {
            int l = 9, c = 0;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }
        private void tabla2_91_Click(object sender, EventArgs e)
        {
            int l = 9, c = 1;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_92_Click(object sender, EventArgs e)
        {
            int l = 9, c = 2;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_93_Click(object sender, EventArgs e)
        {
            int l = 9, c = 3;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_94_Click(object sender, EventArgs e)
        {
            int l = 9, c = 4;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_95_Click(object sender, EventArgs e)
        {
            int l = 9, c = 5;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_96_Click(object sender, EventArgs e)
        {
            int l = 9, c = 6;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_97_Click(object sender, EventArgs e)
        {
            int l = 9, c = 7;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++; if (b[l, c + 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_98_Click(object sender, EventArgs e)
        {
            int l = 9, c = 8;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l - 1, c + 1] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c + 1] == 2) ct++; if (b[l, c - 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)");
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void tabla2_99_Click(object sender, EventArgs e)
        {
            int l = 9, c = 9;
            if (b[l, c] == 1)
            {
                tabla2[l, c].BackColor = Color.Red; b[l, c] = 2;
                int ct = 1;
                if (b[l - 1, c - 1] == 2) ct++;
                if (b[l - 1, c] == 2) ct++;
                if (b[l, c - 1] == 2) ct++;
                if (b[l, c - 2] == 2) ct++;
                if (b[l - 2, c] == 2) ct++;
                if (ct == 4)
                {
                    MessageBox.Show("Vapor scufundat!"); vs++;
                    if (vs == 3) MessageBox.Show("Trei vapoare scufundate! Ati castigat! :)"); Close();
                }
            }
            else { tabla2[l, c].BackColor = Color.DeepSkyBlue; b[l, c] = 3; }

            tabla2[l, c].Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lc > 0 && cc > 0 && a[lc - 1, cc - 1] == 1) { lc--; cc--; }
            else
                if (lc > 0 && a[lc - 1, cc] == 1) lc--;
            else
                    if (lc > 0 && cc < 9 && a[lc - 1, cc + 1] == 1) { lc--; cc++; }
            else
                        if (cc < 9 && a[lc, cc + 1] == 1) cc++;
            else
                            if (lc < 9 && cc < 9 && a[lc + 1, cc + 1] == 1) { lc++; cc++; }
            else
                                if (lc < 9 && a[lc + 1, cc] == 1) lc++;
            else
                                    if (lc < 9 && cc > 0 && a[lc + 1, cc - 1] == 1) { lc++; cc--; }
            else
                                        if (cc > 0 && a[lc, cc - 1] == 1) cc--;
            else
                                            if (lc > 1 && a[lc - 2, cc] == 1) lc = lc - 2;
            else
                                                if (lc < 8 && a[lc + 2, cc] == 1) lc = lc + 2;
            else
                                                    if (cc > 1 && a[lc, cc - 2] == 1) cc = cc - 2;
            else
                                                        if (cc < 8 && a[lc, cc + 2] == 1) cc = cc + 2;
            else
            {
                Random x = new Random();

                do
                {
                    lc = x.Next() % 10;
                    cc = x.Next() % 10;
                } while (a[lc, cc] > 1);
            }

            if (a[lc, cc] == 1)
            {
                a[lc, cc] = 2;
                tabla1[lc, cc].BackColor = Color.Red;
                nr_vap_calc++;
            }
            else
            {
                a[lc, cc] = 3;
                tabla1[lc, cc].BackColor = Color.DeepSkyBlue;
            }



            if (nr_vap_calc == 4)
            {
                vs_calc++; MessageBox.Show("Vapor scufundat!"); nr_vap_calc = 0;
                if (vs_calc == 3) { MessageBox.Show("Toate vapoarele au fost scufundate! Ati pierdut... :("); Close(); }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void aseazaVapoareToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Deseneaza1();
        }

        private void aseazaVapoareCalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int nrfile;

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    b[i, j] = 0;
            Random x = new Random();
            nrfile = 1 + x.Next() % 4;
            string f;
            f = nrfile.ToString() + ".txt";
            StreamReader fin = new StreamReader(f);
            int[] p = new int[101];
            string lin;
            string[] v = new string[10];
            for (int i = 0; i < 10; i++)
            {
                lin = fin.ReadLine();
                v = lin.Split(' ');
                for (int j = 0; j < 10; j++)
                    b[i, j] = Int32.Parse(v[j]);

            }
            Deseneaza2();
        }

        private void startJocToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (tabla1[i, j].BackColor == Color.Black) a[i, j] = 1;
                    else
                        a[i, j] = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
