Console.WriteLine("Введите пятизначное число: ");
string number1 = Console.ReadLine();
Zadacha19 (number1);
void  Zadacha19 (string number1 )
{
    if  ( number1.Length == 5  )
    {

        if (number1[0] == number1[4] && number1[1] == number1[3] )
        {
        Console.WriteLine ("Введенное Вами число является палиндромом");

        }
    
        else  
        {
        Console.WriteLine ("Введенное Вами число не является палиндромом");

        }
    }
    else 
    {
        Console.WriteLine ("Введенное Вами число не является пятизначным");
    }
   


}
