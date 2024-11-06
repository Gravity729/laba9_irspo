﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    public class CMass
    {
        //закрытое поле для хранения массива
        private double[] mass;
        // Конструктор класса CMass, принимающий длину массива
        public CMass(int lengh)
        {
            mass = new double[lengh];
        }
        // Конструктор класса CMass, принимающий массив вещественных чисел
        public CMass(double[] massValue)
        {
            mass = massValue;
        }
        //свойство определения длины массива
        public int getLenghMass
        {
            get { return mass.Length; }
        }
        // Индексатор для доступа к элементам массива по индексу
        public double this[int i]
        {
            get { return mass[i]; }
            set { mass[i] = value; }
        }
        // Метод для подсчета количества отрицательных элементов в массиве
        public int CountNegativeElements()
        {
            return mass.Count(n => n < 0);
        }
        // Метод для подсчета количества элементов в массиве после заданного индекса
        public int CountElementsAfterIndex(int i)
        {
            return mass.Length - i;
        }
        // Метод для подсчета количества отрицательных элементов в массиве, превышающих заданное значение
        public int CountNegativeElementsGreaterThan(double value)
        {
            return mass.Count(n => n < 0 && n > value);
        }
    }
}