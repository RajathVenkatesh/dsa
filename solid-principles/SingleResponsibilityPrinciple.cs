//A class should have only one reason to change, meaning it should only have one job or responsibility.

//Violates SRP

public class InvoiceProcessor {
    public void ProcessInvoice() {

    }

    public void SendEmail() {

    }
}

//Follows SRP

public class InvoiceProcessor {
    public void ProcessInvoice() {

    }
}

public class EmailSender {
    public void sendEmail() {

    }
}