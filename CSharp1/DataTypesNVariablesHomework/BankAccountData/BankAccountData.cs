//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Iron";
        string middleName = "Man";
        string lastName = "3";
        decimal balance = 7000294645.25M;
        string bankName = "The Best Bank In teh World"; //there's no such thing :)
        string iban = "BG01 TBBW 1111 1481 9230 01";
        string firstCard = "9999 4145 6873 3935";
        string secondCard = "5555 4138 2442 3009";
        string thirdCard = "4444 5622 3589 7376";

        Console.WriteLine("{0} {1} {2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", 
            firstName, middleName, lastName, balance, bankName, iban, firstCard, secondCard, thirdCard);
    }
}
