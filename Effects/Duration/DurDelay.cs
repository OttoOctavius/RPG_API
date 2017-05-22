using Utils;

namespace Effects.Duration{
    public class DurRetardado : DurNormal{

		private uint retardo;
        private DurNormal tipoduracion;

        public DurRetardado(uint retardo, DurNormal tipoduracion)
                       : base(0){
                this.tipoduracion = tipoduracion;
				this.retardo = retardo;
        }

		public override DurNormal update(ParametroRecargable objetivo)
		{
			if (--retardo > 0)
			{
				return this;
			}
			else
			{
				return tipoduracion;
			}
		}
    }
	
 }
