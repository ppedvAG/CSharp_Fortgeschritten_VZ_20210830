using System;

namespace SOLID_DependencyInversionPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar mockCar = new MockCar();

            ICarService service = new CarService();
            service.RepairCar(mockCar);

            ICar releaseCarObject = new Car();
            service.RepairCar(releaseCarObject);
        }
    }


    #region BadCode

    public class BadCode_Car //Programmier A -> 5 Tage 
    {
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }
    }

    //Werkstatt
    public class BadCode_CarService  //Programmierer B -> 3 Tage (kann erst am Tag 6 starten) 
    {
        public void RepairCar(BadCode_Car car)
        {
            //Reparie das Auto 
        }
    }

    //Contras 
    // - Paralleles Arbeiten funktioniert hier sehr beschwert
    // - 
    #endregion

    #region Good Code 

    public interface ICar
    {
         string Marke { get; set; }
         string Modell { get; set; }
         int Baujahr { get; set; }
    }

    public interface ICarService
    {
        public void RepairCar(ICar car);
    }



    //Programmier A -> 5 Tage 

    public class Car : ICar
    {
        public string Marke { get; set; }
        public string Modell { get; set; }
        public int Baujahr { get; set; }

        //Hier ist ein wenig drin 
    }


    //Programmierer B -> 3 Tage

    public class CarService : ICarService
    {
        public void RepairCar(ICar car)
        {
           //Repair Car
        }
    }

    public class MockCar : ICar
    {
        public string Marke { get; set; } = "VW";
        public string Modell { get; set; } = "POLO";
        public int Baujahr { get; set; } = 2001;
    }

    #endregion


}
