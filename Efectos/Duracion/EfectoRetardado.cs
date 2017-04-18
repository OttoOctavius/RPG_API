
namespace RPG_API.Efectos{
    public class EfectoRetardado : EfectoNormal{

        private EfectoNormal tipoduracion;

        public EfectoRetardado(ParametroRecargable objetivo,uint retardo, EfectoNormal tipoduracion)
                       : super(retardo,0){
                this.tipoduracion = tipoduracion;
        }
        
        public EfectoNormal update(ParametroRecargable objetivo){
            if( --vec > 0){
                return this;
            }
            else{
                return tipoduracion;
            }
    }
	
 }
