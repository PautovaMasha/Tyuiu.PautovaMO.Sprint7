using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tyuiu.PautovaMO.Sprint7.Project.V11.Lib;

namespace Tyuiu.PautovaMO.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void TestReadAndSave()
        {
 
            DataService ds = new DataService();

            // Создаем тестового сотрудника
            Employee testEmp = new Employee();
            testEmp.LastName = "Тестов";
            testEmp.FirstName = "Тест";
            testEmp.Position = "Тестер";
            testEmp.Salary = 50000;
            testEmp.Experience = 1;

            // Создаем список с одним сотрудником
            List<Employee> list = new List<Employee>();
            list.Add(testEmp);


            ds.SaveToCSV("test.csv", list);

            // Читаем из файла
            List<Employee> result = ds.LoadFromCSV("test.csv");


            Assert.AreEqual(1, result.Count); // Должен быть 1

            
            Employee firstEmp = result[0];
            Assert.AreEqual("Тестов", firstEmp.LastName);
            Assert.AreEqual("Тест", firstEmp.FirstName);
            Assert.AreEqual("Тестер", firstEmp.Position);
            Assert.AreEqual(50000, firstEmp.Salary);
            Assert.AreEqual(1, firstEmp.Experience);
        }


        [TestMethod]
        public void TestStatistics()
        {

            DataService ds = new DataService();

            // Создаем список тестовых сотрудников
            List<Employee> list = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.LastName = "А";
            emp1.Salary = 100;
            list.Add(emp1);

            Employee emp2 = new Employee();
            emp2.LastName = "Б";
            emp2.Salary = 200;
            list.Add(emp2);

            Employee emp3 = new Employee();
            emp3.LastName = "В";
            emp3.Salary = 300;
            list.Add(emp3);

           
            var stats = ds.GetStatistics(list);

            
            Assert.AreEqual(3, stats.count); // 3 сотрудника
            Assert.AreEqual(200, stats.avgSalary); // (100+200+300)/3 = 200
            Assert.AreEqual(100, stats.minSalary); // Мин 
            Assert.AreEqual(300, stats.maxSalary); // Макс 
            Assert.AreEqual(600, stats.totalSalary); // (100+200+300)
        }


        [TestMethod]
        public void TestSearch() 
        {
            DataService ds = new DataService();

            var list = new List<Employee>
            {
                new Employee {
                    LastName = "Иванов",
                    FirstName = "Иван",
                    Position = "Директор",  
                    Salary = 100000,        
                    Experience = 10         
            },
                new Employee {
                    LastName = "Петров",
                    FirstName = "Петр",
                    Position = "Менеджер",  
                    Salary = 70000,         
                    Experience = 5          
            },
                new Employee {
                    LastName = "Иванова",
                     FirstName = "Мария",
                    Position = "Бухгалтер", 
                    Salary = 80000,         
                    Experience = 3          
            }
        };

            var result = ds.SearchAll(list, "иван");

            Assert.AreEqual(2, result.Count); //Иванов Иванова 
        }
    }
}