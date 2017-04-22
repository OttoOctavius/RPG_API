
namespace RPG_API.Recogibles.Tipos{
    public class UnknowStrategy : TypeStrategy{

		private TypeStrategy interno; 

        public UnknowStrategy(String nombre, String descripcion, TypeStrategy oculto ) : this(oculto);

        public UnknowStrategy( TypeStrategy oculto ) : super("?","?"){
        	this.interno = oculto;
        }

        public TypeStrategy change(){ return oculto; }
        
    }
	
 }