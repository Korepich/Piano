using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    class Piano
    {

        public int blackKeyWidht = 42;
        public int blackKeyHight = 180;

        public int WhiteKeyWidht = 55;
        public int WhiteKeyHight = 280;

        public void createBlackKeys(string[] BlackKeyNod, Panel panel)
        {
            for (int i = 0; i < BlackKeyNod.Length; i++)
            {
                if (BlackKeyNod[i] != "_")
                {
                    Button blakey = new Button();
                    blakey.BackColor = Color.Black;
                    blakey.ForeColor = Color.White;

                    blakey.Size = new Size(this.blackKeyWidht, this.blackKeyHight);
                    blakey.Name = BlackKeyNod[i].ToString();
                    int B = blakey.Location.X + (i * this.WhiteKeyWidht) + 30;
                    blakey.Location = new Point(B, blakey.Location.Y);
                    blakey.Text = BlackKeyNod[i];
                    blakey.Click += PlaySound;
                    panel.Controls.Add(blakey);

                }

            }

        }

        public void createWhiteKey(string[] WhiteKeyNod, Panel panel)
        {
            for (int i = 0; i < WhiteKeyNod.Length; i++)
            {
                Button whiteKey = new Button();
                whiteKey.Name = WhiteKeyNod[i].ToString();
                whiteKey.Text = WhiteKeyNod[i];

                whiteKey.TextAlign = ContentAlignment.BottomCenter;
                whiteKey.Size = new Size(this.WhiteKeyWidht, this.WhiteKeyHight);
                int W = whiteKey.Location.X + (i * WhiteKeyWidht);
                whiteKey.Location = new Point(W, whiteKey.Location.Y);
                whiteKey.Click += PlaySound;
                panel.Controls.Add(whiteKey);
            }
        }

         public void PlaySound(object sender, EventArgs e)
         {
             var Btnsound = (Button)sender;
             Stream str = (Stream)Properties.Resources.ResourceManager.GetObject(Btnsound.Name.ToString().Replace("#", "g"));
             SoundPlayer sound = new SoundPlayer(str);
             sound.Play();

         }  

    }
}
