namespace Tyuiu.LuzinDD.Sprint0.Task2.V0.Test
{ 
    using Tyuiu.LuzinDD.Sprint0.Task2.V0.Lib;

    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Дмитрий";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Дмитрий", res);
        }
    }
}
