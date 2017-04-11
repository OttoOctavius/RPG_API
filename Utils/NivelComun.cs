namespace RPG_API.Utils{
    public class Nivel{
		static Map<Int,Int> tablaComun;

		public void asignarTabla(Map<Int,Int> tablaNiveles){
			tablaComun = tablaNiveles;
		}

		public Nivel(Niveliable ente, Int experiencia):super(ente,tablaComun,experiencia);
    }

 }
