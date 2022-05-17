using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo3
{
    internal class Car_Info
    {
        int carno;
        string carName;
        string carType;
        readonly double carcost = 1000000;

        public Car_Info(int carno, string carName, string carType)
        {
            this.carno = carno;
            this.carName = carName;
            this.carType = carType;
            //this.carcost = carcost;

            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");
        }

        public Car_Info(double cost)
        {
            carcost = cost;
            Console.WriteLine("After changing");
            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");
        }
        public void displaycardetails()
        {
            Console.WriteLine("Before changing");
            Console.WriteLine($" carno is : {carno}, car namee is {carName}, car Type is {carType}, car cost is {carcost}");

        }
    }
}
