// Hourly Employee

public class HourlyEmployee extends Employee
{
	private double rate;
	private double hours;

	public HourlyEmployee(String first, String last, String SSN, double r, double h)
	{
		super(first, last, SSN);	// call Employee constructor
		rate = (r>=0 ? r : 0);
		hours = (h>=0 ? h : 0);
	}

	// This MUST be here to satisfy the superclass abstract earnings
	public double earnings()
	{
		return rate * hours;
	}

	public String toString()
	{
		return "Hourly Employee: " + super.toString();
	}
}