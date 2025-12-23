namespace Tyuiu.PautovaMO.Sprint7.Project.V11.Lib
{
  
        public class Employee
        {
            public string LastName { get; set; }    
            public string FirstName { get; set; }   
            public string Position { get; set; }    
            public decimal Salary { get; set; }     
            public int Experience { get; set; }      

            public override string ToString()
            {
                return $"{LastName} {FirstName} - {Position} ({Salary} руб.)"; // Для вывода в таблицу
            }

        }


        public class DataService
        {
            private List<Employee> employees = new List<Employee>();


            // Чтение из файла
            public List<Employee> LoadFromCSV(string filePath)
            {
                employees.Clear();

                if (!File.Exists(filePath))
                    return employees; 

                string[] lines = File.ReadAllLines(filePath);

                // Пропускаем первую строку (заголовки)
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');

                    if (parts.Length >= 5) // Проверяем что все есть
                    {
                        employees.Add(new Employee
                        {
                            LastName = parts[0],
                            FirstName = parts[1],
                            Position = parts[2],
                            Salary = decimal.Parse(parts[3]),
                            Experience = int.Parse(parts[4])
                        });
                    }
                }

                return employees;
            }


            // Сохранение
            public void SaveToCSV(string filePath, List<Employee> employeesToSave)
            {
                List<string> lines = new List<string>();

   
                lines.Add("Фамилия,Имя,Должность,Зарплата,Стаж");

                foreach (Employee emp in employeesToSave)
                {
                    lines.Add($"{emp.LastName},{emp.FirstName},{emp.Position},{emp.Salary},{emp.Experience}");
                }

                File.WriteAllLines(filePath, lines); //сохраняем в файл
            }



            // Вся статистика сразу
            public (int count, decimal avgSalary, decimal minSalary, decimal maxSalary, decimal totalSalary)
                GetStatistics(List<Employee> employeesList)
            {
                if (employeesList.Count == 0)
                    return (0, 0, 0, 0, 0);

                decimal total = 0;
                decimal min = employeesList[0].Salary;
                decimal max = employeesList[0].Salary;

                foreach (Employee emp in employeesList) //для каждого сотр в списке
            {
                    total += emp.Salary;
                    if (emp.Salary < min) min = emp.Salary;
                    if (emp.Salary > max) max = emp.Salary;
                }

                return (employeesList.Count, total / employeesList.Count, min, max, total);
            }

            

            // Общий поиск (по всем полям)
            public List<Employee> SearchAll(List<Employee> employeesList, string searchText)
            {
                List<Employee> result = new List<Employee>();

                foreach (Employee emp in employeesList)
                {
                    if (emp.LastName.ToLower().Contains(searchText.ToLower()) || //сравниваем фамилию(без регистра) сотрудника с поиском
                        emp.FirstName.ToLower().Contains(searchText.ToLower()) || 
                        emp.Position.ToLower().Contains(searchText.ToLower()))
                    {
                        result.Add(emp);
                    }
                }

                return result;
            }


            // Сортировка по фамилии А-Я
            public List<Employee> SortByName(List<Employee> employeesList)
            {
                return employeesList.OrderBy(e => e.LastName).ToList();
            }


            //по зарплате (большая → маленькая)
            public List<Employee> SortBySalary(List<Employee> employeesList)
            {
                return employeesList.OrderByDescending(e => e.Salary).ToList();
            }


            // по стажу (много → мало)
            public List<Employee> SortByExperience(List<Employee> employeesList)
            {
                return employeesList.OrderByDescending(e => e.Experience).ToList();
            }

      


            // Добавить
            public void AddEmployee(Employee employee)
            {
                employees.Add(employee);
            }

            // Удалить
            public bool RemoveEmployee(Employee employee)
            {
                return employees.Remove(employee);
            }

            


            // доп Проверка файла
            public bool FileExists(string filePath)
            {
                return File.Exists(filePath);
            }

            
            // доп Проверка данных сотрудника
            public bool ValidateEmployee(Employee employee)
            {
                if (string.IsNullOrWhiteSpace(employee.LastName)) return false;
                if (string.IsNullOrWhiteSpace(employee.FirstName)) return false;
                if (employee.Salary <= 0) return false;
                if (employee.Experience < 0) return false;

                return true;
            }
        }
    }

