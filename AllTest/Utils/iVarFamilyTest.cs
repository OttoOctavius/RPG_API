namespace AllTest.Utils{
    public class iVarFamilyTest{

        @Test
		public testSeCreaDurabilidad(){
            Equipo mock = Guantes();
            Durabilidad dur = new Durabilidad(20,mock);
            assert(dur.deQue == mock);
            assert(dur.getEstado == 20f);
        }

        @Test
		public testSeReduce(){
            Equipo mock = Guantes();
            Durabilidad dur = new Durabilidad(20,mock);
            dur.reducir(5f);
            assert(dur.getEstado == 15f);
            dur.reducir(10f);
            assert(dur.getEstado == 5f);           
        }

        @Test
		public testSeReduce(){
            Equipo mock = Guantes();
            Durabilidad dur = new Durabilidad(20,mock);
            dur.reducir(5f);
            dur.restaurar(10f);
            assert(dur.getEstado == 20f);           
        }

        @Test
		public testSeRompe(){
            Equipo mock = Guantes();
            Durabilidad dur = new Durabilidad(20,mock);
            dur.reducir(20f);
            checked
            {
                mock.seRompio();
            }
            assert(dur.getEstado == 0f);            
        }
		}

 }
