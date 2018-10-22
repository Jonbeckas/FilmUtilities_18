using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmUtilities_18
{
    class nuetzlich
    {
        Form1 fm;
        public nuetzlich(Form1 frm)
        {
            fm = frm;
        }
        public void playNext()
        {
            if (fm.index-1 >= fm.videos.Length)
            {
                MessageBox.Show(
                        "Alle Durchgespielt",
                        "!!!Information!!!      (Film Utilitys'18)",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                //Komplett durchgespilt
            }
            else
            {
                fm.end.Text = fm.videos[fm.index].Extension;
                fm.axWindowsMediaPlayer1.URL = fm.videos[fm.index].FullName;
                fm.axWindowsMediaPlayer1.Ctlcontrols.play();
                fm.text.Text = fm.text.Text + "[" + DateTime.Now + "] Abspielen von " + fm.videos[fm.index].FullName + " erfolgreich\n";
                fm.index++;
            }
        }
        public void AddVideo(FileInfo[] files)
        {
            fm.videos = files;
        }

        public void onError()
        {

            DialogResult result = MessageBox.Show(
                    "Die Datei " + fm.videos[fm.index-1].Name + " konnte nicht abgespielt werden.\nWollen sie die Datei in den Film Utilities Papierkorb verschieben?",
                    "!!!Frage!!!      (Film Utilitys'18)",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (!Directory.Exists(fm.path + "\\Trash"))
                {
                    Directory.CreateDirectory(fm.path + "\\Trash");
                }
                if (!File.Exists(fm.path + "\\Trash\\" + DateTimeOffset.UtcNow.ToUnixTimeSeconds() + fm.videos[fm.index-1].Name))
                {
                    File.Move(fm.videos[fm.index-1].FullName, fm.path + "\\Trash\\" + DateTimeOffset.UtcNow.ToUnixTimeSeconds() + fm.videos[fm.index-1].Name);
                }
                fm.text.Text = fm.text.Text + "[" + DateTime.Now + "] Die Datei " + fm.videos[fm.index-1].FullName + " wurde in den Film Utilities Mülleimer verschoben\n";
                fm.index++;
                playNext();
            }
        }
            
    }
}
