namespace Program
{
	public delegate void ParameterLess();
	public delegate double DoCalculation(int a, int b);

	class Program
	{
		public static void Print()
		{
			Console.WriteLine("Hello World!");
		}

		public static void PrintName()
		{
			Console.WriteLine("Hello Mahmoud!");
		}

		public static void PrintName(string message)
		{
			Console.WriteLine(message);
		}

		public delegate void D(MyClass p1, Object p2, int[] arr);

		public static void Main(string[] args)
		{
			//Action<MyClass, Object, int[]> myFancyAction;
			//Func<int, int, double> func;
			//Predicate<MyClass> predicate;


			//DoSomething(Print);
			//DoSomething(PrintName);


			MyClass obj = new MyClass(PrintName);
			MyClass obj2 = new MyClass();

			Console.WriteLine(MyClass.IsValidObject(obj.IsValid, obj));
			Console.WriteLine(MyClass.IsValidObject(obj.IsValid, obj2));

			//Delegate a = Print;
			//ParameterLess b = Print;

			//DoCalculation calculation = Add;

			//double result = calculation(5, 6);
			//Console.WriteLine(result);


			//calculation = Subtract;
			//result = calculation(5, 6);
			//Console.WriteLine(result);

		}

		public static double Add(int a, int b)
		{
			return a + b;
		}

		public static double Subtract(int a, int b)
		{
			return a - b;
		}

		public static double Multiply(int a, int b)
		{
			return a * b;
		}

		public static void DoSomething(Action callback)
		{
			callback();
		}
	}

	delegate void MyDelegate(string message);

	class MyClass
	{
		// A field to store the delegate
		private Action<string> _delegate;

		// A constructor that takes a delegate parameter
		public MyClass()
		{
		}

		public MyClass(Action<string> del)
		{
			_delegate = del;
		}

		public bool IsValid(MyClass obj)
		{
			return obj._delegate != null;
		}

		public static bool IsValidObject(Predicate<MyClass> pre, MyClass obj)
		{
			return pre(obj);
		}

		public static bool IsValidObject<T>(Predicate<T> pre, T obj)
		{
			return pre(obj);
		}

		// A method that invokes the delegate
		public void DoSomething(string message)
		{
			if (_delegate != null)
			{
				_delegate(message);
			}
		}
	}
}