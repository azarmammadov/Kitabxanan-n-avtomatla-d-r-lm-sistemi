
namespace AzTU
{
    partial class Tlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tisl = new System.Windows.Forms.TextBox();
            this.tidl = new System.Windows.Forms.TextBox();
            this.minimizeL = new System.Windows.Forms.Button();
            this.exitL = new System.Windows.Forms.Button();
            this.tbd = new System.Windows.Forms.Button();
            this.tbg = new System.Windows.Forms.Button();
            this.tbq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "TƏLƏBƏ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "İstifadəçi adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bilet №";
            // 
            // tisl
            // 
            this.tisl.BackColor = System.Drawing.Color.LavenderBlush;
            this.tisl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tisl.Location = new System.Drawing.Point(14, 121);
            this.tisl.Name = "tisl";
            this.tisl.Size = new System.Drawing.Size(279, 25);
            this.tisl.TabIndex = 3;
            // 
            // tidl
            // 
            this.tidl.BackColor = System.Drawing.Color.LavenderBlush;
            this.tidl.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tidl.Location = new System.Drawing.Point(14, 180);
            this.tidl.Name = "tidl";
            this.tidl.Size = new System.Drawing.Size(279, 25);
            this.tidl.TabIndex = 4;
            this.tidl.TextChanged += new System.EventHandler(this.tidl_TextChanged);
            // 
            // minimizeL
            // 
            this.minimizeL.BackColor = System.Drawing.Color.Gold;
            this.minimizeL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeL.BackgroundImage")));
            this.minimizeL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeL.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.minimizeL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeL.Location = new System.Drawing.Point(252, 3);
            this.minimizeL.Name = "minimizeL";
            this.minimizeL.Size = new System.Drawing.Size(30, 28);
            this.minimizeL.TabIndex = 15;
            this.minimizeL.UseVisualStyleBackColor = false;
            this.minimizeL.Click += new System.EventHandler(this.minimizeL_Click);
            // 
            // exitL
            // 
            this.exitL.BackColor = System.Drawing.Color.Tomato;
            this.exitL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitL.BackgroundImage")));
            this.exitL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitL.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.exitL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitL.Location = new System.Drawing.Point(288, 3);
            this.exitL.Name = "exitL";
            this.exitL.Size = new System.Drawing.Size(30, 28);
            this.exitL.TabIndex = 14;
            this.exitL.UseVisualStyleBackColor = false;
            this.exitL.Click += new System.EventHandler(this.exitL_Click);
            // 
            // tbd
            // 
            this.tbd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tbd.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.tbd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbd.Location = new System.Drawing.Point(185, 261);
            this.tbd.Name = "tbd";
            this.tbd.Size = new System.Drawing.Size(108, 32);
            this.tbd.TabIndex = 16;
            this.tbd.Text = "DAXİL OL";
            this.tbd.UseVisualStyleBackColor = false;
            this.tbd.Click += new System.EventHandler(this.tbd_Click);
            // 
            // tbg
            // 
            this.tbg.BackColor = System.Drawing.Color.Red;
            this.tbg.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.tbg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbg.ForeColor = System.Drawing.Color.White;
            this.tbg.Location = new System.Drawing.Point(14, 317);
            this.tbg.Name = "tbg";
            this.tbg.Size = new System.Drawing.Size(108, 32);
            this.tbg.TabIndex = 17;
            this.tbg.Text = "GERİ";
            this.tbg.UseVisualStyleBackColor = false;
            this.tbg.Click += new System.EventHandler(this.tbg_Click);
            // 
            // tbq
            // 
            this.tbq.BackColor = System.Drawing.Color.SpringGreen;
            this.tbq.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.tbq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbq.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbq.Location = new System.Drawing.Point(14, 261);
            this.tbq.Name = "tbq";
            this.tbq.Size = new System.Drawing.Size(108, 32);
            this.tbq.TabIndex = 19;
            this.tbq.Text = "QEYDİYYAT";
            this.tbq.UseVisualStyleBackColor = false;
            this.tbq.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 362);
            this.Controls.Add(this.tbq);
            this.Controls.Add(this.tbg);
            this.Controls.Add(this.tbd);
            this.Controls.Add(this.minimizeL);
            this.Controls.Add(this.exitL);
            this.Controls.Add(this.tidl);
            this.Controls.Add(this.tisl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Tlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tisl;
        private System.Windows.Forms.TextBox tidl;
        private System.Windows.Forms.Button minimizeL;
        private System.Windows.Forms.Button exitL;
        private System.Windows.Forms.Button tbd;
        private System.Windows.Forms.Button tbg;
        private System.Windows.Forms.Button tbq;
    }
}