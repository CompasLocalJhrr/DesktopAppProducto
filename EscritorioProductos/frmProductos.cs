using EscritorioProductos.Controllers;
using EscritorioProductos.Models;

namespace EscritorioProductos
{
    public partial class frmProductos : Form
    {
        private ProductoController ProductoController;
        private List<Producto> productos;
        public frmMain formPadre { get; set; }


        public frmProductos()
        {
            InitializeComponent();
            ProductoController = new ProductoController();
            productos = new List<Producto>();
        }

        /// <summary>
        /// Metodo que consulta la lista de productos 
        /// y Carga la tabla
        /// </summary>
        private async void ConsultarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();

            productos = await ProductoController.GetProducto();

            if (productos != null)
            {
                foreach (var item in productos)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProductos);

                    row.Cells[0].Value = item.Id;
                    row.Cells[1].Value = item.Nombre;
                    row.Cells[2].Value = item.Precio;
                    row.Cells[3].Value = item.Stock;
                    row.Cells[4].Value = "🖋️";
                    row.Cells[5].Value = "➖";

                    dgvProductos.Rows.Add(row);
                }
            }

        }

        /// <summary>
        /// Metodo que permite organizar y llamar para eliminar un producto
        /// </summary>
        /// <param name="Id">Id del producto a eliminar</param>
        private async void EliminarProducto(int Id)
        {
            try
            {
                var result = await ProductoController.DeleteProducto(Id);

                if (result)
                {
                    MessageBox.Show("Producto eliminado exitosamente",
                        "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ConsultarProductos();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubieron errores al intentar eliminar el producto"
                    + Environment.NewLine + e.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        #region Eventos de los controles

        private void frmProductos_Load(object sender, EventArgs e)
        {
            this.ConsultarProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                var IdProducto = this.dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                int Id = int.Parse(IdProducto);
                this.Close();
                formPadre.AbrirEditarProducto(Id);

            }
            else if (this.dgvProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                var IdProducto = this.dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                var Nombre = this.dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();

                int Id = int.Parse(IdProducto);

                var respuesta = MessageBox.Show($"¿Estas seguro de querer eliminar el producto: {Nombre}? "
                    , "Validación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                { 
                    EliminarProducto(Id);
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            formPadre.VisibleFondo(true);
            this.Close();
        }
         
        private void btnResearch_Click(object sender, EventArgs e)
        {
            ConsultarProductos();
        }

        #endregion
    }
}
