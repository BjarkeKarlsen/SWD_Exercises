using Chain_Of_Responsibility;

var atm = new ATM();

int value = 340;
Console.WriteLine($"Dispensing {value}");
atm.Dispense(new Currency(value));
Console.WriteLine("");

value = 5320;
Console.WriteLine($"Dispensing {value}");
atm.Dispense(new Currency(value));
Console.WriteLine("");

value = 55;
Console.WriteLine($"Dispensing {value}");
atm.Dispense(new Currency(value));
Console.WriteLine("");

value = 20;
Console.WriteLine($"Dispensing {value}");
atm.Dispense(new Currency(value));
Console.WriteLine("");

value = 50;
Console.WriteLine($"Dispensing {value}");
atm.Dispense(new Currency(value));
Console.WriteLine("");

value = 100;
Console.WriteLine($"Dispensing {value}");
atm.Dispense(new Currency(value));