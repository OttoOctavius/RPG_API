
namespace RPG_API.Combate.Daño{
    public abstract class Daño : iIntercambioDañoCombate, iIntercambioEfectosCombate{

		public float getDaño(String tipo){
			switch (tipo){
				case "golpe": return golpe();
				case "corte": return corte();
				case "clavar": return clavar();

    			case "magiaBlanca": return magiaBlanca();
				case "magiaPura": return magiaPura();
				case "magiaOscura": return magiaOscura();

				case "viento": return viento();
				case "agua": return agua();
				case "tierra": return tierra();

				case "fuego": return fuego();
				case "hielo": return hielo();
				case "electricidad": return electricidad();
				default: return otros(tipo);
			}
		}

		protected virtual float otros(String tipo){return 0.0;}

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

		//los template method salvando las papas
		public float remanente(iIntercambioCombate atenuado);
		public float descontar(iIntercambioCombate descuento);

		protected float restante(float num){ return 1 - num; }

		public iIntercambioDañoCombate copia();

		public String[] getTipos(){ 
			return {"golpe", "corte", "clavar", "magiaBlanca", "magiaPura", "magiaOscura",
					"viento", "agua", "tierra", "fuego", "hielo", "electricidad", "caos" };
		}
    }
	
 }


