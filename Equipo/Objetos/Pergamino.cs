
namespace RPG_API.Equipo.Objetos{
    public class Pergamino{
      private SerVivo dueño;
      private Habilidad hab;
      public Int red,green,blue;
      private bool usado = false;

      public String tag(){
        if( dueño.atributo.persepcion() > this.minimo() || usado)
          return this.description();
      }

      public virtual String description();

      public Pergamino(SerVivo poseedor){
        dueño = poseedor;
      }

      public Daño lanzar(){
          if( usado )
            return hab.usar();
          else{
            usado = true;
            return penalizacion(hab.usar());
          }
      }

      public virtual Daño penalizacion(Daño dn);

    }
}