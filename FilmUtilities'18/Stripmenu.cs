using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace FilmUtilities_18
{
    class Stripmenu
    {
        Form1 fm;
        public Stripmenu(Form1 frm)
        {
            fm = frm;
        }
        public void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                MessageBox.Show(
                           "Der angegebene Ordner "+sourceDirName+" wurde nicht gefunden",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                if (File.Exists(temppath)==true)
                {
                   DialogResult dialog = MessageBox.Show(
                           "Die Datei "+temppath+" existiert bereits.\nWollen sie die Datei überschreiben?",
                           "!!!Frage!!!      (Film Utilitys'18)",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        if (!Directory.Exists(fm.path + "\\Trash"))
                        {
                            Directory.CreateDirectory(fm.path + "\\Trash");
                        }
                        File.Move(fm.path + "\\Rohschnitt\\"+file, fm.path + "\\Trash\\" + DateTimeOffset.UtcNow.ToUnixTimeSeconds() + file);
                        file.CopyTo(temppath, false);
                    }
                }
                else
                {
                    file.CopyTo(temppath, false);
                }
            }
            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    Task copy = Task.Run(() => DirectoryCopy(subdir.FullName, temppath, copySubDirs));
                }
            }
        }
        //Path öffnen
        public string path()
        {
            var ofd = new FolderBrowserDialog();
            ofd.Description = "Bitte wählen sie den Projektordner aus.";
            ofd.ShowDialog();
            var quelle = ofd.SelectedPath;
            if(quelle == null||quelle=="")
            {
                return "false";
            }
            fm.text.Text = fm.text.Text + "[" + DateTime.Now + "] Projektpfad wurde auf "+quelle+" gesetzt.\n";
            return quelle;
        }
        //Import
        public bool import(string ziel)
        {
            var ofd = new FolderBrowserDialog();
            ofd.Description = "Bitte wählen sie den zu Importierenden Ordner aus.";
            ofd.ShowDialog();
            var quelle = ofd.SelectedPath;
            if (quelle == null || quelle == "")
            {
                return false;
            }
            if (ziel == null || ziel == "")
            {
                MessageBox.Show(
                           "Bitte gebe zuerst den Projektordner an.\nDatei->Projektordner öffnen",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return false;
            }
            if (!Directory.Exists(quelle))
            {
                MessageBox.Show(
                           "Der angegebene Ordner "+quelle+" wurde nicht gefunden",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return false;
            }
            if (!Directory.Exists(ziel+"\\Rohschnitt"))
            {
                Directory.CreateDirectory(ziel + "\\Rohschnitt");
            }
            fm.text.Text = fm.text.Text + "[" + DateTime.Now + "] Importieren wurde gestartet.\n";
            Task copy = Task.Run(() => DirectoryCopy(quelle, ziel+"\\Rohschnitt", true));
            copy.Wait();
            fm.text.Text = fm.text.Text + "[" + DateTime.Now + "] Dateien wurden von "+ quelle+" zu "+ziel+" importiert.\n";
            videos(fm.path);
            return true;
        }
        //videos öffnen
        public bool videos(string path)
        {
            if (!Directory.Exists(path + "\\Rohschnitt"))
            {
                MessageBox.Show(
                           "Bitte importieren sie zuerst Daten.\nDatei->Projektordner öffnen",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return false;
            }
            if (path == null || path == "")
            {
                MessageBox.Show(
                           "Bitte gebe zuerst den Projektordner an.\nDatei->Projektordner öffnen",
                           "!!!Information!!!      (Film Utilitys'18)",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                return false;
            }
            DirectoryInfo dir = new DirectoryInfo(path+"\\Rohschnitt");
            nuetzlich player = new nuetzlich(fm);
            player.AddVideo(dir.GetFiles());
            player.playNext();
            return true;
        }
        //Mülleimer öffnen
        public void Trash()
        {
            if (fm.path==null||fm.path=="")
            {
                MessageBox.Show(
                          "Bitte gebe zuerst den Projektordner an.\nDatei->Projektordner öffnen",
                          "!!!Information!!!      (Film Utilitys'18)",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Warning);
            }
            else
            {
                Process.Start("explorer.exe", "/root," + fm.path + "\\Trash");
            }
        }
        //Mülleimer Löschen

        //Update
        public void Update()
        {
            Update up = new Update();
            up.Updater();
        }
    }
}
