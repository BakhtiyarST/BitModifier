using System.Security.Cryptography.X509Certificates;

namespace BitModifier_S2;

internal class Program
{
	static void Main(string[] args)
	{
		// <<<<<<< Task 1: Bits class testing >>>>>>>
		/*
		Bits bits = new(4);

		Console.WriteLine(bits.GetBitByIndex(2));
		Console.WriteLine($"The value {bits.Value}: {bits[2]}, {bits[1]}, {bits[0]}");
		bits[1] = true;
		Console.WriteLine($"The value {bits.Value}: {bits[2]}, {bits[1]}, {bits[0]}");

		Console.WriteLine(bits);
		byte val = (byte)bits;
		Console.WriteLine(val);
		*/


		// <<<<<<< Task 2: Control devices via bits >>>>>>>
		/*
		Devices devices = new();
		Bits bits = new(5);

		Console.WriteLine(devices);
		devices.TurnOnOff(bits);
		Console.WriteLine(devices);
		*/


		// <<<<<<< Task 3: Overload Bits class for Byte, Int, Long >>>>>>>
		/*
		Bits bit = new Bits(180);
		Bits bitByte = new Bits((byte)10);
		Bits bitInt = new Bits((int)11);
		Bits bitLong = new Bits((long)12);

		Console.WriteLine(bit);
		Console.WriteLine(bitByte);
		Console.WriteLine(bitInt);
		Console.WriteLine(bitLong);
		*/


		// <<<<<<< Task 4: Indexable Collection >>>>>>>
		/*
		Collection<string> collection = new Collection<string>(3);
		collection[0] = "Astana";
		collection[1] = "Almaty";
		Console.WriteLine(collection[0]);
		Console.WriteLine(collection[1]);
		*/


		// <<<<<<< Task 5: Class Matrix with interface IMatrix >>>>>>>

		Matrix<int> array = new Matrix<int>(2,2);
		array[0,0] = 1;
		array[0,1] = 2;
		array[1,0] = 3;
		array[1,1] = 4;
		array.PrintMatrix();
	}
}
