using Chain_of_responsibility;

var atm = new ATM();

atm.Dispense(new Currency(2600));

atm.Dispense(new Currency(300));

