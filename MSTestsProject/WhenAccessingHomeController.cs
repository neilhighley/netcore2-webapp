using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebTestSolution.Controllers;
using WebTestSolution.Models;

namespace MSTestsProject
{
    [TestClass]
    public class WhenAccessingHomeController
    {
        HomeController CUT;
        private ViewResult IndexResult;
        private HomeViewModel IndexModel;

        [TestInitialize]
        public void InitTest()
        {
            CUT = new HomeController();
            IndexResult = CUT.Index() as ViewResult;
            IndexModel = IndexResult.Model as HomeViewModel;
        }

        [TestMethod]
        public void Then_The_Result_Is_Not_Null()
        {
            Assert.IsNotNull(IndexResult);
        }
        [TestMethod]
        public void Then_The_Title_Is_Index_Page()
        {
            Assert.AreEqual("Index Page",IndexModel.Title);
        }
    }
}
