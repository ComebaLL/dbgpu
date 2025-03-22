///реализация простой базы данных GPU
///author Kuvykin N.D

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_GPU
{
    public partial class MainForm : Form
    {   ///поле хранит имя файла для работы 
        public string filename = "";

        ///cсылка на объект класса base_GPU
        public base_GPU gpu = new base_GPU();
        

        public MainForm()
        {
            InitializeComponent();
        }

        ///Заполнение таблицы на форме из объекта gpu
        private void WriteToDataGrid()
        {
            for (int i = 0; i < gpu.gpuu.Count; i++)
            {
                GPU b = gpu.gpuu[i];
                dataGridView1.Rows.Add(b.GetGPU(), b.GetProducer(), b.GetMemoryType(), b.GetMemorySize(), b.GetPrice());
            }

        }
        /// Открыть новую форму и добавить GPU
        /// object sender - объект который взял на себя событие
        /// EventArgs e - стандатрный аргумент событий, содержащий доп инфу о событии
        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddNewGPU addform = new FormAddNewGPU();
            addform.Owner = this;
            addform.Show();
        }
        ///очиcтить таблицу на форме и объект gpu
        private void button_alldelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            gpu.gpuu.Clear();
        }
        ///сохранить в фаил
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
        ///открыть из файла
        private void открытьБазуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

                filename = openFileDialog.FileName;

                dataGridView1.Rows.Clear();
                ///открывает файл и загружает данные в объект gpu
                gpu.OpenFile(filename);
                //заполняет таблицу на форме
                WriteToDataGrid();
            }
        }


    }
}