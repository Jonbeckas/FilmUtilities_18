using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmUtilities_18.Help;
using FilmUtilities_18.Lizens;

namespace FilmUtilities_18
{
    public partial class Form1 : Form
    {
        public static double ver;
        public Form1()
        {
            InitializeComponent();
            ver = 1.0;
            init inits = new init(this);
            inits.Init();
        }
        public int index = 0;
        public FileInfo[] videos;
        public string path;
        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stripmenu sm = new Stripmenu(this);
            path = sm.path();
        }

        private void importierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stripmenu sm = new Stripmenu(this);
            sm.import(path);
        }

        private void videosÖffenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stripmenu sm = new Stripmenu(this);
            sm.videos(path);
        }

        private void mülleimerÖffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stripmenu sm = new Stripmenu(this);
            sm.Trash();
        }

        private void skip_Click(object sender, EventArgs e)
        {
            Buttons bu = new Buttons(this);
            bu.PlayButton();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Buttons bu = new Buttons(this);
            bu.OKButton();
        }

        private void trash_Click(object sender, EventArgs e)
        {
            Buttons bu = new Buttons(this);
            bu.TrashButton();
        }

        private void überToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Übercs üe = new Übercs();
            üe.Show();
        }

        private void hilfedokumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpform help = new Helpform();
            help.Show();
        }

        private void aufUpdatesPrüfenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stripmenu sm = new Stripmenu(this);
            sm.Update();
        }

        private void lizenzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lizenzen li = new Lizenzen();
            li.Show();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Helpform help = new Helpform();
            help.Show();
        }

        private void axWindowsMediaPlayer1_ErrorEvent(object sender, EventArgs e)
        {
            nuetzlich nu = new nuetzlich(this);
            nu.onError();
        }
    }
}
