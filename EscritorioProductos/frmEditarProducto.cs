using EscritorioProductos.Controllers;
using EscritorioProductos.Models;

namespace EscritorioProductos
{
    public partial class frmEditarProducto : Form
    {
        /// <summary>
        /// Controller que contiene los metodos que consumenla API
        /// </summary>
        private ProductoController ProductoController;

        /// <summary>
        /// Instancia de la ventana principal para tener accedo a sus metodos
        /// </summary>
        public frmMain formPadre { get; set; }


        public frmEditarProducto(int Id)
        {
            InitializeComponent();
            ProductoController = new ProductoController();
            ConsultarProducto(Id);
        }

        /// <summary>
        /// Realiza la validación de los campos antes de guardar
        /// </summary>
        /// <returns>bool</returns>
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
        /// Permite consultar los datos del producto a editar
        /// </summary>
        /// <param name="Id"> Id del producto a editar</param>
        private async void ConsultarProducto(int Id)
        {
            var producto = await ProductoController.GetByIdProducto(Id);

            if (producto != null)
            {
                txtCodigo.Text = producto.Id.ToString();
                txtNombre.Text = producto.Nombre;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                txtStock.Text = producto.Stock.ToString();

            }
            else
            {
                MessageBox.Show("No se pudo encontrar el producto a editar", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Metodo para validar, organiza y manda a guardar la actualización del producto
        /// </summary>
        private async void EditarProducto()
        {
            try
            { 
                if (Validar())
                {

                    int Id = int.Parse(txtCodigo.Text);
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
                    var productoResult = await ProductoController.PutProducto(Id, producto);
                    if (productoResult != null)
                    {
                        MessageBox.Show("Producto actualizado exitosamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCodigo = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            lblDescripcion = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblCodigo = new Label();
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
            panelControles.Controls.Add(txtCodigo);
            panelControles.Controls.Add(txtStock);
            panelControles.Controls.Add(txtPrecio);
            panelControles.Controls.Add(lblDescripcion);
            panelControles.Controls.Add(lblStock);
            panelControles.Controls.Add(lblPrecio);
            panelControles.Controls.Add(txtNombre);
            panelControles.Controls.Add(lblCodigo);
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
            // txtCodigo
            // 
            txtCodigo.AllowDrop = true;
            txtCodigo.BackColor = SystemColors.InactiveBorder;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Enabled = false;
            txtCodigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(597, 77);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(67, 27);
            txtCodigo.TabIndex = 1;
            txtCodigo.Text = "0";
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            txtCodigo.TextChanged += textBox1_TextChanged;
            txtCodigo.KeyPress += txtStock_KeyPress;
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
            txtNombre.Size = new Size(515, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            lblCodigo.Location = new Point(533, 77);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(62, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            lblCodigo.Click += label1_Click;
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
            panelTitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelTitulo.ForeColor = SystemColors.Control;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(827, 39);
            panelTitulo.TabIndex = 1;
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
            btnCerrar.Click += button1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(145, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Editar Producto";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // frmEditarProducto
            // 
            ClientSize = new Size(827, 537);
            Controls.Add(panelTitulo);
            Controls.Add(panelControles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEditarProducto";
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
            EditarProducto();
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
