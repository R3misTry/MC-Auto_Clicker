
namespace MC_Auto_Clicker
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
            this.MaxTrackBar = new System.Windows.Forms.TrackBar();
            this.MinTrackBar = new System.Windows.Forms.TrackBar();
            this.buttonToggle = new System.Windows.Forms.Button();
            this.checkBoxMC = new System.Windows.Forms.CheckBox();
            this.clicktimer = new System.Windows.Forms.Timer(this.components);
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MaxTrackBar
            // 
            this.MaxTrackBar.Location = new System.Drawing.Point(12, 12);
            this.MaxTrackBar.Name = "MaxTrackBar";
            this.MaxTrackBar.Size = new System.Drawing.Size(287, 45);
            this.MaxTrackBar.TabIndex = 0;
            this.MaxTrackBar.Scroll += new System.EventHandler(this.MaxTrackBar_Scroll);
            // 
            // MinTrackBar
            // 
            this.MinTrackBar.Location = new System.Drawing.Point(12, 65);
            this.MinTrackBar.Name = "MinTrackBar";
            this.MinTrackBar.Size = new System.Drawing.Size(287, 45);
            this.MinTrackBar.TabIndex = 1;
            this.MinTrackBar.Scroll += new System.EventHandler(this.MinTrackBar_Scroll);
            // 
            // buttonToggle
            // 
            this.buttonToggle.Location = new System.Drawing.Point(283, 135);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(94, 28);
            this.buttonToggle.TabIndex = 2;
            this.buttonToggle.Text = "Toggle : on";
            this.buttonToggle.UseVisualStyleBackColor = true;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            // 
            // checkBoxMC
            // 
            this.checkBoxMC.AutoSize = true;
            this.checkBoxMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkBoxMC.Location = new System.Drawing.Point(197, 142);
            this.checkBoxMC.Name = "checkBoxMC";
            this.checkBoxMC.Size = new System.Drawing.Size(80, 21);
            this.checkBoxMC.TabIndex = 3;
            this.checkBoxMC.Text = "MC Only";
            this.checkBoxMC.UseVisualStyleBackColor = true;
            // 
            // clicktimer
            // 
            this.clicktimer.Tick += new System.EventHandler(this.clicktimer_Tick_1);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.labelMax.Location = new System.Drawing.Point(305, 24);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(71, 15);
            this.labelMax.TabIndex = 4;
            this.labelMax.Text = "Max CPS: 0";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F);
            this.labelMin.Location = new System.Drawing.Point(305, 76);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(68, 15);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "Min CPS: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "R3misTry";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.checkBoxMC);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.MinTrackBar);
            this.Controls.Add(this.MaxTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MC-Auto_Clicker";
            ((System.ComponentModel.ISupportInitialize)(this.MaxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar MaxTrackBar;
        private System.Windows.Forms.TrackBar MinTrackBar;
        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.CheckBox checkBoxMC;
        private System.Windows.Forms.Timer clicktimer;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label label1;
    }
}

