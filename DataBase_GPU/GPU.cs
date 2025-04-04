/// реализация простой базы данных GPU
/// author Kuvykin N.D

using System;

namespace DataBase_GPU
{
    /// Класс GPU
    public class GPU
    {
        public string GPUName { get; set; } // название
        public string Producer { get; set; } // издатель
        public string MemoryType { get; set; } // тип памяти

        private uint memorySize; // размер памяти в МБ
        public uint MemorySize
        {
            get => memorySize;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Объем памяти должен быть не меньше 1 мб.");
                memorySize = value;
            }
        }

        private uint price; // цена
        public uint Price
        {
            get => price;
            set
            {
                if (value < 1)
                    throw new ArgumentException("Цена должна быть не меньше 1.");
                price = value;
            }
        }

        public GPU(string gPU, string producer, string memoryType, uint memorySize, uint price)
        {
            GPUName = gPU;
            Producer = producer;
            MemoryType = memoryType;
            MemorySize = memorySize;
            Price = price;
        }

        public override string ToString()
        {
            return $"{GPUName}|{Producer}|{MemoryType}|{MemorySize}|{Price}";
        }
    }
}
