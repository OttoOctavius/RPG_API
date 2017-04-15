namespace RPG_API.Utils{
    public class Nivel{
		uint nivel;
		uint experiencia;
		Map<Int,Int> tabla;
		Niveliable ente;

		public Nivel(Niveliable ente,Map<Int,Int> tablaNiveles, uint nivel,uint experiencia){
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
