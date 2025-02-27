
namespace SLEEPC
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
            this.BtnConfig = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LblHoraActual = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TPrincipal = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TOpacity = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConfig
            // 
            this.BtnConfig.BackgroundImage = global::SLEEPC.Properties.Resources.SleePC_Configuracion_icono;
            this.BtnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfig.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnConfig.FlatAppearance.BorderSize = 0;
            this.BtnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfig.Location = new System.Drawing.Point(119, 14);
            this.BtnConfig.Name = "BtnConfig";
            this.BtnConfig.Size = new System.Drawing.Size(20, 20);
            this.BtnConfig.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BtnConfig, "Configuración");
            this.BtnConfig.UseVisualStyleBackColor = true;
            this.BtnConfig.Click += new System.EventHandler(this.BtnConfig_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.toolStripSeparator1,
            this.ocultarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 76);
            // 
            // LblHoraActual
            // 
            this.LblHoraActual.AutoSize = true;
            this.LblHoraActual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraActual.ForeColor = System.Drawing.Color.White;
            this.LblHoraActual.Location = new System.Drawing.Point(20, 15);
            this.LblHoraActual.Name = "LblHoraActual";
            this.LblHoraActual.Size = new System.Drawing.Size(92, 19);
            this.LblHoraActual.TabIndex = 2;
            this.LblHoraActual.Text = "00:00:00 a.";
            this.toolTip1.SetToolTip(this.LblHoraActual, "Hora actual del sistema.");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SLEEPC está corriendo";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // TPrincipal
            // 
            this.TPrincipal.Enabled = true;
            this.TPrincipal.Interval = 1000;
            this.TPrincipal.Tick += new System.EventHandler(this.TPrincipal_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "SLEEPC";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // ocultarToolStripMenuItem
            // 
            this.ocultarToolStripMenuItem.Name = "ocultarToolStripMenuItem";
            this.ocultarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.ocultarToolStripMenuItem.Text = "Ocultar";
            this.ocultarToolStripMenuItem.Click += new System.EventHandler(this.ocultarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(147, 6);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1,
            this.configuraciónToolStripMenuItem1,
            this.mostrarToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(151, 98);
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem1.Text = "Configuración";
            this.configuraciónToolStripMenuItem1.Click += new System.EventHandler(this.configuraciónToolStripMenuItem1_Click);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(147, 6);
            // 
            // TOpacity
            // 
            this.TOpacity.Enabled = true;
            this.TOpacity.Tick += new System.EventHandler(this.TOpacity_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(159, 49);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.ControlBox = false;
            this.Controls.Add(this.LblHoraActual);
            this.Controls.Add(this.BtnConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(175, 65);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(175, 65);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConfig;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LblHoraActual;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer TPrincipal;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Timer TOpacity;
    }
}

