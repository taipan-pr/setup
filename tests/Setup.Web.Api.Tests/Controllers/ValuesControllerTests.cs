﻿using System.Linq;
using NUnit.Framework;
using Setup.Web.Api.Controllers;
using Test.Core;

namespace Setup.Web.Api.Tests.Controllers
{
    public class ValuesControllerTests : BaseTestFixture
    {
        private ValuesController target;

        public override void Setup()
        {
            base.Setup();
            this.target = new ValuesController();
        }

        [Test]
        public void Get_Success()
        {
            var result = this.target.Get();

            Assert.AreEqual(2, result.Value.Count());
        }
    }
}