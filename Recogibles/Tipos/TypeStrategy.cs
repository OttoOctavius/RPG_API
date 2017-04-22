
namespace RPG_API.Recogibles.Tipos{
    public abstract class TypeStrategy : iRecogibles{

        private String nombre;
        private String descripcion;
        public Requerimientos req;

        public TypeStrategy( String nombre, String descripcion){
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        
        public TypeStrategy change();
        public bool check(SerVivo usuario);

        public String getNombre() {  return nombre; }
        public String getDescripcion() { return descripcion; }

        public Damage throw();
        protected Damage penalization();
    }
	
 }