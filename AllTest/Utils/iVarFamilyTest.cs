using NUnit.Framework;
using Utils;


namespace AllTest.Utils{
	[TestFixture]
    public class iVarFamilyTest{

		[Test]
		public void testUInt(){
			var uInt = new UInt(20);
			var cp = uInt.copy();
			Assert.AreEqual(uInt.get(), 20);
			Assert.AreEqual(uInt.get(), cp.get());
			Assert.AreEqual(uInt.nulo(), 0);

			uInt.add(20);
			uInt.reduce(10);
			Assert.AreEqual(uInt.get(), 30);
			Assert.AreNotEqual(uInt.get(), cp.get());

			uInt.mult(10f);
			Assert.AreEqual(uInt.get(), 300);

			uInt.set(200);
			Assert.AreEqual(uInt.get(), 200);
        }

		[Test]
		public void testFloat()
		{
			var f = new Float(20f);
			var cp = f.copy();
			Assert.AreEqual(f.get(), 20f);
			Assert.AreEqual(f.get(), cp.get());
			Assert.AreEqual(f.nulo(), 0f);

			f.add(20f);
			f.reduce(10f);
			Assert.AreEqual(f.get(), 30f);
			Assert.AreNotEqual(f.get(), cp.get());

			f.mult(10f);
			Assert.AreEqual(f.get(), 300f);

			f.set(200f);
			Assert.AreEqual(f.get(), 200f);
		}
	
	}

 }
