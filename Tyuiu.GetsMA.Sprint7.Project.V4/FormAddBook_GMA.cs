using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GetsMA.Sprint7.Project.V4.Lib.Models;

namespace Tyuiu.GetsMA.Sprint7.Project.V4.WinForms
{
    public partial class FormAddBook_GMA : Form
    {
        
        private TextBox textBoxAuthor_GMA;
        private TextBox textBoxTitle_GMA;
        private NumericUpDown numericUpDownYear_GMA;
        private NumericUpDown numericUpDownPrice_GMA;
        private TextBox textBoxAnnotation_GMA;
        private CheckBox checkBoxIsNew_GMA;
        private Button buttonSaveBook_GMA;
        private Button buttonCancel_GMA;
        private Label labelAuthor_GMA;
        private Label labelTitle_GMA;
        private Label labelYear_GMA;
        private Label labelPrice_GMA;
        private Label labelAnnotation_GMA;

        public FormAddBook_GMA()
        {
            InitializeComponent();
        }

        public Book_GMA GetNewBook()
        {
            return new Book_GMA
            {
                Author = textBoxAuthor_GMA.Text.Trim(),
                Title = textBoxTitle_GMA.Text.Trim(),
                Year = (int)numericUpDownYear_GMA.Value,
                Price = (decimal)numericUpDownPrice_GMA.Value,
                IsNewEdition = checkBoxIsNew_GMA.Checked,
                Annotation = textBoxAnnotation_GMA.Text.Trim()
            };
        }


        private void buttonSaveBook_GMA_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAuthor_GMA.Text) ||
                string.IsNullOrWhiteSpace(textBoxTitle_GMA.Text))
            {
                MessageBox.Show("Заполните поля 'Автор' и 'Название'!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_GMA_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
         private void InitializeComponent()
        {
            this.SuspendLayout();

            // Автор
            this.labelAuthor_GMA = new Label();
            this.labelAuthor_GMA.Text = "Автор:";
            this.labelAuthor_GMA.Location = new Point(20, 20);
            this.labelAuthor_GMA.Size = new Size(60, 23);
            this.labelAuthor_GMA.Name = "labelAuthor_GMA";
            this.Controls.Add(this.labelAuthor_GMA);

            this.textBoxAuthor_GMA = new TextBox();
            this.textBoxAuthor_GMA.Name = "textBoxAuthor_GMA";
            this.textBoxAuthor_GMA.Location = new Point(90, 20);
            this.textBoxAuthor_GMA.Size = new Size(250, 23);
            this.Controls.Add(this.textBoxAuthor_GMA);

            // Название
            this.labelTitle_GMA = new Label();
            this.labelTitle_GMA.Text = "Название:";
            this.labelTitle_GMA.Location = new Point(20, 50);
            this.labelTitle_GMA.Size = new Size(60, 23);
            this.labelTitle_GMA.Name = "labelTitle_GMA";
            this.Controls.Add(this.labelTitle_GMA);

            this.textBoxTitle_GMA = new TextBox();
            this.textBoxTitle_GMA.Name = "textBoxTitle_GMA";
            this.textBoxTitle_GMA.Location = new Point(90, 50);
            this.textBoxTitle_GMA.Size = new Size(250, 23);
            this.Controls.Add(this.textBoxTitle_GMA);

            // Год
            this.labelYear_GMA = new Label();
            this.labelYear_GMA.Text = "Год:";
            this.labelYear_GMA.Location = new Point(20, 80);
            this.labelYear_GMA.Size = new Size(60, 23);
            this.labelYear_GMA.Name = "labelYear_GMA";
            this.Controls.Add(this.labelYear_GMA);

            this.numericUpDownYear_GMA = new NumericUpDown();
            this.numericUpDownYear_GMA.Name = "numericUpDownYear_GMA";
            this.numericUpDownYear_GMA.Location = new Point(90, 80);
            this.numericUpDownYear_GMA.Size = new Size(80, 23);
            this.numericUpDownYear_GMA.Minimum = 1900;
            this.numericUpDownYear_GMA.Maximum = 2025;
            this.numericUpDownYear_GMA.Value = 2025;
            this.Controls.Add(this.numericUpDownYear_GMA);

            // Цена
            this.labelPrice_GMA = new Label();
            this.labelPrice_GMA.Text = "Цена:";
            this.labelPrice_GMA.Location = new Point(20, 110);
            this.labelPrice_GMA.Size = new Size(60, 23);
            this.labelPrice_GMA.Name = "labelPrice_GMA";
            this.Controls.Add(this.labelPrice_GMA);

            this.numericUpDownPrice_GMA = new NumericUpDown();
            this.numericUpDownPrice_GMA.Name = "numericUpDownPrice_GMA";
            this.numericUpDownPrice_GMA.Location = new Point(90, 110);
            this.numericUpDownPrice_GMA.Size = new Size(80, 23);
            this.numericUpDownPrice_GMA.Minimum = 0;
            this.numericUpDownPrice_GMA.Maximum = 10000;
            this.numericUpDownPrice_GMA.DecimalPlaces = 2;
            this.numericUpDownPrice_GMA.Value = 0;
            this.Controls.Add(this.numericUpDownPrice_GMA);

            // Аннотация
            this.labelAnnotation_GMA = new Label();
            this.labelAnnotation_GMA.Text = "Аннотация:";
            this.labelAnnotation_GMA.Location = new Point(20, 140);
            this.labelAnnotation_GMA.Size = new Size(60, 23);
            this.labelAnnotation_GMA.Name = "labelAnnotation_GMA";
            this.Controls.Add(this.labelAnnotation_GMA);

            this.textBoxAnnotation_GMA = new TextBox();
            this.textBoxAnnotation_GMA.Name = "textBoxAnnotation_GMA";
            this.textBoxAnnotation_GMA.Location = new Point(90, 140);
            this.textBoxAnnotation_GMA.Size = new Size(250, 60);
            this.textBoxAnnotation_GMA.Multiline = true;
            this.Controls.Add(this.textBoxAnnotation_GMA);

            // Новое издание
            this.checkBoxIsNew_GMA = new CheckBox();
            this.checkBoxIsNew_GMA.Name = "checkBoxIsNew_GMA";
            this.checkBoxIsNew_GMA.Text = "Новое издание";
            this.checkBoxIsNew_GMA.Location = new Point(20, 210);
            this.Controls.Add(this.checkBoxIsNew_GMA);

            // Кнопки
            this.buttonSaveBook_GMA = new Button();
            this.buttonSaveBook_GMA.Name = "buttonSaveBook_GMA";
            this.buttonSaveBook_GMA.Text = "Сохранить";
            this.buttonSaveBook_GMA.Location = new Point(80, 250);
            this.buttonSaveBook_GMA.Size = new Size(90, 30);
            this.buttonSaveBook_GMA.Click += buttonSaveBook_GMA_Click;
            this.Controls.Add(this.buttonSaveBook_GMA);

            this.buttonCancel_GMA = new Button();
            this.buttonCancel_GMA.Name = "buttonCancel_GMA";
            this.buttonCancel_GMA.Text = "Отмена";
            this.buttonCancel_GMA.Location = new Point(180, 250);
            this.buttonCancel_GMA.Size = new Size(90, 30);
            this.buttonCancel_GMA.Click += buttonCancel_GMA_Click;
            this.Controls.Add(this.buttonCancel_GMA);

            // Настройки формы
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(380, 300);
            this.Text = "Добавить новую книгу";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.ResumeLayout(false);
        }

    }
}