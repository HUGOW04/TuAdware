using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Speech.Synthesis;


namespace TuAdware
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Visible = false;
            string[] words = { "Hot moms in your area just 10 km away",
                "Hot suggar daddys closeby ;)",
                "Playful players creative with their hands",
                "Hotter then the sun ;)" };
            Random rng = new Random();
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            int random = rng.Next(0, 4);
            notifyIcon1.ShowBalloonTip(10000, words[random], "Enter valid information!", ToolTipIcon.Info);
            speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
            speechSynthesizer.Speak(words[random]);
            Thread.Sleep(10000);
        }
    }
}
