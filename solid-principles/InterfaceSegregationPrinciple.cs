/*Clients should not be forced to depend on interfaces they do not use. 
Create smaller, more specific interfaces rather than one large, general-purpose interface.
*/

//Violates ISP

public interface IWorker {
    void Work();
    void Eat();
}

public class Robot: IWorker {
    public void Work() =>  Console.WriteLine("Working");

    public void Eat() => throw new NotImplementatedException();

}

//Follows ISP

public interface IWorkable {
    void Work();
}

public interface IEatable {
    void Eat();
}

public class Human: IWorkable, IEatable {
   public void Work() =>  Console.WriteLine("Working");

   public void Eat() =>  Console.WriteLine("Eating");
}

public class Robot: IWorkable {
   public void Work() =>  Console.WriteLine("Working");
   
}