
using Entitys.Tipos;

namespace Entitys.Extras{
    public class Potion{
		public TypeStrategy estado;

      public string getDescription(){
        	return estado.getDescripcion();
      }

		public string getNombre()
		{
			return estado.getNombre();
		}

		public Potion(TypeStrategy tipoEnt){
			estado = tipoEnt;

    	  }

      public void use(){
        
      }

    }
}