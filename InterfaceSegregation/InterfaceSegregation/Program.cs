﻿using System;

namespace InterfaceSegregation
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Принцип разделения интерфейсов каждый интерфейс отвечает за 1 логику
            //Принцип Liskov можно сделать класс перемещение как абстрактный с абстрактными методами
            //но тогда для корабля всех child нужно было бы реализовать методы, которые они логически
            //не должны реализовывать, тем самым мы не нарушаем определение типа родительского класса(в нашем случае интерфейса )
            //и мы можем вести себя с любым произвольным классом как с родителем 
            Car car = new Car();
            car.Move();
            Ship ship = new Ship();
            ship.sail();
            Plane plane = new Plane();
            plane.Move();
            plane.fly();
        }
    }
}
