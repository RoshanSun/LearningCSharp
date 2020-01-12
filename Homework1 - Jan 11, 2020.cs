using System;

public class Homework1
{
	/**
	 * Homework #1
	 * Read name, surename, age, weight (in kg) and height (in cm) from console.
	 * 1) Print all the info based on the example message below:
	 * Tom Jefferson is 19 years old, his weight is 50 kg and his height is 156.5 cm.
	 * 2) Calculate and print body-mass index (BMI)
	 * 3) Do 1 and 2 for another person.
	 * @author: Roshan
	 */
	public static void Main(string[] args)
    {
        Console.WriteLine("Input your first name: ");
		string firstName = Console.ReadLine();
		Console.WriteLine("Input your surname: ");
		string lastName = Console.ReadLine();
		Console.WriteLine("Input your age: ");
		int age = Console.ReadLine();
		Console.WriteLine("Input your weight (in kg): ");
		int weight = Console.ReadLine();
		Console.WriteLine("Input your height (in cm): ");
		int height = Console.ReadLine();

        Console.WriteLine(firstName + lastName + " is " + age + " years old, his weight is "
			+ weight + " kg and his height is " + height + " cm." );

		float bodyMassIndex = weight / ((height / 100) ^ 2);
		Console.WriteLine("The BMI of " + firstName + lastName + " is " + bodyMassIndex);
	}
}
