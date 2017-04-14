
namespace RPG_API.Combate.Daño{
    public class DañoFisico : Daño{
 		private float golpe;
		private float corte;
		private float clavar;

		public DañoFisico(float golpe,float corte,float clavar){
			this.golpe = golpe,
			this.corte = corte;
			this.clavar = clavar;
		}

 		public float golpe(){return golpe;}
		public float corte(){return corte;}
		public float clavar(){return clavar;}

		public float remanente(iIntercambioCombate atenuado){
			float recibido = golpe()*atenuado.golpe() + corte()*atenuado.corte() + clavar()*atenuado.clavar();
			this.golpe = golpe()*restante(atenuado.golpe());
			this.corte = corte()*restante(atenuado.corte());
			this.clavar = clavar()*restante(atenuado.clavar());

			return recibido;
		}

        public float descontar(iIntercambioCombate descuento){
			float recibido = 0.0;
			
			this.golpe = golpe() - atenuado.golpe();
			recibido = (golpe()>=0)? atenuado.golpe():-golpe();
			this.golpe = min( golpe(), 0);

			
			fail();//mucha paja de seguir

			return recibido;
		}

		public Daño copia(){	return new DañoFisico(golpe(),corte(),clavar()); }	
    }
}