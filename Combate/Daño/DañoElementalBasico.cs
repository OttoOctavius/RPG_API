
namespace RPG_API.Combate.Daño{  
    
    public class DañoElementalBasico: Daño{
		private float viento;
		private float agua;
		private float tierra;

		public float viento(){return viento;}
		public float agua(){return agua;}
		public float tierra(){return tierra;}

		public DañoElementalBasico(float viento,float agua ,float tierra){
			this.viento = viento;
			this.agua = agua;
			this.tierra = tierra;
		}

		public float remanente(iIntercambioCombate atenuado){
			float recibido = viento()*atenuado.viento() + agua()*atenuado.agua() + tierra()*atenuado.tierra();
			this.viento = viento()*restante(atenuado.viento());
			this.agua = agua()*restante(atenuado.agua());
			this.tierra = tierra()*restante(atenuado.tierra());

			return recibido;
		}		

		public Daño copia(){	return new DañoElementalBasico(viento(),agua(),tierra()); }	
    }
}