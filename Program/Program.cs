// // AGGREGATION

// Battery my_battrey = new Battery();
// Phone my_phone = new Phone(my_battrey);


// // ABSTRACTS & VIRTUAL & OVERRIDING METHODS

// Cat my_cat = new Cat();
// Dog my_dog = new Dog();

// my_cat.Sleep();
// my_dog.Moving();

// my_cat.Eating();
// my_dog.Eating();


// // EXEPION HANDLING

// Calc my_calc = new Calc();


// Console.WriteLine(my_calc.Divide(20,2));


// // OUT

// Calc my_calc = new Calc();
// int tavan;
// int zarb;
// my_calc.Multiple(3,5 , out tavan , out zarb);

// Console.WriteLine($"{tavan} && {zarb}");


// // REF

// Calc my_calc = new Calc();
// int i =5;
// Console.WriteLine(my_calc.BaghiMande(ref i));


// // STRUCT

// public struct User
// {
//     public string FirstName;
//     public string LastName;
//     public int Age;
// }

// User user;
// user.FirstName = "Farzad";
// user.LastName = "Ebrahimi";
// user.Age = 18;


// // Access Level

// Access my_access = new Access();

// my_access.PublicMethod();
// my_access.PrivateMethod(); // Not work
// my_access.InternalMethod();
// my_access.ProtectedMethod(); // Not Work



// // GENERIC

// using System.Collections.ObjectModel;

// Item item1 = new Item() {Id=555,Name="Soda",Count=2,Type="Drinks"};
// Item item2 = new Item() {Id=444,Name="Titap",Count=5,Type="Snaks"};
// Item item3 = new Item() {Id=333,Name="Honey",Count=1,Type="IDK"};

// ICollection<Item> item_collection = new Collection<Item>();
// item_collection.Add(item1);
// item_collection.Add(item2);
// item_collection.Add(item3);

// Order my_order = new Order(265654,"farzad",item_collection);

// my_order.ShowOrderInfo();


// // LINQ

// List<string> names = new List<string>()
// {
//     "Farzad",
//     "Behnam",
//     "Ali",
//     "Mahsa",
//     "Sanaz"
// };


// var my_query = from n in names
// where n == "Ali"
// select n;

// Console.WriteLine(my_query);


// INTERFACE

// Iterface face = new Terface();
// face.Hello();

// Terface face = new Terface();
// face.Hello();

// DI (DEPENDENCY INJECTION)

// Sword sword = new Sword();
// Shutgun shutgun = new Shutgun();

// Warrior warrior1 = new Warrior(sword);

// warrior1.Attack();