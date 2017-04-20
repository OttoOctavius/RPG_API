namespace RPG_API{
    public interface iAtaque{
		float getAtaque(String tipo);
		iAtaque copia();
    String[] getTipos();
    }
}