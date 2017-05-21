
using Entitys.Tipos;

namespace Entitys.Tipos{
    public class UnknowStrategy : TypeStrategy{

		private TypeStrategy interno;

		public UnknowStrategy(string nombre, string descripcion, TypeStrategy oculto) : base(nombre,descripcion) { 
            this.interno = oculto;
		}

        public UnknowStrategy( TypeStrategy oculto ) : base("?","?"){
        	this.interno = oculto;
        }

		public override TypeStrategy change(){ return interno; }
        
    }
	
 }