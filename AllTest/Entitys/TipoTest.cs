using System;
using NUnit.Framework;

namespace Entitys.Tipos
{
	[TestFixture]
	public class TipoTest
	{
		[Test]
		public void testNormalStrg()
		{
			var strg = new NormalStrategy("nom", "des");
			Assert.AreSame(strg.change(), strg);
			Assert.AreEqual(strg.getNombre(), "nom");
			Assert.AreEqual(strg.getDescripcion(), "des");
			Assert.AreSame(strg.tirar(), null);
		}

		[Test]
		public void testUnkStrgSimple()
		{
			var escondido = new NormalStrategy("nom", "des");
			var strg = new UnknowStrategy(escondido);
			Assert.AreSame(strg.change(), escondido);
			Assert.AreEqual(strg.getNombre(), "?");
			Assert.AreEqual(strg.getDescripcion(), "?");
			Assert.AreSame(strg.tirar(), null);
		}

		[Test]
		public void testUnkStrgCompleto()
		{
			var escondido = new NormalStrategy("nom", "des");
			var strg = new UnknowStrategy("algo","maravilloso",escondido);
			Assert.AreSame(strg.change(), escondido);
			Assert.AreEqual(strg.getNombre(), "algo");
			Assert.AreEqual(strg.getDescripcion(), "maravilloso");
			Assert.AreSame(strg.tirar(), null);
		}

		[Test]
		public void testMagicStrg()
		{
			var strg = new MagicStrategy("nom", "des");
			Assert.AreSame(strg.change(), strg);
			Assert.AreEqual(strg.getNombre(), "nom");
			Assert.AreEqual(strg.getDescripcion(), "des");
			Assert.AreSame(strg.tirar(), null);
		}

		[Test]
		public void testEquipStrg()
		{
			var strg = new EquipStrategy("armadura", "de un rey");
			Assert.AreSame(strg.change(), strg);
			Assert.AreEqual(strg.getNombre(), "armadura");
			Assert.AreEqual(strg.getDescripcion(), "de un rey");
			Assert.AreSame(strg.tirar(), null);
		}
	}
}
