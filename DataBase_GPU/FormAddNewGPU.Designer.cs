namespace DataBase_GPU
{
    partial class FormAddNewGPU
    {

        /// Автоматически сгенерированные компоненты фор
        private System.ComponentModel.IContainer components = null;


        /// Освобождение ресурсов формы>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, сгенерированный дизайнером формы

        /// Метод инициализации компонентов формы
        private void InitializeComponent()
        {
            // Создание текстовых полей для ввода информации о видеокарте
            this.textBox_gpu = new System.Windows.Forms.TextBox();
            this.textBox_producer = new System.Windows.Forms.TextBox();
            this.textBox_memoryType = new System.Windows.Forms.TextBox();
            this.textBox_memorySize = new System.Windows.Forms.TextBox();
            this.textBox_price = new System.Windows.Forms.TextBox();

            // Создание кнопок "Добавить" и "Закрыть"
            this.button_Close = new System.Windows.Forms.Button();
            this.button_AddNew = new System.Windows.Forms.Button();

            // Создание меток для полей ввода
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();

            this.SuspendLayout();


            // textBox_gpu (Название GPU)
            this.textBox_gpu.Location = new System.Drawing.Point(120, 20);
            this.textBox_gpu.Size = new System.Drawing.Size(150, 20);

             
            // textBox_producer (Производитель)
            this.textBox_producer.Location = new System.Drawing.Point(120, 50);
            this.textBox_producer.Size = new System.Drawing.Size(150, 20);

          
            // textBox_memoryType (Тип памяти)
            this.textBox_memoryType.Location = new System.Drawing.Point(120, 80);
            this.textBox_memoryType.Size = new System.Drawing.Size(150, 20);

            
            // textBox_memorySize (Объем памяти)
            this.textBox_memorySize.Location = new System.Drawing.Point(120, 110);
            this.textBox_memorySize.Size = new System.Drawing.Size(150, 20);

            
            // textBox_price (Цена)
            this.textBox_price.Location = new System.Drawing.Point(120, 140);
            this.textBox_price.Size = new System.Drawing.Size(150, 20);

           
            // button_AddNew (Добавить видеокарту)
            this.button_AddNew.Location = new System.Drawing.Point(20, 180);
            this.button_AddNew.Size = new System.Drawing.Size(100, 30);
            this.button_AddNew.Text = "Добавить";
            this.button_AddNew.Click += new System.EventHandler(this.button_AddNew_Click);

            
            // button_Close (Закрыть форму)
            this.button_Close.Location = new System.Drawing.Point(170, 180);
            this.button_Close.Size = new System.Drawing.Size(100, 30);
            this.button_Close.Text = "Закрыть";
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);


            // label1 (Название GPU)
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "Название:";

            
            // label2 (Производитель)
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "Издатель:";

            // label3 (Тип памяти)
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Тип памяти:";

            // label4 (Объем памяти)
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.Text = "Объем памяти:";


            // label5 (Цена)
            this.label5.Location = new System.Drawing.Point(20, 140);
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.Text = "Цена:";


            // label_error (Сообщение об ошибке)
            this.label_error.Location = new System.Drawing.Point(20, 220);
            this.label_error.Size = new System.Drawing.Size(250, 20);
            this.label_error.ForeColor = System.Drawing.Color.Red;


            // FormAddNewGPU (Настройки формы)
            this.ClientSize = new System.Drawing.Size(300, 260);
            this.Controls.Add(this.textBox_gpu);
            this.Controls.Add(this.textBox_producer);
            this.Controls.Add(this.textBox_memoryType);
            this.Controls.Add(this.textBox_memorySize);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.button_AddNew);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_error);
            this.Name = "FormAddNewGPU";
            this.Text = "Добавить новую видеокарту";
            this.Load += new System.EventHandler(this.FormAddNewGPU_Load);

            this.ResumeLayout(false);
        }

        #endregion

        // Поля формы
        private System.Windows.Forms.TextBox textBox_gpu;
        private System.Windows.Forms.TextBox textBox_producer;
        private System.Windows.Forms.TextBox textBox_memoryType;
        private System.Windows.Forms.TextBox textBox_memorySize;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_AddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_error;
    }
}
