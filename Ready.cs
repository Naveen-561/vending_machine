package vendingmachine;

public class Ready implements state{
private vendingMachine vendingMachine;
Ready(vendingMachine vendingMachine){
this.vendingMachine = vendingMachine;
}

public void collectCash(int cash){
this.vendingMachine.addCollectedCash(cash);
}

public void Dispensechange(String productcode){
this.vendingmachine.setstate(new Dispensechange(this.vendingmachine));
this.vendingmachine.dispensechange(productcode);
}

public void dispenseitem(String productcode){
throw new RuntimeException("Txn not intiated.unable to dispense item");
}

public void canceltransaction() {
this.vendingmachine.setstate( new TransactionCancelled(vendingmachine));
this.vendingmachine.canceltransaction();
}
}
