using NUnit.Framework;
using Combat.Attacks;
using Utils;
using System;

namespace Combat{
	[TestFixture]
	public class AttackTest{

		[Test]
		public void testAtaqueInterfazUINT()
		{
			string[] golpe = { "golpe" };
			var d = new UInt(3);
			iAttack<uint> atk = new AttackSimple<uint>(golpe[0], d);
			var atkcp = atk.copy();

			//atq.Ataque queda testeado por iVar
			Assert.AreEqual(atk.getTypes(), golpe);
			Assert.AreEqual(atk.getTypes(), atkcp.getTypes());
			Assert.AreEqual(atk.getAttack(golpe[0]), 3);
			Assert.AreEqual(atk.getAttack(golpe[0]), atkcp.getAttack(golpe[0]));
		}
		/*
		[Test]
		public void testAtaqueInterfazBYTE()
		{
		string[] golpe =  {"golpe"};
			Utils.Byte d = new Byte(3);
		iAttack<byte> atk = new AttackSimple<byte>(golpe[0], d);
		var atkcp = atk.copy();

		Assert.AreEqual(atk.getTypes(), golpe);
		Assert.AreEqual(atk.getTypes(), atkcp.getTypes());
		Assert.AreEqual(atk.getAttack(golpe[0]), 3);
		Assert.AreEqual(atk.getAttack(golpe[0]), atkcp.getAttack(golpe[0]));
		}*/

		[Test]
		public void testAtaqueInterfazfloat()
		{
			String[] golpe = { "golpe" };
			var d = new Float(3f);
			iAttack<float> atk = new AttackSimple<float>(golpe[0], d);
			var atkcp = atk.copy();

			Assert.AreEqual(atk.getTypes(), golpe);
			Assert.AreEqual(atk.getTypes(), atkcp.getTypes());
			Assert.AreEqual(atk.getAttack(golpe[0]), 3);
			Assert.AreEqual(atk.getAttack(golpe[0]), atkcp.getAttack(golpe[0]));
		}

        [Test]
    	public void testAttackComplexInterfazFloat(){
			AttackComplex<float> atk = new AttackComplex<float>(new Float(0f),new Float(3f) );
			string[] cadena = { "golpe pecho", "golpe cabeza", "golpe pies" };
			Float pt = new Float(3f);
			atk.cast().addAttack(  new AttackSimple<float>( "golpe pecho",pt) );
            atk.cast().addAttack(  new AttackSimple<float>( "golpe cabeza", pt) );
            atk.cast().addAttack(  new AttackSimple<float>( "golpe pies", pt) );
			var attack = (atk as iAttack<float>);
			var atkcp = attack.copy();

			Assert.AreEqual( attack.getTypes() , cadena ); 
			Assert.AreEqual( attack.getTypes() , atkcp.getTypes() ); 

			foreach(string elem in cadena ){
				Assert.AreEqual(attack.getAttack(elem), pt.get() );
				Assert.AreEqual(attack.getAttack(elem), atkcp.getAttack(elem)); 
            }
        }

    }   
 }


