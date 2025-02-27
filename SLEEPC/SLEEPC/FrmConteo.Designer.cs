
namespace SLEEPC
{
    partial class FrmConteo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConteo));
            this.PnCfSuperior = new System.Windows.Forms.Panel();
            this.LblCfTitulo = new System.Windows.Forms.Label();
            this.PbIcono = new System.Windows.Forms.PictureBox();
            this.PbBarra = new CircularProgressBar.CircularProgressBar();
            this.LblTituloC = new System.Windows.Forms.Label();
            this.PbConteo = new System.Windows.Forms.PictureBox();
            this.BtnConteo = new System.Windows.Forms.Button();
            this.LblConteo = new System.Windows.Forms.Label();
            this.TTempo = new System.Windows.Forms.Timer(this.components);
            this.PnCfSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbConteo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnCfSuperior
            // 
            this.PnCfSuperior.BackColor = System.Drawing.Color.White;
            this.PnCfSuperior.Controls.Add(this.LblCfTitulo);
            this.PnCfSuperior.Controls.Add(this.PbIcono);
            this.PnCfSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnCfSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnCfSuperior.Name = "PnCfSuperior";
            this.PnCfSuperior.Size = new System.Drawing.Size(356, 42);
            this.PnCfSuperior.TabIndex = 2;
            // 
            // LblCfTitulo
            // 
            this.LblCfTitulo.AutoSize = true;
            this.LblCfTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCfTitulo.ForeColor = System.Drawing.Color.MediumBlue;
            this.LblCfTitulo.Location = new System.Drawing.Point(45, 9);
            this.LblCfTitulo.Name = "LblCfTitulo";
            this.LblCfTitulo.Size = new System.Drawing.Size(95, 25);
            this.LblCfTitulo.TabIndex = 1;
            this.LblCfTitulo.Text = "SLEEPC";
            // 
            // PbIcono
            // 
            this.PbIcono.Image = global::SLEEPC.Properties.Resources.SleePC_logo;
            this.PbIcono.Location = new System.Drawing.Point(5, 3);
            this.PbIcono.Name = "PbIcono";
            this.PbIcono.Size = new System.Drawing.Size(38, 35);
            this.PbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbIcono.TabIndex = 0;
            this.PbIcono.TabStop = false;
            // 
            // PbBarra
            // 
            this.PbBarra.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PbBarra.AnimationSpeed = 500;
            this.PbBarra.BackColor = System.Drawing.Color.Transparent;
            this.PbBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.PbBarra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PbBarra.InnerColor = System.Drawing.Color.White;
            this.PbBarra.InnerMargin = 2;
            this.PbBarra.InnerWidth = -1;
            this.PbBarra.Location = new System.Drawing.Point(101, 96);
            this.PbBarra.MarqueeAnimationSpeed = 2000;
            this.PbBarra.Name = "PbBarra";
            this.PbBarra.OuterColor = System.Drawing.Color.Gray;
            this.PbBarra.OuterMargin = -25;
            this.PbBarra.OuterWidth = 26;
            this.PbBarra.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PbBarra.ProgressWidth = 10;
            this.PbBarra.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.PbBarra.Size = new System.Drawing.Size(155, 155);
            this.PbBarra.StartAngle = 270;
            this.PbBarra.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PbBarra.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PbBarra.SubscriptText = ".23";
            this.PbBarra.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.PbBarra.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PbBarra.SuperscriptText = "°C";
            this.PbBarra.TabIndex = 3;
            this.PbBarra.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.PbBarra.Value = 100;
            // 
            // LblTituloC
            // 
            this.LblTituloC.AutoSize = true;
            this.LblTituloC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblTituloC.Location = new System.Drawing.Point(71, 60);
            this.LblTituloC.Name = "LblTituloC";
            this.LblTituloC.Size = new System.Drawing.Size(170, 31);
            this.LblTituloC.TabIndex = 4;
            this.LblTituloC.Text = "¿Sigues ahí?";
            // 
            // PbConteo
            // 
            this.PbConteo.Image = global::SLEEPC.Properties.Resources.SleePC_ojos;
            this.PbConteo.Location = new System.Drawing.Point(234, 59);
            this.PbConteo.Name = "PbConteo";
            this.PbConteo.Size = new System.Drawing.Size(51, 38);
            this.PbConteo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbConteo.TabIndex = 5;
            this.PbConteo.TabStop = false;
            // 
            // BtnConteo
            // 
            this.BtnConteo.BackColor = System.Drawing.Color.Green;
            this.BtnConteo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConteo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnConteo.FlatAppearance.BorderSize = 3;
            this.BtnConteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConteo.ForeColor = System.Drawing.Color.White;
            this.BtnConteo.Location = new System.Drawing.Point(111, 260);
            this.BtnConteo.Name = "BtnConteo";
            this.BtnConteo.Size = new System.Drawing.Size(134, 39);
            this.BtnConteo.TabIndex = 6;
            this.BtnConteo.Text = "Sí";
            this.BtnConteo.UseVisualStyleBackColor = false;
            this.BtnConteo.Click += new System.EventHandler(this.BtnConteo_Click);
            // 
            // LblConteo
            // 
            this.LblConteo.AutoSize = true;
            this.LblConteo.BackColor = System.Drawing.Color.White;
            this.LblConteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConteo.ForeColor = System.Drawing.Color.Black;
            this.LblConteo.Location = new System.Drawing.Point(140, 147);
            this.LblConteo.Name = "LblConteo";
            this.LblConteo.Size = new System.Drawing.Size(80, 55);
            this.LblConteo.TabIndex = 7;
            this.LblConteo.Text = "29";
            // 
            // TTempo
            // 
            this.TTempo.Interval = 1000;
            this.TTempo.Tick += new System.EventHandler(this.TTempo_Tick);
            // 
            // FrmConteo
            // 
            this.AcceptButton = this.BtnConteo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(356, 313);
            this.ControlBox = false;
            this.Controls.Add(this.LblConteo);
            this.Controls.Add(this.BtnConteo);
            this.Controls.Add(this.PbConteo);
            this.Controls.Add(this.LblTituloC);
            this.Controls.Add(this.PbBarra);
            this.Controls.Add(this.PnCfSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 329);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 329);
            this.Name = "FrmConteo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmConteo_Load);
            this.PnCfSuperior.ResumeLayout(false);
            this.PnCfSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbConteo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnCfSuperior;
        private System.Windows.Forms.Label LblCfTitulo;
        private System.Windows.Forms.PictureBox PbIcono;
        private CircularProgressBar.CircularProgressBar PbBarra;
        private System.Windows.Forms.Label LblTituloC;
        private System.Windows.Forms.PictureBox PbConteo;
        private System.Windows.Forms.Button BtnConteo;
        private System.Windows.Forms.Label LblConteo;
        private System.Windows.Forms.Timer TTempo;
    }
}