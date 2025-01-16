namespace EscritorioProductos.Models;
public class Result
{
    public bool Success { get; set; }
    public Producto Data { get; set; }
    public List<Producto> ListData { get; set; }
    public string ErrorMessage { get; set; }
}