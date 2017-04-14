namespace RPG_API.Combate.Daño{
    public class DañoAlterado: Daño{
    	private float veneno;
    	private float sangrado;
    	private float maldicion;

		public DañoAlterado(float veneno,float sangrado,float maldicion){
			this.veneno = veneno,
			this.sangrado = sangrado;
			this.maldicion = maldicion;
		}

    	public float veneno(){return veneno;}
    	public float sangrado(){return sangrado;}
    	public float maldicion(){return maldicion;}

		public float remanente(iIntercambioCombate atenuado){
			float recibido = veneno()*atenuado.veneno() + sangrado()*atenuado.sangrado() + maldicion()*atenuado.maldicion();

			this.veneno = veneno()*restante(atenuado.veneno());
			this.sangrado = sangrado()*restante(atenuado.sangrado());
			this.maldicion = maldicion()*restante(atenuado.maldicion());

			return recibido;
		}

		public Daño copia(){	return new DañoAlterado(veneno(),sangrado(),maldicion()); }	
    }
}