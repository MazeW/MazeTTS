using System;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace MazeTTS
{
    public partial class Form1 : Form
    {

        private int speechRate = 0;
        private int speechVolume = 50;

        public Form1()
        {
            InitializeComponent();
            voicesList();

        }
        SpeechSynthesizer speechSynthesizerObj;

        private void play_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer
                {
                    Volume = speechVolume,
                    Rate = speechRate
                };
                speechSynthesizerObj.SelectVoice(voiceBox.Text);
                speechSynthesizerObj.SpeakAsync(textBox1.Text);
                play.Enabled = false;
                speechSynthesizerObj.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(speechEnded);
            }
        }
        private void speechEnded(object sender, SpeakCompletedEventArgs e)
        {
            play.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            speechSynthesizerObj.SpeakAsyncCancelAll();
        }

        private void rateBar_Scroll(object sender, EventArgs e)
        {
            speechRate = rateBar.Value;
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            speechVolume = volumeBar.Value;
        }

        private void voicesList()
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            foreach (var voice in speechSynthesizerObj.GetInstalledVoices())
            {
                voiceBox.Items.Add(voice.VoiceInfo.Name);
            }
            voiceBox.SelectedIndex = 0;

        }
    }
}