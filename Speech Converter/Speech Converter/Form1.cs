using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
namespace Speech_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
            buttonNastaviPauziraj.Visible = false;
            buttonZaustavi.Visible = false;
            buttonPokreni.Location = lokacija;
        }

        int index = 0;
        Point lokacija = new Point(235,273);
        Point lokacija2 = new Point(49,273);
        SpeechSynthesizer citanje = new SpeechSynthesizer();


        private void Pokreni(object sender, EventArgs e)
        {
            index = 0;
            buttonPokreni.Visible = false;
            buttonZaustavi.Visible = true;
            buttonNastaviPauziraj.Location = lokacija2;
            if (richTextBoxText.Text != "")
            {
                
                buttonNastaviPauziraj.Text = "Pauziraj";
                buttonNastaviPauziraj.Visible = true;
                citanje.Dispose();
                citanje = new SpeechSynthesizer();
                citanje.SpeakAsync(richTextBoxText.Text);
            }
            else
            {
               MessageBox.Show("Morate uneti neki tekst prvo!");
            }
        }

        private void PauzirajNastavi(object sender, EventArgs e)
        {
            if (index%2==0)
            {
                buttonNastaviPauziraj.Text = "Nastavi";
                citanje.Pause();
            }
            else
            {
                buttonNastaviPauziraj.Text = "Pauziraj";
                citanje.Resume();
            }
            index++;
        }

        private void Zaustavi(object sender, EventArgs e)
        {
            buttonPokreni.Visible = true;
            buttonNastaviPauziraj.Visible = false;
            buttonZaustavi.Visible = false;
            citanje.Dispose();
            buttonNastaviPauziraj.Visible = false;
        }
    }
}
