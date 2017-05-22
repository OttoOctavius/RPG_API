using System;
using System.Collections.Generic;
using Combat;
using Utils;
using System.Text;
using NUnit.Framework;
using Entitys.Equipment;

using Moq;
using Entitys.Tipos;

namespace Entitys{
	[TestFixture]
	public class EquipoTest{

		[Test]
          public void testComprobarCreacionEquipo(){
			var mk = new EquipStrategy("nom","des");

			Equipo eq = new Equipo(20, PesoEquipo.Ligero, 10f);
			eq.modificador = mk;
			Assert.AreEqual( eq.getNombre() ,"nom");
			Assert.AreEqual(eq.getDescripcion() ,"desc");
			Assert.AreSame(eq.modificador, mk);
			Assert.AreEqual(eq.getDurabilidad.get() , 20);
			Assert.AreEqual(eq.TipoEquipo, PesoEquipo.MuyLigero );
			Assert.AreEqual(eq.getPeso, 10f);
			Assert.AreEqual(eq.TipoEquipo, PesoEquipo.Ligero);
        }
 
    }
 }
