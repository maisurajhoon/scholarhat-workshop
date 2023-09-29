using System;

public class Contact
{
    public long ContactNumber;
    public string Name;
    public int AreaPin;
    public string Location;
    public int SerialNumber;

    public Contact(long contactNumber, string name, int areaPin, string location, int serialNumber)
    {
        ContactNumber = contactNumber;
        Name = name;
        AreaPin = areaPin;
        Location = location;
        SerialNumber = serialNumber;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine();
        Console.WriteLine($"Serial No: {SerialNumber}");
        Console.WriteLine($"Contact Number: {ContactNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Pincode: {AreaPin}");
        Console.WriteLine($"Location: {Location}");
    }
}

public class NewContact : Contact
{
    public NewContact(long contactNumber, string name, int areaPin, string location, int serialNumber)
    : base(contactNumber, name, areaPin, location, serialNumber)
    {
        // This field is kept empty
    }
}

public class ContactBook
{
    public static void Main()
    {
        Console.Clear();
        NewContact customer1 = new NewContact(8292355072, "Suraj", 462003, "Bhopal MP", 1);
        NewContact customer2 = new NewContact(9876543210, "Mohan", 846003, "Darbhanga Bihar", 2);

        Console.WriteLine("Customer Details:");
        customer1.DisplayDetails();  // This will display customer 1 details
        customer2.DisplayDetails();  // This will display customer 2 details
    }
}
