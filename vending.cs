package vendingmachine;




Public Class VendingMachine {
private int collectedCash;
private  state state;
private <string> ProductCodeItemMap;
private  <string,int> ProductCodePriceMap;


Public vendingMachine()
{
this.collectedcash=0;
this.state=State.Ready;
}

Public void collectcash (int cash)
{
switch(state)
{
case Ready:
handleCollectCash(cash);
break;
case Dispense_change:
throw new  RuntimeException(“Dispensing change unable to collect cash”);
case Dispense_item:
throw new RuntimeException(“Dispensing item unable to collect cash”);
case Transaction_cancelled:
throw new RuntimeException(“Transaction cancelled unable to collect cash”);
}
}

Public void dispenseitem(string productcode)
{
switch(state)
{
case Ready:
throw new RuntimeException(“Unable to dispense item cash not be collected”);
case Dispense_change:
handleDispensechange(productcode);
break;
case Dispense_item:
handleDispensechange(productcode);
break;
case Transaction_cancelled:
throw new RuntimeException(“Transaction cancelled. Unable to dispense item”);
}
}

private void handleCollectCash(int cash){
this.collectcash += cash;
}

private void handleDispenseitem(String productcode){
//dispense item logic
}

private void handleDispensechange(String productcode){
//dispense change logic
}
}




package vendingmachine;

public interface state{
public void collectcash(int cash);
public void dispensechange(String productcode);
public void dispenseitem(String productcode);
public void cancelTransaction();
}

Public class vendingmachine{
Private int collectedcash;
private state state;
private <string>  productcodeitemmap;
private <string,int> productcodepricemap;

Public void addcollectedcash(int collectedcash){
this.collectedcash += collectedcash;
}

public vendingmachine setcollectedcash (int collectedcash){
this.collectedcash = collectedcash;
return this;
}

public state getstate(){
return state;
}

public vendingmachine setstate (State state){
this.state=state;
return this;
}

public void removeproduct (String productcode){
}

public void dispenseChange (String productcode){
this.state.dispensechange(productcode);
}

public void canceltransaction() {
this.state.canceltransaction();
}

public int calculatechange(String productcode){
return collectedcash - productcodepricemap.get(productcode);
}

public void dispenseitem(String productcode){
this.state.dispenseitem(productcode);
}

public int getcollectedcash() {
return collectedcash;
}
