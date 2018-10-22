using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmUtilities_18
{
    class Buttons
    {
        Form1 fm;
        public Buttons(Form1 frm)
        {
            fm = frm;
        }
        //Ok Button
        public bool OKButton()
        {
            string end = fm.videos[fm.index - 1].Extension.ToLower();
            //audio
            if (fm.videos[fm.index-1].Extension==".cda"|| fm.videos[fm.index-1].Extension == ".CDA"|| fm.videos[fm.index-1].Extension == ".aif"|| fm.videos[fm.index-1].Extension == ".AIF"|| fm.videos[fm.index-1].Extension == ".aifc"|| fm.videos[fm.index-1].Extension == ".AIFC"
                || fm.videos[fm.index-1].Extension == ".aiff"||fm.videos[fm.index-1].Extension == ".AIFF"|| fm.videos[fm.index-1].Extension == ".wav"|| fm.videos[fm.index-1].Extension == ".WAV"|| fm.videos[fm.index-1].Extension == ".wma"|| fm.videos[fm.index-1].Extension == ".WMA"
                || fm.videos[fm.index-1].Extension == ".mid" || fm.videos[fm.index-1].Extension == ".MID" || fm.videos[fm.index-1].Extension == ".midi" || fm.videos[fm.index-1].Extension == ".MIDI" || fm.videos[fm.index-1].Extension == ".rmi" || fm.videos[fm.index-1].Extension == ".RMI" 
                || fm.videos[fm.index-1].Extension == ".mp3" || fm.videos[fm.index-1].Extension == ".MP3" || fm.videos[fm.index-1].Extension == ".m3u" || fm.videos[fm.index-1].Extension == ".M3U")
            {
                if(fm.szene.Text==""||fm.take.Text==""||fm.camera.Text==""||fm.end.Text==""||fm.bewertung.Text=="")
                {
                    MessageBox.Show(
                           "Bitte füllen sie zuerst alle Felder aus",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    return false;
                }
                Directory.CreateDirectory(fm.path+ "\\Ergebnis\\Audio\\Szene_" + fm.szene.Text+"\\Kameraperspektieve_"+fm.camera.Text);
                File.Move(fm.videos[fm.index-1].FullName, fm.path + "\\Ergebnis\\Audio\\Szene_" + fm.szene.Text + "\\Kameraperspektieve_" + fm.camera.Text + "\\Take" + fm.take.Text + "_" + fm.bewertung.Text + "." + fm.end.Text);
            }
            //video
            else if (end==".avi"|| end == ".wmv" || end == ".mpg" || end == ".mpeg" || end == ".mov" || end == ".mp4" || end == ".m4a" || end == ".mp4v" || end == ".3g2" || end == ".3gp2" || end == ".3gp" || end == ".3gpp" || end == ".m1v" || end == ".dvr-ms" || end == ".ivf" || end == ".m2ts" )
            {
                if(fm.szene.Text == "" || fm.take.Text == "" || fm.camera.Text == "" || fm.end.Text == "" || fm.bewertung.Text == "")
                {
                    MessageBox.Show(
                           "Bitte füllen sie zuerst alle Felder aus",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    return false;
                }
                Console.WriteLine(fm.path + "\\Ergebnis\\Video\\Szene_" + fm.szene.Text + "\\Kameraperspektieve_" + fm.camera.Text);
                Directory.CreateDirectory(fm.path + "\\Ergebnis\\Video\\Szene_" + fm.szene.Text + "\\Kameraperspektieve_" + fm.camera.Text);
                File.Move(fm.videos[fm.index - 1].FullName, fm.path + "\\Ergebnis\\Video\\Szene_" + fm.szene.Text + "\\Kameraperspektieve_" + fm.camera.Text + "\\Take" + fm.take.Text + "_" + fm.bewertung.Text + "." + fm.end.Text);
            }
            else
            {
                if (fm.szene.Text == "" || fm.take.Text == "" || fm.camera.Text == "" || fm.end.Text == "" || fm.bewertung.Text == "")
                {
                    MessageBox.Show(
                           "Bitte füllen sie zuerst alle Felder aus",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    return false;
                }
                Directory.CreateDirectory(fm.path + "\\Ergebnis\\Anderes\\Szene_" + fm.szene.Text + "\\Kameraperspektieve_" + fm.camera.Text);
                File.Move(fm.videos[fm.index - 1].FullName, fm.path + "\\Ergebnis\\Anderes\\Szene_" + fm.szene.Text + "\\Kameraperspektieve_" + fm.camera.Text + "\\Take" + fm.take.Text + "_" + fm.bewertung.Text + "." + fm.end.Text);
            }
            return true;
        }
        //skip Button
        public void PlayButton()
        {
            nuetzlich nu = new nuetzlich(fm);
            fm.text.Text = fm.text.Text + "[" + DateTime.Now + "] Die Datei " + fm.videos[fm.index-1].FullName + " wurde übersprungen\n";
            nu.playNext();
        }
        public void TrashButton()
        {
            nuetzlich nu = new nuetzlich(fm);
            if (!Directory.Exists(fm.path + "\\Trash"))
            {
                Directory.CreateDirectory(fm.path + "\\Trash");
            }
            if(File.Exists(fm.videos[fm.index-1].FullName))
            {
                File.Move(fm.videos[fm.index-1].FullName, fm.path + "\\Trash\\" + DateTimeOffset.UtcNow.ToUnixTimeSeconds() + fm.videos[fm.index-1].Name);
                nu.playNext();
            }
            fm.text.Text = fm.text.Text + "[" + DateTime.Now + "] Die Datei " + fm.videos[fm.index-1].FullName + " wurde in den Film Utilities Mülleimer verschoben\n";
        }
    }
}
