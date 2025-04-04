/// реализация простой базы данных GPU
/// author Kuvykin N.D

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace DataBase_GPU
{
    public partial class MainForm : Form
    {
        /// поле хранит имя файла для работы 
        public string filename = "";

        /// ссылка на объект класса base_GPU
        public base_GPU gpu = new base_GPU();

        public MainForm()
        {
            InitializeComponent();
        }

        /// Заполнение таблицы на форме из объекта gpu
        private void WriteToDataGrid()
        {
            for (int i = 0; i < gpu.gpuu.Count; i++)
            {
                GPU b = gpu.gpuu[i];
                dataGridView1.Rows.Add(b.GPUName, b.Producer, b.MemoryType, b.MemorySize, b.Price);
            }
        }

        /// Добавление последней записи из базы данных в таблицу
        public void AddLastRecordToGrid()
        {
            if (gpu.gpuu.Count > 0)
            {
                GPU lastGpu = gpu.gpuu[gpu.gpuu.Count - 1];
                dataGridView1.Rows.Add(lastGpu.GPUName, lastGpu.Producer, lastGpu.MemoryType, lastGpu.MemorySize, lastGpu.Price);
            }
        }

        /// Открыть форму добавления GPU
        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddNewGPU addform = new FormAddNewGPU();
            addform.Owner = this;
            addform.Show();
        }

        /// Очистить таблицу и базу
        private void button_alldelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            gpu.gpuu.Clear();
        }

        /// Сохранить базу в файл
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                if (filename == "")
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
                    filename = saveFileDialog.FileName;
                }
                gpu.SaveBase(filename);
            }
        }

        /// Открыть базу из файла
        private void открытьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

                filename = openFileDialog.FileName;

                dataGridView1.Rows.Clear();
                gpu.OpenFile(filename);
                WriteToDataGrid();
            }
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox_Search.Text;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Если строка поиска пуста — показать все элементы
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = gpu.GpuList; // возвращаем исходную коллекцию
            }
            else
            {
                // Если есть текст — отфильтровать
                var result = gpu.Search(searchText);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result;
            }
        }


        public void UpdateGrid(ObservableCollection<GPU> list)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list.ToList(); 
        }



    }
}
