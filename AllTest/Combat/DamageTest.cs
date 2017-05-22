using NUnit.Framework;
using Moq;
using Combat.Attacks;
using Utils;

namespace Combat{
    [TestFixture]
    public class DamageTest{

		[Test]
		public void testCrearDamageyUsarRemanente(){
			string gp = "golpe" ;
			var mock = Mock.Of<iAttack<float>>();
			//Assume.That( () => true);
			var mainatk = new AttackComplex<float>(new Float(0f),new Float(10f) );
			var iAtt = mainatk.cast().addAttack( new AttackSimple<float>( gp, new Float(10f) ) );
			var damage = new Damage( iAtt );


			var atk = new AttackSimple<float>( gp, new Float(0.5f) );

			Assert.AreEqual(damage.remanente(atk),5f);
			Assert.AreEqual( iAtt.getAttack(gp), 5f );
		}

		[Test]
		public void testCrearDamageyUsarDescontar()
		{
			string gp = "golpe" ;
			var mainatk = new AttackComplex<float>(new Float(0f), new Float(10f));
			var iAtt = mainatk.cast().addAttack(new AttackSimple<float>(gp, new Float(10f) ) );
			var damage = new Damage(iAtt);

			var atk = new AttackSimple<float>(gp, new Float(5f));

			Assert.AreEqual(damage.descontar(atk),5f);
			Assert.AreEqual( iAtt.getAttack(gp), 5f );
		}

		/*
        [Test]
    	public void testDañoSimple(){
			var df1 = new Damage();
 			var df2 = df1.copia();
            String[] tipos = { "golpe", "corte", "clavar" };
			this.testDaño(df1, df2, tipos);
        }

        [Test]
    	public void testDañoElementalBasico(){
 			DañoElementalBasico df1 = new DañoFisico(3,3,3);
 			DañoElementalBasico df2 = df.copia();
            String[] tipos = { "viento", "agua", "tierra" };
            this.testDaño(df1,df2,tipos);
        }

        [Test]
    	public void testDañoElemental(){
 			DañoElemental df1 = new DañoElemental(3,3,3);
 			DañoElemental df2 = df.copia();
            String[] tipos = { "fuego", "hielo", "electricidad" };
            this.testDaño(df1,df2,tipos);
        }    

        [Test]
    	public void testDañoElemental(){
 			DañoElemental df1 = new DañoElemental(3,3,3);
 			DañoElemental df2 = df.copia();
            String[] tipos = { "fuego", "hielo", "electricidad" };
            this.testDaño(df1,df2,tipos);
        }   

        [Test]
    	public void testDañoElemental(){
 			DañoCaos df1 = new DañoCaos(3);
 			DañoCaos df2 = df.copia();
            String[] tipos = { "caos" };
            this.testDaño(df1,df2,tipos);
        }


    	public void testDaño(Daño df1,Daño df2,String[] tipos ){
            foreach(String elem in df1.getTipos() ){
                if( tipos.include(elem) )
                     Assert.AreEqual(df1.getDaño(elem),3); 
                else
                     Assert.AreEqual(df1.getDaño(elem),0);
                Assert.AreEqual(df1.getDaño(elem),df2.getDaño(elem));    
            }
        }   
*/
    }   
 }


