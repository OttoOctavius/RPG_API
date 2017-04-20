namespace RPG_API.Combate.Ataque{
    /**Sirve para aclarar cuales son las 
     */
    public class Ataque : iAtaque{
        public static String[] tipos;
        
		float getDaño(String tipo){ return 0.0;}
		iAtaque copia(){ return new AtaqueNulo(); }
        String[] getTipos(){ return tipos; }
    }
}