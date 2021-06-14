using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();  
        }
        
        private void Form1_Load( object sender, EventArgs e)
        {
            string[] Black = { "C#", "D#", "_", "F#", "G#", "A#", "_", "R#", "K#" };
            string[] White = { "C", "D", "E", "F", "G", "A", "B", "K", "L", "M" };

            Piano mypiano = new Piano();
            mypiano.createBlackKeys(Black, panelPiano); 
            mypiano.createWhiteKey(White, panelPiano);

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == (char)Keys.Z)
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.C);
                player1.Play();
            }
            if (e.KeyValue == (char)Keys.X)
            {
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.D);
                player2.Play();
            }

            if (e.KeyValue == (char)Keys.C) 
            {
                System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.E);
                player3.Play();
            }

            if (e.KeyValue == (char)Keys.V) 
            {
                System.Media.SoundPlayer player4 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.F);
                player4.Play();
            }

            if (e.KeyValue == (char)Keys.B) 
            {
                System.Media.SoundPlayer player5 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.G);
                player5.Play();
            }

            if (e.KeyValue == (char)Keys.N)
            {
                System.Media.SoundPlayer player6 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.A);
                player6.Play();
            }

            if (e.KeyValue == (char)Keys.M) 
            {
                System.Media.SoundPlayer player7 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.B);
                player7.Play();
            }

            if (e.KeyValue == (char)Keys.Oemcomma) 
            {
                System.Media.SoundPlayer player8 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.K);
                player8.Play();
            }

            if (e.KeyValue == (char)Keys.S) 
            {
                System.Media.SoundPlayer player9 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.Cg);
                player9.Play();
            }

            if (e.KeyValue == (char)Keys.D) 
            {
                System.Media.SoundPlayer player10 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.Dg);
                player10.Play();
            }

            if (e.KeyValue == (char)Keys.G) 
            {
                System.Media.SoundPlayer player11 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.Fg);
                player11.Play();
            }

            if (e.KeyValue == (char)Keys.H) 
            {
                System.Media.SoundPlayer player12 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.Gg);
                player12.Play();
            }

            if (e.KeyValue == (char)Keys.J) 
            {
                System.Media.SoundPlayer player13 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.Kg);
                player13.Play();
            }

            if (e.KeyValue == (char)Keys.L) 
            {
                System.Media.SoundPlayer player14 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.L);
                player14.Play();
            }

            if (e.KeyValue == (char)Keys.Oem1) 
            {
                System.Media.SoundPlayer player15 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.M);
                player15.Play();
            }

            if (e.KeyValue == (char)Keys.OemPeriod)
            {
                System.Media.SoundPlayer player16 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.Ag);
                player16.Play();
            }

            if (e.KeyValue == (char)Keys.OemQuestion)
            {
                System.Media.SoundPlayer player17 = new System.Media.SoundPlayer(WindowsFormsApp2.Properties.Resources.Rg);
                player17.Play();
            }
        }
    }
}
