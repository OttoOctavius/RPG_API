
using System;
using Effects.Duration;
using Utils;

namespace Effects.Type{
    public class EfectoAgotado : EffType{

		public EfectoAgotado(ParametroRecargable objetivo,uint retardo, uint cantidad) 
			:base(objetivo, new DurRetardado(retardo, new DurNormal(cantidad) )){
			
		}

		public override void update()
		{
			throw new NotImplementedException();
		}
	}
	
 }
