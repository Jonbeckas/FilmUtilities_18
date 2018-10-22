/*
 * Erstellt mit SharpDevelop.
 * Benutzer: Jonas
 * Datum: 18.02.2018
 * Zeit: 13:58
 * 
 * Sie können diese Vorlage unter Extras > Optionen > Codeerstellung > Standardheader ändern.
 */
using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace FilmUtilities_18
{
	/// <summary>
	/// Description of Update.
	/// </summary>
	public class Update
	{
		public void UpdateQ()
		{
			 DialogResult Ergebnis = MessageBox.Show("Wollen sie nach FilmUtilities'18 Updates suchen?", "Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			 
			 if (Ergebnis==DialogResult.Yes)
			 {
			 	Updater();
			 }
			 
			 else
			 {
			 	
			 }
		}
		public void Updater()
		{
            string AVersion;
            try
            {
                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/Jonbeckas/FilmUtilities_18/master/version.txt");
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                AVersion = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch(Exception e)
            {
                AVersion = "0";
            }
            if (Convert.ToDouble(AVersion)>Form1.ver)
            {
                string Anwendung = Application.StartupPath;
                if (File.Exists(Anwendung + "\\GFU-Updater.exe"))
                {
                    File.Delete(Anwendung + "\\GFU-Updater.exe");
                }
                try
                {
                    DialogResult Frage = MessageBox.Show("Wollen sie FilmUtilities'18 auf die Version "+AVersion+" updaten?", "Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Frage == DialogResult.No)
                    {
                        return;
                    }
                    else if (Frage==DialogResult.None)
                    {
                        return;
                    }
                    WebClient myClient = new WebClient();
                    myClient.DownloadFile("https://github.com/Jonbeckas/FilmUtilities_18/releases/download/v" + AVersion + "/GFU-Updater.exe", "GFU-Updater.exe");

                }
                catch (Exception e)
                {
                    MessageBox.Show("Es ist ein Fehler aufgetreten.\nFehler:\n" + e.Message, "Updater", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    Process.Start(Anwendung + "\\GFU-Updater.exe");
                    Application.Exit();
                }

                catch
                {
                    MessageBox.Show("Das Updateprogramm ist defekt. Bitte schreibe einen issue auf GitHub", "Updater", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
		}
	}
}
