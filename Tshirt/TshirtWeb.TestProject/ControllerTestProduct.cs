namespace TshirtWeb.TestProject
{
using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Security.Cryptography;

    [TestClass]
    public class ControllerTestProduct
    {
        Product productOne;
        Product productTwo;
        Product productTree;

        Category categoryOne;
        Category categoryTwo;

        [TestMethod]

        public void Index()
        {
            productOne = new Product {  ProductId = 1, TshirtName = "T-shirt"}

        }


    }
}
