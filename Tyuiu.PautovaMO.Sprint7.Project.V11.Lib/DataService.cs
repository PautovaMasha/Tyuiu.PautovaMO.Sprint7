namespace Tyuiu.PautovaMO.Sprint7.Project.V11.Lib
{
  
        // КЛАСС СОТРУДНИКА (карточка сотрудника)
        public class Employee
        {
            // Основные данные
            public string LastName { get; set; }    // Фамилия
            public string FirstName { get; set; }   // Имя
            public string Position { get; set; }    // Должность
            public decimal Salary { get; set; }     // Зарплата
            public int Experience { get; set; }     // Стаж (лет)

            // Для вывода в таблицу
            public override string ToString()
            {
                return $"{LastName} {FirstName} - {Position} ({Salary} руб.)";
            }
        }

        // ГЛАВНЫЙ КЛАСС - вся логика здесь
        public class DataService
        {
            private List<Employee> employees = new List<Employee>();

            // ==================== 1. РАБОТА С ФАЙЛАМИ ====================

            // Чтение из CSV
            public List<Employee> LoadFromCSV(string filePath)
            {
                employees.Clear();

                if (!File.Exists(filePath))
                    return employees; // Если файла нет - пустой список

                string[] lines = File.ReadAllLines(filePath);

                // Пропускаем первую строку (заголовки)
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');

                    if (parts.Length >= 5) // Проверяем, что хватит данных
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

            // Сохранение в CSV
            public void SaveToCSV(string filePath, List<Employee> employeesToSave)
            {
                List<string> lines = new List<string>();

                // Заголовок
                lines.Add("Фамилия,Имя,Должность,Зарплата,Стаж");

                // Данные
                foreach (Employee emp in employeesToSave)
                {
                    lines.Add($"{emp.LastName},{emp.FirstName},{emp.Position},{emp.Salary},{emp.Experience}");
                }

                // Пишем в файл
                File.WriteAllLines(filePath, lines);
            }

            // ==================== 2. СТАТИСТИКА ====================

            // Вся статистика сразу
            public (int count, decimal avgSalary, decimal minSalary, decimal maxSalary, decimal totalSalary)
                GetStatistics(List<Employee> employeesList)
            {
                if (employeesList.Count == 0)
                    return (0, 0, 0, 0, 0);

                decimal total = 0;
                decimal min = employeesList[0].Salary;
                decimal max = employeesList[0].Salary;

                foreach (Employee emp in employeesList)
                {
                    total += emp.Salary;
                    if (emp.Salary < min) min = emp.Salary;
                    if (emp.Salary > max) max = emp.Salary;
                }

                return (employeesList.Count, total / employeesList.Count, min, max, total);
            }

            // Только количество
            public int GetCount(List<Employee> employeesList)
            {
                return employeesList.Count;
            }

            // Только средняя зарплата
            public decimal GetAverageSalary(List<Employee> employeesList)
            {
                if (employeesList.Count == 0) return 0;
                return employeesList.Average(e => e.Salary);
            }

            // ==================== 3. ПОИСК ====================

            // Общий поиск (по всем полям)
            public List<Employee> SearchAll(List<Employee> employeesList, string searchText)
            {
                List<Employee> result = new List<Employee>();

                foreach (Employee emp in employeesList)
                {
                    if (emp.LastName.ToLower().Contains(searchText.ToLower()) ||
                        emp.FirstName.ToLower().Contains(searchText.ToLower()) ||
                        emp.Position.ToLower().Contains(searchText.ToLower()))
                    {
                        result.Add(emp);
                    }
                }

                return result;
            }

            // ==================== 4. СОРТИРОВКА ====================

            // Сортировка по фамилии А-Я
            public List<Employee> SortByNameAsc(List<Employee> employeesList)
            {
                return employeesList.OrderBy(e => e.LastName).ToList();
            }

            // Сортировка по фамилии Я-А
            public List<Employee> SortByNameDesc(List<Employee> employeesList)
            {
                return employeesList.OrderByDescending(e => e.LastName).ToList();
            }

            // Сортировка по зарплате (маленькая → большая)
            public List<Employee> SortBySalaryAsc(List<Employee> employeesList)
            {
                return employeesList.OrderBy(e => e.Salary).ToList();
            }

            // Сортировка по зарплате (большая → маленькая)
            public List<Employee> SortBySalaryDesc(List<Employee> employeesList)
            {
                return employeesList.OrderByDescending(e => e.Salary).ToList();
            }

            // Сортировка по стажу (мало → много)
            public List<Employee> SortByExperienceAsc(List<Employee> employeesList)
            {
                return employeesList.OrderBy(e => e.Experience).ToList();
            }

            // Сортировка по стажу (много → мало)
            public List<Employee> SortByExperienceDesc(List<Employee> employeesList)
            {
                return employeesList.OrderByDescending(e => e.Experience).ToList();
            }

        // ==================== 5. ФИЛЬТРАЦИЯ ====================

        public List<Employee> FilterBySearchText(List<Employee> employeesList, string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
                return employeesList; // Если пустой поиск - возвращаем всех

            string searchLower = searchText.ToLower();

            // Фильтрация по всем полям
            List<Employee> result = new List<Employee>();

            foreach (Employee emp in employeesList)
            {
                if (emp.LastName.ToLower().Contains(searchLower) ||
                    emp.FirstName.ToLower().Contains(searchLower) ||
                    emp.Position.ToLower().Contains(searchLower) ||
                    emp.Salary.ToString().Contains(searchText) || // Без ToLower для чисел
                    emp.Experience.ToString().Contains(searchText))
                {
                    result.Add(emp);
                }
            }

            return result;
        }

        // ==================== 6. РАБОТА СО СПИСКОМ ====================

        // Добавить сотрудника
        public void AddEmployee(Employee employee)
            {
                employees.Add(employee);
            }

            // Удалить сотрудника
            public bool RemoveEmployee(Employee employee)
            {
                return employees.Remove(employee);
            }

            


            // ==================== 7. ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ ====================

            // Проверка файла
            public bool FileExists(string filePath)
            {
                return File.Exists(filePath);
            }

            // Создание тестового файла
            public void CreateTestFile(string filePath)
            {
                List<Employee> testEmployees = new List<Employee>
            {
                new Employee { LastName = "Иванов", FirstName = "Иван", Position = "Директор", Salary = 100000, Experience = 10 },
                new Employee { LastName = "Петрова", FirstName = "Мария", Position = "Бухгалтер", Salary = 70000, Experience = 5 },
                new Employee { LastName = "Сидоров", FirstName = "Алексей", Position = "Менеджер", Salary = 60000, Experience = 3 },
                new Employee { LastName = "Кузнецова", FirstName = "Елена", Position = "Программист", Salary = 90000, Experience = 4 }
            };

                SaveToCSV(filePath, testEmployees);
            }

            // Проверка данных сотрудника
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

