using Utils;

namespace Effects.Duration{
    public class DurGradual : DurNormal{
		private uint veces;
        public DurGradual(uint vec, uint cantidad):base(cantidad){
			veces = vec;
		}
        
		public override DurNormal update(ParametroRecargable objetivo){
            if( --veces > 0){
				objetivo.agregar(getCantidad);
                return this;
            }
            else{
                return new DurNull();
            }
        }
    }
	
 }
