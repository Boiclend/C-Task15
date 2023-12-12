using System.ComponentModel;

// Описать функцию аddRightDigit(d, k), которая должна добавлять к целому положительному числу К справа цифру D 
// (D — целочисленное значение в диапазоне 0-9, К — целочисленное значение, которое является одновременно входным параметром и модифицируемым значением).
// С помощью этой функции добавить к данному числу К цифры D1 и D2, выводя результат каждого добавления


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