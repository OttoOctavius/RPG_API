
namespace RPG_API.Efectos{
    public abstract class EfectoState{
        protected Ente destino;
        public Ente getDestinario
        {
            get { return destino;}
        }
        
        protected int velocidad;
        public int getVelocidad
        {
            get { return velocidad;}
        }
        
        protected int cantidad;
        public int getCantidad
        {
            get { return cantidad;}
        }

        public EfectoState(Ente dest, int vel, int cantidad){
            this.destino = dest;
            this.velocidad = vel;
            this.cantidad = cantidad;
        }

        public void update();

    }
	
 }
