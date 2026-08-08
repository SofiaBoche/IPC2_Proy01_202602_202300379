public class Lista<T>
{
    private Nodo<T>? primero;
    private int tamanio;

    public Lista()
    {
        primero = null;
        tamanio = 0;
    }

    public void Agregar(T dato)
    {
        Nodo<T> nuevo = new Nodo<T>(dato);

        if (primero == null)
        {
            primero = nuevo;
        }
        else
        {
            Nodo<T> actual = primero;

            while (actual.GetSiguiente() != null)
            {
                actual = actual.GetSiguiente()!;
            }

            actual.SetSiguiente(nuevo);
        }

        tamanio++;
    }

    public T Obtener(int posicion)
    {
        if (posicion < 0 || posicion >= tamanio)
        {
            throw new ArgumentException("La posición no es válida.");
        }

        Nodo<T> actual = primero!;

        for (int i = 0; i < posicion; i++)
        {
            actual = actual.GetSiguiente()!;
        }

        return actual.GetDato();
    }

    public int GetTamanio()
    {
        return tamanio;
    }

    public bool EstaVacia()
    {
        return primero == null;
    }
}