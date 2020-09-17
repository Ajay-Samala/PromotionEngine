using NUnit.Framework;
using PromotionEngine;
using System.Collections.Generic;

namespace NUnitProject
{
    [TestFixture]
    public class Tests
    {
        private PromotionEngine.Program _priceService;

        [SetUp]
        public void Setup()
        {
            _priceService = new PromotionEngine.Program();
        }

        [Test]
        public void TestScenario1()
        {

            List<CartModel> items = new List<CartModel>();
            items.Add(new CartModel("A"));
            items.Add(new CartModel("B"));
            items.Add( new CartModel("C"));

            int result = _priceService.GetCheckoutPrice(items);
            Assert.AreEqual(result,100);
        }

        [Test]
        public void TestScenario2()
        {

            List<CartModel> items = new List<CartModel>();
            items.Add(new CartModel("A"));
            items.Add(new CartModel("A"));
            items.Add(new CartModel("A"));
            items.Add(new CartModel("A"));
            items.Add(new CartModel("A"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("C"));

            int result = _priceService.GetCheckoutPrice(items);
            Assert.AreEqual(result, 370);
        }

        [Test]
        public void TestScenario3()
        {

            List<CartModel> items = new List<CartModel>();
            items.Add(new CartModel("A"));
            items.Add(new CartModel("A"));
            items.Add(new CartModel("A"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("B"));
            items.Add(new CartModel("C"));
            items.Add(new CartModel("D"));

            int result = _priceService.GetCheckoutPrice(items);
            Assert.AreEqual(result, 280);
        }
    }
}