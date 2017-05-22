using Utils;

namespace Effects.Duration{
    public class DurNormal{
        
        private uint cantidad;
        public uint getCantidad
        {
            get { return cantidad;}
        }

        public DurNormal(uint cantidad){
            this.cantidad = cantidad;
        }

		public virtual DurNormal update(ParametroRecargable objetivo){
			objetivo.agregar(cantidad);
			//No usa las veces, es permanente
			return this;
        }

    }
	
 }
