// Salaried Employee

public class SalariedEmployee extends Employee
{
	private double weeklySalary;

	public SalariedEmployee(String first, String last, String SSN, double salary)
	{
		super(first, last, SSN);	// call Employee constructor
		weeklySalary = (salary >= 0 ? salary : 0);
	}

	// This MUST be here to satisfy the superclass abstract earnings
	public double earnings()
	{
		return weeklySalary;
	}

	public String toString()
	{
		return "Salaried Employee: " + super.toString();
	}
}