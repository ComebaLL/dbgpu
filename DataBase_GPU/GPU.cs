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
        uint memorySize;   ///Объем памяти (только положительные числа)
        uint price;        ///Цена (только положительные числа)

        public GPU(string gPU, string producer, string memoryType, uint memorySize, uint price)
        {
            this.gPU = gPU;
            this.producer = producer;
            this.memoryType = memoryType;
            SetMemorySize(memorySize);
            SetPrice(price);
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
        ///Вернуть объем памяти
        public uint GetMemorySize()
        {
            return memorySize;
        }
        ///Задать объем памяти (не меньше 1)
        public void SetMemorySize(uint memorySize)
        {
            if (memorySize < 1)
                throw new ArgumentException("Объем памяти должен быть не меньше 1 мб.");
            this.memorySize = memorySize;
        }
        ///Вернуть цену
        public uint GetPrice()
        {
            return price;
        }
        ///Задать цену (не меньше 1)
        public void SetPrice(uint price)
        {
            if (price < 1)
                throw new ArgumentException("Цена должна быть не меньше 1.");
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
