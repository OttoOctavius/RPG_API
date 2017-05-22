using System;
using Utils;

namespace Effects.Duration{
    public class DurInmediato : DurNormal{
		public DurInmediato(uint cantidad): base(cantidad){}

        public override DurNormal update(ParametroRecargable objetivo){
				objetivo.agregar(getCantidad);
                return new DurNull();
        }
    }
	
 }
