
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmUtilities_18
{
    public  class init 
    {

        Form1 fm;
        public init(Form1 frm)
        {
            fm = frm;
        }       
        public void Init()
        {
            if (File.Exists("GFU-Updater.exe"))
            {
                File.Delete("GFU-Updater.exe");
            }
            Update up = new Update();
            up.Updater();
            fm.camera.DropDownStyle = ComboBoxStyle.DropDownList;
            fm.bewertung.DropDownStyle = ComboBoxStyle.DropDownList;
            fm.axWindowsMediaPlayer1.uiMode = "mini";
            fm.axWindowsMediaPlayer1.enableContextMenu = false;
            fm.camera.Items.Add("A");
            fm.camera.Items.Add("B");
            fm.camera.Items.Add("C");
            fm.camera.Items.Add("D");
            fm.camera.Items.Add("E");
            fm.camera.Items.Add("F");
            fm.camera.Items.Add("G");
            fm.camera.Items.Add("H");
            fm.camera.Items.Add("I");
            fm.camera.Items.Add("J");
            fm.camera.Items.Add("K");
            fm.camera.Items.Add("L");
            fm.camera.Items.Add("M");
            fm.camera.Items.Add("N");
            fm.camera.Items.Add("O");
            fm.camera.Items.Add("P");
            fm.camera.Items.Add("Q");
            fm.camera.Items.Add("R");
            fm.camera.Items.Add("S");
            fm.camera.Items.Add("T");
            fm.camera.Items.Add("U");
            fm.camera.Items.Add("V");
            fm.camera.Items.Add("W");
            fm.camera.Items.Add("X");
            fm.camera.Items.Add("Y");
            fm.camera.Items.Add("Z");
            fm.end.Items.Remove(".mp3");
            fm.end.Items.Remove(".wav");
            fm.end.Items.Remove(".ogg");
            fm.end.Items.Remove(".wma");
            fm.end.Items.Remove(".aac");
            fm.end.Items.Remove(".mp4");
            fm.end.Items.Remove(".mov");
            fm.end.Items.Remove(".avi");
            fm.end.Items.Remove(".wmv");
            fm.end.Items.Remove(".mts");
            fm.end.Items.Remove(".mpeg");
            fm.end.Items.Remove(".mpeg2");
            fm.end.Items.Remove(".mpeg4");
            fm.end.Items.Add(".mp3");
            fm.end.Items.Add(".wav");
            fm.end.Items.Add(".ogg");
            fm.end.Items.Add(".wma");
            fm.end.Items.Add(".aac");
            fm.end.Items.Add(".mp4");
            fm.end.Items.Add(".mov");
            fm.end.Items.Add(".avi");
            fm.end.Items.Add(".wmv");
            fm.end.Items.Add(".mts");
            fm.end.Items.Add(".mpeg");
            fm.end.Items.Add(".mpeg2");
            fm.end.Items.Add(".mpeg4");
            fm.bewertung.Items.Add("Gut");
            fm.bewertung.Items.Add("Mittel");
            fm.bewertung.Items.Add("Schlecht");
        }
    }
}
