using System;

namespace JugadorNS
{
    public class Jugador
    {
        private string nombre;
        private int vida;
        private double oro;
        private bool npc;
        private int resistencia;

        // Constructor por defecto
        public Jugador()
        {
            nombre = "Sin nombre";
            vida = 100;
            oro = 0;
            npc = false;
            resistencia = 50;
        }

        // Constructor con nombre
        public Jugador(string nombre)
        {
            if (nombre == null)
                throw new NullReferenceException("El nombre no puede ser null");

            this.nombre = nombre;
            vida = 100;
            oro = 0;
            npc = false;
            resistencia = 50;
        }

        // Getters
        public string GetNombre() { return nombre; }
        public int GetVida() { return vida; }
        public double GetOro() { return oro; }
        public bool IsNpc() { return npc; }
        public int GetResistencia() { return resistencia; }

        // Métodos
        public void CambiarNombre(string nuevoNombre)
        {
            if (nuevoNombre == null)
                throw new NullReferenceException("El nombre no puede ser null");
            nombre = nuevoNombre;
        }

        public void AnyadirOro(double cantidad)
        {
            oro += cantidad;
        }

        public void QuitarOro(double cantidad)
        {
            if (cantidad > oro)
                throw new ArgumentOutOfRangeException("cantidad", "No tienes suficiente oro");
            oro -= cantidad;
        }

        public void AsignarNPC() { npc = true; }
        public void DesasignarNPC() { npc = false; }

        public void AnyadirResistencia()
        {
            if (npc)
                throw new Exception("Error de resistencia, este personaje es un npc");
            resistencia += 10;
        }

        public void QuitarResistencia()
        {
            if (resistencia <= 0)
                throw new ArgumentOutOfRangeException("resistencia", "La resistencia ya es 0");
            resistencia -= 10;
        }
    }
}
