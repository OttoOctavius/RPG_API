using System;
using System.Collections.Generic;

namespace Utils
{

public class Float : iVar<float>
{
	float valor;

	public Float(float val)
	{
		valor = val;
	}

	public void add(float cantidad)
	{
		valor += cantidad;
	}

	public void reduce(float cantidad)
	{
		valor -= cantidad;
	}

	public void mult(float cantidad)
	{
		valor *= cantidad;
	}

	public float get(){
		return valor;
	}

	public float nulo(){
			return 0f;
	}

	public iVar<float> copy()
	{
			return new Float(valor);
	}

	public int CompareTo(object obj){
		Float comp = (Float)obj;
		return get().CompareTo(comp.get());
	}

	public void set(float t){
			valor = t;	
	}

	}
}