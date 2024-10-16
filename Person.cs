using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabAsocjacyjna
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        //konstruktor
        
        public Person(string name, int age, double salary)
        { 
                this.Name = name;
                this.Age = age;  
                this.Salary = salary;    
        }
     
    }
}
