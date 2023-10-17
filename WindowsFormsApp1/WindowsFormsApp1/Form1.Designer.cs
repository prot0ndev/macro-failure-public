namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ButtonStart = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.ButtonStop = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.CPStext = new System.Windows.Forms.Label();
            this.CPSbar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.Autoclicker = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BorderRadius = 25;
            this.ButtonStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonStart.FillColor = System.Drawing.Color.IndianRed;
            this.ButtonStart.FillColor2 = System.Drawing.Color.Salmon;
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonStart.ForeColor = System.Drawing.Color.White;
            this.ButtonStart.Location = new System.Drawing.Point(59, 153);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(129, 45);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BorderRadius = 25;
            this.ButtonStop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStop.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonStop.FillColor = System.Drawing.Color.IndianRed;
            this.ButtonStop.FillColor2 = System.Drawing.Color.Salmon;
            this.ButtonStop.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonStop.ForeColor = System.Drawing.Color.White;
            this.ButtonStop.Location = new System.Drawing.Point(366, 153);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(129, 45);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // CPStext
            // 
            this.CPStext.AutoSize = true;
            this.CPStext.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CPStext.ForeColor = System.Drawing.Color.White;
            this.CPStext.Location = new System.Drawing.Point(244, 26);
            this.CPStext.Name = "CPStext";
            this.CPStext.Size = new System.Drawing.Size(62, 46);
            this.CPStext.TabIndex = 2;
            this.CPStext.Text = "10";
            // 
            // CPSbar
            // 
            this.CPSbar.Location = new System.Drawing.Point(59, 94);
            this.CPSbar.Maximum = 50;
            this.CPSbar.Minimum = 1;
            this.CPSbar.Name = "CPSbar";
            this.CPSbar.Size = new System.Drawing.Size(436, 34);
            this.CPSbar.TabIndex = 3;
            this.CPSbar.ThumbColor = System.Drawing.Color.Salmon;
            this.CPSbar.Value = 10;
            this.CPSbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.CPSbar_Scroll);
            // 
            // Autoclicker
            // 
            this.Autoclicker.Interval = 1000;
            this.Autoclicker.Tick += new System.EventHandler(this.Autoclicker_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(333, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discord: zbktoastyy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(564, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CPSbar);
            this.Controls.Add(this.CPStext);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QntmAutoClicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton ButtonStart;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton ButtonStop;
        private System.Windows.Forms.Label CPStext;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar CPSbar;
        private System.Windows.Forms.Timer Autoclicker;
        private System.Windows.Forms.Label label2;
    }
}

