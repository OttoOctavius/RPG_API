
namespace RPG_API.Efectos{
    public abstract class EfectoType : Observer{
        protected ParametroRecargable objetivo;
        protected EfectoState tipoduracion;

        public Ente getDestinario
        {
            get { return destino;};
        }

        public EfectoState(ParametroRecargable objetivo,EfectoState tipoduracion){
            this.objetivo = objetivo;
            tipoduracion = tipoduracion;
        }

        public void update();
        public void avisar(String mensaje);
    }
	
 }
