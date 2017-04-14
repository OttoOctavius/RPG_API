namespace RPG_API.Combate.Daño{
     public class DañoCaos: Daño{
    	private float caos;

		public DañoCaos(float caos){
			this.caos = caos;
		}

    	public float caos(){return caos;}

		public float remanente(iIntercambioCombate atenuado){
			return 0.0;
		}

		public Daño copia(){	return new DañoCaos(caos()); }
    }
}