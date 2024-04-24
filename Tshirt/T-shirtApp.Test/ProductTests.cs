namespace T_shirtApp.Test
{

    using T_shirt.Models.Models;

    public class ProductTests
    {

        [Test]
        public void CanChangeProductName()
        {
            var p = new Product { TshirtName = "Test Product Nme", ListPrice = 50.2 };

            p.TshirtName = "New Name";

            Assert.AreEqual("New Name", p.TshirtName);
        }

        [Test]
        public void CanChangeProductPrice()
        {
            var p = new Product { TshirtName = "Test Product Price", ListPrice = 50 };

            p.ListPrice = 78;

            Assert.AreEqual(78, p.ListPrice);
        }

        [Test]
        public void CanChangeProductSize()
        {
            var p = new Product { TshirtName = "Test Product Size", Size = "L" };

            p.Size = "Xl";

            Assert.AreEqual("Xl", p.Size);
        }

        [Test]
        public void CanChangeProductColor()
        {
            var p = new Product { TshirtName = "Test Product Color", Color = "Yellow" };

            p.Color = "Purple";

            Assert.AreEqual("Purple", p.Color);
        }

        [Test]
        public void CanChangeProductDescription()
        {
            var p = new Product { TshirtName = "Test Product Description", Description = "T-shirt with image with flowers." };

            p.Description = "Abstract t-shirt design using real acrylic paint and digital geometrical shapes.";

            Assert.AreEqual("Abstract t-shirt design using real acrylic paint and digital geometrical shapes.", p.Description);
        }

        [Test]
        public void CanChangeProductImageUrl()
        {
            var p = new Product { TshirtName = "Test Product Image Url", ImageUrl = "https://images-workbench.99static.com/vXoTxxG1KC93a3KWRkuDFwoKZgA=/99designs-contests-attachments/35/35695/attachment_35695847" };

            p.ImageUrl = "https://images-workbench.99static.com/ewddr8oHD3ce5FYpDcwL69PeaIQ=/99designs-contests-attachments/141/141507/attachment_141507794";

            Assert.AreEqual("https://images-workbench.99static.com/ewddr8oHD3ce5FYpDcwL69PeaIQ=/99designs-contests-attachments/141/141507/attachment_141507794", p.ImageUrl);
        }

        [Test]
        public void DescriptionIsNull()
        {
            var p = new Product { TshirtName = "Test Description Is Not Null", Description = "T-shirt with image with flowers" };

            p.Description = null;

            Assert.IsNull(p.Description);
        }

        [Test]
        public void ImageUrlIsNull()
        {
            var p = new Product { TshirtName = "Test Image Url Is Null", ImageUrl = "https://images-workbench.99static.com/FgBrNrxH0uWekOlGxbw72jokLqQ=/99designs-contests-attachments/96/96790/attachment_96790758" };

            p.ImageUrl = null;

            Assert.IsNull(p.ImageUrl);
        }

        [Test]
        public void DescriptionIsNotNull()
        {
            var p = new Product { TshirtName = "Test Description Is Not Null", Description = "T-shirt with image with flowers" };

            p.Description = "T-shirt with image flowers and animated heroes.";

            Assert.IsNotNull(p.Description);
        }

        [Test]
        public void ImageUrlIsNotNull()
        {
            var p = new Product { TshirtName = "Test Image Url Is Not Null", ImageUrl = "https://images-workbench.99static.com/FgBrNrxH0uWekOlGxbw72jokLqQ=/99designs-contests-attachments/96/96790/attachment_96790758" };

            p.ImageUrl = "https://images-workbench.99static.com/ewddr8oHD3ce5FYpDcwL69PeaIQ=/99designs-contests-attachments/141/141507/attachment_141507794";

            Assert.IsNotNull(p.ImageUrl);
        }

        [Test]
        public void TshirtNameIsNotNull()
        {
            var p = new Product { TshirtName = "Test Name Is Not Null", ListPrice = 58 };

            p.ListPrice = 94;

            Assert.IsNotNull(p.ListPrice);
        }

        [Test]
        public void TshirtSizeIsNotNull()
        {
            var p = new Product { TshirtName = "Test Size Is Not Null", Size = "XL,L,M,S" };

            p.Size = "Xl,L";

            Assert.IsNotNull(p.Size);
        }

        [Test]
        public void TshirtColorIsNotNull()
        {
            var p = new Product { TshirtName = "Test Color Is Not Null", Color = "yellow, black, green" };

            p.Color = "Black";

            Assert.IsNotNull(p.Color);
        }



        [Test]
        public void ProductTshirtNameIsNotEqual()
        {
            var p = new Product { TshirtName = "Test Name Is Not Null", ListPrice = 50.2 };

            p.TshirtName = "New Name T-shirt.";

            Assert.AreNotEqual("New Name", p.TshirtName);
        }


        [Test]
        public void ProductDescriptionIsNotEqual()
        {
            var p = new Product { TshirtName = "Test Description Is Not Null", Description = "Test description for a t-shirt" };

            p.Description = "Test";

            Assert.AreNotEqual("Test One", p.Description);
        }

        [Test]
        public void ProductSizeIsNotEqual()
        {
            var p = new Product { TshirtName = "Test Size Is Not Null", Size = "Test L,M" };

            p.Size = "L";

            Assert.AreNotEqual("Test Size One", p.Size);
        }

        [Test]
        public void ProductColorIsNotEqual()
        {
            var p = new Product { TshirtName = "Test Color Is Not Null", Color = "Test black" };

            p.Color = "Yellow";

            Assert.AreNotEqual("Test color t-shirt", p.Color);
        }

        [Test]
        public void ProductListPriceIsNotEqual()
        {
            var p = new Product { TshirtName = "Test Price Is Not Null", ListPrice = 12 };

            p.ListPrice = 21;

            Assert.AreNotEqual(19, p.ListPrice);
        }

        [Test]
        public void ProductImageUrlIsNotEqual()
        {
            var p = new Product { TshirtName = "Test ImageUrl Is Not Null", ImageUrl = "https://i.etsystatic.com/16674207/r/il/971ad0/3688067178/il_1588xN.3688067178_9vuk.jpg" };

            Assert.AreNotEqual("https://i.etsystatic.com/43465611/r/il/c1d1d5/4905301960/il_1588xN.4905301960_c3g9.jpg", p.ImageUrl);

        }
    }
}
