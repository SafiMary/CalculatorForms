using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CalculatorForms
{
    public partial class FormCalculator : Form
    {

        public FormCalculator()
        {
            InitializeComponent();
            this.MouseDown += FormCalculator_MouseDown;
            // Получение максимально размера окна
            // var size = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            // Получение графического разрешения монитора
            var size002 = SystemInformation.PrimaryMonitorSize;
            //Text = $"{size002.Width} : {size002.Height}";
            // Запрещаем пользователю изменять размер формы
            // и устанавливаем его кратно разрешению монитора
            this.MaximumSize = this.MinimumSize
                = new Size(size002.Width / 2, size002.Height / 2);//1/4 по ширине и 1/5 по высоте от разрешения экрана не видно всех кнопок формы
                                                                  //так как  у меня ноутбук
            

        }
        private void FormCalculator_MouseDown(object sender, MouseEventArgs e)//перемещать мышкой форму
        {
            base.Capture = false;// указываем все объекты за которые можно перетаскивать форму
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
        private void FormCalculator_Load(object sender, EventArgs e)
        {

        }
        private void buttonOne_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBoxOne.Text);
            b = Convert.ToDouble(textBoxTwo.Text);
            switch (comboBox.Text)
            {
                case "+":
                    textBoxThree.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    textBoxThree.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    textBoxThree.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                    }
                    textBoxThree.Text = Convert.ToString(a / b);
                    break;
                default:
                    Console.WriteLine("Неизвестный оператор.");
                    break;

            }
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxOne.Text = "";
            textBoxTwo.Text = "";
            textBoxThree.Text = "";
            comboBox.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string a = "=";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "myText";
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.InitialDirectory = @"D:/";
            saveFileDialog.Title = "Сохраните свой файл здесь";
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(@"D:/myText.txt", true))
                {
                    sw.Write(textBoxOne.Text);
                    sw.Write(comboBox.Text);
                    sw.Write(textBoxTwo.Text);
                    sw.Write(a);
                    sw.WriteLine(textBoxThree.Text);
                    MessageBox.Show("Файл сохранен");
                }
            }

        }

        private void comboBoxForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
           // System.Drawing.Drawing2D.GraphicsPath mybutton = new System.Drawing.Drawing2D.GraphicsPath();
            if (comboBoxForm.SelectedIndex == 1)//элипс
            {
                this.FormBorderStyle = FormBorderStyle.None;//убираем верхнюю панель
                // создаем эллипс с высотой и шириной формы
                myPath.AddEllipse(0, 0, this.Width, this.Height);
                // создаем с помощью элипса ту область формы, которую мы хотим видеть
                Region myRegion = new Region(myPath);
                // устанавливаем видимую область
                this.Region = myRegion;
                

            }
            else
            {
                if (comboBoxForm.SelectedIndex == 0)//восьмигранник
                {
                    this.FormBorderStyle = FormBorderStyle.None;//убираем верхнюю панель
                    //формируем вершины
                    Point[] myPoint = {
                    new Point(0,this.Height/3), // 1 point
                new Point(this.Width/3, 0), // 2 point
                new Point(2* this.Width/3, 0), // 3 point
                new Point(this.Width, this.Height/3), // 4 point}
                new Point(this.Width, 2* this.Height/3), // 5 point
                new Point(2* this.Width/3, this.Height), // 6 point
                new Point(this.Width/3, this.Height), // 7 point
                new Point(0, 2* this.Height/3)}; // 8 point
                    myPath.AddPolygon(myPoint);
                    // создаем с помощью трапеции ту область формы, которую мы хотим видеть  
                    Region myRegion = new Region(myPath);
                    // Устанавливаем видимую область  
                    this.Region = myRegion;
                    
                }
                else
                if (comboBoxForm.SelectedIndex == 2)//трапеция
                {
                    this.FormBorderStyle = FormBorderStyle.None;//убираем верхнюю панель
                    //формируем вершины
                    Point[] myPoint = { new Point(this.Width-150, this.Height),
                new Point(150, this.Height),
                new Point(0,0),
                new Point(this.Width, 0)};
                    myPath.AddPolygon(myPoint);
                    // создаем с помощью трапеции ту область формы, которую мы хотим видеть  
                    Region myRegion = new Region(myPath);
                    // Устанавливаем видимую область  
                    this.Region = myRegion;
                   
                }
            }
        }
       
    
            private void buttonColour_Click(object sender, EventArgs e)//кнопка выбора цвета для формы, но не для выбора цвета кнопок
            {
                colorDialog1.FullOpen = true;// расширенное окно для выбора цвета
                if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // установка цвета 
                this.BackColor = colorDialog1.Color;
            buttonOne.BackColor = colorDialog1.Color;
            buttonTwo.BackColor = colorDialog1.Color;
            buttonSave.BackColor = colorDialog1.Color;
            }

            private void buttonClose_Click(object sender, EventArgs e)//запасная кнопка закрытия формы
            {
                this.Close();
            }

        private void pictureBoxClean_Click(object sender, EventArgs e)
        {
            textBoxOne.Text = "";
            textBoxTwo.Text = "";
            textBoxThree.Text = "";
            comboBox.Text = "";
        }

        
    } 
}
