using System;
using System.Collections.Generic;

namespace Utils
{
	public interface iVar<T> : IComparable
	{
		T get();
		T nulo();

		void add(T cantidad);

		void reduce(T cantidad);

		void mult(float cantidad);

		iVar<T> copy();

		void set(T t);
	}

}
