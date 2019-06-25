﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPP4
{
    public partial class Form1 : Form
    {
        public struct Bloczek
        {
            public int x;
            public int y;
            public int waga;
        }
        public struct Hak
        {
            public int x;
            public int y;
            public int maxWaga;
        }
        int dzwigWysokosc = 450;
        int dzwigSzerokosc = 10;
        int dzwigDlugosc = 500;
        int bloczekRozmiar = 40;
        int hakRozmiar = 6;
        List<Bloczek> bloki = new List<Bloczek>();
        Hak hak;
        public Form1()
        {
            InitializeComponent();
            
            hak.x = 72;
            hak.y = 210;
            int[] wagi = { 10, 50, 20, 30, 100, 15, 40, 40, 10};
            for(int i = 0; i < 9; i++)
            {
                Bloczek bloczek = new Bloczek();
                bloczek.x = 70 + i * bloczekRozmiar + i * 10;
                bloczek.y = panel1.Height - bloczekRozmiar;
                bloczek.waga = wagi[i];
                bloki.Add(bloczek);
            }
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {   
            System.Drawing.SolidBrush pen = new System.Drawing.SolidBrush(System.Drawing.Color.Orange);
            Graphics g = panel1.CreateGraphics();
            g.FillRectangle(pen, new Rectangle(panel1.Width / 5 - dzwigSzerokosc - 50, panel1.Height - dzwigWysokosc, dzwigSzerokosc, dzwigWysokosc));
            g.FillRectangle(pen, new Rectangle(panel1.Width / 5 - dzwigSzerokosc - 100, panel1.Height - dzwigWysokosc + 50, dzwigDlugosc, dzwigSzerokosc));
            g.FillRectangle(pen, new Rectangle(hak.x + 4, panel1.Height - dzwigWysokosc + 50 + dzwigSzerokosc, 2, hak.y - (panel1.Height - dzwigWysokosc + 50 + dzwigSzerokosc)));
            pen = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            g.FillRectangle(pen, new Rectangle(hak.x-2, panel1.Height - dzwigWysokosc + 50, dzwigSzerokosc, dzwigSzerokosc));
            pen = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            g.FillRectangle(pen, new Rectangle(hak.x, hak.y, hakRozmiar, hakRozmiar));
            pen = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            for (int i = 0; i < bloki.Count; i++) g.FillRectangle(pen, new Rectangle(bloki[i].x, bloki[i].y, bloczekRozmiar, bloczekRozmiar));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
