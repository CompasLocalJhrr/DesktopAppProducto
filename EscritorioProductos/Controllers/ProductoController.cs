using EscritorioProductos.Models;
using Newtonsoft.Json;
using System.Text;

namespace EscritorioProductos.Controllers
{
    internal class ProductoController
    {

        private HttpClient client;

        /// <summary>
        /// URL de la API
        /// </summary>
        const string UriAPi = "https://localhost:7051/Producto";
        public ProductoController()
        {
            client = new HttpClient();
        }

        /// <summary>
        /// Metodo que obtine el listado de los productos
        /// </summary>
        /// <returns>List<Producto>(Listado de productos)</returns>
        public async Task<List<Producto>> GetProducto()
        {
            try
            {

                List<Producto> productos = new List<Producto>();
                Result result = new Result();

                HttpResponseMessage response = await client
                                            .GetAsync(UriAPi);

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Result>(responseJson);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return null;
                }

                return result.ListData;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al obtener los productos: {Environment.NewLine} {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// Obtiene un producto filtrado por el ID
        /// </summary>
        /// <param name="Id">Id de producto a consultar</param>
        /// <returns>Producto</returns>
        public async Task<Producto> GetByIdProducto(int Id)
        {
            try
            {

                Producto producto = new Producto();
                Result result = new Result();


                HttpResponseMessage response = await client
                                            .GetAsync($"{UriAPi}/{Id}");

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Result>(responseJson);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return null;
                }

                return result.Data;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al obtener producto: {Environment.NewLine} {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// Metodo para crear un producto
        /// </summary>
        /// <param name="producto">Datos del producto a crear</param>
        /// <returns>Producto ya creado</returns>
        public async Task<Producto> PostProducto(Producto producto)
        {
            try
            {
                Result result = new Result();

                string strProducto = JsonConvert.SerializeObject(producto);

                StringContent content = new StringContent(strProducto, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(UriAPi, content);

                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Result>(responseJson);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return null;
                }

                return result.Data;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al guardar producto: {Environment.NewLine} {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// Permite acualizar un producto
        /// </summary>
        /// <param name="Id"> Id de producto a Actualizar</param>
        /// <param name="producto">Resto de los valores del producto a actualizar</param>
        /// <returns>Producto(Ya actualizado)</returns>
        public async Task<Producto> PutProducto(int Id, Producto producto)
        {
            try
            {

                string strProducto = JsonConvert.SerializeObject(producto);
                Result result = new Result();

                StringContent content = new StringContent(strProducto, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync($"{UriAPi}/{Id}", content);

                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Result>(responseJson);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return null;
                }

                return result.Data;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al actualizar producto: {Environment.NewLine} {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return null;
            }
        }

        /// <summary>
        /// Permite eliminar un producto
        /// </summary>
        /// <param name="Id">Id del producto a eliminar</param>
        /// <returns>bool</returns>
        public async Task<bool> DeleteProducto(int Id)
        {
            try
            {
                Result result = new Result();

                HttpResponseMessage response = await client.DeleteAsync($"{UriAPi}/{Id}");

                response.EnsureSuccessStatusCode();
                string responseJson = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<Result>(responseJson);

                if (!result.Success)
                {
                    MessageBox.Show(result.ErrorMessage, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al eliminar el producto: {Environment.NewLine} {ex.Message}", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }
        }

    }
}
