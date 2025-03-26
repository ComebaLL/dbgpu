///реализация простой базы данных GPU
///author Kuvykin N.D


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_GPU
{
    ///класс для работы с базой
    public class base_GPU
    {
        ///список "GPU" объектов "GPU"
        List<GPU> gpu = new List<GPU>();

        /// Вернуть список
        public List<GPU> gpuu => gpu;

        /// Добавить GPU
        public void AddNewGPU(string gPU, string producer, string memoryType, uint memorySize, uint price)
        {
            GPU newGpu = new GPU(gPU, producer, memoryType, memorySize, price);
            gpu.Add(newGpu);
        }


        /// Сохранить базу в файл
        public void SaveBase(string name)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(name, false, Encoding.Unicode))
                {
                    foreach (GPU g in gpu)
                    {
                        sw.WriteLine(g);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка сохранения файла: " + e.Message);
            }
        }

        /// Открыть базу из файла
        public void OpenFile(string name)
        {
            if (!File.Exists(name))
                throw new Exception("Файл не существует");

            // Очищаем список gpu перед чтением новых данных из файла
            gpu.Clear();

            using (StreamReader sr = new StreamReader(name))
            {
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string[] dataFromFile = str.Split('|');

                    if (dataFromFile.Length < 5)
                        continue;

                    string gPU = dataFromFile[0];
                    string producer = dataFromFile[1];
                    string memoryType = dataFromFile[2];
                    if (!uint.TryParse(dataFromFile[3], out uint memorySize) ||
                        !uint.TryParse(dataFromFile[4], out uint price))
                        continue;

                    // Добавляем данные в список
                    AddNewGPU(gPU, producer, memoryType, memorySize, price);
                }
            }
        }

        /// Удаляет элемент из списка gpu по индексу 
        public void DeleteOne(int ind)
        {
            if (ind >= 0 && ind < gpu.Count)
            {
                gpu.RemoveAt(ind);
            }
        }
    }
}
