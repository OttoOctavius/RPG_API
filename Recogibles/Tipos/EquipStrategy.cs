
namespace RPG_API.Recogibles.Tipos{
    public class EquipStrategy : TypeStrategy{

        public EquipStrategy( String nombre, String descripcion) :super(nombre,descripcion);

        public TypeStrategy change(){return this;}
        
        public void repair(float cantidad,Requerimiento costo){ }
        private void upgrade(){}
    }
	
 }