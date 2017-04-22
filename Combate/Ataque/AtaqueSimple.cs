namespace RPG_API.Combate.Ataque{
    public class AtaqueSimple : AtaqueNulo{

        protected String tipo1;
        protected float ataque1;

        public String tipo { get{return tipo1;};}
        
        private float maximo;

        public AtaqueSimple(String tipo, float val,float maximo){
            tipo1 = tipo;
            this.maximo = maximo;
            ataque1 = (val>maximo)?maximo:val; 
        }

        public AtaqueSimple(String tipo, float val){
            tipo1 = tipo;
            maximo = val;
            ataque1 = val;
        }

		public override float getAtaque(String tipo){ 
            if( tipo1.equals(tipo) )
                return ataque1;
            else
                return 0.0;
        }

		iAtaque copia(){ return new AtaqueSimple(tipo1,ataque1,maximo); }
        String[] getTipos(){ return tipos; }
    }
}