using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Simple_TTS
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void TTS_Click(object sender, EventArgs e)
        {
            string Text = TTS.Text;
            synthesizer.Speak(Text);
            synthesizer.Speak(TextHolder.Text );
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            synthesizer.SetOutputToDefaultAudioDevice();
        }
        private void TextHolder_KeyDown(object sender, KeyEventArgs e)
        {

            if (!e.SuppressKeyPress)
            {
                string text = "";

                if (e.KeyCode == Keys.Enter)
                {
                    text = "Enter";
                }
                else if (e.KeyCode == Keys.Back)
                {
                    text = "Backspace";
                }
                else if (e.KeyCode == Keys.Space)
                {
                    text = "Space";
                }
                else if (e.Shift && e.KeyCode != Keys.ShiftKey)
                {
                    text = "Shift " + e.KeyCode.ToString();
                }
                else if (e.Alt)
                {
                    text =   e.KeyCode.ToString();
                }
                else if (e.Control)
                {
                    text =  e.KeyCode.ToString();
                }
                else if (e.KeyCode == Keys.CapsLock)
                {
                    text = "Caps Lock " + (Control.IsKeyLocked(Keys.CapsLock) ? "On" : "Off");
                }
                else if (e.KeyCode != Keys.ShiftKey && e.KeyCode != Keys.ControlKey && e.KeyCode != Keys.Menu)
                {
                    text = e.KeyCode.ToString();
                }

                if (text != "")
                {
                    synthesizer.Speak(text);
                }
            }
        }
    }
}
