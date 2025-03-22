﻿using DataBase_GPU;
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
    public partial class FormAddNewGPU : Form
    {
        public FormAddNewGPU()
        {
            InitializeComponent();
        }

        // Метод, вызываемый при загрузке формы
        private void FormAddNewGPU_Load(object sender, EventArgs e)
        {
            // Устанавливаем стандартные значения для текстовых полей
            textBox_gpu.Text = "4070";
            textBox_producer.Text = "Nvidia";
            textBox_memoryType.Text = "GDDR6"; // По умолчанию
            textBox_memorySize.Text = "4"; // Минимальный объем памяти в ГБ
            textBox_price.Text = "100"; // Минимальная цена
            label_error.Text = "";
        }

        // добавить изделие, проверка исключений
        private void button_AddNew_Click(object sender, EventArgs e)
        {
            /// цвет ошибочных полей 
            Color error = Color.FromArgb(252, 187, 187);
            /// цвет полей обычный
            Color usual = Color.White;
            // Объект mainForm ссылается на главную форму
            MainForm mainForm = Owner as MainForm;

            if (mainForm == null)
            {
                MessageBox.Show("Ошибка: главная форма не найдена.");
                return;
            }

            string GPU = textBox_gpu.Text;
            string producer = textBox_producer.Text;
            string memoryType = textBox_memoryType.Text;
            double memorySize;
            double price;
            // для определения наличия ошибки
            bool hasError = false;

            // Проверяем, заполнено ли поле "Название GPU"
            if (string.IsNullOrWhiteSpace(GPU))
            {
                textBox_gpu.BackColor = error; // Если пустое, меняем цвет на красный
                hasError = true;
            }
            else
            {
                textBox_gpu.BackColor = usual; // Если все в порядке, оставляем белый
            }

            // Проверяем поле "Производитель"
            if (string.IsNullOrWhiteSpace(producer))
            {
                textBox_producer.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_producer.BackColor = usual;
            }

            // Проверяем поле "Тип памяти"
            if (string.IsNullOrWhiteSpace(memoryType))
            {
                textBox_memoryType.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_memoryType.BackColor = usual;
            }

            // Проверяем корректность ввода "Объема памяти"
            if (!double.TryParse(textBox_memorySize.Text, out memorySize))
            {
                textBox_memorySize.BackColor = error; // Если не число, окрашиваем красным
                hasError = true;
            }
            else
            {
                textBox_memorySize.BackColor = usual;
            }

            // Проверяем корректность ввода "Цены"
            if (!double.TryParse(textBox_price.Text, out price))
            {
                textBox_price.BackColor = error;
                hasError = true;
            }
            else
            {
                textBox_price.BackColor = usual;
            }

            // Если хотя бы одно поле содержит ошибку, выводим сообщение
            if (hasError)
            {
                label_error.Text = "Заполните все поля";
            }
            else
            {
                // Если ошибок не найдено, все введенные поля очищаются
                textBox_gpu.Clear();
                textBox_producer.Clear();
                textBox_memoryType.Clear();
                textBox_memorySize.Text = "";
                textBox_price.Text = "";

                // изделие добавляется в список и на главную форму
                mainForm.gpu.AddNewGPU(GPU, producer, memoryType, memorySize, price);
                mainForm.dataGridView1.Rows.Add(GPU, producer, memoryType, memorySize, price);
            }
        }

        // закрыть форму
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}