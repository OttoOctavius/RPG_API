using System;
using System.Collections.Generic;

namespace Utils{
    public class ParametroRecargable : Observer{

	protected Observer involucrado;
	public Observer quien { get{ return involucrado;}}

	bool bloqueado_sumar, bloqueado_restar;
	
	public ParametroRecargable(UInt refmaxima, Observer objetivo){
			maxima = refmaxima;
			actual = new Float(refmaxima.get());
			involucrado = objetivo;
			bloqueado_sumar = bloqueado_restar = false;
	}

	protected Float actual;
	protected UInt maxima;

	public Float getEstado
	{
		get { return actual;}
	}

	public bool Bloqueado_sumar{
			get
			{
				return bloqueado_sumar;
			}

			set
			{
				bloqueado_sumar = value;
			}
	}

	public bool Bloqueado_restar{
			get
			{
				return bloqueado_restar;
			}

			set
			{
				bloqueado_restar = value;
			}
	}

	bool bloqueo(float cantidad)	{
		return (cantidad > 0 && Bloqueado_sumar || cantidad < 0 && Bloqueado_restar);
	}

	public void agregar(float cantidad)	{
		if(bloqueo(cantidad)) return;
			actual.add(cantidad);
			comprobar();
	}

	public void atenuar(float cantidad){
		if(bloqueo(cantidad)) return;
		actual.mult( cantidad );
		comprobar();
	}

	void comprobar(){
		if (actual.get() > maxima.get())
			{
				actual.reduce(actual.get() - maxima.get());
				this.avisar("max");
			}
		else if (actual.get() <= 0)
			{
				actual.add(actual.get());
				this.avisar("0");
			}
	}

	public void avisar(String mensaje){
		involucrado.avisar(mensaje);
	}	

 	}
}
