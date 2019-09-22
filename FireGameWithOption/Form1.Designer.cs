namespace FireGameWithOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbBullet = new System.Windows.Forms.PictureBox();
            this.Pistol = new System.Windows.Forms.PictureBox();
            this.pbTarget = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.optnThird = new System.Windows.Forms.PictureBox();
            this.optnSecnd = new System.Windows.Forms.PictureBox();
            this.optnFirst = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.Bullet = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.Retry = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pistol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optnThird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optnSecnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optnFirst)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbBullet);
            this.groupBox1.Controls.Add(this.Pistol);
            this.groupBox1.Controls.Add(this.pbTarget);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 213);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shot Box";
            // 
            // pbBullet
            // 
            this.pbBullet.BackColor = System.Drawing.Color.White;
            this.pbBullet.Location = new System.Drawing.Point(82, 109);
            this.pbBullet.Name = "pbBullet";
            this.pbBullet.Size = new System.Drawing.Size(24, 23);
            this.pbBullet.TabIndex = 5;
            this.pbBullet.TabStop = false;
            this.pbBullet.Visible = false;
            // 
            // Pistol
            // 
            this.Pistol.BackColor = System.Drawing.Color.White;
            this.Pistol.Location = new System.Drawing.Point(179, 96);
            this.Pistol.Name = "Pistol";
            this.Pistol.Size = new System.Drawing.Size(110, 82);
            this.Pistol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pistol.TabIndex = 1;
            this.Pistol.TabStop = false;
            // 
            // pbTarget
            // 
            this.pbTarget.Image = ((System.Drawing.Image)(resources.GetObject("pbTarget.Image")));
            this.pbTarget.Location = new System.Drawing.Point(28, 31);
            this.pbTarget.Name = "pbTarget";
            this.pbTarget.Size = new System.Drawing.Size(134, 151);
            this.pbTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTarget.TabIndex = 0;
            this.pbTarget.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.optnThird);
            this.groupBox2.Controls.Add(this.optnSecnd);
            this.groupBox2.Controls.Add(this.optnFirst);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(357, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Gun";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Click to Choose Third";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Click to Choose Second";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click to Choose First";
            // 
            // optnThird
            // 
            this.optnThird.Image = ((System.Drawing.Image)(resources.GetObject("optnThird.Image")));
            this.optnThird.Location = new System.Drawing.Point(26, 190);
            this.optnThird.Name = "optnThird";
            this.optnThird.Size = new System.Drawing.Size(82, 58);
            this.optnThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optnThird.TabIndex = 4;
            this.optnThird.TabStop = false;
            this.optnThird.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // optnSecnd
            // 
            this.optnSecnd.BackColor = System.Drawing.Color.White;
            this.optnSecnd.Image = ((System.Drawing.Image)(resources.GetObject("optnSecnd.Image")));
            this.optnSecnd.Location = new System.Drawing.Point(26, 111);
            this.optnSecnd.Name = "optnSecnd";
            this.optnSecnd.Size = new System.Drawing.Size(82, 58);
            this.optnSecnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optnSecnd.TabIndex = 3;
            this.optnSecnd.TabStop = false;
            this.optnSecnd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // optnFirst
            // 
            this.optnFirst.Image = global::FireGameWithOption.Properties.Resources.optn3;
            this.optnFirst.Location = new System.Drawing.Point(26, 31);
            this.optnFirst.Name = "optnFirst";
            this.optnFirst.Size = new System.Drawing.Size(82, 58);
            this.optnFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.optnFirst.TabIndex = 2;
            this.optnFirst.TabStop = false;
            this.optnFirst.Click += new System.EventHandler(this.optnFirst_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(12, 235);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(76, 45);
            this.start.TabIndex = 2;
            this.start.Text = "Load ";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Bullet
            // 
            this.Bullet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bullet.Location = new System.Drawing.Point(94, 235);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(103, 45);
            this.Bullet.TabIndex = 3;
            this.Bullet.Text = "Spin Gun";
            this.Bullet.UseVisualStyleBackColor = true;
            this.Bullet.Click += new System.EventHandler(this.Bullet_Click);
            // 
            // Fire
            // 
            this.Fire.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.Location = new System.Drawing.Point(216, 235);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(130, 45);
            this.Fire.TabIndex = 4;
            this.Fire.Text = "Shoot Away";
            this.Fire.UseVisualStyleBackColor = true;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // Retry
            // 
            this.Retry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retry.Location = new System.Drawing.Point(103, 298);
            this.Retry.Name = "Retry";
            this.Retry.Size = new System.Drawing.Size(147, 45);
            this.Retry.TabIndex = 5;
            this.Retry.Text = "Retry";
            this.Retry.UseVisualStyleBackColor = true;
            this.Retry.Click += new System.EventHandler(this.Retry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(685, 367);
            this.Controls.Add(this.Retry);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Bullet);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pistol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTarget)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optnThird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optnSecnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optnFirst)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbTarget;
        private System.Windows.Forms.PictureBox Pistol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox optnFirst;
        private System.Windows.Forms.PictureBox optnThird;
        private System.Windows.Forms.PictureBox optnSecnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Bullet;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.PictureBox pbBullet;
        private System.Windows.Forms.Button Retry;
    }
}

