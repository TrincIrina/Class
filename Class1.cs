using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    // Класс описывающий посудомоечные машины
    partial class Dishwasher
    {
        // Поля
        private string name;           // Название машины
        private double height;         // Высота, см
        private double width;          // Ширина, см
        private double depth;          // Глубина, см
        private double weight;         // Вес, кг
        static private int numberPrograms;    // Количество программ
        static private int setsDishes;        // Количество комплектов посуды

        // Конструктор по умолчанию
        public Dishwasher() : this("undefined", 0, 0, 0, 0) { }
        // Конструкторы с параметрами
        public Dishwasher(string name, double value, double weight)
            : this(name, value, value, value, weight) { }
        public Dishwasher(string name, double height, double value, double weight)
            : this(name, height, value, value, weight) { }
        public Dishwasher(string name, double height, double width, double depth, double weight)
        {
            this.name = name;
            this.height = height;
            this.width = width;
            this.depth = depth;
            this.weight = weight;
        }
        // Статический конструктор
        static Dishwasher()
        {
            numberPrograms = 3;
            setsDishes = 9;
        }
        // Методы доступа к полям        
        public string Name
        {
            get
            {
                return name;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public double Depth
        {
            get
            {
                return depth;
            }
            set
            {
                depth = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        // Метод для изменения полей: количество програм и количество комплектов посуды
        static public void ChangeCharacteristics(ref int program, ref int dishes)
        {
            numberPrograms += program;
            setsDishes += dishes;
        }
        // Методы вывода
        public partial void Print();        
        public override string ToString()
        {
            return $"Dishwasher - {name} ({width} x {height} x {depth}), {weight} kg, " +
                $"programs - {numberPrograms}, sets of dishes - {setsDishes}";
        }
    }
}
