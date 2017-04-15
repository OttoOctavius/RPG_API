namespace RPG_API.Utils{
    public class NivelHumano : Nivel{
		public static Map<Int,Int> tablaComun;

		public Nivel(Niveliable ente, Int experiencia):super(ente,tablaComun,experiencia);
    
		}

 }
