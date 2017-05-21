
using System;
using Entitys.Tipos;

namespace Entitys.Tipos{
    public class NormalStrategy : TypeStrategy{

		public NormalStrategy(string nombre, string descripcion) : base(nombre, descripcion) { }

		public override TypeStrategy change()
		{
			return this;
		}

    }
	
 }