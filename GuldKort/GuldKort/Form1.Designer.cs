namespace GuldKort
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoggaIn = new System.Windows.Forms.Button();
            this.btnKollaKod = new System.Windows.Forms.Button();
            this.btnMeddelande = new System.Windows.Forms.Button();
            this.txtLoggaIn = new System.Windows.Forms.TextBox();
            this.txtsmeddlande = new System.Windows.Forms.TextBox();
            this.txtskod = new System.Windows.Forms.TextBox();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnLoggaUt = new System.Windows.Forms.Button();
            this.MittNamn = new System.Windows.Forms.RichTextBox();
            this.txtRecieve = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skapa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoggaIn
            // 
            this.btnLoggaIn.Location = new System.Drawing.Point(511, 89);
            this.btnLoggaIn.Name = "btnLoggaIn";
            this.btnLoggaIn.Size = new System.Drawing.Size(134, 36);
            this.btnLoggaIn.TabIndex = 1;
            this.btnLoggaIn.Text = "Logga in";
            this.btnLoggaIn.UseVisualStyleBackColor = true;
            this.btnLoggaIn.Click += new System.EventHandler(this.btnLoggaIn_Click);
            // 
            // btnKollaKod
            // 
            this.btnKollaKod.Location = new System.Drawing.Point(511, 441);
            this.btnKollaKod.Name = "btnKollaKod";
            this.btnKollaKod.Size = new System.Drawing.Size(134, 38);
            this.btnKollaKod.TabIndex = 3;
            this.btnKollaKod.Text = "Kolla min kod!";
            this.btnKollaKod.UseVisualStyleBackColor = true;
            this.btnKollaKod.Click += new System.EventHandler(this.btnKollaKod_Click);
            // 
            // btnMeddelande
            // 
            this.btnMeddelande.Location = new System.Drawing.Point(22, 131);
            this.btnMeddelande.Name = "btnMeddelande";
            this.btnMeddelande.Size = new System.Drawing.Size(146, 56);
            this.btnMeddelande.TabIndex = 4;
            this.btnMeddelande.Text = "Skicka meddelande";
            this.btnMeddelande.UseVisualStyleBackColor = true;
            this.btnMeddelande.Click += new System.EventHandler(this.btnMeddelande_Click);
            // 
            // txtLoggaIn
            // 
            this.txtLoggaIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtLoggaIn.Location = new System.Drawing.Point(511, 38);
            this.txtLoggaIn.Multiline = true;
            this.txtLoggaIn.Name = "txtLoggaIn";
            this.txtLoggaIn.Size = new System.Drawing.Size(194, 26);
            this.txtLoggaIn.TabIndex = 5;
            this.txtLoggaIn.Enter += new System.EventHandler(this.txtLoggaIn_Enter);
            this.txtLoggaIn.Leave += new System.EventHandler(this.txtLoggaIn_Leave);
            // 
            // txtsmeddlande
            // 
            this.txtsmeddlande.Location = new System.Drawing.Point(24, 12);
            this.txtsmeddlande.Multiline = true;
            this.txtsmeddlande.Name = "txtsmeddlande";
            this.txtsmeddlande.Size = new System.Drawing.Size(421, 91);
            this.txtsmeddlande.TabIndex = 6;
            this.txtsmeddlande.Enter += new System.EventHandler(this.txtsmeddlande_Enter);
            this.txtsmeddlande.Leave += new System.EventHandler(this.txtsmeddlande_Leave);
            // 
            // txtskod
            // 
            this.txtskod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtskod.Location = new System.Drawing.Point(511, 400);
            this.txtskod.Multiline = true;
            this.txtskod.Name = "txtskod";
            this.txtskod.Size = new System.Drawing.Size(194, 26);
            this.txtskod.TabIndex = 7;
            this.txtskod.Enter += new System.EventHandler(this.txtskod_Enter);
            this.txtskod.Leave += new System.EventHandler(this.txtskod_Leave);
            // 
            // btnServer
            // 
            this.btnServer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnServer.Location = new System.Drawing.Point(22, 249);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(180, 101);
            this.btnServer.TabIndex = 8;
            this.btnServer.Text = "Starta server";
            this.btnServer.UseVisualStyleBackColor = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnLoggaUt
            // 
            this.btnLoggaUt.Location = new System.Drawing.Point(511, 131);
            this.btnLoggaUt.Name = "btnLoggaUt";
            this.btnLoggaUt.Size = new System.Drawing.Size(134, 36);
            this.btnLoggaUt.TabIndex = 9;
            this.btnLoggaUt.Text = "Logga ut";
            this.btnLoggaUt.UseVisualStyleBackColor = true;
            this.btnLoggaUt.Click += new System.EventHandler(this.btnLoggaUt_Click);
            // 
            // MittNamn
            // 
            this.MittNamn.BackColor = System.Drawing.SystemColors.MenuBar;
            this.MittNamn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MittNamn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MittNamn.Enabled = false;
            this.MittNamn.Location = new System.Drawing.Point(511, 535);
            this.MittNamn.Name = "MittNamn";
            this.MittNamn.Size = new System.Drawing.Size(204, 28);
            this.MittNamn.TabIndex = 13;
            this.MittNamn.Text = "By: Mohammad Omar Kalthoum";
            // 
            // txtRecieve
            // 
            this.txtRecieve.BackColor = System.Drawing.SystemColors.Window;
            this.txtRecieve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecieve.Location = new System.Drawing.Point(22, 429);
            this.txtRecieve.Multiline = true;
            this.txtRecieve.Name = "txtRecieve";
            this.txtRecieve.ReadOnly = true;
            this.txtRecieve.Size = new System.Drawing.Size(339, 94);
            this.txtRecieve.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Meddelande från Klient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(508, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skapa
            // 
            this.skapa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.skapa.Location = new System.Drawing.Point(505, 217);
            this.skapa.Name = "skapa";
            this.skapa.Size = new System.Drawing.Size(200, 104);
            this.skapa.TabIndex = 18;
            this.skapa.Text = "Skapa ett konto för GRATIS";
            this.skapa.UseVisualStyleBackColor = false;
            this.skapa.Click += new System.EventHandler(this.skapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 584);
            this.Controls.Add(this.skapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecieve);
            this.Controls.Add(this.MittNamn);
            this.Controls.Add(this.btnLoggaUt);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.txtskod);
            this.Controls.Add(this.txtsmeddlande);
            this.Controls.Add(this.txtLoggaIn);
            this.Controls.Add(this.btnMeddelande);
            this.Controls.Add(this.btnKollaKod);
            this.Controls.Add(this.btnLoggaIn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Norr om Söder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoggaIn;
        private System.Windows.Forms.Button btnKollaKod;
        private System.Windows.Forms.Button btnMeddelande;
        private System.Windows.Forms.TextBox txtLoggaIn;
        private System.Windows.Forms.TextBox txtsmeddlande;
        private System.Windows.Forms.TextBox txtskod;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnLoggaUt;
        private System.Windows.Forms.RichTextBox MittNamn;
        private System.Windows.Forms.TextBox txtRecieve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button skapa;
    }
}

