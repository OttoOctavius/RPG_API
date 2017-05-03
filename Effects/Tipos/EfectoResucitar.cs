using RPG_API.Efectos.Duracion;

namespace RPG_API.Efectos{
    public class EfectoResucitar : Efectotype{

        public EfectoResucitar(ParametroRecargable objetivo,float porcentaje)
            :super(objetivo, new EfectoInmediato( porcentaje*objetivo.getEstado() ));

        void avisar(String mensaje){
             if( (dest as SerVivo).murio() )
                ;
        }
    }
	
 }
