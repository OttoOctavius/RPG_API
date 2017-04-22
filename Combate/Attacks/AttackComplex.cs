using RPG_API.Combate;

namespace RPG_API.Combate.Attacks{
    /**Sirve para aclarar cuales son las 
     */
    public class AttackComplex : iAttack{
        private Map<String,ParametroRecargable> ataques;
        private Int maximo;

        public int getMaximo(){ return maximo; }
        
        public AttackComplex(Int maximo){
            ataques = new Map<String,ParametroRecargable>();
            this.maximo = maximo;

            //foreach (var item in this.getTypes() )
            //    ataques.add(item, new ParametroRecargable(maximo,this,item));
            //Llena de todos los tipos el mapa
        }

        public AttackComplex() : super(1000){
            
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


        public AttackBuilder addAttackSimple(AttackSimple ataque){
            String tipo = ataque.tipo;
            this.crear(tipo).agregar(ataque.getAttack(tipo));
            return this;
        }

        public AttackBuilder remAttackSimple(AttackSimple ataque){
            String tipo = ataque.tipo;
            this.crear(tipo).atenuar( ataque.getAttack(tipo) );
            return this;
        }

        public AttackBuilder addAttackComplex(AttackComplex ataque){
            foreach (var item in ataque.getTypes() )
                this.addAttackSimple(item,ataque.getAttack());

            return this;        
        }

		public override float getAttack(String tipo){
            return ataques.find(tipo).getEstado();
        }
        
        iAttack copy(){ 
            AttackComplex ataq = new AttackComplex(maximo);
            ataq.agregarAtaqueComplejo(this);
            return ataq;
        }

        String[] getTypes(){ return ataques.dom(); }

    }
}