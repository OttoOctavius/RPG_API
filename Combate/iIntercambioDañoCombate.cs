namespace RPG_API{
    public interface iIntercambioDañoCombate{
		float getDaño(String tipo);
		iIntercambioDañoCombate copia();
    String[] getTipos();
    }
}