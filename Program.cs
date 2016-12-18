//Stopping a programme from crashing.
using System;
class TryIt
{
	public static void Main()
	{
		//dataType array, arrayName, =new dataType array of 5.
		int[] mikesArray = new int[5];
		
		try //start of error testing.
		{
			//loops ctr 10x
			for (int ctr=0; ctr<10; ctr++) 
			{
				//array counter is asigned to ctr.
				mikesArray[ctr] = ctr;
			}
		}
		catch(Exception e)  //testing ends and error is caught.
		{
			Console.WriteLine("The exception was caught Mike: {0}", e);
		}
		finally
		{
			Console.WriteLine("Last thing to run.");
		}
		Console.ReadKey(true);
	}
}
