
namespace RPG_API.Efectos{
    public class EfectoEnvenenamiento : EfectoType{

        public EfectoEnvenenamiento(int duracion,int cantidad){
            this.destino = dest;
            duracion = new EfectoGradual(duracion,-cantidad);
        }

        public void update(){
            if( !duracion.equals(new EfectoNulo() )
                duracion.update( this.objetivo );
            else
                this.avisar("veneno");
        }

    }
	
 }
