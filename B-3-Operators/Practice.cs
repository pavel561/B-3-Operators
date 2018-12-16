using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P1_9_NumbersAddition");
			Console.WriteLine("Программа для суммирования чисел");
			Console.WriteLine("");
			Console.Write("Введите первое число >> ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число >> ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			int result = number1 + number2;
			Console.WriteLine($"Результат суммирования чисел {number1} и {number2} >> {result} ");
			Console.ReadKey();
		}

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P2_9_CheckResultAddition");
			Console.WriteLine("Программа для суммирования чисел с запросом результата");
			Console.WriteLine("");
			Console.Write("Введите первое число >> ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число >> ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			int result = number1 + number2;
			Console.Write("Введите предполагаемый результат вычисления >> ");
			int userResult = Convert.ToInt32(Console.ReadLine());
			if(userResult == result)
			{
				Console.WriteLine($"Верно");
			}
			else
			{
				Console.WriteLine($"Неверно");
			}
			Console.ReadKey();
		}

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P3_9_CheckResultAdditionWithTipsn");
			Console.WriteLine("Программа для суммирования чисел с запросом результата и проверкой больше-меньше");
			Console.WriteLine("");
			Console.Write("Введите первое число >> ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число >> ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			int result = number1 + number2;
			Console.Write("Введите предполагаемый результат вычисления >> ");
			int userResult = Convert.ToInt32(Console.ReadLine());
			if (userResult == result)
			{
				Console.WriteLine($"Верно");
			}
			else
			{
				Console.Write($"Неверно. ");
				if(userResult>result)
				{
					Console.WriteLine($"Ожидается число меньше указанного");
				}
				else
				{
					Console.WriteLine($"Ожидается число больше указанного");
				}
			}
			Console.ReadKey();
		}

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P4_9_CheckResultWithOperator");
			Console.WriteLine("Программа для сложения и вычитания чисел с запросом результата и проверкой больше-меньше");
			Console.WriteLine("");
			Console.Write("Введите первое число >> ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число >> ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите знак операции >> ");
			char operationMark = Console.ReadKey().KeyChar;
			Console.WriteLine("");
			int result=0;
			switch (operationMark)
			{
				case ('+'):
					{
						result = number1 + number2;
						break;
					}
				case ('-'):
					{
						result = number1 - number2;
						break;
					}
				default:
					{
						break;
					}
			}
			/*
			if (operationMark=='+')
			{
				result = number1 + number2;
			}
			if (operationMark == '-')
			{
				result = number1 - number2;
			}
			*/
			Console.Write("Введите предполагаемый результат вычисления >> ");
			int userResult = Convert.ToInt32(Console.ReadLine());
			if (userResult == result)
			{
				Console.WriteLine($"Верно");
			}
			else
			{
				Console.Write($"Неверно. ");
				if (userResult > result)
				{
					Console.WriteLine($"Ожидается число меньше указанного");
				}
				else
				{
					Console.WriteLine($"Ожидается число больше указанного");
				}
			}
			Console.ReadKey();
		}

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P5_9_CheckResultWithAttemps");
			Console.WriteLine("Программа для сложения и вычитания чисел с запросом результата и проверкой больше-меньше");
			Console.WriteLine("Даетсяя 3 попытки на правильный ответ");
			Console.WriteLine("");
			Console.Write("Введите первое число >> ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число >> ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите знак операции >> ");
			char operationMark = Console.ReadKey().KeyChar;
			Console.WriteLine("");
			int result = 0;
			switch (operationMark)
			{
				case ('+'):
					{
						result = number1 + number2;
						break;
					}
				case ('-'):
					{
						result = number1 - number2;
						break;
					}
				default:
					{
						break;
					}
			}
			int attempts = 3;
			while (true)
			{
				if(attempts!=0)
				{
					Console.Write("Введите предполагаемый результат вычисления >> ");
					int userResult = Convert.ToInt32(Console.ReadLine());
					if (userResult == result)
					{
						Console.WriteLine($"Верно");
						break;
					}
					else
					{
						attempts--;
						Console.Write($"Неверно. ");
						if (userResult > result)
						{
							Console.WriteLine($"Ожидается число меньше указанного");
						}
						else
						{
							Console.WriteLine($"Ожидается число больше указанного");
						}
					}
					
				}
				else
				{
					Console.WriteLine($"Вы исчерпали число попыток");
					break;
				}
			}
			Console.ReadKey();
		}

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P6_9_FiveNumbersAddition");
			Console.WriteLine("Программа для сложения и вычитания пяти чисел ");
			Console.WriteLine("с запросом результата и проверкой больше-меньше "); 
			Console.WriteLine("");
			Console.Write("Введите первое число >> ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число >> ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите третье число >> ");
			int number3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите четвертое число >> ");
			int number4 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите пятое число >> ");
			int number5 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите знак операции >> ");
			char operationMark = Console.ReadKey().KeyChar;
			Console.WriteLine("");
			int result = 0;
			switch (operationMark)
			{
				case ('+'):
					{
						result = number1 + number2+number3+number4+number5;
						break;
					}
				case ('-'):
					{
						result = number1 - number2-number3-number4-number5;
						break;
					}
				default:
					{
						break;
					}
			}
			int attempts = 3;
			while (true)
			{
				if (attempts != 0)
				{
					Console.Write("Введите предполагаемый результат вычисления >> ");
					int userResult = Convert.ToInt32(Console.ReadLine());
					if (userResult == result)
					{
						Console.WriteLine($"Верно");
						break;
					}
					else
					{
						attempts--;
						Console.Write($"Неверно. ");
						if (userResult > result)
						{
							Console.WriteLine($"Ожидается число меньше указанного");
						}
						else
						{
							Console.WriteLine($"Ожидается число больше указанного");
						}
					}

				}
				else
				{
					Console.WriteLine($"Вы исчерпали число попыток");
					break;
				}
			}
			Console.ReadKey();
		}

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
			bool answerIsCorrect = false;
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P7_9_NumbersResultWithInfoIfCorrect");
			Console.WriteLine("Программа для сложения и вычитания пяти чисел ");
			Console.WriteLine("с запросом результата и проверкой больше-меньше ");
			Console.WriteLine("");
			Console.Write("Введите первое число >> ");
			int number1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите второе число >> ");
			int number2 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите третье число >> ");
			int number3 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите четвертое число >> ");
			int number4 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите пятое число >> ");
			int number5 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите знак операции >> ");
			char operationMark = Console.ReadKey().KeyChar;
			Console.WriteLine("");
			int result = 0;
			switch (operationMark)
			{
				case ('+'):
					{
						result = number1 + number2 + number3 + number4 + number5;
						break;
					}
				case ('-'):
					{
						result = number1 - number2 - number3 - number4 - number5;
						break;
					}
				default:
					{
						break;
					}
			}
			int attempts = 3;
			while (true)
			{
				if (attempts != 0)
				{
					Console.Write("Введите предполагаемый результат вычисления >> ");
					int userResult = Convert.ToInt32(Console.ReadLine());
					if (userResult == result)
					{
						Console.WriteLine($"Верно");
						answerIsCorrect = true;
						break;
					}
					else
					{
						attempts--;
						answerIsCorrect = false;
						Console.Write($"Неверно. ");
						if (userResult > result)
						{
							Console.WriteLine($"Ожидается число меньше указанного");
						}
						else
						{
							Console.WriteLine($"Ожидается число больше указанного");
						}
					}

				}
				else
				{
					Console.WriteLine($"Вы исчерпали число попыток");
					break;
				}
			}
			if (answerIsCorrect == true)
			{
				Console.WriteLine($"Ответ пользователя был верным");
			}
			else
			{
				Console.WriteLine($"Ответ пользователя был ошибочным");
			}
			Console.ReadKey();
		}

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P8_9_CircleArea");
			Console.WriteLine("Программа для расчета площади куга по известному радиусу");
			Console.WriteLine("");
			Console.Write("Введите радиус, м >> ");
			double radius = Convert.ToDouble(Console.ReadLine());
			double circleArea = Math.PI * radius * radius;
			//double circleArea = Math.PI * Math.Sqrt(radius);
			Console.WriteLine($"Площать круга с радиусом {radius} м, составяет {circleArea} м^2");
		}

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
			Console.WriteLine("");
			Console.WriteLine("====================================");
			Console.WriteLine("B3_P9_9_CreaditCalculator");
			Console.WriteLine("Программа для расчета кредита");
			Console.WriteLine("");
			int creditMaturity;			//срок погашения кредита, мес.
			double creditAmount;		//Суммма кредита, руб.
			double interestRate;        //Процентная ставка, %
			double monthlyPayment;      //Ежемесячный платеж, руб.
			double loanInterest = 0;	//Проценты по кредиту, руб.
			Console.Write("Введите сумму кредита, руб.BYN >> ");
			creditAmount = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите процентную ставку, % >> ");
			interestRate = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите срок погашения кредита, мес. >> ");
			creditMaturity = Convert.ToInt32(Console.ReadLine());
			double ood = creditAmount;	//Остаток основного долга
			double delta = creditAmount / creditMaturity;	//сумма кредита за каждый месяц
			for (int i=1;i<= creditMaturity;i++)
			{
				loanInterest += ood * interestRate * 0.01 / 12;
				ood -= delta;
			}
			monthlyPayment = (loanInterest + creditAmount) / creditMaturity;
			Console.WriteLine($"Сумма кредита {Math.Round(creditAmount, 2)} руб.");
			Console.WriteLine($"Сумма процентов по кредиту {Math.Round(loanInterest, 2)} руб.");
			Console.WriteLine($"Сумма результирующего долга перед банком {Math.Round(loanInterest + creditAmount,2)} руб.");
			Console.WriteLine($"Сумма ежемесячного платежа {Math.Round(monthlyPayment, 2)} руб.");
		}
    }
}
