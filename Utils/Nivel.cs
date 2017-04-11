namespace RPG_API.Utils{
    public class Nivel{
		Int nivel;
		Int experiencia;
		Map<Int,Int> tabla;

		public Nivel(Niveliable ente,Map<Int,Int> tablaNiveles, Int experiencia){
			tabla = tablaNiveles;
			this.experiencia = experiencia;
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
