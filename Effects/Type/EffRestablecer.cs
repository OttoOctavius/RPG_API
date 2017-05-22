using System;
using Utils;
using Effects.Duration;
using Effects.Type;

namespace Effects.Type{
	public class EffRestablecer : EffType{

		public EffRestablecer(ParametroRecargable obj,uint duracion,uint cantidad)
			: base(obj,new DurGradual(duracion,cantidad)){
        }

        public override void update(){
			duracion = duracion.update(objetivo);
        }

    }
	
 }
