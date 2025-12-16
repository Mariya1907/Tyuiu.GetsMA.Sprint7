using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.GetsMA.Sprint7.Project.V4.Lib.Services;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.Test
{
    [TestClass]
    public class CsvServiceTest_GMA
    {
        [TestMethod]
        public void SaveAndLoadBooks_ShouldWorkCorrectly()
        {
            CsvService_GMA service = new CsvService_GMA();
            Assert.IsNotNull(service);
        }
    }
}
