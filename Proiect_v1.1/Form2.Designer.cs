namespace Proiect_v1._1
{
    partial class Form2
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
            this.btnInserare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.lvw = new System.Windows.Forms.ListView();
            this.Nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DenumireFisier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CaleFisier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extensie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dimensiune = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.tbExtensie = new System.Windows.Forms.TextBox();
            this.tbRating = new System.Windows.Forms.TextBox();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.cbVizualizat = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInserare
            // 
            this.btnInserare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserare.Location = new System.Drawing.Point(42, 399);
            this.btnInserare.Name = "btnInserare";
            this.btnInserare.Size = new System.Drawing.Size(82, 64);
            this.btnInserare.TabIndex = 0;
            this.btnInserare.Text = "Inserare date curente";
            this.btnInserare.UseVisualStyleBackColor = false;
            this.btnInserare.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizare.Location = new System.Drawing.Point(246, 400);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(84, 62);
            this.btnActualizare.TabIndex = 2;
            this.btnActualizare.Text = "Actualizare Baza de date";
            this.btnActualizare.UseVisualStyleBackColor = false;
            this.btnActualizare.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(352, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 62);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStergere.Location = new System.Drawing.Point(145, 399);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(80, 64);
            this.btnStergere.TabIndex = 5;
            this.btnStergere.Text = "Stergere Baza de date";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.button4_Click);
            // 
            // lvw
            // 
            this.lvw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nr,
            this.DenumireFisier,
            this.CaleFisier,
            this.Extensie,
            this.Gen,
            this.Dimensiune,
            this.Rata,
            this.columnHeader1});
            this.lvw.ContextMenuStrip = this.contextMenuStrip1;
            this.lvw.FullRowSelect = true;
            this.lvw.GridLines = true;
            this.lvw.Location = new System.Drawing.Point(12, 25);
            this.lvw.Name = "lvw";
            this.lvw.Size = new System.Drawing.Size(579, 369);
            this.lvw.TabIndex = 6;
            this.lvw.UseCompatibleStateImageBehavior = false;
            this.lvw.View = System.Windows.Forms.View.Details;
            // 
            // Nr
            // 
            this.Nr.Text = "Nr.";
            this.Nr.Width = 45;
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
            this.Gen.Width = 73;
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
            // columnHeader1
            // 
            this.columnHeader1.Text = "Vizualizat";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.editToolStripMenuItem,
            this.clearListToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(455, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 63);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch1.Location = new System.Drawing.Point(710, 48);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(50, 20);
            this.btnSearch1.TabIndex = 8;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.button6_Click);
            // 
            // tbExtensie
            // 
            this.tbExtensie.Location = new System.Drawing.Point(604, 48);
            this.tbExtensie.Name = "tbExtensie";
            this.tbExtensie.Size = new System.Drawing.Size(100, 20);
            this.tbExtensie.TabIndex = 9;
            // 
            // tbRating
            // 
            this.tbRating.Location = new System.Drawing.Point(604, 93);
            this.tbRating.Name = "tbRating";
            this.tbRating.Size = new System.Drawing.Size(100, 20);
            this.tbRating.TabIndex = 11;
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch2.Location = new System.Drawing.Point(710, 93);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(50, 20);
            this.btnSearch2.TabIndex = 10;
            this.btnSearch2.Text = "Search";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(604, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(604, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Vizualizat";
            // 
            // btnSearch3
            // 
            this.btnSearch3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch3.Location = new System.Drawing.Point(710, 145);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(50, 20);
            this.btnSearch3.TabIndex = 14;
            this.btnSearch3.Text = "Search";
            this.btnSearch3.UseVisualStyleBackColor = false;
            this.btnSearch3.Click += new System.EventHandler(this.button8_Click);
            // 
            // cbVizualizat
            // 
            this.cbVizualizat.FormattingEnabled = true;
            this.cbVizualizat.Items.AddRange(new object[] {
            "Da",
            "Nu"});
            this.cbVizualizat.Location = new System.Drawing.Point(604, 146);
            this.cbVizualizat.Name = "cbVizualizat";
            this.cbVizualizat.Size = new System.Drawing.Size(100, 21);
            this.cbVizualizat.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 195);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(160, 248);
            this.textBox1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rezultatele cautarii";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(761, 471);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbVizualizat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRating);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.tbExtensie);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lvw);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.btnInserare);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.ListView lvw;
        private System.Windows.Forms.ColumnHeader Nr;
        private System.Windows.Forms.ColumnHeader DenumireFisier;
        private System.Windows.Forms.ColumnHeader CaleFisier;
        private System.Windows.Forms.ColumnHeader Extensie;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader Dimensiune;
        private System.Windows.Forms.ColumnHeader Rata;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.TextBox tbExtensie;
        private System.Windows.Forms.TextBox tbRating;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.ComboBox cbVizualizat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}