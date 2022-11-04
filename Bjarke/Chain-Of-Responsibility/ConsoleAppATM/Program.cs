using Chain_Of_Responsibility;

var atm = new ATM();

atm.Dispense(new Currency(340));

atm.Dispense(new Currency(5320));