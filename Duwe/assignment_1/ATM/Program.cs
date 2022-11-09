using ATM; 

ATMDispenseChain atmDispenser = new ATMDispenseChain();


while(true)
{
    int amount = 0;
    Console.WriteLine("Enter amount to dispense");
    int input = Convert.ToInt32(Console.ReadLine());
    amount = input;

    atmDispenser.Dispense(new Currency(amount));



}