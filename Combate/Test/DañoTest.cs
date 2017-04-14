namespace RPG_API.Combate.Test{
    public class DañoTest{

        @Test
    	public void testDañoFisico(){
 			DañoFisico df1 = new DañoFisico(3,3,3);
 			DañoFisico df2 = df.copia();
            String[] tipos = { "golpe", "corte", "clavar" };
            this.testDaño(df1,df2,tipos)
        }

        @Test
    	public void testDañoMagico(){
 			testDañoMagico df1 = new DañoFisico(3,3,3);
 			testDañoMagico df2 = df.copia();
            String[] tipos = { "magiaBlanca", "magiaPura", "magiaOscura" };
            this.testDaño(df1,df2,tipos);
        }

        @Test
    	public void testDañoElementalBasico(){
 			DañoElementalBasico df1 = new DañoFisico(3,3,3);
 			DañoElementalBasico df2 = df.copia();
            String[] tipos = { "viento", "agua", "tierra" };
            this.testDaño(df1,df2,tipos);
        }

        @Test
    	public void testDañoElemental(){
 			DañoElemental df1 = new DañoElemental(3,3,3);
 			DañoElemental df2 = df.copia();
            String[] tipos = { "fuego", "hielo", "electricidad" };
            this.testDaño(df1,df2,tipos);
        }    

        @Test
    	public void testDañoElemental(){
 			DañoElemental df1 = new DañoElemental(3,3,3);
 			DañoElemental df2 = df.copia();
            String[] tipos = { "fuego", "hielo", "electricidad" };
            this.testDaño(df1,df2,tipos);
        }   

        @Test
    	public void testDañoElemental(){
 			DañoCaos df1 = new DañoCaos(3);
 			DañoCaos df2 = df.copia();
            String[] tipos = { "caos" };
            this.testDaño(df1,df2,tipos);
        }


    	public void testDaño(Daño df1,Daño df2,String[] tipos ){
            foreach(String elem in df1.getTipos() ){
                if( tipos.include(elem) )
                    assertTrue(df1.getDaño(elem)==3);
                else
                    assertTrue(df1.getDaño(elem)==0);
 			    assertTrue(df1.getDaño(elem)==df2.getDaño(elem));
            }
        }   

    }   
 }


