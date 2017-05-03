
namespace RPG_API.Efectos{
    public class EfectoNormal{
           
        protected int veces;
        public int getVeces
        {
            get { return veces;};
        }
        
        protected int cantidad;
        public int getCantidad
        {
            get { return cantidad;}
        }

        public EfectoNormal(int vec, int cantidad){
            this.veces = vec;
            this.cantidad = cantidad;
        }

        public EfectoNormal update(ParametroRecargable objetivo){
            objetivo.restaurar(cantidad);
            //No usa las veces, es permanente
        }

    }
	
 }
