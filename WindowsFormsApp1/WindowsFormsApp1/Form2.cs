using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private double[] array = new double[2];

        public Form2()
        {
            InitializeComponent();
        }

        //Я запутался с индексами,
        //В итоге получилось так,
        //Что программа считает числа правильно
        //Лишь после ввода после примера ещё одного знака
        //+, *, - или /, а в текст бокс выводит предыдущее значение результата
        //(проследить за этим можно с помощью консоли например введя 12+14+ только тогда результат становится 26),
        //исправить к сожалению не выходит, для этого нужно знать второе число до вычислений, я не смог этого сделать,
        //Пробовал создать два массива в 1 запоминались числа во второй знаки,
        //Но там также запутался в индексах и в итоге не смог посчитать пример.









        private void calculatorText(object sender, EventArgs e)
        {
            if (!Calculator.Text.Equals(""))
            {
                string a= "";
                int[] numbers=new int[100];
                string text = Calculator.Text;
                text.Replace(" ","");
                char[] signs;
                int j = 0;
                int result = 0;
                numbers[0] = 0;
                foreach (var character in text)
                {
                    try
                    {
                        if (Char.IsNumber(character))
                        {
                            a += character;
                            Console.WriteLine($"a {a}");
                        }
                        else
                        {
                            numbers[j + 1] = Convert.ToInt32(a);
                            a = "";
                            switch (character)
                            {
                                case '+':

                                    result = numbers[j] + numbers[j + 1];
                                    Console.WriteLine($"j {j}");
                                    Console.WriteLine($"number j {numbers[j]}");
                                    Console.WriteLine($"number j2 {numbers[j + 1]}");
                                    Console.WriteLine($"result {result}");
                                    j++;
                                    Console.WriteLine($"j {j}");
                                    
                                    break;
                                case '-':
                                    result = numbers[j] * numbers[j + 1];
                                    Console.WriteLine($"j {j}");
                                    Console.WriteLine($"number j {numbers[j]}");
                                    Console.WriteLine($"number j2 {numbers[j + 1]}");
                                    Console.WriteLine($"result {result}");
                                    j++;
                                    Console.WriteLine($"j {j}");
                                    break;
                                case '/':
                                    result = numbers[j] / numbers[j + 1];
                                    Console.WriteLine($"j {j}");
                                    Console.WriteLine($"number j {numbers[j]}");
                                    Console.WriteLine($"number j2 {numbers[j + 1]}");
                                    Console.WriteLine($"result {result}");
                                    j++;
                                    Console.WriteLine($"j {j}");
                                    break;
                                case '*':
                                    result = numbers[j] * numbers[j + 1];
                                    Console.WriteLine($"j {j}");
                                    Console.WriteLine($"number j {numbers[j]}");
                                    Console.WriteLine($"number j2 {numbers[j + 1]}");
                                    Console.WriteLine($"result {result}");
                                    j++;
                                    Console.WriteLine($"j {j}");
                                    break;
                            }
                        }
                    if (character == '=')
                    {
                            Calculator.Text = result.ToString();
                            break;
                    }
                    
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex);
                    }
                    catch(DivideByZeroException ex)
                    {
                        Console.WriteLine(ex);
                    }
                }
            }
        }
    }
}