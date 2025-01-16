namespace EscritorioProductos
{
    partial class frmProductos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            dgvProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            panelTitulo = new Panel();
            btnCerrar = new Button();
            lblTitulo = new Label();
            btnResearch = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Id, nombre, precio, stock, Editar, Eliminar });
            dgvProductos.Location = new Point(79, 134);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(676, 364);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            //dgvProductos.CellPainting += dgvProductos_CellPainting;
            // 
            // Id
            // 
            Id.HeaderText = "Codigo";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.Width = 200;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.SteelBlue;
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.ForeColor = SystemColors.Control;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(827, 39);
            panelTitulo.TabIndex = 3;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(785, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(42, 39);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Listar Productos";
            // 
            // btnResearch
            // 
            btnResearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResearch.Location = new Point(640, 90);
            btnResearch.Name = "btnResearch";
            btnResearch.Size = new Size(115, 28);
            btnResearch.TabIndex = 7;
            btnResearch.Text = "Refrescar";
            btnResearch.UseVisualStyleBackColor = true;
            btnResearch.Click += btnResearch_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Editar.ico");
            imageList1.Images.SetKeyName(1, "Eliminar.ico");
            // 
            // frmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(827, 537);
            Controls.Add(btnResearch);
            Controls.Add(panelTitulo);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProductos";
            Text = "Form2";
            Load += frmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private Panel panelTitulo;
        private Button btnCerrar;
        private Label lblTitulo;
        private Button btnResearch;
        private ImageList imageList1;
    }
}