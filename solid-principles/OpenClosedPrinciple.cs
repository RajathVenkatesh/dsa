/*
A class should be open for extension but closed for modification. 
You should be able to extend the behavior of a class without modifying its source code.
*/
 
//Violates OCP

public class Discount {
    public double GetDiscount(string customerType) {
        if(customerType == "Regular") {
            return 10;
        }
        else if(customerType == "VIP") {
            return 20;
        }
    }
}

//Follow OCP 

public abstract class Discount {
    public abstract double GetDiscount();
}

public class RegularCustomerDiscount: Discount {
    public override double GetDiscount() => 10;
}

public class VIPCustomerDiscount: Discount {
public override double GetDiscount() => 20;
}

