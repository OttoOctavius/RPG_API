using System;
using System.Collections.Generic;

namespace Utils
{

	public class VariableUInt : Variable<uint>
	{

		public VariableUInt(uint val) : base(val) { }

		public override void restaurar(uint cantidad)
		{
			this.Val = this.Val + cantidad;
		}

		public override void reducir(uint cantidad)
		{
            this.Val = this.Val - cantidad;
		}

		public override void add(uint cantidad)
		{
			throw new Exception("al pedo");
		}

		public override void mult(float cantidad)
		{
			this.Val = (uint)(this.Val * cantidad);
		}
	}
}