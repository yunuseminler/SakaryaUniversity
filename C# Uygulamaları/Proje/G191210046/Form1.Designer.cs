namespace G191210046
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resim = new System.Windows.Forms.PictureBox();
            this.new_btn = new System.Windows.Forms.Button();
            this.sure_gb = new System.Windows.Forms.GroupBox();
            this.sure_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.puan_gb = new System.Windows.Forms.GroupBox();
            this.puan_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.organik_btn = new System.Windows.Forms.Button();
            this.organik_ltb = new System.Windows.Forms.ListBox();
            this.organik_pb = new System.Windows.Forms.ProgressBar();
            this.organik_bos_btn = new System.Windows.Forms.Button();
            this.kagit_bos_btn = new System.Windows.Forms.Button();
            this.kagit_pb = new System.Windows.Forms.ProgressBar();
            this.kagit_ltb = new System.Windows.Forms.ListBox();
            this.kagit_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cam_bos_btn = new System.Windows.Forms.Button();
            this.cam_pb = new System.Windows.Forms.ProgressBar();
            this.cam_ltb = new System.Windows.Forms.ListBox();
            this.cam_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.metal_bos_btn = new System.Windows.Forms.Button();
            this.metal_pb = new System.Windows.Forms.ProgressBar();
            this.metal_ltb = new System.Windows.Forms.ListBox();
            this.metal_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.sure_gb.SuspendLayout();
            this.puan_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Pink;
            this.groupBox1.Controls.Add(this.resim);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // resim
            // 
            this.resim.Location = new System.Drawing.Point(6, 10);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(189, 167);
            this.resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim.TabIndex = 0;
            this.resim.TabStop = false;
            // 
            // new_btn
            // 
            this.new_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.new_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.new_btn.ForeColor = System.Drawing.Color.Snow;
            this.new_btn.Location = new System.Drawing.Point(46, 244);
            this.new_btn.Name = "new_btn";
            this.new_btn.Size = new System.Drawing.Size(139, 57);
            this.new_btn.TabIndex = 0;
            this.new_btn.Text = "Yeni Oyun";
            this.new_btn.UseVisualStyleBackColor = false;
            this.new_btn.Click += new System.EventHandler(this.new_btn_Click);
            // 
            // sure_gb
            // 
            this.sure_gb.BackColor = System.Drawing.Color.Honeydew;
            this.sure_gb.Controls.Add(this.sure_lbl);
            this.sure_gb.Controls.Add(this.label1);
            this.sure_gb.Location = new System.Drawing.Point(46, 307);
            this.sure_gb.Name = "sure_gb";
            this.sure_gb.Size = new System.Drawing.Size(139, 71);
            this.sure_gb.TabIndex = 1;
            this.sure_gb.TabStop = false;
            // 
            // sure_lbl
            // 
            this.sure_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sure_lbl.ForeColor = System.Drawing.Color.Red;
            this.sure_lbl.Location = new System.Drawing.Point(21, 38);
            this.sure_lbl.Name = "sure_lbl";
            this.sure_lbl.Size = new System.Drawing.Size(91, 33);
            this.sure_lbl.TabIndex = 1;
            this.sure_lbl.Text = "0";
            this.sure_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(45, 5, 45, 5);
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Süre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puan_gb
            // 
            this.puan_gb.BackColor = System.Drawing.Color.MintCream;
            this.puan_gb.Controls.Add(this.puan_lbl);
            this.puan_gb.Controls.Add(this.label2);
            this.puan_gb.Location = new System.Drawing.Point(46, 384);
            this.puan_gb.Name = "puan_gb";
            this.puan_gb.Size = new System.Drawing.Size(139, 76);
            this.puan_gb.TabIndex = 2;
            this.puan_gb.TabStop = false;
            // 
            // puan_lbl
            // 
            this.puan_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan_lbl.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.puan_lbl.Location = new System.Drawing.Point(27, 40);
            this.puan_lbl.Name = "puan_lbl";
            this.puan_lbl.Size = new System.Drawing.Size(85, 33);
            this.puan_lbl.TabIndex = 2;
            this.puan_lbl.Text = "0";
            this.puan_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(45, 5, 45, 5);
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_btn.ForeColor = System.Drawing.Color.Snow;
            this.exit_btn.Location = new System.Drawing.Point(46, 478);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(139, 57);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "Çıkış";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 307);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label6.Location = new System.Drawing.Point(264, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 245);
            this.label6.TabIndex = 5;
            // 
            // organik_btn
            // 
            this.organik_btn.Enabled = false;
            this.organik_btn.Location = new System.Drawing.Point(277, 50);
            this.organik_btn.Name = "organik_btn";
            this.organik_btn.Size = new System.Drawing.Size(146, 27);
            this.organik_btn.TabIndex = 6;
            this.organik_btn.Text = "Organik Atık";
            this.organik_btn.UseVisualStyleBackColor = true;
            this.organik_btn.Click += new System.EventHandler(this.organik_btn_Click);
            // 
            // organik_ltb
            // 
            this.organik_ltb.FormattingEnabled = true;
            this.organik_ltb.Location = new System.Drawing.Point(277, 83);
            this.organik_ltb.Name = "organik_ltb";
            this.organik_ltb.Size = new System.Drawing.Size(146, 121);
            this.organik_ltb.TabIndex = 7;
            // 
            // organik_pb
            // 
            this.organik_pb.Location = new System.Drawing.Point(277, 212);
            this.organik_pb.Name = "organik_pb";
            this.organik_pb.Size = new System.Drawing.Size(146, 23);
            this.organik_pb.TabIndex = 8;
            // 
            // organik_bos_btn
            // 
            this.organik_bos_btn.Enabled = false;
            this.organik_bos_btn.Location = new System.Drawing.Point(277, 241);
            this.organik_bos_btn.Name = "organik_bos_btn";
            this.organik_bos_btn.Size = new System.Drawing.Size(146, 28);
            this.organik_bos_btn.TabIndex = 9;
            this.organik_bos_btn.Text = "Boşalt";
            this.organik_bos_btn.UseVisualStyleBackColor = true;
            this.organik_bos_btn.Click += new System.EventHandler(this.organik_bos_btn_Click);
            // 
            // kagit_bos_btn
            // 
            this.kagit_bos_btn.Enabled = false;
            this.kagit_bos_btn.Location = new System.Drawing.Point(497, 241);
            this.kagit_bos_btn.Name = "kagit_bos_btn";
            this.kagit_bos_btn.Size = new System.Drawing.Size(146, 28);
            this.kagit_bos_btn.TabIndex = 14;
            this.kagit_bos_btn.Text = "Boşalt";
            this.kagit_bos_btn.UseVisualStyleBackColor = true;
            this.kagit_bos_btn.Click += new System.EventHandler(this.kagit_bos_btn_Click);
            // 
            // kagit_pb
            // 
            this.kagit_pb.Location = new System.Drawing.Point(497, 212);
            this.kagit_pb.Name = "kagit_pb";
            this.kagit_pb.Size = new System.Drawing.Size(146, 23);
            this.kagit_pb.TabIndex = 13;
            // 
            // kagit_ltb
            // 
            this.kagit_ltb.FormattingEnabled = true;
            this.kagit_ltb.Location = new System.Drawing.Point(497, 83);
            this.kagit_ltb.Name = "kagit_ltb";
            this.kagit_ltb.Size = new System.Drawing.Size(146, 121);
            this.kagit_ltb.TabIndex = 12;
            // 
            // kagit_btn
            // 
            this.kagit_btn.Enabled = false;
            this.kagit_btn.Location = new System.Drawing.Point(497, 50);
            this.kagit_btn.Name = "kagit_btn";
            this.kagit_btn.Size = new System.Drawing.Size(146, 27);
            this.kagit_btn.TabIndex = 11;
            this.kagit_btn.Text = "Kağıt";
            this.kagit_btn.UseVisualStyleBackColor = true;
            this.kagit_btn.Click += new System.EventHandler(this.kagit_btn_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label7.Location = new System.Drawing.Point(484, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 245);
            this.label7.TabIndex = 10;
            // 
            // cam_bos_btn
            // 
            this.cam_bos_btn.Location = new System.Drawing.Point(277, 500);
            this.cam_bos_btn.Name = "cam_bos_btn";
            this.cam_bos_btn.Size = new System.Drawing.Size(146, 28);
            this.cam_bos_btn.TabIndex = 19;
            this.cam_bos_btn.Text = "Boşalt";
            this.cam_bos_btn.UseVisualStyleBackColor = true;
            this.cam_bos_btn.Click += new System.EventHandler(this.cam_bos_btn_Click);
            // 
            // cam_pb
            // 
            this.cam_pb.Location = new System.Drawing.Point(277, 471);
            this.cam_pb.Name = "cam_pb";
            this.cam_pb.Size = new System.Drawing.Size(146, 23);
            this.cam_pb.TabIndex = 18;
            // 
            // cam_ltb
            // 
            this.cam_ltb.FormattingEnabled = true;
            this.cam_ltb.Location = new System.Drawing.Point(277, 342);
            this.cam_ltb.Name = "cam_ltb";
            this.cam_ltb.Size = new System.Drawing.Size(146, 121);
            this.cam_ltb.TabIndex = 17;
            // 
            // cam_btn
            // 
            this.cam_btn.Enabled = false;
            this.cam_btn.Location = new System.Drawing.Point(277, 309);
            this.cam_btn.Name = "cam_btn";
            this.cam_btn.Size = new System.Drawing.Size(146, 27);
            this.cam_btn.TabIndex = 16;
            this.cam_btn.Text = "Cam";
            this.cam_btn.UseVisualStyleBackColor = true;
            this.cam_btn.Click += new System.EventHandler(this.cam_btn_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label8.Location = new System.Drawing.Point(264, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 245);
            this.label8.TabIndex = 15;
            // 
            // metal_bos_btn
            // 
            this.metal_bos_btn.Location = new System.Drawing.Point(497, 500);
            this.metal_bos_btn.Name = "metal_bos_btn";
            this.metal_bos_btn.Size = new System.Drawing.Size(146, 28);
            this.metal_bos_btn.TabIndex = 24;
            this.metal_bos_btn.Text = "Boşalt";
            this.metal_bos_btn.UseVisualStyleBackColor = true;
            this.metal_bos_btn.Click += new System.EventHandler(this.metal_bos_btn_Click);
            // 
            // metal_pb
            // 
            this.metal_pb.Location = new System.Drawing.Point(497, 471);
            this.metal_pb.Name = "metal_pb";
            this.metal_pb.Size = new System.Drawing.Size(146, 23);
            this.metal_pb.TabIndex = 23;
            // 
            // metal_ltb
            // 
            this.metal_ltb.FormattingEnabled = true;
            this.metal_ltb.Location = new System.Drawing.Point(497, 342);
            this.metal_ltb.Name = "metal_ltb";
            this.metal_ltb.Size = new System.Drawing.Size(146, 121);
            this.metal_ltb.TabIndex = 22;
            // 
            // metal_btn
            // 
            this.metal_btn.Enabled = false;
            this.metal_btn.Location = new System.Drawing.Point(497, 309);
            this.metal_btn.Name = "metal_btn";
            this.metal_btn.Size = new System.Drawing.Size(146, 27);
            this.metal_btn.TabIndex = 21;
            this.metal_btn.Text = "Metal";
            this.metal_btn.UseVisualStyleBackColor = true;
            this.metal_btn.Click += new System.EventHandler(this.metal_btn_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label9.Location = new System.Drawing.Point(484, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 245);
            this.label9.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(264, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(386, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "ATIK KUTULARI";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(705, 552);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.metal_bos_btn);
            this.Controls.Add(this.metal_pb);
            this.Controls.Add(this.metal_ltb);
            this.Controls.Add(this.metal_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cam_bos_btn);
            this.Controls.Add(this.cam_pb);
            this.Controls.Add(this.cam_ltb);
            this.Controls.Add(this.cam_btn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kagit_bos_btn);
            this.Controls.Add(this.kagit_pb);
            this.Controls.Add(this.kagit_ltb);
            this.Controls.Add(this.kagit_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.organik_bos_btn);
            this.Controls.Add(this.organik_pb);
            this.Controls.Add(this.organik_ltb);
            this.Controls.Add(this.organik_btn);
            this.Controls.Add(this.new_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.puan_gb);
            this.Controls.Add(this.sure_gb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Atık Toplama Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.sure_gb.ResumeLayout(false);
            this.sure_gb.PerformLayout();
            this.puan_gb.ResumeLayout(false);
            this.puan_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button new_btn;
        private System.Windows.Forms.GroupBox sure_gb;
        private System.Windows.Forms.Label sure_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox puan_gb;
        private System.Windows.Forms.Label puan_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button organik_btn;
        private System.Windows.Forms.ListBox organik_ltb;
        private System.Windows.Forms.ProgressBar organik_pb;
        private System.Windows.Forms.Button organik_bos_btn;
        private System.Windows.Forms.Button kagit_bos_btn;
        private System.Windows.Forms.ProgressBar kagit_pb;
        private System.Windows.Forms.ListBox kagit_ltb;
        private System.Windows.Forms.Button kagit_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cam_bos_btn;
        private System.Windows.Forms.ProgressBar cam_pb;
        private System.Windows.Forms.ListBox cam_ltb;
        private System.Windows.Forms.Button cam_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button metal_bos_btn;
        private System.Windows.Forms.ProgressBar metal_pb;
        private System.Windows.Forms.ListBox metal_ltb;
        private System.Windows.Forms.Button metal_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox resim;
    }
}

