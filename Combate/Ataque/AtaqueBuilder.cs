namespace RPG_API.Combate.Ataque{
    /**Sirve para aclarar cuales son las 
     */
    public class AtaqueBuilder{

        AtaqueComplejo atqComp;

        public AtaqueBuilder(Int maximo){
            atqComp = new AtaqueComplejo(maximo);
        }


    	public AtaqueBuilder agregarSimple(String nombre,float valor){
            this.crear(nombre).agregar(valor);
    		return this;
    	}

        public AtaqueBuilder agregarAtaqueSimple(AtaqueSimple ataque){
            this.atqComp.agregarAtaqueSimple(ataque);
            return this;
        }

        public AtaqueBuilder agregarAtaqueComplejo(AtaqueComplejo ataque){
            this.atqComp.agregarAtaqueComplejo(ataque);
            return this;      
        }

		public override float getDaño(String tipo){ 
            return atqComp.getDaño(tipo);
        }

		iAtaque copia(){ return atqComp.copia(); }
        String[] getTipos(){ return tipos; }
    }
}