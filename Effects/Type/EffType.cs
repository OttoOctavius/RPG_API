using System;
using Utils;
using Effects.Duration;

namespace Effects.Type{
	public abstract class EffType : Observer{
        protected ParametroRecargable objetivo;
        protected DurNormal duracion;

		public EffType(ParametroRecargable objetivo, DurNormal tipoduracion)
		{
			this.objetivo = objetivo;
			duracion = tipoduracion;
		}

		public virtual void update()
		{
			if( !duracion.Equals(new DurNull() ) )
                duracion.update( this.objetivo );
			else
				this.avisar(objetivo.ToString());
		}

		public void avisar(string mensaje)
		{
			objetivo.avisar(mensaje);
		}
	}
	
 }
