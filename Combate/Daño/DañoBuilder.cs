namespace RPG_API.Combate.Daño{
    public class DañoBuilder{
    	private DañoCombinado acumulacion;

    	public DañoCombinado(){
    		this.acumulacion = new DañoCombinado(new DañoFisico(0,0,0));
    	}
    	
        protected bool nulos(float f1,float f2,float f3){
            return f1<0f || f2<0f || f3<0f;
        }

        protected bool condicion(float f1,float f2,float f3){ return !nulos(float f1,float f2,float f3) };

		public DañoBuilder addDañoIndividual(String tipo,float valor){
			switch (tipo){
				case "golpe": { this.agregarFisico(valor,0,0); break;};
				case "corte": { this.agregarFisico(0,valor,0); break;};
				case "clavar": { this.agregarFisico(0,0,valor); break;};

    			case "magiaBlanca": { this.agregarMagia(valor,0,0); break;};
				case "magiaPura": { this.agregarMagia(0,valor,0); break;};
				case "magiaOscura": { this.agregarMagia(0,0,valor); break;};

				case "viento": { this.agregarElementalBasico(valor,0,0); break;};
				case "agua": { this.agregarElementalBasico(0,valor,0); break;};
				case "tierra": { this.agregarElementalBasico(0,0,valor); break;};

				case "fuego": { this.agregarElemental(valor,0,0); break;};
				case "hielo": { this.agregarElemental(0,valor,0); break;};
				case "electricidad": { this.agregarElemental(0,0,valor); break;};
				default: return otros(tipo);
			}
			return this;
		}

		protected virtual float setotros(String tipo){}

    	public DañoBuilder agregarFisico(float golpe,float corte,float clavar){
            if( condicion(golpe,corte,clavar) )
    		    this.acumulacion.add( new DañoFisico(golpe,corte,clavar) );
    		return this;
    	}

    	public DañoBuilder agregarMagia(float mBlanca,float mPura,float mOscura){
            if( condicion(mBlanca,mPura,mOscura) )
    		    this.acumulacion.add( new DañoMagico(mBlanca,mPura,mOscura));
    		return this;
    	}

    	public DañoBuilder agregarCaos(float caos){
            if( condicion(caos,caos,caos) )
    		    this.acumulacion.add( new DañoCaos(caos));
    		return this;
    	}

    	public DañoBuilder agregarElemental(float fuego,float hielo,float electricidad){
            if( condicion(fuego,hielo,electricidad) )
    		    this.acumulacion.add( new DañoElemental(fuego,hielo,electricidad));
    		return this;
    	}

    	public DañoBuilder agregarElementalBasico(float viento,float agua,float tierra){
    		 if( condicion(viento,agua,tierra) )
                this.acumulacion.add( new DañoElementalBasico(viento,agua,tierra) );
    		return this;
    	}

    	//Por favor, no metas el mismo dañoMixto aqui, reventara
    	public DañoBuilder agregarDaño(Daño daño){
    		this.acumulacion.add( daño );
    		return this;
    	}

    	public Daño build(){
    		DañoCombinado nuevo = new DañoCombinado();
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
    	
 		public float golpe(){   return acumulacion.golpe(); } 
		public float corte(){  return acumulacion.corte(); } 
		public float clavar(){ return acumulacion.clavar(); } 

    	public float magiaBlanca(){ return acumulacion.magiaBlanca(); } 
		public float magiaPura(){ return acumulacion.magiaPura(); } 
        public float magiaOscura(){ return acumulacion.magiaOscura(); } 

		public float viento(){ return acumulacion.viento(); } 
		public float agua(){ return acumulacion.agua(); } 
		public float tierra(){ return acumulacion.tierra(); } 

		public float fuego(){ return acumulacion.fuego(); } 
		public float hielo(){ return acumulacion.hielo(); } 
		public float electricidad(){ return acumulacion.electricidad(); } 

		public float caos(){  return acumulacion.caos(); } 


    	public float remanente(iIntercambioCombate atenuado){
    		float total = 0.0;
    		foreach(Daño daño in acumulacion)
    			total = daño.remanente(atenuado);

			return total;
		}
    }    
}