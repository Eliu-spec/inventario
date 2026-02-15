using Inventario;
//Mi nombre aún no ha cambiado y es este: Eliu Hesiel Vallecillo Amaya  
//Mi numero de cuenta sigue sinedo el mismo: 20231930134
//Lugar donde vivo: Flores / Comayagua
//Nombre: Eliu Hesiel Vallecillo Amaya
//NumerodeCuenta: 20231930134

//Creacion de Productos
Producto producto = new Producto("Sansung S21 Ultra", 101, "Tecnologia", 8000, 2);
Producto producto1 = new Producto("Camisa Polo", 201, "Ropa", 599, 20);
Producto producto2 = new Producto("Laptop Acer Nitro V", 301, "Tecnologia", 22000, 2);

//Llamado de productos
producto.Informacion();
Console.WriteLine();
producto.PrecioConDescuento(200);
producto.ValorTotalDelInventario();
producto.PreciodelEnvio(350);
producto.PrecioconImpuesto(300);
Console.WriteLine();
producto1.Informacion();
Console.WriteLine();
producto1.PrecioConDescuento(150);
producto1.ValorTotalDelInventario();
producto1.PreciodelEnvio(250);
producto1.PrecioconImpuesto(100);
Console.WriteLine();
producto2.Informacion();
Console.WriteLine();
producto2.PrecioConDescuento(1150);
producto2.ValorTotalDelInventario();
producto2.PreciodelEnvio(500);
producto2.PrecioconImpuesto(2150);