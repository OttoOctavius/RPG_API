namespace RPG_API.Combate{
    public class Damage {

        public AtaqueComplejo dmg;

		/**
        Se espera que el que lo invoco sea del tipo fraccionario
        */
		public float remanente(iAtaque atenuado){
			float recibido = 0f;
            foreach (var item in dmg.getDom())
            {
                recibido += dmg.getAtaque(item) * atenuado.getAtaque(item);
                dmg.atenuarAtaqueSimple(item, restante(atenuado.getAtaque(atenuado)) );
            }
			return recibido;
		}

        /**
        Se le resta el valor de descuento al ataque
         */
        public float descontar(iAtaque descuento){
			float recibido = 0f, diferencia = 0f;

            foreach (var item in dmg.getDom())
            {
                diferencia = dmg.getAtaque(item); //Valor viejo
                dmg.getAtaque(item).reducir( descuento.getAtaque(item).getEstado() ); //nuevo, minimo 0
                recibido +=  diferencia - dmg.getAtaque(item).getEstado();
            }
			return recibido;           
		}

		protected float restante(float num){ return 1 - num; }
    }
}