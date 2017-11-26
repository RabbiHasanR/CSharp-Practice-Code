using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractise
{
    //simple delegate example
    //public delegate void HelloFunctionDelegate(String mas);
     class Program
    {
        static void Main(string[] args)
        {
            //delegate calling
            /*HelloFunctionDelegate hrd = new HelloFunctionDelegate(Hello);
            hrd("Rabbi");*/
            //delegates usage
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(new Employee() { Id = 1, Name = "Rabbi", Salary = 5000, Experience = 5 });
            listEmployee.Add(new Employee() { Id = 2, Name = "Tuhin", Salary = 4000, Experience = 4 });
            listEmployee.Add(new Employee() { Id = 3, Name = "Riaz", Salary = 6000, Experience = 6 });
            listEmployee.Add(new Employee() { Id = 4, Name = "Puspo", Salary = 3000, Experience = 3 });
            IsPromotionPosible isPromotable = new IsPromotionPosible(promotion);
            Employee.EmployeePromotion(listEmployee,isPromotable);
        }
        //method
        public static void Hello(String masg)
        {
            Console.WriteLine(masg);
        }
        public static bool promotion(Employee em)
        {
            if (em.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    //delegate demo
    delegate bool IsPromotionPosible(Employee em);
     class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Experience { get; set; }

        public static void EmployeePromotion(List<Employee>listEmployee,IsPromotionPosible isEligiblePromotion)
        {
            foreach(Employee employee in listEmployee)
            {
                if (isEligiblePromotion(employee))
                {
                    Console.WriteLine(employee.Name+" "+"Promotion");
                }
            }
        }
    }
}
