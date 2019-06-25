using System;
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
        List<Bloczek> Bloki = new List<Bloczek>();
        Hak hak;
        public Form1()
        {
            InitializeComponent();
            int dzwigWysokosc = 450;
            int dzwigSzerokosc = 10;
            int dzwigDlugosc = 500;
            int bloczekRozmiar = 50;
            int hakRozmiar = 5;
            hak.x = 75;
            hak.y = 150;
            int[] wagi = { 10, 50, 20, 30, 100, 15, 40, 40, 10};
            for(int i = 0; i < 9; i++)
            {
                Bloczek bloczek = new Bloczek();
                bloczek.x = 50 + i * 50 + i * 10;
                bloczek.y = panel1.Height - bloczekRozmiar;
                bloczek.waga = wagi[i];
                Bloki.Add(bloczek);
            }
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
