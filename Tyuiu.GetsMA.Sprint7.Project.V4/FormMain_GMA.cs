using System;
using System.Windows.Forms;
using Tyuiu.GetsMA.Sprint7.Project.V4.Lib.Services;
using Tyuiu.GetsMA.Sprint7.Project.V4.Lib.Models;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.WinForms
{
    public partial class FormMain_GMA : Form
    {
        private CsvService_GMA csvService_GMA = new CsvService_GMA();
        private List<Book_GMA> books_GMA = new List<Book_GMA>();

        public FormMain_GMA()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            menuStripMain_GMA = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            загрузитьCSVToolStripMenuItem = new ToolStripMenuItem();
            сохранитьCSVToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            руководствоПользователяToolStripMenuItem = new ToolStripMenuItem();
            toolStripMain_GMA = new ToolStrip();
            toolStripButtonLoad_GMA = new ToolStripButton();
            toolStripButtonSave_GMA = new ToolStripButton();
            toolStripButtonAdd_GMA = new ToolStripButton();
            toolStripButtonDelete_GMA = new ToolStripButton();
            dataGridViewBooks_GMA = new DataGridView();
            textBoxSearch_GMA = new TextBox();
            buttonSearch_GMA = new Button();
            buttonStatistics_GMA = new Button();
            menuStripMain_GMA.SuspendLayout();
            toolStripMain_GMA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_GMA).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain_GMA
            // 
            menuStripMain_GMA.ImageScalingSize = new Size(20, 20);
            menuStripMain_GMA.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, справкаToolStripMenuItem });
            menuStripMain_GMA.Location = new Point(0, 0);
            menuStripMain_GMA.Name = "menuStripMain_GMA";
            menuStripMain_GMA.Size = new Size(800, 28);
            menuStripMain_GMA.TabIndex = 5;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьCSVToolStripMenuItem, сохранитьCSVToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // загрузитьCSVToolStripMenuItem
            // 
            загрузитьCSVToolStripMenuItem.Name = "загрузитьCSVToolStripMenuItem";
            загрузитьCSVToolStripMenuItem.Size = new Size(196, 26);
            загрузитьCSVToolStripMenuItem.Text = "Загрузить CSV";
            // 
            // сохранитьCSVToolStripMenuItem
            // 
            сохранитьCSVToolStripMenuItem.Name = "сохранитьCSVToolStripMenuItem";
            сохранитьCSVToolStripMenuItem.Size = new Size(196, 26);
            сохранитьCSVToolStripMenuItem.Text = "Сохранить CSV";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(196, 26);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оПрограммеToolStripMenuItem, руководствоПользователяToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(278, 26);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            руководствоПользователяToolStripMenuItem.Size = new Size(278, 26);
            руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            // 
            // toolStripMain_GMA
            // 
            toolStripMain_GMA.ImageScalingSize = new Size(20, 20);
            toolStripMain_GMA.Items.AddRange(new ToolStripItem[] { toolStripButtonLoad_GMA, toolStripButtonSave_GMA, toolStripButtonAdd_GMA, toolStripButtonDelete_GMA });
            toolStripMain_GMA.Location = new Point(0, 28);
            toolStripMain_GMA.Name = "toolStripMain_GMA";
            toolStripMain_GMA.Size = new Size(800, 27);
            toolStripMain_GMA.TabIndex = 4;
            // 
            // toolStripButtonLoad_GMA
            // 
            toolStripButtonLoad_GMA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonLoad_GMA.Name = "toolStripButtonLoad_GMA";
            toolStripButtonLoad_GMA.Size = new Size(81, 24);
            toolStripButtonLoad_GMA.Text = "Загрузить";
            toolStripButtonLoad_GMA.Click += toolStripButtonLoad_GMA_Click;
            // 
            // toolStripButtonSave_GMA
            // 
            toolStripButtonSave_GMA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSave_GMA.Name = "toolStripButtonSave_GMA";
            toolStripButtonSave_GMA.Size = new Size(87, 24);
            toolStripButtonSave_GMA.Text = "Сохранить";
            toolStripButtonSave_GMA.Click += toolStripButtonSave_GMA_Click;
            // 
            // toolStripButtonAdd_GMA
            // 
            toolStripButtonAdd_GMA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAdd_GMA.Name = "toolStripButtonAdd_GMA";
            toolStripButtonAdd_GMA.Size = new Size(80, 24);
            toolStripButtonAdd_GMA.Text = "Добавить";
            toolStripButtonAdd_GMA.Click += toolStripButtonAdd_GMA_Click;
            // 
            // toolStripButtonDelete_GMA
            // toolStripButtonDelete_GMA
            this.toolStripButtonDelete_GMA = new ToolStripButton();
            this.toolStripButtonDelete_GMA.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete_GMA.Name = "toolStripButtonDelete_GMA";
            this.toolStripButtonDelete_GMA.Size = new Size(69, 24);
            this.toolStripButtonDelete_GMA.Text = "Удалить";
            this.toolStripButtonDelete_GMA.Click += this.toolStripButtonDelete_GMA_Click; 
            toolStripMain_GMA.Items.Add(this.toolStripButtonDelete_GMA); 


            // 
            // dataGridViewBooks_GMA
            // 
            dataGridViewBooks_GMA.ColumnHeadersHeight = 29;
            dataGridViewBooks_GMA.Dock = DockStyle.Bottom;
            dataGridViewBooks_GMA.Location = new Point(0, 150);
            dataGridViewBooks_GMA.Name = "dataGridViewBooks_GMA";
            dataGridViewBooks_GMA.RowHeadersWidth = 51;
            dataGridViewBooks_GMA.Size = new Size(800, 300);
            dataGridViewBooks_GMA.TabIndex = 0;
            dataGridViewBooks_GMA.AllowUserToOrderColumns = true;
            //
            // textBoxSearch_GMA
            // 
            textBoxSearch_GMA.Location = new Point(12, 58);
            textBoxSearch_GMA.Name = "textBoxSearch_GMA";
            textBoxSearch_GMA.Size = new Size(250, 27);
            textBoxSearch_GMA.TabIndex = 3;
            // 
            // buttonSearch_GMA
            // 
            buttonSearch_GMA.Location = new Point(268, 57);
            buttonSearch_GMA.Name = "buttonSearch_GMA";
            buttonSearch_GMA.Size = new Size(94, 29);
            buttonSearch_GMA.TabIndex = 2;
            buttonSearch_GMA.Text = "Поиск";
            buttonSearch_GMA.Click += buttonSearch_GMA_Click;
            // 
            // buttonStatistics_GMA
            // 
            buttonStatistics_GMA.Location = new Point(368, 58);
            buttonStatistics_GMA.Name = "buttonStatistics_GMA";
            buttonStatistics_GMA.Size = new Size(94, 29);
            buttonStatistics_GMA.TabIndex = 1;
            buttonStatistics_GMA.Text = "Статистика";
            buttonStatistics_GMA.Click += buttonStatistics_GMA_Click;
            // 
            // FormMain_GMA
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewBooks_GMA);
            Controls.Add(buttonStatistics_GMA);
            Controls.Add(buttonSearch_GMA);
            Controls.Add(textBoxSearch_GMA);
            Controls.Add(toolStripMain_GMA);
            Controls.Add(menuStripMain_GMA);
            MainMenuStrip = menuStripMain_GMA;
            Name = "FormMain_GMA";
            Text = "Library management system (Sprint 7, Variant 4)";
            menuStripMain_GMA.ResumeLayout(false);
            menuStripMain_GMA.PerformLayout();
            toolStripMain_GMA.ResumeLayout(false);
            toolStripMain_GMA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks_GMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void toolStripButtonLoad_GMA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog_GMA = new OpenFileDialog();
            openFileDialog_GMA.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog_GMA.Title = "Выберите файл с книгами";

            if (openFileDialog_GMA.ShowDialog() == DialogResult.OK)
            {
                books_GMA = csvService_GMA.LoadBooksFromCsv(openFileDialog_GMA.FileName);
                dataGridViewBooks_GMA.DataSource = null;
                dataGridViewBooks_GMA.DataSource = books_GMA;

                // ✅ НАСТРОЙКА КОЛОНОК НА РУССКОМ
                dataGridViewBooks_GMA.Columns["Author"].HeaderText = "Автор";
                dataGridViewBooks_GMA.Columns["Title"].HeaderText = "Название";
                dataGridViewBooks_GMA.Columns["Year"].HeaderText = "Год";
                dataGridViewBooks_GMA.Columns["Price"].HeaderText = "Цена";
                dataGridViewBooks_GMA.Columns["IsNewEdition"].HeaderText = "Новое";
                dataGridViewBooks_GMA.Columns["Annotation"].HeaderText = "Аннотация";

                MessageBox.Show($"Загружено {books_GMA.Count} книг", "Готово");
            }
        }
        

        private void toolStripButtonAdd_GMA_Click(object sender, EventArgs e)
{
    using (FormAddBook_GMA formAdd = new FormAddBook_GMA())
    {
        if (formAdd.ShowDialog() == DialogResult.OK)
        {
            Book_GMA newBook = formAdd.GetNewBook();
            books_GMA.Add(newBook);
            dataGridViewBooks_GMA.DataSource = null;
            dataGridViewBooks_GMA.DataSource = books_GMA;
            MessageBox.Show("✅ Книга добавлена!", "Готово");
        }
    }
}

        private void toolStripButtonSave_GMA_Click(object sender, EventArgs e)
        {
            if (books_GMA.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения!", "Внимание");
                return;
            }

            SaveFileDialog saveFileDialog_GMA = new SaveFileDialog();
            saveFileDialog_GMA.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog_GMA.Title = "Сохранить книги в файл";

            if (saveFileDialog_GMA.ShowDialog() == DialogResult.OK)
            {
                csvService_GMA.SaveBooksToCsv(books_GMA, saveFileDialog_GMA.FileName);
                MessageBox.Show("Файл сохранён!", "Готово");
            }
        }
        private void toolStripButtonDelete_GMA_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks_GMA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления!", "Внимание");
                return;
            }

            try
            {
               
                int rowIndex = dataGridViewBooks_GMA.SelectedRows[0].Index;
                Book_GMA bookToDelete = books_GMA[rowIndex];  

                var result = MessageBox.Show($"Удалить:\n{bookToDelete.Author} - {bookToDelete.Title}?",
                    "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    books_GMA.RemoveAt(rowIndex);  

                  
                    dataGridViewBooks_GMA.DataSource = null;
                    dataGridViewBooks_GMA.DataSource = books_GMA;
                    dataGridViewBooks_GMA.Refresh();  

                    MessageBox.Show("✅ Книга удалена!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка");
            }
        }





        private MenuStrip menuStrip1;
        private DataGridViewTextBoxColumn columnAuthor_GMA;
        private DataGridViewTextBoxColumn columnTitle_GMA;
        private DataGridViewTextBoxColumn columnYear_GMA;
        private DataGridViewTextBoxColumn columnPrice_GMA;
        private DataGridViewCheckBoxColumn columnIsNew_GMA;
        private DataGridViewTextBoxColumn columnAnnotation_GMA;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem загрузитьCSVToolStripMenuItem;
        private ToolStripMenuItem сохранитьCSVToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem руководствоПользователяToolStripMenuItem;
        private ToolStrip toolStripMain_GMA;
        private ToolStripButton toolStripButtonLoad_GMA;
        private ToolStripButton toolStripButtonSave_GMA;
        private ToolStripButton toolStripButtonAdd_GMA;
        private ToolStripButton toolStripButtonDelete_GMA;
        private ToolTip toolTip1;
        private System.ComponentModel.IContainer components;
        private DataGridView dataGridViewBooks_GMA;
      
        private TextBox textBoxSearch_GMA;
        private Button buttonSearch_GMA;
        private Button buttonStatistics_GMA;
        public MenuStrip menuStripMain_GMA;



        private void buttonSearch_GMA_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_GMA.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                // Если поле поиска пустое — показываем все книги
                dataGridViewBooks_GMA.DataSource = null;
                dataGridViewBooks_GMA.DataSource = books_GMA;
            }
            else
            {
                // Фильтруем книги по автору ИЛИ названию
                var filteredBooks = books_GMA.Where(book =>
                    book.Author.ToLower().Contains(searchText) ||
                    book.Title.ToLower().Contains(searchText))
                    .ToList();

                dataGridViewBooks_GMA.DataSource = null;
                dataGridViewBooks_GMA.DataSource = filteredBooks;

                MessageBox.Show($"Найдено {filteredBooks.Count} книг по запросу '{searchText}'", "Результат поиска");
            }
        }

        private void buttonStatistics_GMA_Click(object sender, EventArgs e)
        {
            if (books_GMA.Count == 0)
            {
                MessageBox.Show("Нет данных для анализа!", "Статистика");
                return;
            }

            // Подсчёт статистики
            int totalBooks = books_GMA.Count;
            int newBooks = books_GMA.Count(b => b.IsNewEdition);
            decimal totalPrice = books_GMA.Sum(b => b.Price);
            decimal avgPrice = totalPrice / totalBooks;
            decimal minPrice = books_GMA.Min(b => b.Price);
            decimal maxPrice = books_GMA.Max(b => b.Price);
            int avgYear = (int)books_GMA.Average(b => b.Year);

            // Формируем текст статистики
            string stats = $" СТАТИСТИКА ПО КНИГАМ:\n\n" +
                           $" Всего книг: {totalBooks}\n" +
                           $" Новых изданий: {newBooks} ({newBooks * 100 / totalBooks:F1}%)\n" +
                           $" Общая стоимость: {totalPrice:C}\n" +
                           $" Средняя цена: {avgPrice:C}\n" +
                           $" Мин. цена: {minPrice:C}\n" +
                           $" Макс. цена: {maxPrice:C}\n" +
                           $" Средний год: {avgYear}";

            
            string histogram = "\n ГИСТОГРАММА ЦЕН:\n";
            var prices = books_GMA.Select(b => (double)b.Price).ToArray();
            double minP = prices.Min();
            double maxP = prices.Max();
            double step = (maxP - minP) / 10;

            for (int i = 0; i < 10; i++)
            {
                double level = minP + step * i;
                int count = prices.Count(p => p >= level && p < level + step);
                int bars = Math.Min(count * 2, 20);  
                string barChart = new string('█', bars) + new string('░', 20 - bars);
                histogram += $"[{level:F0}-{level + step:F0}] {barChart} {count}\n";
            }


            MessageBox.Show(stats + histogram, " Статистика + Гистограмма",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }






    }
}