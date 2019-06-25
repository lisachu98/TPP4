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
        List<Bloczek> Bloki = new List<Bloczek>();
        public Form1()
        {
            InitializeComponent();
            int rozmiarBloczka = 50;
            int[] wagi = { 10, 50, 20, 30, 100, 15, 40, 40, 10};
            for(int i = 0; i < 9; i++)
            {
                Bloczek bloczek = new Bloczek();
                bloczek.x = 70 + i * 50 + i * 10;
                bloczek.y = panel1.Height - rozmiarBloczka;
                bloczek.waga = wagi[i];
                Bloki.Add(bloczek);
            }
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
