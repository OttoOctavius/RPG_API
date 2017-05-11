using System;
using System.Collections.Generic;

namespace Utils
{

	public class Variablefloat : Variable<float>
	{

		public Variablefloat(float val) : base(val) { }

		public override void restaurar(float cantidad)
		{
			this.Val = this.Val + cantidad;
		}

		public override void reducir(float cantidad)
		{
            this.Val = this.Val - cantidad;
		}

		public override void add(float cantidad)
		{
			throw new Exception("al pedo");
		}

		public override void mult(float cantidad)
		{
			this.Val = (this.Val * cantidad);
		}
	}
}