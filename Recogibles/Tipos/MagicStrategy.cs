
namespace RPG_API.Recogibles.Tipos{
    public class MagicStrategy : TypeStrategy{

        public MagicStrategy(String nombre, String descripcion ) :super(nombre,descripcion);

        public TypeStrategy change(){ return this; }
        
    }
	
 }