static class DataSources
{
    private static List<int> numbers = new List<int>
    {
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12,
        13,
        14,
        15
    };

    private static List<string> names = new List<string>
    {
        "Alice",
        "Bob",
        "Charlie",
        "David",
        "Eve",
        "Frank",
        "Grace",
        "Hank",
        "Ivy",
        "Jack",
        "Kelly",
        "Lucas"
    };

    private static List<Person> people = new List<Person>
    {
        new Person { Name = "Alice", Age = 25 },
        new Person { Name = "Bob", Age = 30 },
        new Person { Name = "Charlie", Age = 35 },
        new Person { Name = "David", Age = 40 },
        new Person { Name = "Eve", Age = 45 },
        new Person { Name = "Frank", Age = 50 }
    };

    private static List<Product> products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Name = "Product A",
            Category = "Category 1",
            Price = 10.00m
        },
        new Product
        {
            Id = 2,
            Name = "Product B",
            Category = "Category 1",
            Price = 20.00m
        },
        new Product
        {
            Id = 3,
            Name = "Product C",
            Category = "Category 2",
            Price = 15.00m
        },
        new Product
        {
            Id = 4,
            Name = "Product D",
            Category = "Category 2",
            Price = 25.00m
        },
        new Product
        {
            Id = 5,
            Name = "Product E",
            Category = "Category 3",
            Price = 30.00m
        },
        new Product
        {
            Id = 6,
            Name = "Product F",
            Category = "Category 3",
            Price = 35.00m
        },
    };

    private static List<Student> students = new List<Student>
    {
        new Student
        {
            Id = 1,
            Name = "Alice",
            BirthDate = new DateTime(2000, 1, 1),
            Courses = new List<Course>
            {
                new Course
                {
                    Id = 1,
                    Name = "Course A",
                    Instructor = "Instructor A"
                },
                new Course
                {
                    Id = 2,
                    Name = "Course B",
                    Instructor = "Instructor B"
                }
            }
        },
        new Student
        {
            Id = 2,
            Name = "Bob",
            BirthDate = new DateTime(2001, 2, 2),
            Courses = new List<Course>
            {
                new Course
                {
                    Id = 2,
                    Name = "Course B",
                    Instructor = "Instructor B"
                },
                new Course
                {
                    Id = 3,
                    Name = "Course C",
                    Instructor = "Instructor C"
                }
            }
        },
        new Student
        {
            Id = 3,
            Name = "Charlie",
            BirthDate = new DateTime(2002, 3, 3),
            Courses = new List<Course>
            {
                new Course
                {
                    Id = 3,
                    Name = "Course C",
                    Instructor = "Instructor C"
                },
                new Course
                {
                    Id = 4,
                    Name = "Course D",
                    Instructor = "Instructor D"
                }
            }
        }
    };

    private static List<Order> orders = new List<Order>
    {
        new Order
        {
            Id = 1,
            OrderDate = new DateTime(2023, 3, 30),
            CustomerId = 1,
            Customer = new Customer
            {
                Id = 1,
                Name = "Alice",
                Email = "alice@example.com",
                Phone = "123-456-7890"
            },
            OrderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Id = 1,
                    Product = new Product
                    {
                        Id = 1,
                        Name = "Product A",
                        Price = 10.00m
                    },
                    Quantity = 2,
                    Price = 20.00m
                },
                new OrderItem
                {
                    Id = 2,
                    Product = new Product
                    {
                        Id = 2,
                        Name = "Product B",
                        Price = 20.00m
                    },
                    Quantity = 1,
                    Price = 20.00m
                },
                new OrderItem
                {
                    Id = 3,
                    Product = new Product
                    {
                        Id = 3,
                        Name = "Product C",
                        Price = 15.00m
                    },
                    Quantity = 3,
                    Price = 45.00m
                }
            },
            TotalPrice = 85.00m
        },
        new Order
        {
            Id = 2,
            OrderDate = new DateTime(2023, 3, 31),
            CustomerId = 2,
            Customer = new Customer
            {
                Id = 2,
                Name = "Bob",
                Email = "bob@example.com",
                Phone = "987-654-3210"
            },
            OrderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Id = 4,
                    Product = new Product
                    {
                        Id = 1,
                        Name = "Product A",
                        Price = 10.00m
                    },
                    Quantity = 1,
                    Price = 10.00m
                },
                new OrderItem
                {
                    Id = 5,
                    Product = new Product
                    {
                        Id = 2,
                        Name = "Product B",
                        Price = 20.00m
                    },
                    Quantity = 2,
                    Price = 40.00m
                },
                new OrderItem
                {
                    Id = 6,
                    Product = new Product
                    {
                        Id = 3,
                        Name = "Product C",
                        Price = 15.00m
                    },
                    Quantity = 1,
                    Price = 15.00m
                },
                new OrderItem
                {
                    Id = 7,
                    Product = new Product
                    {
                        Id = 4,
                        Name = "Product D",
                        Price = 5.00m
                    },
                    Quantity = 5,
                    Price = 25.00m
                }
            },
            TotalPrice = 90.00m
        },
        new Order
        {
            Id = 3,
            OrderDate = new DateTime(2023, 4, 1),
            CustomerId = 3,
            Customer = new Customer
            {
                Id = 3,
                Name = "Charlie",
                Email = "charlie@example.com",
                Phone = "555-555-5555"
            },
            OrderItems = new List<OrderItem>
            {
                new OrderItem
                {
                    Id = 8,
                    Product = new Product
                    {
                        Id = 1,
                        Name = "Product A",
                        Price = 10.00m
                    },
                    Quantity = 5,
                    Price = 50.00m
                },
                new OrderItem
                {
                    Id = 9,
                    Product = new Product
                    {
                        Id = 4,
                        Name = "Product D",
                        Price = 5.00m
                    },
                    Quantity = 10,
                    Price = 50.00m
                }
            },
            TotalPrice = 100.00m
        }
    };

    private static List<Customer> customers = new List<Customer>
    {
        new Customer
        {
            Id = 1,
            Name = "Alice",
            Email = "alice@example.com",
            Phone = "123-456-7890"
        },
        new Customer
        {
            Id = 2,
            Name = "Bob",
            Email = "bob@example.com",
            Phone = "987-654-3210"
        },
        new Customer
        {
            Id = 3,
            Name = "Charlie",
            Email = "charlie@example.com",
            Phone = "555-555-5555"
        }
    };

    public static IReadOnlyList<int> Numbers
    {
        get => numbers;
    }
    public static IReadOnlyList<string> Names
    {
        get => names;
    }
    public static IReadOnlyList<Person> People
    {
        get => people;
    }
    public static IReadOnlyList<Product> Products
    {
        get => products;
    }
    public static IReadOnlyList<Student> Students
    {
        get => students;
    }
    public static IReadOnlyList<Order> Orders
    {
        get => orders;
    }
    public static IReadOnlyList<Customer> Customers
    {
        get => customers;
    }
}

class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Course> Courses { get; set; }
}

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Instructor { get; set; }
}

public class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItem> OrderItems { get; set; }
    public decimal TotalPrice { get; set; }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

public class OrderItem
{
    public int Id { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
