
namespace RPG_API.Combate.Daño{
    public class DañoElemental: Daño{
		private float fuego;
		private float hielo;
		private float electricidad;

		public DañoElemental(float fuego,float hielo,float electricidad){
			this.fuego = fuego;
			this.hielo = hielo;
			this.electricidad = electricidad;
		}

		public float fuego(){return fuego;}
		public float hielo(){return hielo;}
		public float electricidad(){return electricidad;}

		public float remanente(iIntercambioCombate atenuado){
			float recibido = fuego()*atenuado.fuego() + hielo()*atenuado.hielo() + electricidad()*atenuado.electricidad();
			this.fuego = fuego()*restante(atenuado.fuego());
			this.hielo = hielo()*restante(atenuado.hielo());
			this.electricidad = electricidad()*restante(atenuado.electricidad());

			return recibido;
		}

		public Daño copia(){	return new DañoElemental(fuego(),hielo(),electricidad()); }	
    }
}