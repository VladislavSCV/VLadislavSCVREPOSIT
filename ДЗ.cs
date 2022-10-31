using System;
while(true){
    Console.WriteLine("Введите ваше имя");
    string name = Console.ReadLine();

    Console.WriteLine("Сколько вам лет?");
    string age = Console.ReadLine();
    int age1 = Int32.Parse(age);

    Console.WriteLine("Кем вы работаете? Или вы студент? Школьник?");
    string status = Console.ReadLine();

    string firstotvet;

    Console.WriteLine($"Зравствуйте,{name} я могу предложить вам шутку(если открыта если вам больше 18 лет) или включить режим калькулятора)");
    Console.WriteLine("Если вас интересует шутка то напишите слово 'Шутка', если вам нужно включить режим калькулятора, то введите в консоль слово 'Калькулятор'");
    firstotvet = Console.ReadLine();
    if (firstotvet == "Шутка")
    {
        if (age1 >= 18)
        {
            Console.WriteLine("Программа получилась плохой, а сроки горят, и заказчик ругается? Не волнуйтесь, смело выпускайте релиз. Просто назовите его версией 1.0.");
            Console.Write("РЕАЛЬНО СМЕШНО))))))))))))))))))))))))))))))))");
        }
        else
        {
            Console.WriteLine("Нужно еще подрасти)");
        }

    }

    else if (firstotvet == "Калькулятор")
    {
        while (true)
        {
            string x;
            string y;
            string z;
            string oper;
            double a;

            Console.WriteLine("Введите первое число");
            x = Console.ReadLine();
            double num1 = Int32.Parse(x);

            Console.WriteLine("Введите второе число");
            y = Console.ReadLine();
            double num2 = int.Parse(y);

            Console.WriteLine("Введите третье число");
            z = Console.ReadLine();
            double num3 = int.Parse(z);

            Console.WriteLine("+-/*.Введите оператор");
            oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    Console.WriteLine(num1 + num2 + num3);
                    break;
                case "-":
                    Console.WriteLine((num1 - num2) - num3);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2 * num3);
                    break;
                case "/":
                    Console.WriteLine((num1 / num2) / num3);
                    break;
                default:
                    Console.WriteLine("Что то пошло не так(");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Ошибка, проверьте правильность написания команд");
    }
}

string VOva;
int 666;
bool true














