using System;
using System.Collections.Generic;

namespace RPG_API.Utils{
    public class Durabilidad{


	protected Rompible involucrado;
	public int deQue { get{ return involucrado;};}

	public Durabilidad(float maximo, Rompible objetivo){
		actual = maxima = maximo;
		involucrado = objetivo;
	}



	protected float actual,maxima;
	public int getEstado
	{
		get { return actual;}
	}	

	public reducir(float cantidad){
		actual -= cantidad;
		if( this.seRompio())
			involucrado.seRompio();
	}

	public restaurar(float cantidad){
		actual += cantidad;
		if( actual > maxima)
			actual = maxima;
	}

	public seRompio(){
		return actual <= 0.0;
	}	

 	}
}
