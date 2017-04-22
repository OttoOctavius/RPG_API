namespace RPG_API.Combate{
    public class Requerimiento {

        private Estadisticas atributos;

        public Requerimiento(Estadisticas estadisticas){
            atributos = estadisticas;
        }
		/**
        Se espera que el que lo invoco sea del tipo fraccionario
        */
		public bool check(SerVivo objetivo){
			bool puede = true;
            foreach (var item in atributos.dominio )
            {
                puede &= ( objetivo.estadisticas.qatributo(item)>=atributos.qatributo(item) );
            }
			return puede && excluir(objetivo);
		}

		protected bool excluir(SerVivo objetivo){ return true; }
    }
}