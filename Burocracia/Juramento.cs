namespace RPG_API.Combate{
    public abstract class JuramentoImplicito {

        public List<SerVivo> aderentes;
        public List<SerVivo> marginados;

        public JuramentoImplicito(){
            aderentes = new Bag<SerVivo>();
        }
		

		public void condiciones();

		protected bool excluir(SerVivo objetivo){
            aderentes.remove(objetivo);
            marginados.add(objetivo);
        }
    }
}