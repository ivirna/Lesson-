Console.WriteLine($"\nЗадача 25. Возведение числа А в натуральную степень В");

int Exponentiation(int numberA, int numberB){
    int result = 1;
    for(int i=1; i <= numberB; i++){
        result = result * numberA;
    }
}