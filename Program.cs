namespace Program
{
	public delegate void ParameterLess();
	public delegate double DoCalculation(int a, int b);
	public delegate bool Check(MyClass obj);

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

		public delegate void Del(string msg);
		public static void PrintName(string message)
		{
			Console.WriteLine(message);
		}

		

		private delegate void D(MyClass p1, Object p2, int[] arr);

		public static void DB(MyClass p1, Object p2, int[] arr)
		{

		}
		

		public static void Main(string[] args)
		{
			D something = DB;
			something(new MyClass(), new object(), new int[6]);
			//Action<MyClass, Object, int[]> myFancyAction;
			//Func<int, int, double> func;
			//Predicate<MyClass> predicate;


			//DoSomething(Print);
			//DoSomething(PrintName);


			MyClass obj = new MyClass(PrintName);
			MyClass obj2 = new MyClass();

			Check del = obj2.IsValid;
			Check del2 = MyClass.IsValidObj;
			Check del3 = Chk;

			Console.WriteLine(MyClass.IsValidObject(obj.IsValid, obj));
			Console.WriteLine(MyClass.IsValidObject(obj.IsValid, obj2));

			Delegate a = Print;
			ParameterLess b = Print;

			DoCalculation calculation = Multiply;

			Add(5,6);

			double result = calculation(5, 6);
			//Console.WriteLine(result);


			//calculation = Subtract;
			//result = calculation(5, 6);
			//Console.WriteLine(result);

		}

		public static bool Chk(MyClass obj) => true;

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

	public class MyClass
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
		public static bool IsValidObj(MyClass obj)
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