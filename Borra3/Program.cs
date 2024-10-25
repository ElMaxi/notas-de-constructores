using System.Timers;

public class Producto
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }


    public Producto(string nombre, double precio, int stock)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }
}

public class Tienda
{
    //metodo que calcula costo total sin modificar precio original
    public void CalcularCostoTotal(int cantidad, double PrecioUnitario)
    {
        double CostoTotal = cantidad * PrecioUnitario;

        Console.WriteLine($"Costo total {CostoTotal:C}");

    }

    //metodo que despacha un pedido y actualiza el stock (por referencia)
    public void DespacharProducto(int stock, int cantidad)
    {
        stock = stock - cantidad;
        Console.WriteLine($"Stock reducido por {cantidad}");

    }
    //método que utiliza argumento de entrada para asegurar que no se modifique
    public void MostrarPrecio(double precio)
    {
        Console.WriteLine($"precio por unidad es {precio:C}");

    }
    //metodo que usa un argumento de salida para devolver cuantas unidades NO fueron despachadas
    public void CalcularUnidadesFaltantes (int stock, int cantidadpedida, out int unidadesFaltantes)
    {
        if (stock >= cantidadpedida) { unidadesFaltantes = 0; }
        else { unidadesFaltantes = cantidadpedida - stock; }


        Console.WriteLine($"Calc");
    }

}
public class program
{
    static void Main()
    {
        Producto prod = new Producto("yerba", 5000, 234);
        Tienda kiosco = new Tienda();


        int cantidadpedida = 2;
        int unidadesfaltantes= 2;

        Console.WriteLine($"Producto {prod.Nombre}");
        Console.WriteLine($"Producto {prod.Stock}");

        kiosco.MostrarPrecio(prod.Precio);

        kiosco.CalcularCostoTotal(cantidadpedida, prod.Precio);

        kiosco.DespacharProducto(prod.Stock, cantidadpedida);

        Console.WriteLine($"se  {prod.Stock}");
        kiosco.CalcularUnidadesFaltantes(prod.Stock, cantidadpedida, out unidadesfaltantes);
        
    }
}


