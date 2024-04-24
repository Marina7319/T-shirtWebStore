namespace T_shirtApp.Test
{

    using T_shirt.Models.Models;

    public class CategoryTest
    {
        [Test]
        public void CanChangeCategoryName()
        {
            var p = new Category { Name = "Test", DisplayOrder = 1 };

            p.Name = "New Name Category";

            Assert.AreEqual("New Name Category", p.Name);
        }

        [Test]
        public void CanChangeCategoryDisplayOrder()
        {
            var p = new Category { Name = "Test", DisplayOrder = 2 };

            p.DisplayOrder = 3;

            Assert.AreEqual(3, p.DisplayOrder);
        }

        [Test]
        public void CanChangeCategoryNameAreNotEqual()
        {
            var p = new Category { Name = "Test Category T-shirt", DisplayOrder = 3 };

            p.Name = "Test Category T-shirt Action";

            Assert.AreNotEqual("New Name", p.Name);
        }

        [Test]
        public void CanChangeCategoryDisplayOrderIsNotNull()
        {
            var p = new Category { Name = "Test Category T-shirt", DisplayOrder = 4 };

            p.DisplayOrder = 7;

            Assert.IsNotNull(p.DisplayOrder);
        }

        
    }
}
