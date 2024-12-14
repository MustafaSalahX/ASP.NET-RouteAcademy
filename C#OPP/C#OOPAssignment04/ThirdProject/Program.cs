namespace ThirdProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Try all constructors
			Duration D1 = new Duration(1, 20, 30);
			Console.WriteLine(D1);
			Console.WriteLine("****************");
			Duration D2 = new Duration(1200);
			Console.WriteLine(D2);
            Console.WriteLine("****************");

			//Operator Overloading
			//D3 = D1 + D2
			Duration D3 = new Duration();
			D3 = D1 + D2; 
			//Output = 1 hour , 20 mins , 30 seconds
			Console.WriteLine(D3);
            Console.WriteLine("****************");
			//D3 = D2 + 7800
			D3 = D2 + 7800;
            Console.WriteLine(D3);
            Console.WriteLine("****************");
			//D3 = 666 + D3
			D3 = 666 + D3;
			Console.WriteLine(D3);
            Console.WriteLine("****************");
			//D3 = ++D1
			D3 = ++D1;
            Console.WriteLine(D3);
            Console.WriteLine("****************");
			//D3 = --D1
			D3 = --D1;
			Console.WriteLine(D3);
            Console.WriteLine("****************");
			//D3 = D1 - D2
			D3 = D1 - D2;
			Console.WriteLine(D3);
            Console.WriteLine("****************");
			//If(D1>D2)
			if (D1 > D2)
				Console.WriteLine("D1>D2");
			else
				Console.WriteLine("D1<D2");
            Console.WriteLine("****************");
            //If (D1<=D2)
            if (D1 <= D2)
                Console.WriteLine("D1<=D2");
            else
                Console.WriteLine("D1>D2");
            Console.WriteLine("****************");

			//If(D1)
			if (D1)
				Console.WriteLine(D1);
			else
				Console.WriteLine("The hours or minutes or seconds is not setted");
            Console.WriteLine("****************");

            //DateTime obj = (DateTime)D1
            DateTime obj = (DateTime)D1;
			Console.WriteLine(obj);
        }

    }
}
