namespace SistemaOdonto
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadDentista = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.agendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgDentistas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.Suporte = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.agendasToolStripMenuItem,
            this.MAjuda,
            this.MSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadDentista,
            this.menuCadPaciente,
            this.menuCadConsulta});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // menuCadDentista
            // 
            this.menuCadDentista.Name = "menuCadDentista";
            this.menuCadDentista.Size = new System.Drawing.Size(121, 22);
            this.menuCadDentista.Text = "Dentista";
            this.menuCadDentista.Click += new System.EventHandler(this.menuCadDentista_Click);
            // 
            // menuCadPaciente
            // 
            this.menuCadPaciente.Name = "menuCadPaciente";
            this.menuCadPaciente.Size = new System.Drawing.Size(121, 22);
            this.menuCadPaciente.Text = "Paciente";
            // 
            // menuCadConsulta
            // 
            this.menuCadConsulta.Name = "menuCadConsulta";
            this.menuCadConsulta.Size = new System.Drawing.Size(121, 22);
            this.menuCadConsulta.Text = "Consulta";
            // 
            // agendasToolStripMenuItem
            // 
            this.agendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAgDentistas,
            this.menuAgPacientes,
            this.menuAgConsultas});
            this.agendasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendasToolStripMenuItem.Image")));
            this.agendasToolStripMenuItem.Name = "agendasToolStripMenuItem";
            this.agendasToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.agendasToolStripMenuItem.Text = "Agendas";
            // 
            // menuAgDentistas
            // 
            this.menuAgDentistas.Name = "menuAgDentistas";
            this.menuAgDentistas.Size = new System.Drawing.Size(180, 22);
            this.menuAgDentistas.Text = "Dentistas";
            this.menuAgDentistas.Click += new System.EventHandler(this.menuAgDentistas_Click);
            // 
            // menuAgPacientes
            // 
            this.menuAgPacientes.Name = "menuAgPacientes";
            this.menuAgPacientes.Size = new System.Drawing.Size(180, 22);
            this.menuAgPacientes.Text = "Pacientes";
            // 
            // menuAgConsultas
            // 
            this.menuAgConsultas.Name = "menuAgConsultas";
            this.menuAgConsultas.Size = new System.Drawing.Size(180, 22);
            this.menuAgConsultas.Text = "Consultas";
            // 
            // MAjuda
            // 
            this.MAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Suporte});
            this.MAjuda.Image = ((System.Drawing.Image)(resources.GetObject("MAjuda.Image")));
            this.MAjuda.Name = "MAjuda";
            this.MAjuda.Size = new System.Drawing.Size(66, 20);
            this.MAjuda.Text = "Ajuda";
            // 
            // Suporte
            // 
            this.Suporte.Name = "Suporte";
            this.Suporte.Size = new System.Drawing.Size(146, 22);
            this.Suporte.Text = "menuSuporte";
            // 
            // MSair
            // 
            this.MSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sair});
            this.MSair.Image = ((System.Drawing.Image)(resources.GetObject("MSair.Image")));
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(54, 20);
            this.MSair.Text = "Sair";
            // 
            // Sair
            // 
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(125, 22);
            this.Sair.Text = "munuSair";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 299);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Sistema Odonto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MAjuda;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.ToolStripMenuItem menuCadDentista;
        private System.Windows.Forms.ToolStripMenuItem menuCadPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuCadConsulta;
        private System.Windows.Forms.ToolStripMenuItem menuAgDentistas;
        private System.Windows.Forms.ToolStripMenuItem menuAgPacientes;
        private System.Windows.Forms.ToolStripMenuItem menuAgConsultas;
        private System.Windows.Forms.ToolStripMenuItem Suporte;
        private System.Windows.Forms.ToolStripMenuItem Sair;
    }
}

