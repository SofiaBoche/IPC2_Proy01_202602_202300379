namespace IPC2_PROY01_202602_202300379.Modelos
{
    public class Celda
    {
        // Información de esta casilla
        public int Fila { get; set; }
        public int Columna { get; set; }
        public string Tipo { get; set; } // "E", "*", " ", "C", "R"
        public int CapacidadMilitar { get; set; } // Si hay enemigo

        // Punteros a los 4 lados (Sustituye la matriz)
        public Celda Arriba { get; set; }
        public Celda Abajo { get; set; }
        public Celda Izquierda { get; set; }
        public Celda Derecha { get; set; }

        // Puntero comodín
        public Celda Siguiente { get; set; } 

        public Celda(int fila, int columna, string tipo, int capacidadMilitar = 0)
        {
            Fila = fila;
            Columna = columna;
            Tipo = tipo;
            CapacidadMilitar = capacidadMilitar;
            Arriba = null;
            Abajo = null;
            Izquierda = null;
            Derecha = null;
            Siguiente = null;
        }
    }
}