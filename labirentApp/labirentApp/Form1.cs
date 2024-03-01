using System;

namespace labirentApp
{
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer FailSoundPlayer=new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");

        System.Media.SoundPlayer finishSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");



        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }


        private void finish_MouseEnter(object sender, EventArgs e)
        {
            finishSoundPlayer.Play();
            MessageBox.Show("Tebrikler !!");
            Close();

        }

        private void MoveToStart()
        {
            FailSoundPlayer.Play();
            Point startpoint = panel1.Location;
            startpoint.Offset(18, 552);// offset telafi etmek demek yani baþlangýç noktasýný yeniden düzenliyoruz
            Cursor.Position = PointToScreen(startpoint);//cursor mouse u ifade ediyor imleç demek ,,,saðdaki fonksiyonda istediðin þeyi ekrandaki poszisyona atacak fonk
        }

        private void Wall_mouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
