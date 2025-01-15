using System;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Linq;
using static ConsoleApp46.Program;

namespace ConsoleApp46
{
    internal class Program
    {
        public class Firm
        {

            public string Name { get; set; }
            public string Industry { get; set; }
            public int EmployeesCount { get; set; }
            public string City { get; set; }
            public string DirectorLastName { get; set; }
            public int FoundationDate { get; set; }
            public string Money { get;  set; }
           

            public long Num_phone { get;  internal set; }
            public string Email { get; set; }
            public string Post {  get; set; }         
            public string Employess { get; internal set; }
        }




        internal static IEnumerable<object> Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }






       



        static void Main(string[] args)
        {
            Console.WriteLine("1.Показать всю информацию про фирмы");
            Console.WriteLine("2.Показать фирмы какие имеют у названии слово Food");
            Console.WriteLine("3.Показать фирмы какие работают у отрасли маркетингу");
            Console.WriteLine("4.Показать фирмы какие работают в отраслях маркетинга или IT");
            Console.WriteLine("5.Показать фирмы з количеством работников больше 100 ");
            Console.WriteLine("6.Показать фирмы з количеством рабочих у диапоцони от 100 до 300");
            Console.WriteLine("7.Показать фирмы какие находятся в Лондони");
            Console.WriteLine("8.Показать фирмы в каких фамилия директора White");
            Console.WriteLine("9.Показать фирмы з дня создание в каких прошло 123 дня");
            Console.WriteLine("10.Показать фирмы в каких фамилия директора Blaack и имеют у название фирмы слово White");
            Console.WriteLine("11.Показать список всех рабочих с определеной фирмы");
            Console.WriteLine("12.Показать список всех работников с определеной фирмы в каких зарплата больше заданой");
            Console.WriteLine("13.Показать список работников всех фирм в каких должность Менеджер");
            Console.WriteLine("14.Показать список работников у которых номер телефона начинается на 23");
            Console.WriteLine("15.Показать список работников в каких email начинается на di");
            Console.WriteLine("16.Показать список работников с именем Lionel");
            string print_user = Console.ReadLine();
            if (print_user == "1")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},
                                

}; 
         
                foreach (var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Название:{firm.Name},Отрасль:{firm.Industry},Денег у компании:{firm.Money},Количество сотрудников в компании:{firm.EmployeesCount}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "2")
            {


            }
            else if (print_user == "3")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var ITFirm = firms.Where(f => f.Industry == "Marketing");
                foreach (var firm in ITFirm)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "4")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var ITFirm = firms.Where(f => f.Industry == "IT");
                foreach(var firm in ITFirm)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "5")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var ITFirm = firms.Where(f => f.EmployeesCount>100);
                foreach (var firm in ITFirm)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "6")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var ITFirm = firms.Where(f => f.EmployeesCount > 100 | f.EmployeesCount<300);
                foreach (var firm in ITFirm)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "7")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var City_London = firms.Where(f => f.City=="London");
                foreach (var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "8")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var City_London = firms.Where(f => f.DirectorLastName == "White");
                foreach (var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name},Директор фирмы:{firm.DirectorLastName}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "9")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var Date = firms.Where(f => f.FoundationDate > 123);
                foreach(var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name},Директор фирмы:{firm.DirectorLastName},Дата создания компании:{firm.FoundationDate}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "10")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var firma = firms.Where(f => f.DirectorLastName == "Black");
                var firma1 = firms.Where(f => f.Name == "White");
                foreach(var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name},Директор фирмы:{firm.DirectorLastName}");
                    Console.WriteLine("______________________________________________________________________________");
                }

            }
            else if(print_user =="11")
            {
                Console.WriteLine("Введите фирму:");
                string choice_firms=Console.ReadLine();
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var q1 = firms.Where(f => f.DirectorLastName == choice_firms);
                foreach (var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name},Директор фирмы:{firm.DirectorLastName}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "12")
            {
                Console.WriteLine("Введите зарплату:");
                string choice_money=Console.ReadLine();
                Console.WriteLine("Введите фирму:");
                string choice_firms = Console.ReadLine();
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
            
                var q1 = firms.Where(f => f.DirectorLastName == choice_firms);
                var q2 = firms.Where(f => f.Money > choice_money);//-
                foreach (var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name},Директор фирмы:{firm.DirectorLastName},Зарплата:{firm.Money}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "13")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var q3 = firms.Where(f => f.Post == "Менеджер");
                foreach (var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name},Директор фирмы:{firm.DirectorLastName}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else if (print_user == "14")

            {
             //-



            }
            else if (print_user == "15")
            {
                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};
                var employeesWithDiEmail = firms
    .Where(employee => employee.Email.StartsWith("di"))
    .ToList();

                foreach (var employee in employeesWithDiEmail)
                {
                    Console.WriteLine($"Имя: {employee.Name}, Email: {employee.Email}");
                }
            }
            else if (print_user == "16")
            {

                var firms = new List<Firm>
                {
                new Firm{Name="Microsoft",Industry="IT",Money="198,27 млрд $ ",EmployeesCount= 221000,City="Редмонд",DirectorLastName="Маркус Перссон",FoundationDate=1975,Employess="",Num_phone=+380800503405,Email="@outlook.com, @live.com, @hotmail.com или @msn.com",Post="Директор"},
                     new Firm{Name="Apple",Industry="Technology",Money="62,15 млрд доларов",EmployeesCount= 154000 ,City="Cupertino, CA",DirectorLastName="Tim Cook",FoundationDate=1976,Employess="",Num_phone=+1408996-1010,Email="info@apple.com",Post="Директор"},
                        new Firm{Name="Milka",Industry="Food",Money="5 Billion USD",EmployeesCount=20000 ,City="Lörrach, Germany",DirectorLastName="Straus Group",FoundationDate=1901,Employess="",Num_phone=+49762142-0,Email="info@milka.com",Post="Директор"},
                            new Firm{Name="Rozetka",Industry="E-commerce",Money="2 Billion USD",EmployeesCount=5000 ,City="Kyiv, Ukraine",DirectorLastName="Vladislav Chechotkin",FoundationDate=2005,Employess="",Num_phone=+380445367000,Email="info@rozetka.com.ua",Post="Директор"},


};

                var City_London = firms.Where(f => f.Employess== "Lionel");
                foreach (var firm in firms)
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($"Фирма:{firm.Name},Работник:{firm.Employess}");
                    Console.WriteLine("______________________________________________________________________________");
                }
            }
            else
            {
                Console.WriteLine("Error");
                return;
            }
        }
    }
            }


    


  

