using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.OOPS
{
    class Car
    {
        public int car_model;
        public string carbrand;
        public string carcolour;
        public int carprice;
       
        static void Main(string[]args)
        {
            Car car1=new Car();
            car1.car_model = 1;
            car1.carbrand = "i20";
            car1.carcolour = "White";
            car1.carprice = 116500;
            Console.WriteLine(car1.car_model + " " + car1.carbrand + " " + car1.carcolour + " " + car1.carprice);

            Car car2 = new Car();
            car2.car_model = 2;
            car2.carbrand = "Swift Dzire";
            car2.carcolour = "Black";
            car2.carprice = 650000;
            Console.WriteLine(car2.car_model + " " + car2.carbrand + " " + car2.carcolour + " " + car2.carprice);

            Car car3 = new Car();
            car3.car_model = 3;
            car3.carbrand = "Audi";
            car3.carcolour = "Black";
            car3.carprice = 5100000;
            Console.WriteLine(car3.car_model + " " + car3.carbrand + " " + car3.carcolour + " " + car3.carprice);


        }


    }
}
