System.Console.WriteLine("<====== Arrays ======>");

// * Arrays (fixed length)
// Arrays length or capacity don't change at run time
int[] array1 = new int[5]; // Length: 5

// or
int[] array2 = new int[] { 1, 2, 3, 4 }; // Length: 4

// or
int[] array3 = { 1, 2, 3, 4 };

// ! or (Do not use this)
int[] array4 = new int[] { };

// operations
array2[0] = 10;
array2[1] = array2[0] + array2[1];

// array2[6] = 40; // ! Throws IndexOutOfRangeException

// to Fix this
// Create an array have twice the size
int[] temp = new int[8];

// Copy all element
for (int i = 0; i < array2.Length; i++)
{
    temp[i] = array2[i];
}

// Assign it to the old array
array2 = temp;

// Now do your operation
array2[6] = 40; // This works find

Console.WriteLine("<====== Collections ======>");

// Instead us List
//* List (dynamic length and capacity)
// List of int
List<int> list1 = new List<int>(); // or
list1 = new List<int>() { 1, 2, 3, 4 };

// List of int
List<int> list2 = new List<int>();

// List can be accessed to its element with
// the usual way by the indexer
int a = list1[0];

System.Console.WriteLine(list2.Capacity); // 0

// Add single element
list2.Add(0);

System.Console.WriteLine(list2.Capacity); // 4
System.Console.WriteLine(list2.Count); // 1

// Add range of elements
list2.AddRange(list1);

System.Console.WriteLine(list2.Capacity); // 8
System.Console.WriteLine(list2.Count); // 5

// Add another range of elements
list2.AddRange(list2);

System.Console.WriteLine(list2.Capacity); // 16
System.Console.WriteLine(list2.Count); // 10

// Remove element
list2.Remove(0); // Remove element if exists
list2.RemoveAll(item => item == 1); // Remove elements that match if exists
list2.RemoveAt(0); // Remove the element at the 0 index

list2.Clear(); // Clear all the list elements

// Sort the list
list2.Sort();

// Check if the list contains 4
list2.IndexOf(0);
list2.Contains(4); // bool: true

//? All following using Predicate
list2.Exists(item => item > 2);
list2.Find(item => item > 2);
list2.FindIndex(item => item > 2);
list2.FindLast(item => item > 2);
list2.FindLastIndex(item => item > 2);
list2.FindAll(item => item > 2);

list2.GetRange(1, 4); // From index 1 take 4 elements

Console.WriteLine("<====== Dictionary ======>");

// * Dictionary
Dictionary<int, string> dictionary = new Dictionary<int, string> { };

dictionary[0] = "zero";
dictionary[1] = "one";
dictionary[2] = "tow";

// Dictionary<TKey, TValue>.Add
dictionary.Add(3, "Three");
dictionary.Add(1, "two"); // ! Throws ArgumentException

// Dictionary<TKey, TValue>.Remove
dictionary.Remove(2);
dictionary.Remove(1, out string one); // Remove and save the values

// Dictionary<TKey, TValue>.Clear
dictionary.Clear();

// Dictionary<TKey, TValue>.ContainsKey
dictionary[1] = "one";
bool containsOne = dictionary.ContainsKey(1);

// containsOne is true

// Dictionary<TKey, TValue>.ContainsValue
bool containsValueOne = dictionary.ContainsValue("one");

// containsValueOne is false

// Dictionary<TKey, TValue>.GetEnumerator
Dictionary<int, string>.Enumerator enumerator = dictionary.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine("Key: {0}, Value: {1}", enumerator.Current.Key, enumerator.Current.Value);
}

// Dictionary<TKey, TValue>.TryGetValue
string value;
if (dictionary.TryGetValue(2, out value))
{
    Console.WriteLine("The value of 2 is {0}", value);
}
else
{
    Console.WriteLine("'2' is not in the dictionary.");
}

// Dictionary<TKey, TValue>.Keys
ICollection<int> keys = dictionary.Keys;
foreach (int key in keys)
{
    Console.WriteLine(key);
}

// Dictionary<TKey, TValue>.Values
ICollection<string> values = dictionary.Values;
foreach (string val in values)
{
    Console.WriteLine(val);
}

Console.WriteLine("<====== HashSet ======>");

// HashSet<T>.Add
HashSet<string> colors = new HashSet<string>();
colors.Add("red");
colors.Add("green");
colors.Add("blue");

// colors now contains {"red", "green", "blue"}

// HashSet<T>.Clear
colors.Clear();

// colors is now an empty set

// HashSet<T>.Contains
HashSet<int> numbers = new HashSet<int>() { 1, 2, 3 };
bool containsTwo = numbers.Contains(2);

// containsTwo is true


// HashSet<T>.Count
int count = numbers.Count;

// count is 3

// HashSet<T>.ExceptWith
HashSet<int> otherNumbers = new HashSet<int>() { 2, 4 };
numbers.ExceptWith(otherNumbers);

// numbers now contains {1, 3}

// HashSet<T>.IntersectWith
numbers.IntersectWith(otherNumbers);

// numbers now contains {2}

// HashSet<T>.Remove
colors.Remove("green");

// colors now contains {"red", "blue"}

// HashSet<T>.UnionWith
HashSet<int> setA = new HashSet<int>() { 1, 2, 3, 4 };
HashSet<int> setB = new HashSet<int>() { 5 };
setA.UnionWith(setB);

// setA now contains {1, 2, 3, 4, 5}

Console.WriteLine("<====== Queue ======>");

// Queue<T>.Clear
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Clear();

// queue is now empty

// Queue<T>.Enqueue
queue.Enqueue(4);

// queue now contains {2, 3, 4}

// Queue<T>.Dequeue
int firstNum = queue.Dequeue();

// firstNum is 1, and queue now contains {2, 3}

// Queue<T>.Contains
Queue<string> names = new Queue<string>();
names.Enqueue("Alice");
names.Enqueue("Bob");
names.Enqueue("Charlie");

bool containsBob = names.Contains("Bob");

// containsBob is true

Queue<double> nums = new Queue<double>();
nums.Enqueue(1.1);
nums.Enqueue(2.2);
nums.Enqueue(3.3);
double[] arr = new double[3];
nums.CopyTo(arr, 0);

// arr now contains {1.1, 2.2, 3.3}

// Queue<T>.GetEnumerator
IEnumerator<int> enumerator2 = queue.GetEnumerator();
while (enumerator2.MoveNext())
{
    int num = enumerator2.Current;
    // do something with num
}

// Queue<T>.Peek
int firstNumber = queue.Peek();

// firstNumber is 2, and queue still contains {2, 3, 4}


// Queue<T>.ToArray
int[] numsArr = queue.ToArray();

// numsArr contains {2, 3, 4}

Console.WriteLine("<====== Stack ======>");

// Stack<T>.Clear
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Clear();

// stack is now empty

// Stack<T>.Contains
Stack<string> stackNames = new Stack<string>();
stackNames.Push("Alice");
stackNames.Push("Bob");
stackNames.Push("Charlie");
bool stackContainsBob = stackNames.Contains("Bob");

// containsBob is true

// Stack<T>.CopyTo
Stack<double> stackNumbers = new Stack<double>();
stackNumbers.Push(1.1);
stackNumbers.Push(2.2);
stackNumbers.Push(3.3);
double[] arr2 = new double[3];
stackNumbers.CopyTo(arr2, 0);

// arr now contains {3.3, 2.2, 1.1} (the elements are reversed)

// Stack<T>.GetEnumerator
IEnumerator<double> enumerator3 = stackNumbers.GetEnumerator();
while (enumerator3.MoveNext())
{
    double num = enumerator3.Current;
    // do something with num
}

// Stack<T>.Peek
double topNum = stackNumbers.Peek();

// topNum is 3.3, and stackNumbers still contains {1.1, 2.2, 3.3}

// Stack<T>.Pop
double poppedNum = stackNumbers.Pop();

// poppedNum is 3.3, and stackNumbers now contains {1.1, 2.2}

// Stack<T>.Push
stackNumbers.Push(4.4);

// stackNumbers now contains {4.4, 1.1, 2.2}

// Stack<T>.ToArray
double[] numbersArr = stackNumbers.ToArray();

// numsArr contains {4.4, 1.1, 2.2}

Console.WriteLine("<====== Advanced List Method ======>");

// * Advanced List method
list2.Sort();
int l = list2.BinarySearch(0, list2.Count, 1, new IntComparer());

// Or
// int index = list2.BinarySearch(0, list2.Count, 2, Comparer<int>.Default);

System.Console.WriteLine(l);

List<MyClass> list3 = new();
list3.Add(new MyClass() { a = 5 });
list3.Add(new MyClass() { a = 10 });
list3.Add(new MyClass() { a = 7 });
list3.Sort(new MyClassComparer()); // ! Throws InvalidOperationException
list3.Sort();

class IntComparer : IComparer<int>
{
    public int Compare(int x, int y)
    {
        return x.CompareTo(y);
    }
}

class MyClass
{
    public int a;

    public MyClass() { }

    public MyClass(int number)
    {
        a = number;
    }
}

/// <summary>
/// Comparer for MyClass class
/// </summary>
class MyClassComparer : IComparer<MyClass>
{
    /// <summary>
    /// The Compare function takes two objects of type MyClass and returns an integer
    /// </summary>
    /// <param name="x">The type of objects to compare.</param>
    /// <param name="y">The type of objects to compare.</param>
    /// <returns>
    /// The comparison of the two objects.
    /// </returns>
    public int Compare(MyClass x, MyClass y)
    {
        return x.a.CompareTo(y.a);
    }
}
