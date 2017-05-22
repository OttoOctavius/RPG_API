using System;
namespace AllTest.Effects
{
	[TestFixture]
	public class DefensaTest
	{

		[Test]
		public void testDefensaTest()
		{
			DañoFisico df1 = new DañoFisico(3, 3, 3);
			DañoFisico df2 = df.copia();
			String[] tipos = { "golpe", "corte", "clavar" };
			this.testDaño(df1, df2, tipos)

		}


	}
}