namespace RPG_API.Combate.Daño{
    public class DañoMagico: Daño{
    	private float magiaBlanca;
		private float magiaPura;
		private float magiaOscura;

		public float magiaBlanca(){return magiaBlanca;}
		public float magiaPura(){return magiaPura;}
		public float magiaOscura(){return magiaOscura;}

		public DañoMagico(float magiaBlanca,float magiaPura,float magiaOscura){
			this.magiaBlanca = magiaBlanca,
			this.magiaPura = magiaPura;
			this.magiaOscura = magiaOscura;
		}

		public float remanente(iIntercambioCombate atenuado){
			float recibido = magiaBlanca()*atenuado.magiaBlanca() + magiaPura()*atenuado.magiaPura() + magiaOscura()*atenuado.magiaOscura();
			this.magiaBlanca = magiaBlanca()*restante(atenuado.magiaBlanca());
			this.magiaPura = magiaPura()*restante(atenuado.magiaPura());
			this.magiaOscura = magiaOscura()*restante(atenuado.magiaOscura());

			return recibido;
		}	

		public Daño copia(){	return new DañoMagico(magiaBlanca(),magiaPura(),magiaOscura()); }	
    }

}