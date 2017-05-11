using System;
using System.Collections.Generic;

namespace Utils
{
	public abstract class Variable<T>
	{

		public Variable(T max)
		{
			val = max;
		}

		private T val;

		public T Val
		{
			get { return this.val; }
			set { val = value; }
		}

		public abstract void restaurar(T cantidad);

		public abstract void reducir(T cantidad);

		public abstract void add(T cantidad);

		public abstract void mult(float cantidad);

	}

}
