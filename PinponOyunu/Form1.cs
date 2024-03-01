namespace PinponOyunu
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer FailSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Speech Off.wav");
        System.Media.SoundPlayer ScoreSoundPlayer = new System.Media.SoundPlayer(@"C:\Windows\Media\Speech On.wav");
        public int speedleft = 4;
        public int speedtop = 4;
        public int points = 0;//ba�lang�� atamas�
        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            //this.TopMost = true;

            racket.Top = playground.Bottom - (playground.Bottom / 10); //alt k��eden 10da birini ��kar�p raketimin yerini belirliyorum
            gameoverlabel.Left = (playground.Width / 2) - (gameoverlabel.Width / 2);
            gameoverlabel.Top = (playground.Height / 2) - (gameoverlabel.Height / 2);
            gameoverlabel.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - racket.Width / 2;// fareninin pozisyondan raketin pozisyonun yar�s�ndan ��karac���z
            ball.Left += speedleft;
            ball.Top += speedtop;

            if (ball.Left <= playground.Left)
            { //playground zaten en solda onun solundan k���kse eksiye �km�� oluyor
                speedleft = -speedleft;


            }

            if (ball.Right >= playground.Right)
            { //playground zaten en solda onun solundan k���kse eksiye �km�� oluyor
                speedleft = -speedleft;

            }

            if (ball.Top <= playground.Top) { speedtop = -speedtop; }

            if (ball.Bottom >= playground.Bottom)
            {
                FailSoundPlayer.Play();
                gameoverlabel.Visible = true;
                timer1.Enabled = false;

            }
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {

                /* topun alt kenar�,raketin �st kenar�na b�y�k veya e�itse, yani topun en alt k�sm� raketin
                 * �st k�sm�n�n �zerinde veya raketin �st kenar� ile 
                 * ayn� hizada ise.  &&  Topun en alt k�sm�, raketin
                 * en alt kenar�ndan k���k veya e�itse, yani topun en alt k�sm� raketin en alt kenar�
                 * ile ayn� hizada veya raketin alt kenar�n�n �zerinde ise. &&
                 *  ball.Left >= racket.Left: Topun sol kenar�, raketin sol kenar�ndan b�y�k veya e�itse, yani topun sol kenar� raketin sol kenar� ile
                 *  ayn� hizada veya raketin sol kenar�n�n sa��nda ise.      */

                ScoreSoundPlayer.Play();
                speedtop += 2;
                speedleft += 2;
                speedtop = -speedtop;
                points += 1;
                scorelabel2.Text = points.ToString();

                Random r = new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));






            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                this.Close();
                    }

            if(e.KeyCode == Keys.F1)
            {
                ball.Top = 150;
                ball.Left = 150;
                speedleft = 4;
                speedtop = 4;
                points = 0;
                scorelabel2.Text = "0";
                timer1.Enabled = true;
                gameoverlabel.Visible = false;
                playground.BackColor = Color.White;

            }
        }
    }
}

        
    
