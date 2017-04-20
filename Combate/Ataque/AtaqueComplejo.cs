namespace RPG_API.Combate.Ataque{
    /**Sirve para aclarar cuales son las 
     */
    public class AtaqueComplejo : Ataque{
        private Map<String,ParametroRecargable> ataques;
        private float maximo;

        public AtaqueComplejo(Int maximo){
            ataques = new Map<String,ParametroRecargable>();
            this.maximo = maximo;

            foreach (var item in getTipos() )
                ataques.add(item, new ParametroRecargable(maximo,this,item));
            //Llena de todos los tipos el mapa
        }

        public AtaqueComplejo(){
            super(1000);
        }

        private ParametroRecargable crear(String tipo){
            if( ataques.find(tipo) == null){
                ParametroRecargable nuevo = new ParametroRecargable(maximo,this,tipo);
                ataques.add(tipo,nuevo);
                return nuevo;
            } else
            {
                return ataques.find(tipo);
            }
        }


        public void agregarAtaqueSimple(AtaqueSimple ataque){
            this.crear(ataque.tipo).agregar(ataque.getAtaque(ataque.tipo));
        }

        public void atenuarAtaqueSimple(AtaqueSimple ataque){
            this.crear(ataque.tipo).atenuar(ataque.getAtaque(ataque.tipo));
        }

        public void agregarAtaqueComplejo(AtaqueComplejo ataque){
            foreach (var item in ataque.getDom() )
                this.agregarAtaqueSimple(item,ataque.getAtaque());        
        }

		public override float getAtaque(String tipo){ 
            return ataques.find(tipo).getEstado();
        }
        
		iAtaque copia(){ 
            AtaqueComplejo ataq = new AtaqueComplejo(maximo);
            ataq.agregarAtaqueComplejo(this);
            return ataq;
        }

        String[] getDom(){ return ataques.dom(); }
    }
}