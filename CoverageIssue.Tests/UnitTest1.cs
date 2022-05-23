using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoverageIssue.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_ViewModelInheritsObservableObject()
        {
            Assert.AreEqual(ViewModel.Sum(3, 2), 5);
        }

        [TestMethod]
        public void Test_ViewModelUsesObservableProperty()
        {
            Assert.AreEqual(ViewModelUsesObservableProperty.Sum(3, 2), 5);
        }

        [TestMethod]
        public void Test_ViewModelInheritsValidator()
        {
           Assert.AreEqual(ViewModelInheritsValidator.Sum(3, 2), 5);
        }


        [TestMethod]
        public void Test_ViewModel()
        {
            Assert.AreEqual(CoverageIssueNoMVVM.ViewModel.Sum(3, 2), 5);
        }

    }
}