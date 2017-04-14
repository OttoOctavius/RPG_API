namespace RPG_API.Combate.Daño{
    public class DañoCombinado : Daño{
    	public DañoCombinado nodo, hoja;

    	public DañoCombinado( Daño interno ){
    		this.nodo = interno;
    	}
    	
    	//Por favor, no metas el mismo dañoMixto aqui, reventara
    	public void add(Daño daño){
			if( hoja==null)
				hoja = new DañoCombinado(daño);
			else
				hoja.add(daño);
    	}

		public Daño copia(){
			DañoCombinado nuevo = new DañoCombinado(nodo);
			if( hoja == null )
				nuevo.hoja = null;
			else
				nuevo.hoja = this.hoja.copia();
			return this.build();
		 }
    	
 		private float buscador(String nombre){
 			float total = this.nodo.getTipo(nombre);
 			if( hoja != null )
				total += hoja.getTipo(nombre);
    		return total;
   		}
		
		public float golpe(){ return this.buscador("golpe"); }
		public float corte(){ return this.buscador("corte"); }
		public float clavar(){  return this.buscador("clavar"); }

    	public float magiaBlanca(){ return this.buscador("magiaBlanca"); }
		public float magiaPura(){   return this.buscador("magiaPura"); }
		public float magiaOscura(){   return this.buscador("magiaOscura"); }

		public float viento(){ return this.buscador("viento"); }
		public float agua(){ return this.buscador("agua"); }
		public float tierra(){ return this.buscador("tierra"); }

		public float fuego(){ return this.buscador("fuego"); }
		public float hielo(){ return this.buscador("hielo"); }
 		public float electricidad(){ return this.buscador("electricidad"); }
 	
		public float caos(){  return this.buscador("caos"); }

    	public float remanente(iIntercambioCombate atenuado){
    		float total = 0.0;
    		foreach(Daño daño in this.getTipo())
    			total += daño.remanente(atenuado);

			return total;
		}
    }    
}