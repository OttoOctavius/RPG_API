
namespace RPG_API.Efectos{
    public class EfectoGradual : EfectoNormal{
        public EfectoGradual(int vec, int cantidad):super(vec,cantidad){}
        
        public EfectoNormal update(ParametroRecargable objetivo){
            if( --vec > 0){
                objetivo.agregar(cantidad);
                return this;
            }
            else{
                return new EfectoNulo();
            }
        }
    }
	
 }
