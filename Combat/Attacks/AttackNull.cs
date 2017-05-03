namespace RPG_API.Combate.Attacks{
    /**Sirve para aclarar cuales son las 
     */
    public class AttackNull : iAttack{

		private String tipo;

    	public AttackNull(String type){
    		tipo = type;
    	}

		float getAttack(String tipo){ return 0.0;}
		iAtaque copy(){ return new AttackNull(); }
        String[] getTypes(){ return new AttackSimple(tipo,0f); }
    }
}