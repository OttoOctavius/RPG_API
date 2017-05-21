
using Entitys.Tipos;

namespace Entitys.Tipos{
    public class MagicStrategy : TypeStrategy{

		public MagicStrategy(string nombre, string descripcion) : base(nombre, descripcion)
		{
		}

        public override TypeStrategy change(){ return this; }
        
    }
	
 }