using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using WMPLib;

namespace Windows_MediaPlayer
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Dataload();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = "D:/M E D I A/M U S I C/Con-Yeu-Dau-Ai-Roi-Di-Duc-Phuc.mp3";

            //axWindowsMediaPlayer1.newMedia ("D:/M E D I A/M U S I C/Con-Yeu-Dau-Ai-Roi-Di-Duc-Phuc.mp3");
            dataGridView1.Hide();
            panelLibrary.Show();
            if (treeView1.Nodes[0].IsSelected == true)
                MessageBox.Show("library");
            if (treeView1.Nodes[0].IsSelected == true)
                MessageBox.Show("Playlist");
            foreach (TreeNode tn in treeView1.Nodes[2].Nodes)
            {
                if (tn.Index==0 && tn.IsSelected)
                    MessageBox.Show("artist");
                if (tn.Index == 1 && tn.IsSelected)

                    MessageBox.Show("albums");

            }
        }

        void Dataload()
        {

        }

  

        private void roundButton1_MouseUp(object sender, MouseEventArgs e)
        {
            //Bitmap image1;
            //image1 = (Bitmap)roundButton1.Image;
            //int x, y;
            //for (x = 0; x < image1.Width; x++)
            //{
            //    for (y = 0; y < image1.Height; y++)
            //    {
            //        Color pixelColor = image1.GetPixel(x, y);
            //        //Color newColor = Color.FromArgb(pixelColor.R, 0, 0);
            //        //Color newColor = Color.Red;
            //        Color newcl = 
            //        image1.SetPixel(x, y, newColor);
            //    }
            //}

        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            Bitmap image;
            image = new Bitmap(imageList2.Images[0]);
            backButton.Image = image;
        }
        Bitmap Change_brightnessbutton(Bitmap b1)
        {
            Bitmap originalImage = b1;
            Bitmap adjustedImage = b1;
            float brightness = 0.8f; // no change in brightness
            float contrast = 2.0f; // twice the contrast
            float gamma = 1.0f; // no change in gamma

            float adjustedBrightness = brightness - 1.0f;
            // create matrix that will brighten and contrast the image
            float[][] ptsArray ={
                new float[] {contrast, 0, 0, 0, 0}, // scale red
                new float[] {0, contrast, 0, 0, 0}, // scale green
                new float[] {0, 0, contrast, 0, 0}, // scale blue
                new float[] {0, 0, 0, 1.0f, 0}, // don't scale alpha
                new float[] {adjustedBrightness, adjustedBrightness, adjustedBrightness, 0, 1}};

            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ptsArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(adjustedImage);
            g.DrawImage(originalImage, new Rectangle(0, 0, adjustedImage.Width, adjustedImage.Height)
                , 0, 0, originalImage.Width, originalImage.Height,
                GraphicsUnit.Pixel, imageAttributes);

            return adjustedImage;
        }
        private void roundButton1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap originalImage = (Bitmap)backButton.Image;
            backButton.Image = Change_brightnessbutton(originalImage);

        }

        private void roundButton2_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap originalImage = (Bitmap)forwardButton.Image;
            forwardButton.Image = Change_brightnessbutton(originalImage);

        }

        private void roundButton2_MouseLeave(object sender, EventArgs e)
        {
            Bitmap image;
            image = new Bitmap(imageList2.Images[1]);
            forwardButton.Image = image;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var playlist = axWindowsMediaPlayer1.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia media;
            OpenFileDialog ofdSong = new OpenFileDialog();
            ofdSong.Multiselect = true;
            if (ofdSong.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofdSong.FileNames)
                {
                    media = axWindowsMediaPlayer1.newMedia(file);
                    playlist.appendItem(media);
                }
            }
            axWindowsMediaPlayer1.currentPlaylist = playlist;
            axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void Stopbt_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
        private bool compare(Bitmap bmp1, Bitmap bmp2)
        {
            bool equals = true;
            bool flag = true;  //Inner loop isn't broken

            //Test to see if we have the same size of image
            if (bmp1.Size == bmp2.Size)
            {
                for (int x = 0; x < bmp1.Width; ++x)
                {
                    for (int y = 0; y < bmp1.Height; ++y)
                    {
                        if (bmp1.GetPixel(x, y) != bmp2.GetPixel(x, y))
                        {
                            equals = false;
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        break;
                    }
                }
            }
            else
            {
                equals = false;
            }
            return equals;
        }
        private void roundButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "D:/M E D I A/M U S I C/Con-Yeu-Dau-Ai-Roi-Di-Duc-Phuc.mp3";
            if (compare((Bitmap)roundButton1.Image, (Bitmap)imageList3.Images[1]) == true)
            {
                roundButton1.Image = imageList3.Images[0];
                axWindowsMediaPlayer1.Ctlcontrols.pause();

            }
            else
            {
                roundButton1.Image = imageList3.Images[1];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage_music managemusicform = new Manage_music();
            managemusicform.Text = "Music Library Location";
            managemusicform.StartPosition = FormStartPosition.CenterScreen;
            managemusicform.ShowDialog();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form formB = new Form();
            formB.MdiParent = this;
            formB.Show();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panelPlaylist.Hide();
            panelLibrary.Show();
        }

        //private void button1_Click_2(object sender, EventArgs e)
        //{
        //    panelLibrary.Hide();
        //    panelPlaylist.Show();
        //}
        //private void Player_PlayStateChange(int NewState)
        //{
        //    if ((WMPLib.WMPPlayState)NewState == WMPLib.WMPPlayState.wmppsStopped)
        //    {
        //        this.Close();
        //    }
        //}

        //private void Player_MediaError(object pMediaObject)
        //{
        //    MessageBox.Show("Cannot play media file.");
        //    this.Close();
        //}
    }
}
