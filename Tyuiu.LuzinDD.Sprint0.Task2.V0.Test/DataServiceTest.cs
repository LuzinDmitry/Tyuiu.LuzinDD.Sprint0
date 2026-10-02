namespace Tyuiu.LuzinDD.Sprint0.Task2.V0.Test
{ 
    using Tyuiu.LuzinDD.Sprint0.Task2.V0.Lib;

    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            
            var name = "Дмитрий";
            var res = DataService.GetMessage(name);

            
            Assert.AreEqual("Привет, Дмитрий", res);
        }
    }
}
