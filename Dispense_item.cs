
public class Dispenseitem implements state{
private final vendingMachine vendingmachine;
DispenseItem (VendingMachine vendingMachine){
this.vendingMachine= vendingMachine;
}

public void collectcash(int cash){
throw new RuntimeException(“Dispense item. unable to collect cash”);
}

public void dispenseChange(String productcode){
throw new RuntimeException(“Dispense item.unable to dispense change”);
}

public void dispenseitem(String productcode){
vendingMachine.removeProduct(productCode);
System.out.printLn(“Dispense item” +productcode);
vendingmachine.setstate(new Ready(this.vendingMachine));
}

public void canceltransaction(){
throw new RuntimeException(“Dispensing item unable to cancel transaction”);
}
}
