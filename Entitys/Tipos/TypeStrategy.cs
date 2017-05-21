
using Combat;
using Entitys.Raza;
using Recogibles;

namespace Entitys.Tipos{
    public abstract class TypeStrategy : iRecogibles{

        private string nombre;
        private string descripcion;
        //public Requerimientos req;

        public TypeStrategy( string nombre, string descripcion){
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        
        public abstract TypeStrategy change();
		public delegate void check(SerVivo usuario);

        public string getNombre() {  return nombre; }
        public string getDescripcion() { return descripcion; }

		public virtual Damage tirar() { return null; }

		protected Damage penalization(){ return null; }
    }
	
 }