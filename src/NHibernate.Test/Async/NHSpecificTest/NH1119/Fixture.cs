﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using NUnit.Framework;

namespace NHibernate.Test.NHSpecificTest.NH1119
{
	using System.Threading.Tasks;
	[TestFixture]
	public class FixtureAsync : BugTestCase
	{
		public override string BugNumber
		{
			get { return "NH1119"; }
		}

		[Test]
		public async Task SelectMinFromEmptyTableAsync()
		{
			using (ISession s = OpenSession())
			{
				DateTime dt = await (s.CreateQuery("select max(tc.DateTimeProperty) from TestClass tc").UniqueResultAsync<DateTime>());
				Assert.AreEqual(default(DateTime), dt);
				DateTime? dtn = await (s.CreateQuery("select max(tc.DateTimeProperty) from TestClass tc").UniqueResultAsync<DateTime?>());
				Assert.IsFalse(dtn.HasValue);
			}
		}
	}
}
