namespace g191210046
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
            this.friend_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.x_lbl = new System.Windows.Forms.Label();
            this.y_lbl = new System.Windows.Forms.Label();
            this.x_txt = new System.Windows.Forms.TextBox();
            this.y_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // friend_btn
            // 
            this.friend_btn.Location = new System.Drawing.Point(35, 160);
            this.friend_btn.Name = "friend_btn";
            this.friend_btn.Size = new System.Drawing.Size(75, 23);
            this.friend_btn.TabIndex = 0;
            this.friend_btn.Text = "Arkadaş mı";
            this.friend_btn.UseVisualStyleBackColor = true;
            this.friend_btn.Click += new System.EventHandler(this.friend_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(171, 160);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 23);
            this.exit_btn.TabIndex = 1;
            this.exit_btn.Text = "Çıkış";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // x_lbl
            // 
            this.x_lbl.AutoSize = true;
            this.x_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.x_lbl.Location = new System.Drawing.Point(30, 37);
            this.x_lbl.Name = "x_lbl";
            this.x_lbl.Size = new System.Drawing.Size(28, 20);
            this.x_lbl.TabIndex = 2;
            this.x_lbl.Text = "X :";
            // 
            // y_lbl
            // 
            this.y_lbl.AutoSize = true;
            this.y_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.y_lbl.Location = new System.Drawing.Point(32, 94);
            this.y_lbl.Name = "y_lbl";
            this.y_lbl.Size = new System.Drawing.Size(32, 20);
            this.y_lbl.TabIndex = 3;
            this.y_lbl.Text = "Y : ";
            // 
            // x_txt
            // 
            this.x_txt.Location = new System.Drawing.Point(80, 39);
            this.x_txt.Name = "x_txt";
            this.x_txt.Size = new System.Drawing.Size(100, 20);
            this.x_txt.TabIndex = 4;
            this.x_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.x_txt_KeyPress);
            // 
            // y_txt
            // 
            this.y_txt.Location = new System.Drawing.Point(80, 96);
            this.y_txt.Name = "y_txt";
            this.y_txt.Size = new System.Drawing.Size(100, 20);
            this.y_txt.TabIndex = 5;
            this.y_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.y_txt_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(275, 221);
            this.Controls.Add(this.y_txt);
            this.Controls.Add(this.x_txt);
            this.Controls.Add(this.y_lbl);
            this.Controls.Add(this.x_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.friend_btn);
            this.Name = "Form1";
            this.Text = "Arkadaş Mı ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button friend_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label x_lbl;
        private System.Windows.Forms.Label y_lbl;
        private System.Windows.Forms.TextBox x_txt;
        private System.Windows.Forms.TextBox y_txt;
    }
}

