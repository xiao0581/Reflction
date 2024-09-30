//// See https://aka.ms/new-console-template for more information
//using Reflction;

//Console.WriteLine("Hello, World!");

//Clerk clerk = new Clerk("John", 1990, new List<string> { "Excel", "Communication" });
//Manager manager = new Manager("Sarah", 1980, new List<Person> { clerk });

//TryReflection(clerk);
//TryReflection(manager);


//static void TryReflection(Object obj)
//{
//    // Get the type of the object
//    Type type = obj.GetType();

//    // Print the name of the object (the class name)
//    Console.WriteLine($"Object Name: {type.Name}");

//    // Determine if the object is a class, abstract, or interface
//    if (type.IsClass)
//        Console.WriteLine("Type: Class");
//    if (type.IsAbstract)
//        Console.WriteLine("Type: Abstract Class");
//    if (type.IsInterface)
//        Console.WriteLine("Type: Interface");

//    // Get and print the properties of the object
//    Console.WriteLine("\nProperties:");
//    foreach (var prop in type.GetProperties())
//    {
//        Console.WriteLine($"Property Name: {prop.Name}, Property Type: {prop.PropertyType}, Value: {prop.GetValue(obj)}");
//    }

//    // Get and print the methods of the object
//    Console.WriteLine("\nMethods:");
//    foreach (var method in type.GetMethods())
//    {
//        Console.WriteLine($"Method Name: {method.Name}");
//    }

//    // Get and print fields of the object (optional, in case there are fields)
//    Console.WriteLine("\nFields:");
//    foreach (var field in type.GetFields())
//    {
//        Console.WriteLine($"Field Name: {field.Name}, Field Type: {field.FieldType}");
//    }
//}

using Reflction;

Clerk clerk = new Clerk("John", 1990, new List<string> { "Excel", "Communication" });
string json = MyJsonConverter.Serialize(clerk);
Console.WriteLine("Serialized Clerk:");
Console.WriteLine(json);

