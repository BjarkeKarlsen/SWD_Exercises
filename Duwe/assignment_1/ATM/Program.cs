using ATM; 

ATMDispenseChain atmDispenser = new ATMDispenseChain();


while(true)
{
    int amount = 0;
    Console.WriteLine("Enter amount to dispense");
    int input = Convert.ToInt32(Console.ReadLine());
    amount = input;
    if(amount % 10 != 0)
    {
        Console.WriteLine("Amount must be divisible by 10");
        return;
    }
    atmDispenser.Dispense(new Currency(amount));



}