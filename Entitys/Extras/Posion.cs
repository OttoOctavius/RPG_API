
using Entitys.Tipos;

namespace Entitys.Extras{
    public class Posion{

		public TypeStrategy estado;

      public string getDescription(){
        	return estado.getDescripcion();
      }

		public string getNombre()
		{
			return estado.getNombre();
		}

		public Posion(){
      }

      public void use(){
        
      }

    }
}