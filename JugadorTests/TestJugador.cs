using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JugadorNS;

namespace JugadorTests
{
    [TestClass]
    public class TestJugador
    {
        
        [TestMethod]
        public void CrearJugador_ConNombre_NombreAsignadoCorrectamente()
        {
            Jugador j = new Jugador("Ash");
            Assert.AreEqual("Ash", j.GetNombre());
        }

        
        [TestMethod]
        public void AnyadirOro_CantidadValida_OroIncrementaCorrectamente()
        {
            Jugador j = new Jugador("Ash");
            j.AnyadirOro(50.0);
            Assert.AreEqual(50.0, j.GetOro(), 0.001);
        }

        
        [TestMethod]
        public void CrearJugador_VidaInicialEsCien()
        {
            Jugador j = new Jugador("Ash");
            Assert.AreEqual(100, j.GetVida());
        }

        
        [TestMethod]
        public void CrearJugador_NpcEsFalseInicial()
        {
            Jugador j = new Jugador("Ash");
            Assert.IsFalse(j.IsNpc());
        }

        
        [TestMethod]
        public void AsignarNPC_NpcPasaASerTrue()
        {
            Jugador j = new Jugador("Ash");
            j.AsignarNPC();
            Assert.IsTrue(j.IsNpc());
        }

        
        [TestMethod]
        public void DesasignarNPC_DespuesDeAsignar_NpcEsFalse()
        {
            Jugador j = new Jugador("Ash");
            j.AsignarNPC();
            j.DesasignarNPC();
            Assert.IsFalse(j.IsNpc());
        }

        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QuitarOro_MasDelDisponible_LanzaExcepcion()
        {
            Jugador j = new Jugador("Ash");
            j.QuitarOro(100.0);
        }

        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void QuitarResistencia_CuandoEsCero_LanzaExcepcion()
        {
            Jugador j = new Jugador("Ash");
            
            for (int i = 0; i < 5; i++) j.QuitarResistencia();
            j.QuitarResistencia(); 
        }

        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CambiarNombre_ANulo_LanzaExcepcion()
        {
            Jugador j = new Jugador("Ash");
            j.CambiarNombre(null);
        }

        
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CrearJugador_ConNombreNulo_LanzaExcepcion()
        {
            Jugador j = new Jugador(null);
        }

        
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AnyadirResistencia_SiEsNpc_LanzaExcepcion()
        {
            Jugador j = new Jugador("Ash");
            j.AsignarNPC();
            j.AnyadirResistencia();
        }
    }
}
