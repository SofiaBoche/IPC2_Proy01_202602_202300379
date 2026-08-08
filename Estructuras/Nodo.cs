public class Nodo<T>
{
    private T dato;
    private Nodo<T>? siguiente;

    public Nodo(T dato)
    {
        this.dato = dato;
        this.siguiente = null;
    }

    public T GetDato()
    {
        return dato;
    }

    public Nodo<T>? GetSiguiente()
    {
        return siguiente;
    }

    public void SetSiguiente(Nodo<T> siguiente)
    {
        this.siguiente = siguiente;
    }
}
