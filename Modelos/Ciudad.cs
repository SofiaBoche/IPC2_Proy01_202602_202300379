namespace IPC2_PROY01_202602_202300379.Modelos
{
    public class Ciudad
    {
        public string Nombre { get; set; }
        public int Filas { get; set; }
        public int Columnas { get; set; }
        
        // La esquina superior izquierda (Fila 1, Columna 1) del mapa de celdas
        public Celda EsquinaInicio { get; set; }

        public Ciudad(string nombre, int filas, int columnas)
        {
            Nombre = nombre;
            Filas = filas;
            Columnas = columnas;
            EsquinaInicio = null;
        }
    }
}