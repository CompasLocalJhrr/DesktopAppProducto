using EscritorioProductos.Controllers;
using EscritorioProductos.Models;

namespace EscritorioProductos
{
    public partial class frmCrearProducto : Form
    {
        /// <summary>
        /// Controller donde se realizan los llamados a la API
        /// </summary>
        private ProductoController ProductoController;

        /// <summary>
        /// Instancia de ventana padre
        /// </summary>
        public frmMain formPadre { get; set; }

        public frmCrearProducto()
        {
            InitializeComponent();
            ProductoController = new ProductoController();
        }

        /// <summary>
        /// Se realiza validación de los controles
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            if (txtNombre.Text == "")
            {
                return false;
            }
            else if (txtPrecio.Text == "")
            {
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                return false;
            }
            else if (txtStock.Text == "")
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Metodo desde el que de valida, organiza la innformación y realiza llamado para guardar el nuevo producto
        /// </summary>
        private async void CrearProducto()
        {
            try
            {

                if (Validar())
                {

                    string? Nombre = txtNombre.Text;
                    decimal? Precio = decimal.Parse(txtPrecio.Text);
                    string? Descripcion = txtDescripcion.Text;
                    int? Stock = int.Parse(txtStock.Text);


                    Producto producto = new Producto()
                    {
                        Nombre = Nombre,
                        Precio = Precio,
                        Descripcion = Descripcion,
                        Stock = Stock,
                    };

                    var productoResult = await ProductoController.PostProducto(producto);

                    if (productoResult != null)
                    {
                        MessageBox.Show("Producto guardado exitosamente", "Guardado"
                            , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        int Id = productoResult.Id;
                        this.Close();
                        formPadre.VisibleFondo(true);
                        formPadre.AbrirEditarProducto(Id);

                    }

                }
                else
                {
                    MessageBox.Show("Existen campos sin llenar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hubo un error en el proceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Cierra la ventana
        /// </summary>
        private void CerrarVentana()
        {
            formPadre.VisibleFondo(true);
            this.Close();
        }
         
        #region Eventos de los controles
        private void frmProductos_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private Panel panelControles;
        private Panel panelTitulo;
        private Label lblNombre;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;

        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Button btnGuardar;
        private Button btnCerrar;
        private Label lblTitulo;
        private Button btnCancelar;

        private void InitializeComponent()
        {
            panelControles = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            lblDescripcion = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panelTitulo = new Panel();
            btnCerrar = new Button();
            lblTitulo = new Label();
            panelControles.SuspendLayout();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelControles
            // 
            panelControles.Controls.Add(btnCancelar);
            panelControles.Controls.Add(btnGuardar);
            panelControles.Controls.Add(txtDescripcion);
            panelControles.Controls.Add(txtStock);
            panelControles.Controls.Add(txtPrecio);
            panelControles.Controls.Add(lblDescripcion);
            panelControles.Controls.Add(lblStock);
            panelControles.Controls.Add(lblPrecio);
            panelControles.Controls.Add(txtNombre);
            panelControles.Controls.Add(lblNombre);
            panelControles.Dock = DockStyle.Fill;
            panelControles.Location = new Point(0, 0);
            panelControles.Name = "panelControles";
            panelControles.Size = new Size(827, 537);
            panelControles.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(414, 419);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 44);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(549, 419);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 44);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9.75F);
            txtDescripcion.Location = new Point(149, 311);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(515, 59);
            txtDescripcion.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 9.75F);
            txtStock.Location = new Point(424, 230);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(240, 25);
            txtStock.TabIndex = 3;
            txtStock.TextChanged += textBox1_TextChanged;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9.75F);
            txtPrecio.Location = new Point(149, 230);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(240, 25);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextChanged += textBox1_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblDescripcion.Location = new Point(149, 288);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(89, 20);
            lblDescripcion.TabIndex = 0;
            lblDescripcion.Text = "Descripción";
            lblDescripcion.Click += label1_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblStock.Location = new Point(424, 207);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(46, 20);
            lblStock.TabIndex = 0;
            lblStock.Text = "Stock";
            lblStock.Click += label1_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblPrecio.Location = new Point(149, 207);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 20);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += label1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(149, 152);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(517, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblNombre.Location = new Point(149, 129);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(66, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.SteelBlue;
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(827, 39);
            panelTitulo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(785, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(42, 39);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += button1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(12, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(141, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Crear Producto";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // frmCrearProducto
            // 
            ClientSize = new Size(827, 537);
            Controls.Add(panelTitulo);
            Controls.Add(panelControles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCrearProducto";
            panelControles.ResumeLayout(false);
            panelControles.PerformLayout();
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CrearProducto();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.CerrarVentana();
        }

        #endregion
    }
}
