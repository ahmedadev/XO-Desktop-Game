using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using XO_Game_Final.Properties;

namespace XO_Game_Final
{
    public partial class Form1 : Form
    {

        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }

        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public short PlayCount;

        }



       public Form1()
        {
            InitializeComponent();
        }


private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(White);
            pen.Width = 10;
            // pen.DashStyle=System.Drawing.Drawing2D.DashStyle.Dash;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            e.Graphics.DrawLine(pen, 300, 20, 300, 470);
            e.Graphics.DrawLine(pen, 900, 20, 900, 470);
            e.Graphics.DrawLine(pen, 490, 20, 490, 470);
            e.Graphics.DrawLine(pen, 700, 20, 700, 470);
            e.Graphics.DrawLine(pen, 300, 320, 900, 320);
            e.Graphics.DrawLine(pen, 300, 160, 900, 160);
            e.Graphics.DrawLine(pen, 300, 20, 900, 20);
            e.Graphics.DrawLine(pen, 300, 470, 900, 470);


        }




    }
}


 