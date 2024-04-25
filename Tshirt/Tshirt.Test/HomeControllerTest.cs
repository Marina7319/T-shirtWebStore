namespace Tshirt.Test
{
    public class HomeControllerTest
    {

        [Fact]

        public void ReturnViewName()
        {
            var homeControler = new HomeController();
            var result = homeControler.Index() as IActionResult;
            Assert.Equal("Index", result?.ViewName);
        }
    }
}
