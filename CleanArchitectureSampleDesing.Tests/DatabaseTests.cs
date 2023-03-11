using Microsoft.Extensions.DependencyInjection;
using CleanArchitectureSampleDesing.Domain.IService;
using CleanArchitectureSampleDesing.Domain.Model;

namespace CleanArchitectureSampleDesing.Tests
{
    [TestClass]
    public class DatabaseTests
    {
        [TestInitialize]
        public void TestInit()
        {
            TestHelper.DoConfiguration();
        }
        [TestMethod]
        public void TestItemCatagoryShouldBeSuccess()
        {

            var service = TestHelper.ServiceProvider.GetService<IItemCatagoryService>();
            TestHelper.DoTryCatchAssert(()=>service.Insert(new ItemCatagory() { Title = "TestItem"}));   
        }
        [TestMethod]
        public void TestItemSubCatagoryShouldBeSuccess()
        {
            var service = TestHelper.ServiceProvider.GetService<IItemSubCatagoryService>();
            TestHelper.DoTryCatchAssert(()=>service.Insert(new ItemSubCatagory() { Title = "TestItem",ItemCatagoryId=1 }));
        }
        [TestMethod]
        public void TestBrandTypeShouldBeSuccess()
        {
            var service = TestHelper.ServiceProvider.GetService<IBrandTypeService>();
            TestHelper.DoTryCatchAssert(() => service.Insert(new BrandType() { Title = "TestItem"}));
        }
        [TestMethod]
        public void TestModelTypeShouldBeSuccess()
        {
            var service = TestHelper.ServiceProvider.GetService<IModelTypeService>();
            TestHelper.DoTryCatchAssert(() => service.Insert(new ModelType() { Title = "TestItem",BrandTypeId=1 }));
        }
        [TestMethod]
        public void TestItemUnitTypeShouldBeSuccess()
        {
            var service = TestHelper.ServiceProvider.GetService<IItemUnitTypeService>();
            TestHelper.DoTryCatchAssert(() => service.Insert(new ItemUnitType() { Title = "TestItem"}));
        }
    }
}