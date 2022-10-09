using System;

namespace PRoject1_Akhtar_Saeed_4373
{
    class SalarySlip                     //Parent CLass ( Inheritance MEthodolgy is used although  polymorphism can also be implemented
    {
        public int basicSalry;
        public int MA;                   //Medical Allowance
        public int FA;                   // Fuel Allowance
        public int tax;



        public SalarySlip()
        {
            basicSalry=1500;                 // basic salary for all employees(constructor)
        }
        
        
        

    }
    //Engineer Inherited Class
    class Engineer : SalarySlip                       
    {
        private double Bonus;
        public Engineer()                  
        {
             Bonus = 7000 / 12;                     //engineer salary bonus
        }
    
        
        public  double Salary()                    // salary function for engineers
        {
            double salary = basicSalry + Bonus;
            Console.WriteLine("NetSalary of Engineer is: " );
            return salary;
            
        }
    }
    //HR inherited Class
    class HR : SalarySlip
    {
       
        
        public HR()
        {
            MA = 800;
            FA = 150;
        }
        public int Salary()                //HR Salary Function
        {
            int TA;                        //Telephonic Bonus Allowance
            TA = ((MA + FA) * 10) / 100;
            int salary = basicSalry + MA + FA + TA;
            Console.WriteLine("NetSalary of HR is: ");
            return salary;
        }
    }
    //Manager Inherited Class
    class Manager : SalarySlip
    {
                              
        public Manager()
        {
            MA =1000;
            FA =250;
            
        }
        public int Salary()                         //MAnager Salary function
        {
            int salary=basicSalry+ MA+FA;
            tax=   (basicSalry * 17 / 100);        //17% Tax induced on salary 
            salary -= tax;
            Console.WriteLine("NetSalary of Manager is: ");
            return salary;
           
        }
    }






    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("For NetSalary Calculations Follow the following Instruction. \n");
            Console.WriteLine("To get NetSalary: \na.For Engineer Enter 1. \nb.For HR Enter 2 \nc.For Manager Enter 3: ");
            int x=Convert.ToInt32( Console.ReadLine());            //Getting Employee Type from USer
            Console.WriteLine();
            if(x==1)
            {
                Engineer salarySlip = new Engineer();              //salarySlip object created for All employees 
                Console.WriteLine(salarySlip.Salary());
            }
           else if (x==2)
            {
                HR salarySlip =new HR();
                Console.WriteLine(salarySlip.Salary());
            }
           else if(x==3)
            {
                Manager salarySlip=new Manager();
                Console.WriteLine(salarySlip.Salary());
                
            }
           else
            {
                Console.WriteLine("Invalid Input");
            }
            
            Console.ReadLine();

        }
    }
}
