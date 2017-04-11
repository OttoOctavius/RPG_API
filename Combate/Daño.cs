
namespace RPG_API{
    public abstract class Daño : iIntercambioDañoCombate, iIntercambioEfectosCombate{
 		public float golpe(){return 0.0;}
		public float corte(){return 0.0;}
		public float clavar(){return 0.0;}

    	public float magiaBlanca(){return 0.0;}
		public float magiaPura(){return 0.0;}
		public float magiaOscura(){return 0.0;}

		public float viento(){return 0.0;}
		public float agua(){return 0.0;}
		public float tierra(){return 0.0;}

		public float fuego(){return 0.0;}
		public float hielo(){return 0.0;}
		public float electricidad(){return 0.0;}

		public float caos(){return 0.0;}

    	public float veneno(){return 0.0;}
    	public float sangrado(){return 0.0;}
    	public float maldicion(){return 0.0;}

		public float humedad(){return 0.0;}
		public float quemaduras(){return 0.0;}
		public float paralisis(){return 0.0;}

		//los template method salvando las papas
		public float remanente(iIntercambioCombate atenuado);
		public float descontar(iIntercambioCombate descuento);

		protected float restante(float num){ return 1 - num; }

		public Daño copia();
    }

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


