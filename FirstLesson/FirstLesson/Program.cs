using FirstLesson.Models;
using FirstLesson.Models.Group3;
using FirstLesson.Models.Group4;
using FirstLesson.Models.Klase;
using System;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ne moze se kreirati instanca apstraktne klase
            //Models.Employee employee = new Models.Employee();

            ////pozivanje metode apstrakne klase koja je overridovana u nasledjenoj klase
            //Developer dev = new Developer("Project_Beacon");
            //float salary = dev.CalculateSalary();
            //Console.WriteLine(salary);
            //Console.ReadLine();

            ////primer visestrukog override-a
            //Person1 person1 = new Person1();
            //var vacation = person1.CalculateNumberOfVacation();
            //Console.WriteLine(vacation);
            //Console.ReadLine();

            ////primer override metode obicne klase
            //Telekom tel = new Telekom();
            //tel.Print();
            //Console.ReadLine();

            ////klasa Prson implementira dva interfejsa sa identicnom metodom
            ////u samoj klasi bice samo jedna implementacija metode ukoliko se vrsi implicitno implementiranje interfejsa
            //Models.Group4.Person p = new Models.Group4.Person();
            //p.PrintName();
            //Console.ReadLine();

            ////------primena interfejsa implicitno / eksplicitno
            ////klasa implementira 2 interfejsa koja imaju istu metodu
            //Company company = new Company();            
            //IAddress address = company;
            //IEmployed employed = company;
            ////kada je implicitno -> metoda print ima jednu implementaciju te se stampa isto
            ////kada je eksplicitno -> moze imati razlicitu implementaciju
            //address.Print();
            //employed.Print();
            //Console.ReadLine();

            ////pokusaj kreiranja instance static klase
            ////-----------nije moguce napraviti instancu static klase------------
            ////Bank bank = new Bank();
            ////-----------ali mozemo dodeliti vrednost clana nekoj promenljivoj ili mozemo pozvati metodu iz statik klase
            //string ime = Bank.Name;
            //Console.WriteLine(ime);
            //Console.ReadLine();

            ////partial classes
            ////jedna public jedna sealed - moze
            ////jedna public jedna private - ne moze (greska usled konflikta access modifiers)
            ////jedna public jedna abstract - ne moze (greska: jer ne moze da se instacira abstraktna klasa)
            //Models.Klase.Employee em = new Models.Klase.Employee();
            //em.DoWork();
            //em.GoToLunch();
            //Console.ReadLine();

            ////abstraktna klasa ne moze da se instancira
            //Osoba o = new Osoba();
        }
    }
}
