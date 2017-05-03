
using NUnit.Framework;

namespace RPG_API.Combate.Test{
    [TestFixture]
    public class AttackTest{

        [Test]
    	public void testAtaqueSimple(){
    		String[] golpe =  ["golpe"];
 			AttackSimple atk = new AttackSimple( golpe[0],3);
 			AttackSimple atkcp = atk.copy();

 			Assert.AreEqual( atk.getTypes(), golpe ); 
            Assert.AreEqual( atk.getTypes(), atkcp.getTypes() ); 
			Assert.AreEqual( atk.getAttack(), 3 ); 
			Assert.AreEqual( atk.getAttack(), atkcp.getAttack() ); 
        }

        [Test]
    	public void testAttackNull(){
    		String[] golpe =  ["golpe a nuca"];
 			AttackNull df1 = new AttackNull(golpe);
 			AttackSimple atkcp = atk.copy();

 			Assert.AreEqual( atk.getTypes(), golpe ); 
            Assert.AreEqual( atk.getTypes(), atkcp.getTypes() ); 
			Assert.AreEqual( atk.getAttack(), 0.0 ); 
			Assert.AreEqual( atk.getAttack(), atkcp.getAttack() ); 
        }

        [Test]
    	public void testAttackComplex(){
 			AttackComplex atk = new AttackComplex();

            atk.agregarAtaqueSimple(  new AttackSimple( "golpe pecho",10) );
            atk.agregarAtaqueSimple(  new AttackSimple( "golpe cabeza",3) );
            atk.agregarAtaqueSimple(  new AttackSimple( "golpe pies",50) );
            
            AttackSimple atkcp = atk.copy();

            this.testDaño(atk,atkcp, ["golpe pecho", "golpe cabeza" ,"golpe pies"]);
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

    }   
 }


