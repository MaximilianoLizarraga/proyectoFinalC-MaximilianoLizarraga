

using AplicacionConsola.Clases;

Usuario usuario1 = new Usuario(12, "Maximiliano", "Lizarraga", "Chapita", 1234,"maxi.lizarraga.91@gmail.com");

Producto producto1 = new Producto(1, "Camiseta", "camiseta de futbol", 30000, 40000, 5, usuario1.Id);

Venta venta1 = new Venta(14, "Felicitaciones! vendiste una camiseta.", usuario1.Id);

ProductoVendido productoVendido1 = new ProductoVendido(1, producto1.Id, 2, venta1.Id);


Console.WriteLine("USUARIO:");
MostrarObjeto(usuario1);
Console.WriteLine("\n");
Console.WriteLine("PRODUCTO:");
MostrarObjeto(producto1);
Console.WriteLine("\n");
Console.WriteLine("VENTA:");
MostrarObjeto(venta1);
Console.WriteLine("\n");
Console.WriteLine("PRODUCTO VENDIDO:");
MostrarObjeto(productoVendido1);
Console.WriteLine("\n");



void MostrarObjeto(object objeto)
{
    Type tipoObjeto = objeto.GetType();
    foreach (var propiedad in tipoObjeto.GetProperties())
    {
        Console.WriteLine($"{propiedad.Name}: {propiedad.GetValue(objeto)}");
    }
}