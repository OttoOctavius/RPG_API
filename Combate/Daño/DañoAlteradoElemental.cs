namespace RPG_API.Combate.Daño{
    public class DañoAlteradoElemental: Daño{
		private float humedad;
		private float quemaduras;
		private float paralisis;

		public DañoAlteradoElemental(float humedad,float quemaduras,float paralisis){
			this.humedad = humedad;
			this.quemaduras = quemaduras;
			this.paralisis = paralisis;
		}

		public float humedad(){return humedad;}
		public float quemaduras(){return quemaduras;}
		public float paralisis(){return paralisis;}

		public float remanente(iIntercambioCombate atenuado){
			float recibido = humedad()*atenuado.humedad() + quemaduras()*atenuado.quemaduras() + paralisis()*atenuado.paralisis();

			this.humedad = humedad()*restante(atenuado.humedad());
			this.quemaduras = quemaduras()*restante(atenuado.quemaduras());
			this.paralisis = paralisis()*restante(atenuado.paralisis());

			return recibido;
		}
		public Daño copia(){	return new DañoAlterado(humedad(),quemaduras(),paralisis()); }
    }
}