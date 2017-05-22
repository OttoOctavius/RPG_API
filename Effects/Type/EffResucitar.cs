using System;
using Utils;
using Effects.Duration;

namespace Effects.Type {
	public class EffResucitar : EffType{

		public EffResucitar(ParametroRecargable objetivo,float porcentaje)
			: base(objetivo, new DurInmediato( (uint)(porcentaje * objetivo.getEstado.get() ))){

		}

		public override void update(){
			objetivo.Bloqueado_sumar = true;
			duracion = duracion.update(objetivo);
		}
    }
	
 }
