namespace Proiect_v1._1
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbCale = new System.Windows.Forms.TextBox();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.cbVizualizat = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbExtensie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDimensiune = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Denumire fisier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cale fisier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vizualizat";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(134, 34);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(138, 20);
            this.tbDenumire.TabIndex = 5;
            // 
            // tbCale
            // 
            this.tbCale.Location = new System.Drawing.Point(134, 67);
            this.tbCale.Name = "tbCale";
            this.tbCale.ReadOnly = true;
            this.tbCale.Size = new System.Drawing.Size(138, 20);
            this.tbCale.TabIndex = 6;
            // 
            // nudRating
            // 
            this.nudRating.Location = new System.Drawing.Point(150, 230);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 20);
            this.nudRating.TabIndex = 7;
            // 
            // cbVizualizat
            // 
            this.cbVizualizat.FormattingEnabled = true;
            this.cbVizualizat.Items.AddRange(new object[] {
            "Da",
            "Nu"});
            this.cbVizualizat.Location = new System.Drawing.Point(176, 197);
            this.cbVizualizat.Name = "cbVizualizat";
            this.cbVizualizat.Size = new System.Drawing.Size(95, 21);
            this.cbVizualizat.TabIndex = 8;
            this.cbVizualizat.Validating += new System.ComponentModel.CancelEventHandler(this.cbVizualizat_Validating);
            this.cbVizualizat.Validated += new System.EventHandler(this.cbVizualizat_Validated);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(58, 319);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Extensie";
            // 
            // tbExtensie
            // 
            this.tbExtensie.Location = new System.Drawing.Point(176, 100);
            this.tbExtensie.Name = "tbExtensie";
            this.tbExtensie.ReadOnly = true;
            this.tbExtensie.Size = new System.Drawing.Size(95, 20);
            this.tbExtensie.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gen";
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(176, 164);
            this.tbGen.Name = "tbGen";
            this.tbGen.Size = new System.Drawing.Size(96, 20);
            this.tbGen.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dimensiune";
            // 
            // tbDimensiune
            // 
            this.tbDimensiune.Location = new System.Drawing.Point(176, 132);
            this.tbDimensiune.Name = "tbDimensiune";
            this.tbDimensiune.Size = new System.Drawing.Size(96, 20);
            this.tbDimensiune.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(305, 382);
            this.Controls.Add(this.tbDimensiune);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbExtensie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbVizualizat);
            this.Controls.Add(this.nudRating);
            this.Controls.Add(this.tbCale);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Edit film";
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.ComboBox cbVizualizat;
        private System.Windows.Forms.TextBox tbCale;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbExtensie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDimensiune;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}