using Effects.Duration;
using Utils;

namespace Effects.Type{
	public class EffEnvenenamiento : EffType{

		public EffEnvenenamiento(ParametroRecargable objetivo, uint duracion, uint cantidad)
			: base(objetivo, new DurGradual(duracion, cantidad) ){

			}

    }
	
 }
