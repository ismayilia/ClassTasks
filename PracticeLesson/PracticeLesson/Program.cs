using PracticeLesson;
using PracticeLesson.Models;

//Student stu1 = new()
//{
//    fullName = "Kubra",
//    address = "Xalqlar",
//    age = "25"
//};

//Console.WriteLine(stu1.GetFullData());

//static void GetFullDatas()
//{
//    Student stu1 = new()
//    {
//        fullName = "Kubra",
//        address = "Xalqlar",
//        age = "25"
//    };
//    Console.WriteLine(stu1.GetFullData());
//}

//GetFullDatas();



//Employee employee = new();

//employee.Test();

//Student stu1 = new()
//{
//    fullName = "Kubra",
//    address = "Xalqlar",
//    age = "25"
//};

//Console.WriteLine(stu1.GetFullData());



//Product pr1 = new()
//{
//    id = 1,
//    name = "Iphone 14",
//    price = 3500,
//    CreatedDate = DateTime.Now,
//};


//Product pr2 = new()
//{
//    id = 2,
//    name = "Nokia 1200",
//    price = 35,
//    CreatedDate = DateTime.Now,
//};


//Product pr3 = new()
//{
//    id = 3,
//    name = "Samsung",
//    price = 1000,
//    CreatedDate = DateTime.Now,
//};

//Product tipinden array, foreach salmaq olar. Metod yaziriq id-si 2-ye beraber olan produktu tap.
// Return olan type-i Prouc olmalidir. 

//Product[] products = {pr1, pr2, pr3};



//var result= GetProductById(2);
//Console.WriteLine(result.id);


//static Product GetProductById(int id)
//{
//    Product pr1 = new()
//    {
//        id = 1,
//        name = "Iphone 14",
//        price = 3500,
//        CreatedDate = DateTime.Now,
//    };


//    Product pr2 = new()
//    {
//        id = 2,
//        name = "Nokia 1200",
//        price = 35,
//        CreatedDate = DateTime.Now,
//    };


//    Product pr3 = new()
//    {
//        id = 3,
//        name = "Samsung",
//        price = 1000,
//        CreatedDate = DateTime.Now,
//    };

//    Product[] products = { pr1, pr2, pr3 };


//var result = GetProductById(2);
//Console.WriteLine(result.id);


//var result = GetProductById(3);
//Console.WriteLine(result.name); 


//var result = GetProductByName("Iphone 14");
//Console.WriteLine(result.price+" AZN");

//static Product GetProductByName(string name)
//{
//    var dbProducts = GetAllProducts();
//    foreach (var item in dbProducts)
//    {
//        if (item.name == name)
//        {
//            return item;
//        }


//    }

//    return null;

//}    
//static Product GetProductById(int id)
//{
//    var dbProducts = GetAllProducts();

//    foreach (var item in dbProducts)
//    {
//        if (item.id==id)
//        {
//            return item;
//        }


//    }

//    return null;
//}




//static Product[] GetAllProducts()
//{

//        Product pr1 = new()
//        {
//            id = 1,
//            name = "Iphone 14",
//            price = 3500,
//            CreatedDate = DateTime.Now,
//        };


//        Product pr2 = new()
//        {
//            id = 2,
//            name = "Nokia 1200",
//            price = 35,
//            CreatedDate = DateTime.Now,
//        };


//        Product pr3 = new()
//        {
//            id = 3,
//            name = "Samsung",
//            price = 1000,
//            CreatedDate = DateTime.Now,
//        };

//        Product[] products = { pr1, pr2, pr3 };

//        return products;
//}


//User user = new User();
//User user = new User("xeyyam@gmail.com");
//User user = new User(30);


//User user1 = new User("xeyyam55") ;
//User user2 = new User("fidan44");



//Console.WriteLine(user1.username);
//Console.WriteLine(user2.username);



//Calculator calculator = new(3, 8);


//calculator.Sum(100);


//Product produc = new("Iphone");























