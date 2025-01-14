/*It states that high-level modules should not depend on low-level modules, 
but both should depend on abstractions.
*/

//Violates DIP

public class OrderProcessor
{
    private EmailService emailService;

    public OrderProcessor()
    {
        emailService = new EmailService();  // Direct dependency on EmailService
    }

    public void ProcessOrder(string orderDetails)
    {
        // Business logic to process the order
        Console.WriteLine("Order processed: " + orderDetails);

        // Sending order confirmation email
        emailService.SendEmail("customer@example.com", "Order Confirmation", orderDetails);
    }
}

public class EmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Email sent to {to} with subject '{subject}' and body '{body}'");
    }
} 

//Follows DIP

public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
}

//Concrete Classes

public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"Email sent to {to} with subject '{subject}' and body '{body}'");
    }
}

public class SmsService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"SMS sent to {to} with subject '{subject}' and body '{body}'");
    }
}

public class OrderProcessor
{
    private readonly IEmailService emailService;

    public OrderProcessor(IEmailService emailService)
    {
        this.emailService = emailService;  // Dependency injection through constructor
    }

    public void ProcessOrder(string orderDetails)
    {
        // Business logic to process the order
        Console.WriteLine("Order processed: " + orderDetails);

        // Sending order confirmation (Email/SMS based on injected service)
        emailService.SendEmail("customer@example.com", "Order Confirmation", orderDetails);
    }
}
 