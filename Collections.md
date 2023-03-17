# Collection

Data structures are an essential part of programming that help organize and manipulate data efficiently. <br />
In C#, the System.Collections and System.Collections.Generic namespaces provide a wide range of data structures to choose from.<br />
In this list, we will explore all the data structures present in these namespaces.<br />
These include ArrayList, Dictionary, HashSet, LinkedList, Queue, SortedDictionary, SortedList, SortedSet, and many more. <br />
Each of these data structures has unique characteristics and can be used for different purposes depending on the requirements of your project. <br />
By understanding these data structures, you can write more efficient and optimized code that can handle large amounts of data.

Here's a list of all the data structures in the System.Collections and System.Collections.Generic namespaces in C#:

| Collections                     | Collections.Generic                     |
| ------------------------------- | --------------------------------------- |
| ArrayList                       | Dictionary&lt;TKey, TValue&gt;          |
| BitArray                        | HashSet&lt;T&gt;                        |
| CaseInsensitiveComparer         | IComparer&lt;T&gt;                      |
| CaseInsensitiveHashCodeProvider | IDictionary&lt;TKey, TValue&gt;         |
| CollectionBase                  | IEnumerable&lt;T&gt;                    |
| Comparer                        | IEnumerator&lt;T&gt;                    |
| DictionaryBase                  | IList&lt;T&gt;                          |
| Hashtable                       | ISet&lt;T&gt;                           |
| ICollection                     | KeyNotFoundException                    |
| IComparer                       | KeyValuePair&lt;TKey, TValue&gt;        |
| IDictionary                     | LinkedList&lt;T&gt;                     |
| IEnumerable                     | List&lt;T&gt;                           |
| IEnumerator                     | Queue&lt;T&gt;                          |
| IEqualityComparer               | SortedDictionary&lt;TKey, TValue&gt;    |
| IList                           | SortedList&lt;TKey, TValue&gt;          |
| IStructuralComparable           | SortedSet&lt;T&gt;                      |
| IStructuralEquatable            | Stack&lt;T&gt;                          |
| Queue                           | ICollection&lt;T&gt;                    |
| ReadOnlyCollectionBase          | IReadOnlyCollection&lt;T&gt;            |
| SortedList                      | IReadOnlyDictionary&lt;TKey, TValue&gt; |
| Stack                           | -                                       |

---

The data structures that are listed in the System.Collections and System Collections.Generic namespaces in  C#, are used to store a collection of objects. However, there are some significant differences in the implementation, functionality, and performance of these data structures. Here are some of the key distinctions:

- **Type safety:** The data structures in the System.Collections namespace are not type-safe, meaning that they can store objects of any type. In contrast, the data structures in the System.Collections.Generic namespaces are type-safe, meaning that they are designed to work with a specific type of object and can only store objects of that type.

- **Performance:** The data structures in the System.Collections.Generic namespaces are generally faster and more efficient than the ones in the System.Collections namespace. This is because generic data structures use a specific type of information to optimize memory usage and improve performance.

- **Memory usage:** The data structures in the System.Collections.Generic namespaces are generally more memory efficient than the ones in the System.Collections namespace. This is because generic data structures use a specific type of information to allocate memory more efficiently.

- **Functionality:** The data structures in the System.Collections.Generic namespace offers more functionality and flexibility than the ones in the System.Collections namespace. For example, the List<T> class provides methods for sorting, searching, and manipulating the list, while the Dictionary<TKey, TValue> class provides methods for accessing and modifying key-value pairs.

- **Type parameters:** The data structures in the System.Collections.Generic namespace use type parameters to specify the type of objects that they can store, while the ones in the System.Collections namespace uses the object type to store objects of any type.

In summary, the data structures in the System.Collections.Generic namespaces are generally faster, more memory efficient, and more type-safe than the ones in the System.Collections namespace and they offer more functionality and flexibility. However, both sets of data structures have their use cases and can be useful in different situations.

---

Now, here's a list of some of the most commonly used data structures from the System.Collections and System.Collections.Generic namespaces in C#:

| Collection | Collection.Generic             |
| ---------- | ------------------------------ |
| ArrayList  | List&lt;T&gt;                  |
| Hashtable  | Dictionary&lt;TKey, TValue&gt; |
| -          | HashSet&lt;T&gt;               |
| Queue      | Queue&lt;T&gt;                 |
| Stack      | Stack&lt;T&gt;                 |

But when to use each of these data structures:

- List&lt;T&gt;: Use a List&lt;T&gt; when you need to store a collection of objects that can be accessed by index. A List&lt;T&gt; is useful when you need to add or remove elements from the collection frequently, or when you need to iterate over the collection in order.

- Dictionary&lt;TKey, TValue&gt;: Use a Dictionary&lt;TKey, TValue&gt; when you need to store a collection of key-value pairs, where each key maps to a unique value. A Dictionary&lt;TKey, TValue&gt; is useful when you need to look up values based on their keys quickly.

- HashSet&lt;T&gt;: Use a HashSet&lt;T&gt; when you need to store a collection of unique objects. A HashSet&lt;T&gt; is useful when you need to check whether an object is already in the collection frequently.

- Queue&lt;T&gt;: Use a Queue&lt;T&gt; when you need to store a collection of objects in a first-in, first-out (FIFO) order. A Queue&lt;T&gt; is useful when you need to process items in the order that they were added to the collection.

- Stack&lt;T&gt;: Use a Stack&lt;T&gt; when you need to store a collection of objects in a last-in, first-out (LIFO) order. A Stack&lt;T&gt; is useful when you need to process items in the reverse order that they were added to the collection.

And it depends on your application.

---

Here are some of the most used **List&lt;T&gt;** methods:

- **Add:** This method adds an item to the end of the list.

```cs
// List<T>.Add
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
// numbers now contains {1, 2, 3}
```

- **Clear:** This method removes all items from the list.

```cs
// List<T>.Clear
numbers.Clear();
// numbers is now an empty list
```

- **Contains:** This method determines whether an item is in the list.

```cs
// List<T>.Contains
List<string> fruits = new List<string>() { "apple", "banana", "orange" };
bool containsBanana = fruits.Contains("banana");
// containsBanana is true
```

- **CopyTo:** This method copies the elements of the list to an array, starting at a particular index.

```cs
// List<T>.CopyTo
int[] array = new int[5];
List<int> list = new List<int>() { 1, 2, 3 };
list.CopyTo(array, 1);
// array now contains {0, 1, 2, 3, 0}
```

- **Count:** This property gets the number of elements contained in the list.

```cs
// List<T>.Count
int count = list.Count;
// count is 3
```

- **IndexOf:** This method returns the index of the first occurrence of a specified item in the list.

```cs
// List<T>.IndexOf
int index = fruits.IndexOf("orange");
// index is 2
```

- **Insert:** This method inserts an item into the list at a specified index.

```cs
// List<T>.Insert
fruits.Insert(1, "grape");
// fruits now contains {"apple", "grape", "banana", "orange"}

```

- **InsertRange:** This method inserts a collection of items into the list at a specified index.

```cs
// List<T>.InsertRange
List<int> newNumbers = new List<int>() { 4, 5 };
numbers.InsertRange(1, newNumbers);
// numbers now contains {1, 4, 5, 2, 3}
```

- **Remove:** This method removes the first occurrence of a specified item from the list.

```cs
// List<T>.Remove
numbers.Remove(5);
// numbers now contains {1, 4, 2, 3}
```

- **RemoveAll:** This method removes all items that match a specified predicate from the list.

```cs
// List<T>.RemoveAll
numbers.RemoveAll(n => n % 2 == 0);
// numbers now contains {1}
```

- **RemoveAt:** This method removes the item at a specified index from the list.

```cs
// List<T>.RemoveAt
numbers.RemoveAt(0);
// numbers is now an empty list
```

- **RemoveRange:** This method removes a range of items from the list, starting at a specified index and continuing for a specified number of elements.

```cs
// List<T>.RemoveRange
numbers.AddRange(new List<int>() { 1, 2, 3, 4, 5 });
numbers.RemoveRange(1, 3);
// numbers now contains {1, 5}
```

- **Reverse:** This method reverses the order of the elements in the list.

```cs
// List<T>.Reverse
numbers.Reverse();
// numbers now contains {5, 1}
```

- **Sort:** This method sorts the elements in the list.

```cs
// List<T>.Sort
numbers.Sort();
// numbers now contains {1, 5}
```

- **ToArray:** This method copies the elements of the list to a new array.

```cs
// List<T>.ToArray
int[] numberArray = numbers.ToArray();
// numberArray now contains {1, 5}
```

---

Here are some of the most used **Dictionary&lt;TKey, TValue&gt;** methods:

- **Add:** This method adds an element with the specified key and value to the dictionary.

```cs
// Dictionary<TKey, TValue>.Add
Dictionary<string, int> myDictionary = new Dictionary<string, int>();
myDictionary.Add("apple", 1);
myDictionary.Add("banana", 2);
myDictionary.Add("orange", 3);
```

- **Clear:** This method removes all elements from the dictionary.

```cs
// Dictionary<TKey, TValue>.Clear
myDictionary.Clear();
```

- **ContainsKey:** This method determines whether the dictionary contains the specified key.

```cs
// Dictionary<TKey, TValue>.ContainsKey
myDictionary.Add("apple", 1);
bool containsApple = myDictionary.ContainsKey("apple");
// containsApple is true
```

- **ContainsValue:** This method determines whether the dictionary contains the specified value.

```cs
// Dictionary<TKey, TValue>.ContainsValue
bool containsValueThree = myDictionary.ContainsValue(3);
// containsValueThree is false
```

- **Count:** This property gets the number of key/value pairs contained in the dictionary.

```cs
// Dictionary<TKey, TValue>.Count
int count = myDictionary.Count;
// count is 1
```

- **GetEnumerator:** This method returns an enumerator that iterates through the key/value pairs in the dictionary.

```cs
// Dictionary<TKey, TValue>.GetEnumerator
Dictionary<string, int>.Enumerator enumerator = myDictionary.GetEnumerator();
while (enumerator.MoveNext())
{
Console.WriteLine("Key: {0}, Value: {1}", enumerator.Current.Key, enumerator.Current.Value);
}
```

- **Remove:** This method removes the element with the specified key from the dictionary.

```cs
// Dictionary<TKey, TValue>.Remove
myDictionary.Remove("apple");
```

- **TryGetValue:** This method gets the value associated with the specified key, if the key is found.

```cs
// Dictionary<TKey, TValue>.TryGetValue
int value;
if (myDictionary.TryGetValue("banana", out value))
{
Console.WriteLine("The value of 'banana' is {0}", value);
}
else
{
Console.WriteLine("'banana' is not in the dictionary.");
}
```

- **Keys:** This property gets a collection containing the keys in the dictionary.

```cs
// Dictionary<TKey, TValue>.Keys
ICollection<string> keys = myDictionary.Keys;
foreach (string key in keys)
{
Console.WriteLine(key);
}
```

- **Values:** This property gets a collection containing the values in the dictionary.

```cs
// Dictionary<TKey, TValue>.Values
ICollection<int> values = myDictionary.Values;
foreach (int value in values)
{
Console.WriteLine(value);
}
```

---

Here are some of the most used **HashSet&lt;T&gt;** methods :

- **Add:** This method adds an element to the set.

```cs
// HashSet<T>.Add
HashSet<string> colors = new HashSet<string>();
colors.Add("red");
colors.Add("green");
colors.Add("blue");
// colors now contains {"red", "green", "blue"}
```

- **Clear:** This method removes all elements from the set.

```cs
// HashSet<T>.Clear
colors.Clear();
// colors is now an empty set
```

- **Contains:** This method determines whether the set contains the specified element.

```cs
// HashSet<T>.Contains
HashSet<int> numbers = new HashSet<int>() { 1, 2, 3 };
bool containsTwo = numbers.Contains(2);
// containsTwo is true
```

- **Count:** This property gets the number of elements contained in the set.

```cs
// HashSet<T>.Count
int count = numbers.Count;
// count is 3
```

- **ExceptWith:** This method removes all elements in the specified collection from the set.

```cs
// HashSet<T>.ExceptWith
HashSet<int> otherNumbers = new HashSet<int>() { 2, 4 };
numbers.ExceptWith(otherNumbers);
// numbers now contains {1, 3}
```

- **IntersectWith:** This method modifies the set so that it contains only elements that are also in a specified collection.

```cs
// HashSet<T>.IntersectWith
numbers.IntersectWith(otherNumbers);
// numbers now contains {2}
```

- **Remove:** This method removes the specified element from the set.

```cs
// HashSet<T>.Remove
colors.Remove("green");
// colors now contains {"red", "blue"}
```

- **UnionWith:** This method modifies the set so that it contains all elements that are present in either the set or the specified collection.

```cs
// HashSet<T>.UnionWith
setA.UnionWith(setB);
// setA now contains {1, 2, 3, 4, 5}

```

---

Here are some of the most used **Queue&lt;T&gt;** methods;

- **Clear:** This method removes all elements from the queue.

```cs
// Queue<T>.Clear
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Clear();
// queue is now empty
```

- **Enqueue:** This method adds an object to the end of the queue.

```cs
// Queue<T>.Enqueue
queue.Enqueue(4);
// queue now contains {2, 3, 4}
```

- **Dequeue:** This method removes and returns the object at the beginning of the queue.

```cs
// Queue<T>.Dequeue
int firstNum = queue.Dequeue();
// firstNum is 1, and queue now contains {2, 3}
```

- **Contains:** This method determines whether an element is in the queue.

```cs
// Queue<T>.Contains
Queue<string> names = new Queue<string>();
names.Enqueue("Alice");
names.Enqueue("Bob");
names.Enqueue("Charlie");

bool containsBob = names.Contains("Bob");
// containsBob is true
```

- **CopyTo:** This method copies the elements of the queue to an array, starting at a specified array index.

```cs
// Queue<T>.CopyTo
Queue<double> nums = new Queue<double>();
nums.Enqueue(1.1);
nums.Enqueue(2.2);
nums.Enqueue(3.3);
double[] arr = new double[3];
nums.CopyTo(arr, 0);
// arr now contains {1.1, 2.2, 3.3}
```

- **GetEnumerator:** This method returns an enumerator that iterates through the queue.

```cs
// Queue<T>.GetEnumerator
IEnumerator<int> enumerator = queue.GetEnumerator();
while (enumerator.MoveNext())
{
int num = enumerator.Current;
// do something with num
}
```

- **Peek:** This method returns the object at the beginning of the queue without removing it.

```cs
// Queue<T>.Peek
int firstNum = queue.Peek();
// firstNum is 2, and queue still contains {2, 3, 4}
```

- **ToArray:** This method copies the elements of the queue to a new array.

```cs
// Queue<T>.ToArray
int[] numsArr = queue.ToArray();
// numsArr contains {2, 3, 4}
```

---

Here are some of the most used **Stack&lt;T&gt;** methods;

- **Clear:** This method removes all elements from the stack.

```cs
// Stack<T>.Clear
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Clear();
// stack is now empty
```

- **Contains:** This method determines whether an element is in the stack.

```cs
// Stack<T>.Contains
Stack<string> stackNames = new Stack<string>();
stackNames.Push("Alice");
stackNames.Push("Bob");
stackNames.Push("Charlie");
bool stackContainsBob = stackNames.Contains("Bob");
// containsBob is true
```

- **CopyTo:** This method copies the elements of the stack to an array, starting at a specified array index.

```cs
// Stack<T>.CopyTo
Stack<double> stackNumbers = new Stack<double>();
stackNumbers.Push(1.1);
stackNumbers.Push(2.2);
stackNumbers.Push(3.3);
double[] arr2 = new double[3];
nums.CopyTo(arr2, 0);
// arr now contains {3.3, 2.2, 1.1} (the elements are reversed)
```

- **GetEnumerator:** This method returns an enumerator that iterates through the stack.

```cs
// Stack<T>.GetEnumerator
IEnumerator<double> enumerator = stackNumbers.GetEnumerator();
while (enumerator.MoveNext())
{
double num = enumerator.Current;
// do something with num
}
```

- **Peek:** This method returns the object at the top of the stack without removing it.

```cs
// Stack<T>.Peek
double topNum = stackNumbers.Peek();
// topNum is 3.3, and stackNumbers still contains {1.1, 2.2, 3.3}
```

- **Pop:** This method removes and returns the object at the top of the stack.

```cs
// Stack<T>.Pop
double poppedNum = stackNumbers.Pop();
// poppedNum is 3.3, and stackNumbers now contains {1.1, 2.2}
```

- **Push:** This method adds an object to the top of the stack.

```cs
// Stack<T>.Push
stackNumbers.Push(4.4);
// stackNumbers now contains {4.4, 1.1, 2.2}
```

- **ToArray:** This method copies the elements of the stack to a new array.

```cs
// Stack<T>.ToArray
double[] numsArr = stackNumbers.ToArray();
// numsArr contains {4.4, 1.1, 2.2}
```
