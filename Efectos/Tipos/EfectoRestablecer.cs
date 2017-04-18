
namespace RPG_API.Efectos{
    public class EfectoRestablecer : EfectoType{

        public EfectoRestablecer(int duracion,int cantidad){
            this.destino = dest;
            duracion = new EfectoGradual(duracion,cantidad);
        }

        public void update(){
            if( duracion.equals(EfectoState.nulo()) )
                (dest as SerVivo).sacarVida( this.getCantidad());
            duracion.update();
        }

    }
	
 }
