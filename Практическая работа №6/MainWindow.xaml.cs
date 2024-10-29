using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_работа__6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnInfoProga_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Задание: Создать класс Pair (пара чисел). Создать \nнеобходимые методы и свойства. Определить " +
                "\nметод сравнения пар: пара p1 больше пары р2, \nесли (first.pl > first.р2) или (first.pl = first.р2) и " +
                "\n(second.pl > second.р2). Создать перегруженные \nметоды SetParams, для установки параметров " +
                "\nобъекта.", "О программе");
        }

        private void btnInfoSozdatel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ФИО: Жаров Артём Андреевич \nСтудент группы ИСП-31", "О создателе");
        }

        private void btnPrimechanie_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вводите пару чисел через знак: 'точку с запятой' ; ", "Примечание");
        }

        private void btnRez_Click(object sender, RoutedEventArgs e)
        {
            double firstElementP1 = 0;
            double secondElementP1 = 0;
            string InputFirstPara = FirstParaChisel.Text;
            string[] ElementsFirstPara = InputFirstPara.Split(';');

            double firstElementP2 = 0;
            double secondElementP2 = 0;
            string InputSecondPara = SecondParaChisel.Text;
            string[] ElementsSecondPara = InputSecondPara.Split(";");

            if (ElementsFirstPara.Length == 2 || ElementsSecondPara.Length == 2)
            {
                if (double.TryParse(ElementsFirstPara[0].Trim(), out firstElementP1) && double.TryParse(ElementsFirstPara[1].Trim(), out secondElementP1) && double.TryParse(ElementsSecondPara[0].Trim(), out firstElementP2) && double.TryParse(ElementsSecondPara[1].Trim(), out secondElementP2))
                {
                    Pair pair1 = new Pair(firstElementP1, secondElementP1);
                    Pair pair2 = new Pair(firstElementP2, secondElementP2);

                    if (pair1 > pair2)
                    {
                        tbRezult.Text = "Первая пара чисел больше второй пары чисел.";
                    }
                    else if (pair1 < pair2)
                    {
                        tbRezult.Text = "Первая пара чисел меньше второй пары чисел.";
                    }
                    else
                    {
                        tbRezult.Text = "Первая пара чисел равна второй паре чисел.";
                    }
                }
                else tbRezult.Text = "Ошибка: введены некорректные значения!";
            }
            else tbRezult.Text = "Ошибка: введите два числа в каждую пару чисел!";
        }
    }
}