namespace GuldKort
{
    partial class skapaEttKonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(skapaEttKonto));
            this.txtAnv = new System.Windows.Forms.TextBox();
            this.skaffaBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeNow = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnv
            // 
            this.txtAnv.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnv.Location = new System.Drawing.Point(532, 90);
            this.txtAnv.Multiline = true;
            this.txtAnv.Name = "txtAnv";
            this.txtAnv.Size = new System.Drawing.Size(200, 25);
            this.txtAnv.TabIndex = 1;
            this.txtAnv.Enter += new System.EventHandler(this.txtAnv_Enter);
            this.txtAnv.Leave += new System.EventHandler(this.txtAnv_Leave);
            // 
            // skaffaBtn
            // 
            this.skaffaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skaffaBtn.BackgroundImage")));
            this.skaffaBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skaffaBtn.Location = new System.Drawing.Point(401, 266);
            this.skaffaBtn.Name = "skaffaBtn";
            this.skaffaBtn.Size = new System.Drawing.Size(195, 104);
            this.skaffaBtn.TabIndex = 2;
            this.skaffaBtn.Text = "Skapa kontot";
            this.skaffaBtn.UseVisualStyleBackColor = true;
            this.skaffaBtn.Click += new System.EventHandler(this.skaffaBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 160);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Användarnamn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ort: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Förnamn och efternamn: ";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(532, 143);
            this.txtNamn.Multiline = true;
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(200, 25);
            this.txtNamn.TabIndex = 22;
            this.txtNamn.Enter += new System.EventHandler(this.txtNamn_Enter);
            this.txtNamn.Leave += new System.EventHandler(this.txtNamn_Leave);
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(532, 192);
            this.txtOrt.Multiline = true;
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(200, 24);
            this.txtOrt.TabIndex = 23;
            this.txtOrt.Enter += new System.EventHandler(this.txtOrt_Enter);
            this.txtOrt.Leave += new System.EventHandler(this.txtOrt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "By: Mohammad Omar Kalthoum";
            // 
            // timeNow
            // 
            this.timeNow.AutoSize = true;
            this.timeNow.Location = new System.Drawing.Point(557, 466);
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(39, 17);
            this.timeNow.TabIndex = 25;
            this.timeNow.Text = "TIme";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // skapaEttKonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 492);
            this.Controls.Add(this.timeNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.skaffaBtn);
            this.Controls.Add(this.txtAnv);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "skapaEttKonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Norr om Söder";
            this.Load += new System.EventHandler(this.skapaEttKonto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAnv;
        private System.Windows.Forms.Button skaffaBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeNow;
        private System.Windows.Forms.Timer timer2;
    }
}