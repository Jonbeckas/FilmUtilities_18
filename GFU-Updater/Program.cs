using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;

namespace GFU_Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "GFUU 1.0.0";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("General FilmUtilities Updater Version 1.0.0");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("FilmUtilities.zip wird heruntergeladen");
            


            WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/Jonbeckas/FilmUtilities_18/master/version.txt");
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string AVersion = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            try
            {
                WebClient myClient = new WebClient();
                myClient.DownloadFile("https://github.com/Jonbeckas/FilmUtilities_18/releases/download/v" + AVersion + "/FilmUtilities.18.zip", "FilmUtilities'18.zip.tmp");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Es ist ein Fehler aufgetreten.\nFehler:\n" + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Bitte laden sie sich die neuste Version manuell herunter!");
                Console.WriteLine("https://github.com/Jonbeckas/FilmUtilities_18/releases\n");
                Console.WriteLine("Drücken sie:\neine Taste um Manuell herunterladen und Fortzufahren\nEsc um zu beenden");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.Escape)
                {
                    return;
                }
 

            }
            Console.WriteLine("\nAlte FilmUtilities Version wird gelöscht...");
            try
            {
                File.Delete("FilmUtilities'18.exe");
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Es ist ein Fehler aufgetreten.\nFehler:\n" + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Bitte drücke eine Taste um das Programm zu beenden");
                Console.ReadLine();
                return;
            }
            try
            {
                ZipFile.ExtractToDirectory("FilmUtilities'18.zip.tmp", "GFUUtmp");
                File.Delete("FilmUtilities'18.zip.tmp");
                Console.WriteLine("Version " + AVersion + " wird installiert...");
                File.Copy("GFUUtmp\\FilmUtilities'18.exe", "FilmUtilities'18.exe");
                Console.WriteLine("Räume auf...");
                string[] Files = Directory.GetFiles("GFUUtmp\\");
                for(int i=0; i!=Files.Count();i++)
                {
                    File.Delete(Files[i]);
                }
                Directory.Delete("GFUUtmp");
            }
            catch(Exception e)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Es ist ein Fehler aufgetreten.\nFehler:\n" + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Bitte drücke eine Taste um das Programm zu beenden");
                Console.ReadLine();
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Update erfolgreich ausgeführt!!!\n\nDrücke eine Taste zum beenden");
            Console.ReadLine();
        }
    }
}
