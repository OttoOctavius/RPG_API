
using System;

namespace Entitys.Tipos{
    public class EquipStrategy : TypeStrategy{

		public EquipStrategy(string nombre, string descripcion) : base(nombre, descripcion)
		{
		}

		public override TypeStrategy change()
		{
			return this;
		}
        
        //public void repair(float cantidad,Requerimiento costo){ }
        private void upgrade(){}
    }
	
 }