/*Objects of a superclass should be replaceable with objects of its subclasses without 
affecting the correctness of the program.*/

//Violates LSP

public class Bird {
    public virtual void Fly() => Console.WriteLine("Flying");
}

public class Pengiun : Bird {
    public override void Fly() => throw new NotImplementedException();
}


//Follows LSP

public abstract class Bird {
    public abstract void Move();
}

public class Sparrow: Bird {
    public override void Move() => Console.WriteLine("Flying");
}

public class Pengiun: Bird {
    public override void Move() => Console.WriteLine("Swimming");
}