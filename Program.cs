Lista<string> nombres = new Lista<string>();

nombres.Agregar("Ana");
nombres.Agregar("Luis");
nombres.Agregar("Pedro");

Console.WriteLine(nombres.Obtener(0));
Console.WriteLine(nombres.Obtener(1));
Console.WriteLine(nombres.Obtener(2));

Console.WriteLine("Tamaño: " + nombres.GetTamanio());

Console.WriteLine("¿Está vacía?: " + nombres.EstaVacia());