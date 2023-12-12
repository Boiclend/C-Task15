using System.ComponentModel;

int Message(string text) { 
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void addRightDigit() { // функция добавления числа
    int k = Message("k: ");
        if(k <= 0) {
            Console.WriteLine("Неверный формат числа");
            return;
        }
    int d = Message("d: ");
        if(d < 0 || d > 9) {
            Console.WriteLine("Неверный формат числа");
            return;
        }
    int firstNumber = int.Parse(k.ToString() + d.ToString()); // добавление первой цифры к числу
    Console.WriteLine(firstNumber);
    d = Message("d: ");
        if(d < 0 || d > 9) {
            Console.WriteLine("Неверный формат числа");
            return;
        }
    int secondNumber = int.Parse(firstNumber.ToString() + d.ToString()); // добавление первой цифры к числу
    Console.WriteLine(secondNumber); 
}

addRightDigit(); // вызов функции