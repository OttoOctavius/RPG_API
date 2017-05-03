namespace RPG_API.Combate.Attacks{
    public class AttackSimple : iAttack{

        protected String tipo1;
        protected float ataque1;
        
        private float maximo;

        public AttackSimple(String tipo, float val,float maximo){
            tipo1 = tipo;
            this.maximo = maximo;
            ataque1 = (val>maximo)?maximo:val;
        }

        public AttackSimple(String tipo, float val){
            tipo1 = tipo;
            maximo = val;
            ataque1 = val;
        }
c
		public override float getAttack(String tipo){ 
            if( tipo1.equals(tipo) )
                return ataque1;
            else
                return 0.0;
        }

		iAtaque copy(){ return new AttackSimple(tipo1,ataque1,maximo); }
        String[] getTypes(){ return tipos; }
    }
}