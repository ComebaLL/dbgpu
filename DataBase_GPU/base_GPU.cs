///реализация простой базы данных GPU
///author Kuvykin N.D

using System;
using System.Collections.ObjectModel;
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
        /// ObservableCollection "GPU" объектов "GPU"
        public ObservableCollection<GPU> GpuList { get; set; } = new ObservableCollection<GPU>();


        /// Вернуть коллекцию
        public ObservableCollection<GPU> gpuu => GpuList;

        /// Добавить GPU
        public void AddNewGPU(string gPU, string producer, string memoryType, uint memorySize, uint price)
        {
            GPU newGpu = new GPU(gPU, producer, memoryType, memorySize, price);
            GpuList.Add(newGpu);
        }

        /// Сохранить базу в файл
        public void SaveBase(string name)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(name, false, Encoding.Unicode))
                {
                    foreach (GPU g in GpuList)
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

            // Очищаем коллекцию gpu перед чтением новых данных из файла
            GpuList.Clear();

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

                    // Добавляем данные в коллекцию
                    AddNewGPU(gPU, producer, memoryType, memorySize, price);
                }
            }
        }

        /// Удаляет элемент из коллекции gpu по индексу 
        public void DeleteOne(int ind)
        {
            if (ind >= 0 && ind < GpuList.Count)
            {
                GpuList.RemoveAt(ind);
            }
        }

        /// Очистка всей базы
        public void Clear()
        {
            GpuList.Clear();
        }

        /// Поиск по всем полям 
        public ObservableCollection<GPU> Search(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return new ObservableCollection<GPU>(GpuList);

            searchText = searchText.ToLower();

            var result = GpuList.Where(gpu =>
                gpu.GPUName.ToLower().Contains(searchText) ||
                gpu.Producer.ToLower().Contains(searchText) ||
                gpu.MemoryType.ToLower().Contains(searchText) ||
                gpu.MemorySize.ToString().Contains(searchText) ||
                gpu.Price.ToString().Contains(searchText)
            );

            return new ObservableCollection<GPU>(result);
        }
    }
}