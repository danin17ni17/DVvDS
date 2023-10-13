using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//перевод двочной системы в десятичную систему
//20.10.22
namespace dvvds
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //задаёт цвет фона.
            //BackColor = Color.//BlueViolet;
        }
        //кнопка закрытия
        //
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //кнопка перевода.
        //основные расчёты и значения.
        private void button1_Click(object sender, EventArgs e)
        {
            //задаём сум равную нулю.
            //прим. 1011 = 2^0+2^1+2^2+2^3,
            //2^1 не считается так как 0,
            //это я всё к тому что эти двойки
            //нужно будет суммировать и 
            //переменная сум как раз для этого.
            double sum = 0;
            //задаётся строка ссс к которой
            //приравниваем первый текстбокс.
            string sss = textBox1.Text;
            //задаём массив сh и закидываем 
            //туда строку ссс со свойством Lenght -
            //оно содержит количество элементов,
            //которое может хранить массив.
            //прим. пишем число 111111 в нём
            //шесть символов и именно число 
            //шесть и заносится в свойство Lenght.
            char[] ch = new char[sss.Length];
            //превращаем строку ссс в char.
            ch = sss.ToCharArray();
            try
            {
            }
            //блокировка ошибки формата.
            catch (FormatException)
            {
            }
            //блокировка ошибки 
            //с огромными числами.
            catch (OverflowException)
            {
            }
            //цикл for
            //итак, задаём i равную нулю -
            //ноль, то есть i не должна превышать
            //заданного количества.
            //прим. задали 111 - это 3 символа, 
            //значит, i не будет больше 3, ни 
            //ни 4, ни 5, ок?
            for (int i = 0; i < sss.Length; i++)
            {
                //теперь if
                //если в массиве с переменной i
                //встречается единица,
                //(прим. 1101 - тут их три)
                //то...
                if (ch[i] == '1')
                {
                    //...то он расчитывает сумму
                    //которая изначально равна нулю.
                    //Math - этот класс предоставляет 
                    //константы и стат.методы для
                    //многих-многих функций, а метод
                    //Pow возводит в указанную степень
                    //(в нашем случае i) указанное
                    //число (в нашем случае 2).
                    sum = sum + Math.Pow(2, i);
                }
                //а если не встречается единица
                //(то есть встречается 0), то
                //цикл уходит сюда.
                else { }
            }

     /*       Array.Reverse(ch);

            for (int i = 0; i < sss.Length; i++)
            {
                if (ch[i] == '1')
                {
                    sum = sum + Math.Pow(2, i);
                }  
                else { }
      * Array.Clear(....);
       */    
            textBox2.Text = "" + sum.ToString();
        }
        //текстовый бокс 1.
        //задаются только единицы и нули
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //задаётся строка с цифрами 0 и 1.            
            string ss = "01";
            //если в строке ss находятся символы,
            //кроме нуля и единицы, 
            //то они блокируются.
            //А также если это не символы, 
            //то 0 и 1 могут стираться.
            if (!ss.Contains(e.KeyChar)&& e.KeyChar != Convert.ToChar(Keys.Back))
            {
                //значение true - значит,
                //событие обработано.
                e.Handled = true;
            }
        } 
        //текстовый бокс 1.
        //откликается на enter и esc.
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Enter))
            {
                button1_Click(button1, null);
            }
            if (e.KeyValue == Convert.ToChar(Keys.Escape))
            {
                button2_Click(button2, null);
            }
        }
    }
}

