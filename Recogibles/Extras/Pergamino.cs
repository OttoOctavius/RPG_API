
using RPG_API.Recogibles.Tipos;

namespace RPG_API.Recogibles.Extras{
    public class Pergamino{
      
      private TypeStrategy estado;


      public String getDescription(){
        return estado.getDescripcion();
        //if( dueño.atributo.persepcion() > this.minimo() || usado)
          //return this.description();
      }

      public Pergamino(TypeStrategy caracteristicas){
        estado = new UnknowStrategy(caracteristicas);
      }

    }
}