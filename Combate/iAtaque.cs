namespace RPG_API{
    public interface iAtaque{
		float getDaño(String tipo);
		iAtaque copia();
    String[] getTipos();
    }
}