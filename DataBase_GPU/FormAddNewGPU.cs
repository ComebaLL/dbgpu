using DataBase_GPU;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase_GPU
{
    public partial class FormAddNewGPU : Form
    {
        public FormAddNewGPU()
        {
            InitializeComponent();
        }

        /// При загрузке формы — установка значений по умолчанию
        private void FormAddNewGPU_Load(object sender, EventArgs e)
        {
            textBox_gpu.Text = "111";
            textBox_producer.Text = "111";
            textBox_memoryType.Text = "GDDR6";
            textBox_memorySize.Text = "4";
            textBox_price.Text = "100";
            label_error.Text = "";
        }

        /// Добавить изделие с проверками
        private void button_AddNew_Click(object sender, EventArgs e)
        {
            Color errorColor = Color.FromArgb(252, 187, 187);
            Color normalColor = Color.White;

            MainForm mainForm = Owner as MainForm;

            string gpuName = textBox_gpu.Text;
            string producer = textBox_producer.Text;
            string memoryType = textBox_memoryType.Text;
            bool hasError = false;

            uint memorySize = 0;
            uint price = 0;

            // Проверки полей
            textBox_gpu.BackColor = ValidateText(gpuName, ref hasError, errorColor, normalColor);
            textBox_producer.BackColor = ValidateText(producer, ref hasError, errorColor, normalColor);
            textBox_memoryType.BackColor = ValidateText(memoryType, ref hasError, errorColor, normalColor);

            if (!uint.TryParse(textBox_memorySize.Text, out memorySize) || memorySize < 1)
            {
                textBox_memorySize.BackColor = errorColor;
                hasError = true;
            }
            else
            {
                textBox_memorySize.BackColor = normalColor;
            }

            if (!uint.TryParse(textBox_price.Text, out price) || price < 1)
            {
                textBox_price.BackColor = errorColor;
                hasError = true;
            }
            else
            {
                textBox_price.BackColor = normalColor;
            }

            if (hasError)
            {
                label_error.Text = "Заполните все поля корректно";
                return;
            }

            try
            {
                // Добавляем новую запись в базу
                mainForm.gpu.AddNewGPU(gpuName, producer, memoryType, memorySize, price);

                // Обновляем таблицу
                mainForm.AddLastRecordToGrid();

                // Очищаем поля
                ClearFields();
                label_error.Text = "";
            }
            catch (Exception ex)
            {
                label_error.Text = "Ошибка: " + ex.Message;
            }
        }

        /// Проверка текстового поля
        private Color ValidateText(string text, ref bool hasError, Color errorColor, Color normalColor)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                hasError = true;
                return errorColor;
            }
            return normalColor;
        }

        /// Очистка текстовых полей
        private void ClearFields()
        {
            textBox_gpu.Clear();
            textBox_producer.Clear();
            textBox_memoryType.Clear();
            textBox_memorySize.Text = "";
            textBox_price.Text = "";
        }

        /// Закрыть форму
        private void button_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
