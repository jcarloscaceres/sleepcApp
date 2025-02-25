
namespace SLEEPC
{
    partial class FrmConfig
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
            this.PnCfSuperior = new System.Windows.Forms.Panel();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblCfTitulo = new System.Windows.Forms.Label();
            this.PbIcono = new System.Windows.Forms.PictureBox();
            this.LblTexto = new System.Windows.Forms.Label();
            this.PnHora = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RbPm = new System.Windows.Forms.RadioButton();
            this.RbAm = new System.Windows.Forms.RadioButton();
            this.NudMinutos = new System.Windows.Forms.NumericUpDown();
            this.NudHora = new System.Windows.Forms.NumericUpDown();
            this.LblTextoHora = new System.Windows.Forms.Label();
            this.PnIntervalo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.NudIntervalo = new System.Windows.Forms.NumericUpDown();
            this.LblTextoIntervalo = new System.Windows.Forms.Label();
            this.ChkSonido = new System.Windows.Forms.CheckBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnManual = new System.Windows.Forms.Button();
            this.PnCfSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcono)).BeginInit();
            this.PnHora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHora)).BeginInit();
            this.PnIntervalo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudIntervalo)).BeginInit();
            this.SuspendLayout();
            // 
            // PnCfSuperior
            // 
            this.PnCfSuperior.BackColor = System.Drawing.Color.White;
            this.PnCfSuperior.Controls.Add(this.LblVersion);
            this.PnCfSuperior.Controls.Add(this.LblCfTitulo);
            this.PnCfSuperior.Controls.Add(this.PbIcono);
            this.PnCfSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnCfSuperior.Location = new System.Drawing.Point(0, 0);
            this.PnCfSuperior.Name = "PnCfSuperior";
            this.PnCfSuperior.Size = new System.Drawing.Size(634, 63);
            this.PnCfSuperior.TabIndex = 1;
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.ForeColor = System.Drawing.Color.MediumBlue;
            this.LblVersion.Location = new System.Drawing.Point(525, 19);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(105, 24);
            this.LblVersion.TabIndex = 2;
            this.LblVersion.Text = "Versión 1.1";
            // 
            // LblCfTitulo
            // 
            this.LblCfTitulo.AutoSize = true;
            this.LblCfTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCfTitulo.ForeColor = System.Drawing.Color.MediumBlue;
            this.LblCfTitulo.Location = new System.Drawing.Point(70, 15);
            this.LblCfTitulo.Name = "LblCfTitulo";
            this.LblCfTitulo.Size = new System.Drawing.Size(128, 33);
            this.LblCfTitulo.TabIndex = 1;
            this.LblCfTitulo.Text = "SLEEPC";
            // 
            // PbIcono
            // 
            this.PbIcono.Image = global::SLEEPC.Properties.Resources.SleePC_logo;
            this.PbIcono.Location = new System.Drawing.Point(8, 3);
            this.PbIcono.Name = "PbIcono";
            this.PbIcono.Size = new System.Drawing.Size(60, 57);
            this.PbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbIcono.TabIndex = 0;
            this.PbIcono.TabStop = false;
            // 
            // LblTexto
            // 
            this.LblTexto.AutoSize = true;
            this.LblTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTexto.ForeColor = System.Drawing.Color.Black;
            this.LblTexto.Location = new System.Drawing.Point(17, 81);
            this.LblTexto.Name = "LblTexto";
            this.LblTexto.Size = new System.Drawing.Size(601, 36);
            this.LblTexto.TabIndex = 13;
            this.LblTexto.Text = "Configura la hora en que se activará la aplicación y el intervalo  en que va a re" +
    "alizar la \r\nconfirmación de uso de la PC (mínimo 15 mins, máximo 120 mins o 2 ho" +
    "ras).";
            // 
            // PnHora
            // 
            this.PnHora.BackColor = System.Drawing.Color.White;
            this.PnHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnHora.Controls.Add(this.label5);
            this.PnHora.Controls.Add(this.label4);
            this.PnHora.Controls.Add(this.label3);
            this.PnHora.Controls.Add(this.label2);
            this.PnHora.Controls.Add(this.label1);
            this.PnHora.Controls.Add(this.RbPm);
            this.PnHora.Controls.Add(this.RbAm);
            this.PnHora.Controls.Add(this.NudMinutos);
            this.PnHora.Controls.Add(this.NudHora);
            this.PnHora.Controls.Add(this.LblTextoHora);
            this.PnHora.Location = new System.Drawing.Point(28, 131);
            this.PnHora.Name = "PnHora";
            this.PnHora.Size = new System.Drawing.Size(274, 137);
            this.PnHora.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(191, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "pm / am";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(112, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(176, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(92, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ":";
            // 
            // RbPm
            // 
            this.RbPm.AutoSize = true;
            this.RbPm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPm.Location = new System.Drawing.Point(192, 63);
            this.RbPm.Name = "RbPm";
            this.RbPm.Size = new System.Drawing.Size(55, 22);
            this.RbPm.TabIndex = 5;
            this.RbPm.Text = "p.m.";
            this.RbPm.UseVisualStyleBackColor = true;
            // 
            // RbAm
            // 
            this.RbAm.AutoSize = true;
            this.RbAm.Checked = true;
            this.RbAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbAm.Location = new System.Drawing.Point(192, 39);
            this.RbAm.Name = "RbAm";
            this.RbAm.Size = new System.Drawing.Size(55, 22);
            this.RbAm.TabIndex = 4;
            this.RbAm.TabStop = true;
            this.RbAm.Text = "a.m.";
            this.RbAm.UseVisualStyleBackColor = true;
            // 
            // NudMinutos
            // 
            this.NudMinutos.BackColor = System.Drawing.Color.White;
            this.NudMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudMinutos.Location = new System.Drawing.Point(107, 51);
            this.NudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudMinutos.Name = "NudMinutos";
            this.NudMinutos.ReadOnly = true;
            this.NudMinutos.Size = new System.Drawing.Size(67, 31);
            this.NudMinutos.TabIndex = 3;
            this.NudMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudHora
            // 
            this.NudHora.BackColor = System.Drawing.Color.White;
            this.NudHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudHora.Location = new System.Drawing.Point(25, 51);
            this.NudHora.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NudHora.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudHora.Name = "NudHora";
            this.NudHora.ReadOnly = true;
            this.NudHora.Size = new System.Drawing.Size(67, 31);
            this.NudHora.TabIndex = 2;
            this.NudHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudHora.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblTextoHora
            // 
            this.LblTextoHora.AutoSize = true;
            this.LblTextoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextoHora.ForeColor = System.Drawing.Color.Black;
            this.LblTextoHora.Location = new System.Drawing.Point(64, 9);
            this.LblTextoHora.Name = "LblTextoHora";
            this.LblTextoHora.Size = new System.Drawing.Size(144, 20);
            this.LblTextoHora.TabIndex = 1;
            this.LblTextoHora.Text = "Hora de activación:";
            // 
            // PnIntervalo
            // 
            this.PnIntervalo.BackColor = System.Drawing.Color.White;
            this.PnIntervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnIntervalo.Controls.Add(this.label6);
            this.PnIntervalo.Controls.Add(this.NudIntervalo);
            this.PnIntervalo.Controls.Add(this.LblTextoIntervalo);
            this.PnIntervalo.Location = new System.Drawing.Point(332, 131);
            this.PnIntervalo.Name = "PnIntervalo";
            this.PnIntervalo.Size = new System.Drawing.Size(274, 137);
            this.PnIntervalo.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(111, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Minutos";
            // 
            // NudIntervalo
            // 
            this.NudIntervalo.BackColor = System.Drawing.Color.White;
            this.NudIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudIntervalo.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NudIntervalo.Location = new System.Drawing.Point(103, 52);
            this.NudIntervalo.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NudIntervalo.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NudIntervalo.Name = "NudIntervalo";
            this.NudIntervalo.ReadOnly = true;
            this.NudIntervalo.Size = new System.Drawing.Size(67, 31);
            this.NudIntervalo.TabIndex = 7;
            this.NudIntervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudIntervalo.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // LblTextoIntervalo
            // 
            this.LblTextoIntervalo.AutoSize = true;
            this.LblTextoIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextoIntervalo.ForeColor = System.Drawing.Color.Black;
            this.LblTextoIntervalo.Location = new System.Drawing.Point(58, 9);
            this.LblTextoIntervalo.Name = "LblTextoIntervalo";
            this.LblTextoIntervalo.Size = new System.Drawing.Size(156, 20);
            this.LblTextoIntervalo.TabIndex = 6;
            this.LblTextoIntervalo.Text = "Selecciona Intervalo:";
            // 
            // ChkSonido
            // 
            this.ChkSonido.AutoSize = true;
            this.ChkSonido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSonido.ForeColor = System.Drawing.Color.DimGray;
            this.ChkSonido.Location = new System.Drawing.Point(28, 279);
            this.ChkSonido.Name = "ChkSonido";
            this.ChkSonido.Size = new System.Drawing.Size(185, 20);
            this.ChkSonido.TabIndex = 16;
            this.ChkSonido.Text = "Emitir Sonido al Notificar 🔊";
            this.ChkSonido.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(518, 275);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(88, 34);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCancelar.Location = new System.Drawing.Point(424, 275);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(88, 34);
            this.BtnCancelar.TabIndex = 18;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnManual
            // 
            this.BtnManual.BackColor = System.Drawing.Color.Transparent;
            this.BtnManual.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnManual.FlatAppearance.BorderSize = 0;
            this.BtnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManual.ForeColor = System.Drawing.Color.DimGray;
            this.BtnManual.Location = new System.Drawing.Point(379, 274);
            this.BtnManual.Name = "BtnManual";
            this.BtnManual.Size = new System.Drawing.Size(39, 34);
            this.BtnManual.TabIndex = 19;
            this.BtnManual.Text = "?";
            this.BtnManual.UseVisualStyleBackColor = false;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 316);
            this.Controls.Add(this.BtnManual);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.ChkSonido);
            this.Controls.Add(this.PnIntervalo);
            this.Controls.Add(this.PnHora);
            this.Controls.Add(this.LblTexto);
            this.Controls.Add(this.PnCfSuperior);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 355);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 355);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración SLEEPC";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.PnCfSuperior.ResumeLayout(false);
            this.PnCfSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcono)).EndInit();
            this.PnHora.ResumeLayout(false);
            this.PnHora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHora)).EndInit();
            this.PnIntervalo.ResumeLayout(false);
            this.PnIntervalo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudIntervalo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnCfSuperior;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblCfTitulo;
        private System.Windows.Forms.PictureBox PbIcono;
        private System.Windows.Forms.Label LblTexto;
        private System.Windows.Forms.Panel PnHora;
        private System.Windows.Forms.RadioButton RbPm;
        private System.Windows.Forms.RadioButton RbAm;
        private System.Windows.Forms.NumericUpDown NudMinutos;
        private System.Windows.Forms.NumericUpDown NudHora;
        private System.Windows.Forms.Label LblTextoHora;
        private System.Windows.Forms.Panel PnIntervalo;
        private System.Windows.Forms.NumericUpDown NudIntervalo;
        private System.Windows.Forms.Label LblTextoIntervalo;
        private System.Windows.Forms.CheckBox ChkSonido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnManual;
    }
}