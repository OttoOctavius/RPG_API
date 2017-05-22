using System;
using System.Collections.Generic;

namespace Utils.Niveles{
    public class Nivel{
		uint nivel;
		uint experiencia;
		Dictionary<uint,uint> tabla;
		Niveliable ente;

		public Nivel(Niveliable ente,Dictionary<uint,uint> tablaNiveles, uint nivel,uint experiencia){
			this.ente = ente;
			tabla = tablaNiveles;
			this.experiencia = experiencia;
			this.nivel = nivel;
		}

		public bool puedeSubir(){
			return false;
		}

		public void subir(){
			nivel++;
			ente.subioNivel();
		}
    }

 }
