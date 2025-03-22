///реализация простой базы данных GPU
///author Kuvykin N.D


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_GPU
{ ///Класс GPU
    public class GPU
    {
        private
        string gPU;        ///Название
        string producer;   ///Издатель
        string memoryType; ///Тип памяти
        double memorySize; ///Объем памяти
        double price;      ///Цена



        public GPU(string gPU, string producer, string memoryType, double memorySize, double price)

        {
            this.gPU = gPU;
            this.producer= producer;
            this.memoryType = memoryType;
            this.memorySize = memorySize;
            this.price = price;
        }
        ///Вернуть название
        public string GetGPU()
        {
            return gPU;
        }
        ///Задать имя
        public void SetGPU(string GPU)
        {
            this.gPU = gPU;
        }
        ///Вернуть издателя
        public string GetProducer()
        {
            return producer;
        }

        ///Задать издателя
        public void SetProducer(string producer)
        {
            this.producer = producer;
        }
        ///Вернуть тип памяти
        public string GetMemoryType()
        {
            return memoryType;
        }
        ///Задать тип памяти
        public void SetMemoryType(string memoryType)
        {
            this.memoryType = memoryType;
        }
        ///Вернуть вес
        public double GetMemorySize()
        {
            return memorySize;
        }
        ///Задать вес
        public void SetMemorySize(double memorySize)
        {
            this.memorySize = memorySize;
        }
        ///Вернуть цену
        public double GetPrice()
        {
            return price;
        }
        ///Задать цену
        public void SetPrice(double price)
        {
            this.price = price;
        }

        ///переопределение метода ToString
        public override string ToString()
        {
            return gPU + "|" + producer + "|" + memoryType + "|" +
                memorySize + "|" + price;
        }
    }
}
