namespace EscritorioProductos
{
    public partial class frmMain : Form
    {
        private Form formActive;
        public frmMain()
        {
            InitializeComponent();
            formActive = null;

        } 

        /// <summary>
        /// Oculta y viaualisa el logo del fondo
        /// </summary>
        /// <param name="bVisible"></param>
        public void VisibleFondo(bool bVisible)
        {
            ptbFondo.Visible = bVisible;
        }

        /// <summary>
        /// Metodo que permite abrir la ventana de Editar producto
        /// </summary>
        /// <param name="Id">Id de producto a Editar</param>
        public void AbrirEditarProducto(int Id)
        {
            if (Id == 0)
            {
                return;
            }

            frmEditarProducto frmEditarProducto = new frmEditarProducto(Id);
            frmEditarProducto.formPadre = this;
            AbrirFormularioEnPanel(frmEditarProducto);
        }

        /// <summary>
        /// Metodo que permite abrir la ventana de listar productos
        /// </summary>
        public void AbrirListarProducto()
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.formPadre = this;
            AbrirFormularioEnPanel(frmProductos);
        }

        /// <summary>
        /// Abre ventana embebidas dentro del panel de la pantalla principal
        /// </summary>
        /// <param name="formularioHijo"></param>
        private void AbrirFormularioEnPanel(Form formularioHijo)
        {
            panelConten.Controls.Clear();

            if (formActive != null)
            {
                formActive.Close();
            }

            formActive = formularioHijo;

            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;

            panelConten.Controls.Add(formularioHijo);
            panelConten.Tag = formularioHijo;

            formularioHijo.Show();
        }

        #region Eventos de los controles
        private void button1_Click(object sender, EventArgs e)
        {
            panelMenuProducto.Visible = panelMenuProducto.Visible ? false : true;
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            panelMenuProducto.Visible = panelMenuProducto.Visible ? false : true;

            frmProductos frmProductos = new frmProductos();
            frmProductos.formPadre = this;
            AbrirFormularioEnPanel(frmProductos);
        }

        private void btnCrearProductos_Click(object sender, EventArgs e)
        {
            panelMenuProducto.Visible = panelMenuProducto.Visible ? false : true;

            frmCrearProducto frmCrearProductos = new frmCrearProducto();
            frmCrearProductos.formPadre = this;
            AbrirFormularioEnPanel(frmCrearProductos);

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
