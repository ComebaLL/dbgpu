using System;
using System.Windows.Forms;

namespace DataBase_GPU
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        /// контейнер Icontainer, который управляет временем жизни формы
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memorySize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.GPU.DataPropertyName = "GPUName";
            this.producer.DataPropertyName = "Producer";
            this.memoryType.DataPropertyName = "MemoryType";
            this.memorySize.DataPropertyName = "MemorySize";
            this.price.DataPropertyName = "Price";

            this.button_add = new System.Windows.Forms.Button();
            this.button_alldelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label_Search = new System.Windows.Forms.Label();
            //this.инсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // dataGridView1
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GPU,
            this.producer,
            this.memoryType,
            this.memorySize,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(26, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 257);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
 
            // GPU
            this.GPU.HeaderText = "Название";
            this.GPU.MinimumWidth = 6;
            this.GPU.Name = "GPU";
            this.GPU.Width = 125;

            // producer
            this.producer.HeaderText = "Издатель";
            this.producer.MinimumWidth = 6;
            this.producer.Name = "producer";
            this.producer.Width = 125;
            
            // memoryType
            this.memoryType.HeaderText = "Тип памяти";
            this.memoryType.MinimumWidth = 6;
            this.memoryType.Name = "memoryType";
            this.memoryType.Width = 125;
          
            // memorySize
            this.memorySize.HeaderText = "Объем в MB";
            this.memorySize.MinimumWidth = 6;
            this.memorySize.Name = "memorySize";
            this.memorySize.Width = 125;
           
            // price
            this.price.HeaderText = "Цена(руб.)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
          
            // button_add
            this.button_add.Location = new System.Drawing.Point(26, 40);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
             
            // button_alldelete
            this.button_alldelete.Location = new System.Drawing.Point(107, 40);
            this.button_alldelete.Name = "button_alldelete";
            this.button_alldelete.Size = new System.Drawing.Size(75, 23);
            this.button_alldelete.TabIndex = 5;
            this.button_alldelete.Text = "Удалить все";
            this.button_alldelete.UseVisualStyleBackColor = true;
            this.button_alldelete.Click += new System.EventHandler(this.button_alldelete_Click);
 
            // menuStrip1 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem,
            this.сведенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";

            // правкаToolStripMenuItem
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьБазуToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
           
            // сохранитьToolStripMenuItem
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            
            // открытьБазуToolStripMenuItem
            this.открытьБазуToolStripMenuItem.Name = "открытьБазуToolStripMenuItem";
            this.открытьБазуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьБазуToolStripMenuItem.Text = "Открыть базу";
            this.открытьБазуToolStripMenuItem.Click += new System.EventHandler(this.открытьБазуToolStripMenuItem_Click);

            // сведенияToolStripMenuItem
            this.сведенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРазработчикеToolStripMenuItem });
            //this.инсToolStripMenuItem});
            this.сведенияToolStripMenuItem.Name = "сведенияToolStripMenuItem";
            this.сведенияToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.сведенияToolStripMenuItem.Text = "Сведения";

            // оРазработчикеToolStripMenuItem
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            this.оРазработчикеToolStripMenuItem.Click += new System.EventHandler(this.оРазработчикеToolStripMenuItem_Click);

            // инсToolStripMenuItem
            //this.инсToolStripMenuItem.Name = "инсToolStripMenuItem";
            //this.инсToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            //this.инсToolStripMenuItem.Text = "Инструкция";


            // textBox_Search
            this.textBox_Search.Location = new System.Drawing.Point(80, 70);
            this.textBox_Search.Size = new System.Drawing.Size(200, 20);
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);

            // label_Search
            this.label_Search.Location = new System.Drawing.Point(40, 70);
            this.label_Search.Size = new System.Drawing.Size(60, 20);
            this.label_Search.Text = "Поиск:";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 363);
            this.Controls.Add(this.button_alldelete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "База данных GPU";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_Search);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Метод "О разработчике"
        private void оРазработчикеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Kuvykin N.D\nВерсия: 0.1\nДата выпуска: 2025", "О разработчике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_alldelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn producer;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn memorySize;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инсToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label_Search;
    }
}

