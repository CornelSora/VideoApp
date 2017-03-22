namespace Proiect_v1._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvw = new System.Windows.Forms.TreeView();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.lvFisiere = new System.Windows.Forms.ListView();
            this.Nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DenumireFisier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaleFisier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extensie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dimensiune = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vizualizat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareToolStripMenuItem,
            this.citireToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierXMLToolStripMenuItem,
            this.fisierTextToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.salvareToolStripMenuItem.Text = "Salvare";
            // 
            // fisierXMLToolStripMenuItem
            // 
            this.fisierXMLToolStripMenuItem.Name = "fisierXMLToolStripMenuItem";
            this.fisierXMLToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.fisierXMLToolStripMenuItem.Text = "Fisier XML";
            this.fisierXMLToolStripMenuItem.Click += new System.EventHandler(this.fisierXMLToolStripMenuItem_Click);
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.fisierTextToolStripMenuItem.Text = "Fisier Text";
            this.fisierTextToolStripMenuItem.Click += new System.EventHandler(this.fisierTextToolStripMenuItem_Click);
            // 
            // citireToolStripMenuItem
            // 
            this.citireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireXMLToolStripMenuItem,
            this.citireTextToolStripMenuItem});
            this.citireToolStripMenuItem.Name = "citireToolStripMenuItem";
            this.citireToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.citireToolStripMenuItem.Text = "Citire";
            // 
            // citireXMLToolStripMenuItem
            // 
            this.citireXMLToolStripMenuItem.Name = "citireXMLToolStripMenuItem";
            this.citireXMLToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.citireXMLToolStripMenuItem.Text = "Citire XML";
            this.citireXMLToolStripMenuItem.Click += new System.EventHandler(this.citireXMLToolStripMenuItem_Click);
            // 
            // citireTextToolStripMenuItem
            // 
            this.citireTextToolStripMenuItem.Name = "citireTextToolStripMenuItem";
            this.citireTextToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.citireTextToolStripMenuItem.Text = "Citire Text";
            this.citireTextToolStripMenuItem.Click += new System.EventHandler(this.citireTextToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            this.bazaDeDateToolStripMenuItem.Click += new System.EventHandler(this.bazaDeDateToolStripMenuItem_Click);
            // 
            // tvw
            // 
            this.tvw.ContextMenuStrip = this.contextMenuStrip2;
            this.tvw.Location = new System.Drawing.Point(12, 27);
            this.tvw.Name = "tvw";
            this.tvw.Size = new System.Drawing.Size(282, 398);
            this.tvw.TabIndex = 0;
            this.tvw.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvw_BeforeExpand);
            this.tvw.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvw_NodeMouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(99, 26);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(89, 431);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Button";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lvFisiere
            // 
            this.lvFisiere.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nr,
            this.DenumireFisier,
            this.CaleFisier,
            this.Extensie,
            this.Gen,
            this.Dimensiune,
            this.Rata,
            this.Vizualizat});
            this.lvFisiere.ContextMenuStrip = this.contextMenuStrip1;
            this.lvFisiere.FullRowSelect = true;
            this.lvFisiere.GridLines = true;
            this.lvFisiere.LargeImageList = this.imageList1;
            this.lvFisiere.Location = new System.Drawing.Point(300, 27);
            this.lvFisiere.Name = "lvFisiere";
            this.lvFisiere.Size = new System.Drawing.Size(550, 398);
            this.lvFisiere.SmallImageList = this.imageList1;
            this.lvFisiere.TabIndex = 5;
            this.lvFisiere.UseCompatibleStateImageBehavior = false;
            this.lvFisiere.View = System.Windows.Forms.View.Details;
            // 
            // Nr
            // 
            this.Nr.Text = "Nr.";
            this.Nr.Width = 49;
            // 
            // DenumireFisier
            // 
            this.DenumireFisier.Text = "Denumire";
            this.DenumireFisier.Width = 90;
            // 
            // CaleFisier
            // 
            this.CaleFisier.Text = "Cale";
            this.CaleFisier.Width = 68;
            // 
            // Extensie
            // 
            this.Extensie.Text = "Extensie";
            this.Extensie.Width = 56;
            // 
            // Gen
            // 
            this.Gen.Text = "Gen";
            this.Gen.Width = 87;
            // 
            // Dimensiune
            // 
            this.Dimensiune.Text = "Dimensiune";
            this.Dimensiune.Width = 86;
            // 
            // Rata
            // 
            this.Rata.Text = "Rating";
            this.Rata.Width = 53;
            // 
            // Vizualizat
            // 
            this.Vizualizat.Text = "Vizualizat";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.stergeToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // stergeToolStripMenuItem
            // 
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Movies.png");
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(12, 431);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(69, 23);
            this.btnExpand.TabIndex = 6;
            this.btnExpand.Text = "Expand all";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(170, 431);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(58, 23);
            this.btnAfisare.TabIndex = 7;
            this.btnAfisare.Text = "Afisare Lista";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(234, 431);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(60, 23);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adauga Director";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(859, 460);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.lvFisiere);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tvw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListView lvFisiere;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierXMLToolStripMenuItem;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireTextToolStripMenuItem;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader Nr;
        private System.Windows.Forms.ColumnHeader DenumireFisier;
        private System.Windows.Forms.ColumnHeader CaleFisier;
        private System.Windows.Forms.ColumnHeader Extensie;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader Dimensiune;
        private System.Windows.Forms.ColumnHeader Rata;
        private System.Windows.Forms.ColumnHeader Vizualizat;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}

