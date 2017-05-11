using System;
using System.Collections.Generic;

namespace Utils
{

	public class UInt : Utils.iVar<uint>
	{
		uint valor;

		public UInt(uint val){
			valor = val;
		}

		public void restaurar(uint cantidad)
		{
			valor += cantidad;
		}

		public void reducir(uint cantidad)
		{
            valor -= cantidad;
		}

		public void add(uint cantidad)
		{
			throw new Exception("al pedo");
		}

		public void mult(float cantidad)
		{
			valor = (uint)(valor * cantidad);
		}
	}
}