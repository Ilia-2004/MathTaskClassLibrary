using MathTaskClassLibrary1;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab10Test
{
    [TestClass]
    public class UnitTest1
    {
        // Создание используемой коллекции и локальной переменной
        private static List<double> _testCollection;
        private static Class1 g = new Class1();

        // Создание тест-метода
        private static void Test(int value, List<double> list)
        {
            int actual = g.CoutElement(list);
            Assert.AreEqual(value, actual);
        }

        [TestMethod]
        public void Test1() // Пустой набор
        {
            _testCollection = new List<double> { 0 };
            Test(0, _testCollection);
        }

        [TestMethod]
        public void Test2() // Единичный набор
        {
            _testCollection = new List<double> { 1, 0 };
            Test(0, _testCollection);
        }

        [TestMethod]
        public void Test3() // Нормальный набор
        {
            _testCollection = new List<double> { 1, 2, 3, 0 };
            Test(2, _testCollection);
        }

        [TestMethod]
        public void Test4() // Данные неупорядоченные
        {
            _testCollection = new List<double> { 2, 1, 3, 5, 4, 0 };
            Test(2, _testCollection);
        }

        [TestMethod]
        public void Test5() // Данные упорядочены в прямом порядке
        {
            _testCollection = new List<double> { 2, 3, 4, 5, 0 };
            Test(3, _testCollection);
        }

        [TestMethod]
        public void Test6() // Данные упорядочены в обратном порядке
        {
            _testCollection = new List<double> { 4, 3, 2, 1, 0 };
            Test(0, _testCollection);
        }

        [TestMethod]
        public void Test7() // В наборе имеются повторяющиеся значения
        {
            _testCollection = new List<double> { 2, 3, 3, 4, 0 };
            Test(2, _testCollection);
        }

        [TestMethod]
        public void Test8() // В наборе имеются отрицательные числа
        {
            _testCollection = new List<double> { 3, -1, 2, 4, -4, 5, 0 };
            Test(3, _testCollection);
        }

        [TestMethod]
        public void Test9() // В наборе есть вещественные числа
        {
            _testCollection = new List<double> { 1.3, 0.5, 2, 4.7, 5, 0 };
            Test(3, _testCollection);
        }

        [TestMethod]
        public void Test10() // Короткий набор с одинаковыми значениями
        {
            _testCollection = new List<double> { 2, 2, 0 };
            Test(0, _testCollection);
        }

        [TestMethod]
        public void Test11() // Набор только из отрицательных вещественных чисел
        {
            _testCollection = new List<double> { -1.1, -0.5, -3.2, -1.2, 0 };
            Test(2, _testCollection);
        }

        [TestMethod]
        public void Test12() // Набор только из отрицательных
        {
            _testCollection = new List<double> { -2, -1, -3, -5, 0 };
            Test(1, _testCollection);
        }

        [TestMethod]
        public void Test13() // Набор только из отрицательных чисел разных типов
        {
            _testCollection = new List<double> { -1.2, -2, -4, -3.5, -0.4, 0 };
            Test(2, _testCollection);
        }

        [TestMethod]
        public void Test14() // Набор и отрицательных, и положительных с разными типами
        {
            _testCollection = new List<double> { 2, 9, 1.4, -2, -5.4, 3.2, -1, 0 };
            Test(2, _testCollection);
        }

        [TestMethod]
        public void Test15() // Набор всех равных чисел
        {
            _testCollection = new List<double> { 4, 4, 4, 4, 4, 4, 4, 4, 0 };
            Test(0, _testCollection);
        }
    }
}