namespace RPG_API.Combate.Daño{
    public class DañoMixto: Daño{
    	private List<Daño> acumulacion;

    	public DañoMixto()){
    		this.acumulacion = new List<Daño>();
    	}
    	
    	public DañoMixto agregarFisico(float golpe,float corte,float clavar){
    		this.acumulacion.add( new DañoFisico(golpe,corte,clavar) );
    		return this;
    	}

    	public DañoMixto agregarMagia(float mBlanca,float mPura,float mOscura){
    		this.acumulacion.add( new DañoMagico(mBlanca,mPura,mOscura));
    		return this;
    	}

    	public DañoMixto agregarCaos(float caos){
    		this.acumulacion.add( new DañoCaos(caos));
    		return this;
    	}

    	public DañoMixto agregarElemental(float fuego,float hielo,float electricidad){
    		this.acumulacion.add( new DañoElemental(fuego,hielo,electricidad));
    		return this;
    	}

    	public DañoMixto agregarElementalBasico(float viento,float agua,float tierra){
    		this.acumulacion.add( new DañoElementalBasico(viento,agua,tierra) );
    		return this;
    	}

    	public DañoMixto agregarAlterados(float veneno,float sangrado,float maldicion){
    		this.acumulacion.add( new DañoAlterado(veneno,sangrado,maldicion));
    		return this;
    	}

    	public DañoMixto agregarElementalAlterados(float humedad,float quemaduras,float paralisis){
    		this.acumulacion.add( new DañoAlteradoElemental(humedad,quemaduras,paralisis) );
    		return this;
    	}

    	//Por favor, no metas el mismo dañoMixto aqui, reventara
    	public DañoMixto agregarDaño(Daño daño){
    		this.acumulacion.add( daño );
    		return this;
    	}

    	public Daño build(){
    		DañoMixto nuevo = new DañoMixto();
    		nuevo.agregarFisico(golpe(),corte(),clavar())
    			.agregarElementalBasico(viento(),agua(),tierra())
    			.agregarElemental(fuego(),hielo(),electricidad())
    			.agregarCaos(caos())
    			.agregarMagia(magiaBlanca(),magiaPura(),magiaOscura())
    			.agregarAlterados(veneno(),sangrado(),maldicion())
    			.agregarElementalAlterados(humedad(),quemaduras(),paralisis());

    		return nuevo;

    	}

		public Daño copia(){	return this.build(); }
    	
 		public float golpe(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.golpe();
    		return total;
   		}
		public float corte(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.corte();
    		return total;
   		}
		public float clavar(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.clavar();
    		return total;
   		}

    	public float magiaBlanca(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.magiaBlanca();
    		return total;
   		}
		public float magiaPura(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.magiaPura();
    		return total;
   		}
		public float magiaOscura(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.magiaOscura();
    		return total;
   		}

		public float viento(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.viento();
    		return total;
   		}
		public float agua(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.agua();
    		return total;
   		}
		public float tierra(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.tierra();
    		return total;
   		}

		public float fuego(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.fuego();
    		return total;
   		}
		public float hielo(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.hielo();
    		return total;
   		}
		public float electricidad(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.electricidad();
    		return total;
   		}

		public float caos(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.caos();
    		return total;
   		}
    	public float veneno(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.veneno();
    		return total;
   		}
    	public float sangrado(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.sangrado();
    		return total;
   		}
    	public float maldicion(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.maldicion();
    		return total;
   		}

		public float humedad(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.humedad();
    		return total;
   		}
		public float quemaduras(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.quemaduras();
    		return total;
   		}
		public float paralisis(){
 			float total = 0.0;
 			foreach(Daño daño in acumulacion)
    			total += daño.paralisis();
    		return total;
   		}


    	public float remanente(iIntercambioCombate atenuado){
    		float total = 0.0;
    		foreach(Daño daño in acumulacion)
    			total = daño.remanente(atenuado);

			return total;
		}
    }    
}