using System;
using System.Collections.Generic;

namespace RPG_API.Utils{
    public class Durabilidad{    	
		float actual,maxima;
		Rompible involucrado;

	public Durabilidad(float maximo, Equipo objetivo){
		actual = maxima = maximo;
		involucrado = objetivo;
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
