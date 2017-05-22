using System;
using System.Collections.Generic;

namespace Utils
{

	public class UInt : Utils.iVar<uint>
	{
		uint valor;
		public uint get() { return valor; }

		public UInt(uint val){
			valor = val;
		}

		public void add(uint cantidad)
		{
			valor += cantidad;
		}

		public void reduce(uint cantidad)
		{
            valor -= cantidad;
		}

		public void mult(float cantidad)
		{
			valor = (uint)(valor * cantidad);
		}

		public uint nulo()
		{
			return 0;
		}

		public iVar<uint> copy()
		{
			return new UInt(this.get());
		}

		public int CompareTo(object obj)
		{
			UInt comp = (UInt) obj;
			return get().CompareTo(comp.get());
		}

		public void set(uint t)
		{
			valor = t;
		}


	}
}