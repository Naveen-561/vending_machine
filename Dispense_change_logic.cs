

package vendingmachine;

public class dispensechange implements State{
private VendingMachine vendingmachine;

DispenseChange(VendingMachine vendingMachine){
this.vendingMachine = vendingMachine;
}

public void CollectCash(int cash){
throw new RuntimeException(“Dispense change unable to collect cash”);
}

public void dispensechange(String productcode){
int change= this.vendingmachine.calculatechange(productcode);
system.out.printLn(“change of” + change+ “returned”);
this.vendingmachine.setState (new Dispenseitem(this.vendingmachine));
this.vendingmachine.dispenseitem(productcode);
}

