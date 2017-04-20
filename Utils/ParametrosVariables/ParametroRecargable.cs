using System;
using System.Collections.Generic;

namespace RPG_API.Utils.ParametrosVariables{
    public class ParametroRecargable : Observer{

    List<EfectoType> acumulados;
	String mensaje;
	protected Observer involucrado;
	public Observer quien { get{ return involucrado;};}

	public ParametroRecargable(Int maximo, Observer objetivo, String mensaje){
		maxima = maximo;
        actual = maxima;
		involucrado = objetivo;
		this.mensaje = mensaje;
	}

	protected float actual;
    protected Int maxima;
	public int getEstado
	{
		get { return actual;};
	}	

	public void agregar(float cantidad){
		if(cantidad > 0)
			restaurar(cantidad);
		else
			reducir(-cantidad);
	}

	public void reducir(float cantidad){
		actual -= cantidad;
		if( actual <= 0 ){
			actual = 0;
			this.avisar(mensaje);
		}
	}

	public void restaurar(float cantidad){
		actual += cantidad;
		if( actual > maxima)
			actual = maxima;
	}

	public void atenuar(float cantidad){
		actual *= cantidad;
		if( actual > maxima)
			actual = maxima;
		else if( actual <= 0 ){
			actual = 0;
			this.avisar(mensaje);
		}
	}




	public void avisar(String mensaje){
		involucrado.avisar(mensaje);
	}	

 	}
}
