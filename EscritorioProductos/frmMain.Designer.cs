namespace EscritorioProductos
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            crearProductoToolStripMenuItem = new ToolStripMenuItem();
            listarProductosToolStripMenuItem = new ToolStripMenuItem();
            panelConten = new Panel();
            ptbFondo = new PictureBox();
            panelIzquierda = new Panel();
            panelMenuProducto = new Panel();
            btnCrearProductos = new Button();
            btnVerProductos = new Button();
            btnMenuProductos = new Button();
            panel1 = new Panel();
            panelConten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbFondo).BeginInit();
            panelIzquierda.SuspendLayout();
            panelMenuProducto.SuspendLayout();
            SuspendLayout();
            // 
            // crearProductoToolStripMenuItem
            // 
            crearProductoToolStripMenuItem.Name = "crearProductoToolStripMenuItem";
            crearProductoToolStripMenuItem.Size = new Size(32, 19);
            // 
            // listarProductosToolStripMenuItem
            // 
            listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            listarProductosToolStripMenuItem.Size = new Size(32, 19);
            // 
            // panelConten
            // 
            panelConten.AutoScroll = true;
            panelConten.BackColor = Color.White;
            panelConten.Controls.Add(ptbFondo);
            panelConten.Location = new Point(243, 32);
            panelConten.Name = "panelConten";
            panelConten.Size = new Size(827, 537);
            panelConten.TabIndex = 1;
            // 
            // ptbFondo
            // 
            ptbFondo.Anchor = AnchorStyles.None;
            ptbFondo.Image = (Image)resources.GetObject("ptbFondo.Image");
            ptbFondo.Location = new Point(258, 186);
            ptbFondo.Name = "ptbFondo";
            ptbFondo.Size = new Size(335, 123);
            ptbFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbFondo.TabIndex = 0;
            ptbFondo.TabStop = false;
            // 
            // panelIzquierda
            // 
            panelIzquierda.AutoScroll = true;
            panelIzquierda.BackColor = Color.WhiteSmoke;
            panelIzquierda.BorderStyle = BorderStyle.FixedSingle;
            panelIzquierda.Controls.Add(panelMenuProducto);
            panelIzquierda.Controls.Add(btnMenuProductos);
            panelIzquierda.Controls.Add(panel1);
            panelIzquierda.Dock = DockStyle.Left;
            panelIzquierda.Location = new Point(0, 0);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(200, 603);
            panelIzquierda.TabIndex = 2;
            // 
            // panelMenuProducto
            // 
            panelMenuProducto.BackColor = Color.LightSkyBlue;
            panelMenuProducto.Controls.Add(btnCrearProductos);
            panelMenuProducto.Controls.Add(btnVerProductos);
            panelMenuProducto.Dock = DockStyle.Top;
            panelMenuProducto.Location = new Point(0, 127);
            panelMenuProducto.Name = "panelMenuProducto";
            panelMenuProducto.Size = new Size(198, 82);
            panelMenuProducto.TabIndex = 2;
            panelMenuProducto.Visible = false;
            // 
            // btnCrearProductos
            // 
            btnCrearProductos.Dock = DockStyle.Top;
            btnCrearProductos.Location = new Point(0, 41);
            btnCrearProductos.Name = "btnCrearProductos";
            btnCrearProductos.Size = new Size(198, 41);
            btnCrearProductos.TabIndex = 3;
            btnCrearProductos.Text = "Crear Producto";
            btnCrearProductos.UseVisualStyleBackColor = true;
            btnCrearProductos.Click += btnCrearProductos_Click;
            // 
            // btnVerProductos
            // 
            btnVerProductos.Dock = DockStyle.Top;
            btnVerProductos.Location = new Point(0, 0);
            btnVerProductos.Name = "btnVerProductos";
            btnVerProductos.Size = new Size(198, 41);
            btnVerProductos.TabIndex = 2;
            btnVerProductos.Text = "Listar Productos";
            btnVerProductos.UseVisualStyleBackColor = true;
            btnVerProductos.Click += btnVerProductos_Click;
            // 
            // btnMenuProductos
            // 
            btnMenuProductos.BackColor = SystemColors.GradientActiveCaption;
            btnMenuProductos.Dock = DockStyle.Top;
            btnMenuProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMenuProductos.Location = new Point(0, 86);
            btnMenuProductos.Name = "btnMenuProductos";
            btnMenuProductos.Size = new Size(198, 41);
            btnMenuProductos.TabIndex = 1;
            btnMenuProductos.Text = "PRODUCTOS";
            btnMenuProductos.UseVisualStyleBackColor = false;
            btnMenuProductos.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 86);
            panel1.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1107, 603);
            Controls.Add(panelConten);
            Controls.Add(panelIzquierda);
            KeyPreview = true;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compas";
            Load += Form1_Load;
            panelConten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbFondo).EndInit();
            panelIzquierda.ResumeLayout(false);
            panelMenuProducto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolStripMenuItem crearProductoToolStripMenuItem;
        private ToolStripMenuItem listarProductosToolStripMenuItem;
        private Panel panelConten;
        private Panel panelIzquierda;
        private Button btnMenuProductos;
        private Panel panel1;
        private Panel panelMenuProducto;
        private Button btnCrearProductos;
        private Button btnVerProductos;
        private PictureBox ptbFondo;
    }
}
