namespace IPC2_PROY01_202602_202300379.Estructuras
{
    public class Nodo
    {
        public object Dato { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(object dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}