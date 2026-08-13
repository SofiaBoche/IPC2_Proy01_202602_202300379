namespace IPC2_PROY01_202602_202300379.Estructuras
{
    public class Lista
    {
        public Nodo Cabeza { get; set; }

        public void Agregar(object dato)
        {
            Nodo nuevo = new Nodo(dato);
            if (Cabeza == null)
            {
                Cabeza = nuevo;
            }
            else
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }
    }
}