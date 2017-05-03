namespace RPG_API{
    public interface iAttack{
		float getAttack(String tipo);
		iAtaque copy();
    	String[] getTypes();
    }
}