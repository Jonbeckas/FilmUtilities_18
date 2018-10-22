namespace FilmUtilities_18
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videosÖffenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mülleimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mülleimerÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lizenzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfedokumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aufUpdatesPrüfenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.take = new System.Windows.Forms.TextBox();
            this.szene = new System.Windows.Forms.TextBox();
            this.camera = new System.Windows.Forms.ComboBox();
            this.end = new System.Windows.Forms.ComboBox();
            this.bewertung = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.skip = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.trash = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.777778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(905, 506);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(905, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.importierenToolStripMenuItem,
            this.videosÖffenenToolStripMenuItem,
            this.mülleimerToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(47, 22);
            this.toolStripDropDownButton1.Text = "Datei";
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.öffnenToolStripMenuItem.Text = "Projektordner öffnen";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // importierenToolStripMenuItem
            // 
            this.importierenToolStripMenuItem.Name = "importierenToolStripMenuItem";
            this.importierenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.importierenToolStripMenuItem.Text = "Importieren";
            this.importierenToolStripMenuItem.Click += new System.EventHandler(this.importierenToolStripMenuItem_Click);
            // 
            // videosÖffenenToolStripMenuItem
            // 
            this.videosÖffenenToolStripMenuItem.Name = "videosÖffenenToolStripMenuItem";
            this.videosÖffenenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.videosÖffenenToolStripMenuItem.Text = "Videos öffenen";
            this.videosÖffenenToolStripMenuItem.Click += new System.EventHandler(this.videosÖffenenToolStripMenuItem_Click);
            // 
            // mülleimerToolStripMenuItem
            // 
            this.mülleimerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mülleimerÖffnenToolStripMenuItem});
            this.mülleimerToolStripMenuItem.Name = "mülleimerToolStripMenuItem";
            this.mülleimerToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.mülleimerToolStripMenuItem.Text = "Mülleimer";
            // 
            // mülleimerÖffnenToolStripMenuItem
            // 
            this.mülleimerÖffnenToolStripMenuItem.Name = "mülleimerÖffnenToolStripMenuItem";
            this.mülleimerÖffnenToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.mülleimerÖffnenToolStripMenuItem.Text = "Mülleimer öffnen";
            this.mülleimerÖffnenToolStripMenuItem.Click += new System.EventHandler(this.mülleimerÖffnenToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.überToolStripMenuItem,
            this.lizenzenToolStripMenuItem,
            this.hilfedokumentationToolStripMenuItem,
            this.aufUpdatesPrüfenToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton2.Text = "Hilfe";
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.überToolStripMenuItem.Text = "Über";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // lizenzenToolStripMenuItem
            // 
            this.lizenzenToolStripMenuItem.Name = "lizenzenToolStripMenuItem";
            this.lizenzenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.lizenzenToolStripMenuItem.Text = "Lizenzen";
            this.lizenzenToolStripMenuItem.Click += new System.EventHandler(this.lizenzenToolStripMenuItem_Click);
            // 
            // hilfedokumentationToolStripMenuItem
            // 
            this.hilfedokumentationToolStripMenuItem.Name = "hilfedokumentationToolStripMenuItem";
            this.hilfedokumentationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.hilfedokumentationToolStripMenuItem.Text = "Hilfedokumentation";
            this.hilfedokumentationToolStripMenuItem.Click += new System.EventHandler(this.hilfedokumentationToolStripMenuItem_Click);
            // 
            // aufUpdatesPrüfenToolStripMenuItem
            // 
            this.aufUpdatesPrüfenToolStripMenuItem.Name = "aufUpdatesPrüfenToolStripMenuItem";
            this.aufUpdatesPrüfenToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.aufUpdatesPrüfenToolStripMenuItem.Text = "Auf Updates prüfen";
            this.aufUpdatesPrüfenToolStripMenuItem.Click += new System.EventHandler(this.aufUpdatesPrüfenToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.78085F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.21914F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.text, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.39618F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60382F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(899, 471);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.take, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.szene, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.camera, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.end, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.bewertung, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(639, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 400);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // take
            // 
            this.take.Dock = System.Windows.Forms.DockStyle.Fill;
            this.take.Location = new System.Drawing.Point(131, 83);
            this.take.Name = "take";
            this.take.Size = new System.Drawing.Size(123, 20);
            this.take.TabIndex = 1;
            // 
            // szene
            // 
            this.szene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.szene.Location = new System.Drawing.Point(131, 3);
            this.szene.Name = "szene";
            this.szene.Size = new System.Drawing.Size(123, 20);
            this.szene.TabIndex = 0;
            // 
            // camera
            // 
            this.camera.Cursor = System.Windows.Forms.Cursors.Default;
            this.camera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera.FormattingEnabled = true;
            this.camera.Location = new System.Drawing.Point(131, 163);
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(123, 21);
            this.camera.TabIndex = 2;
            // 
            // end
            // 
            this.end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.end.FormattingEnabled = true;
            this.end.Location = new System.Drawing.Point(131, 243);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(123, 21);
            this.end.TabIndex = 3;
            // 
            // bewertung
            // 
            this.bewertung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bewertung.FormattingEnabled = true;
            this.bewertung.Location = new System.Drawing.Point(131, 323);
            this.bewertung.Name = "bewertung";
            this.bewertung.Size = new System.Drawing.Size(123, 21);
            this.bewertung.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 80);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szene";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 80);
            this.label2.TabIndex = 6;
            this.label2.Text = "Take";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 80);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kameraperspektive";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 80);
            this.label4.TabIndex = 8;
            this.label4.Text = "Format";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 80);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bewertung";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(630, 400);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            this.axWindowsMediaPlayer1.ErrorEvent += new System.EventHandler(this.axWindowsMediaPlayer1_ErrorEvent);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Controls.Add(this.skip, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Ok, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.trash, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(639, 409);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 59);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // skip
            // 
            this.skip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skip.Location = new System.Drawing.Point(3, 3);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(79, 53);
            this.skip.TabIndex = 0;
            this.skip.Text = "Überspringen";
            this.skip.UseVisualStyleBackColor = true;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // Ok
            // 
            this.Ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ok.Location = new System.Drawing.Point(88, 3);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(79, 53);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // trash
            // 
            this.trash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trash.Location = new System.Drawing.Point(173, 3);
            this.trash.Name = "trash";
            this.trash.Size = new System.Drawing.Size(81, 53);
            this.trash.TabIndex = 2;
            this.trash.Text = "In den Papierkorb verschieben";
            this.trash.UseVisualStyleBackColor = true;
            this.trash.Click += new System.EventHandler(this.trash_Click);
            // 
            // text
            // 
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Location = new System.Drawing.Point(3, 409);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(630, 59);
            this.text.TabIndex = 6;
            this.text.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 506);
            this.Controls.Add(this.tableLayoutPanel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Film Utilities\'18";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lizenzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfedokumentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videosÖffenenToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox take;
        public System.Windows.Forms.TextBox szene;
        public System.Windows.Forms.ComboBox camera;
        public System.Windows.Forms.ComboBox end;
        public System.Windows.Forms.ComboBox bewertung;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button skip;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button trash;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.ToolStripMenuItem mülleimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mülleimerÖffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aufUpdatesPrüfenToolStripMenuItem;
    }
}

