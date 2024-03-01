namespace PinponOyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            playground = new Panel();
            gameoverlabel = new Label();
            scorelabel2 = new Label();
            scorelabel = new Label();
            ball = new PictureBox();
            racket = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)racket).BeginInit();
            SuspendLayout();
            // 
            // playground
            // 
            playground.Controls.Add(gameoverlabel);
            playground.Controls.Add(scorelabel2);
            playground.Controls.Add(scorelabel);
            playground.Controls.Add(ball);
            playground.Controls.Add(racket);
            playground.Dock = DockStyle.Fill;
            playground.Location = new Point(0, 0);
            playground.Name = "playground";
            playground.Size = new Size(1032, 672);
            playground.TabIndex = 0;
            // 
            // gameoverlabel
            // 
            gameoverlabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gameoverlabel.Location = new Point(222, 43);
            gameoverlabel.Name = "gameoverlabel";
            gameoverlabel.Size = new Size(204, 220);
            gameoverlabel.TabIndex = 4;
            gameoverlabel.Text = "Game Over!\r\n\r\nF1-Restart Game \r\n\r\nEsc-Exit\r\n";
            // 
            // scorelabel2
            // 
            scorelabel2.AutoSize = true;
            scorelabel2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            scorelabel2.Location = new Point(104, 40);
            scorelabel2.Name = "scorelabel2";
            scorelabel2.Size = new Size(26, 31);
            scorelabel2.TabIndex = 3;
            scorelabel2.Text = "0";
            // 
            // scorelabel
            // 
            scorelabel.AutoSize = true;
            scorelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            scorelabel.Location = new Point(11, 40);
            scorelabel.Name = "scorelabel";
            scorelabel.Size = new Size(87, 31);
            scorelabel.TabIndex = 2;
            scorelabel.Text = "SCORE:";
            // 
            // ball
            // 
            ball.BackColor = Color.Red;
            ball.Location = new Point(728, 129);
            ball.Name = "ball";
            ball.Size = new Size(23, 21);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // racket
            // 
            racket.BackColor = SystemColors.ActiveCaptionText;
            racket.Location = new Point(392, 596);
            racket.Name = "racket";
            racket.Size = new Size(202, 16);
            racket.TabIndex = 0;
            racket.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 672);
            Controls.Add(playground);
            Name = "Form1";
            Text = "PingpongGame";
            KeyDown += Form1_KeyDown;
            playground.ResumeLayout(false);
            playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)racket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel playground;
        private PictureBox ball;
        private PictureBox racket;
        private Label gameoverlabel;
        private Label scorelabel2;
        private Label scorelabel;
        private System.Windows.Forms.Timer timer1;
    }
}
