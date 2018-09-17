// Employee (Abstract Class)

// Abstract class - it's a class used only as a template
//  at no point do we ever JUST make an employee class

public abstract class Employee
{
	private String lastName;
	private String firstName;
	private String SSN;

	public Employee(String first, String last, String ssn)
	{
		firstName = first;
		lastName = last;
		SSN = ssn;
	}

	// Should do a default constructor, should do set functions

	public String getFirstName()
	{
		return firstName;
	}

	public String getLastName()
	{
		return lastName;
	}

	public String getSSN()
	{
		return SSN;
	}

	public String toString()
	{
		return getFirstName() + " " + getLastName() + " " + getSSN();
	}

	// Abstract method in an abstract class means that all subclasses
	//  of this class MUST have a function called "earnings"

	// These don't have bodies here, they will (and MUST) later
	public abstract double earnings();
}