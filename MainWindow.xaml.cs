using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)//перебираем все элементы среди дочерних объектов грида
            {
                if (el is Button)//проверка на принадлежность элемента к кнопкам
                {
                    ((Button)el).Click += Button_Click; //тип UIElement преобразовываем к типу Button и на каждую кнопку вешаем обработчик
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   //в методе обработчика в строку записываем значение каждой копки
            //в правой части преобразуем пришедший объект к классу Button,
            //после вызывается свойство Content и все затем приводится к строке
            string str = (string)((Button)e.OriginalSource).Content;

            if (str == "AC") textLabel.Text = ""; //реализация кнопки оистки
            else if (str == "=") { } //если передан знак равенства то выполняем математическое действие

            else textLabel.Text += str;

            textLabel.Text += str; //в текст лейбла добавляем значение кнопки
        }
    }
}
