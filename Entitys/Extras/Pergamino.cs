
using Entitys.Tipos;

namespace Entitys.Extras{
    public class Pergamino{
      
		public TypeStrategy estado;


      public string getDescription(){
        return estado.getDescripcion();
        //if( dueño.atributo.persepcion() > this.minimo() || usado)
          //return this.description();
      }

      public Pergamino(TypeStrategy caracteristicas){
        estado = new UnknowStrategy(caracteristicas);
      }

    }
}