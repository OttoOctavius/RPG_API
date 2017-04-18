
namespace RPG_API.Efectos{
    public class EfectoInmediato : EfectoNormal{
        public EfectoInmediato(int cantidad): super(1,cantidad){}

        public EfectoNormal update(ParametroRecargable objetivo){
                objetivo.agregar(cantidad);
                return new EfectoNulo();
        }
    }
	
 }
