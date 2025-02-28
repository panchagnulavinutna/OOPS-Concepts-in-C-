using System;
using static OOPChallenges.Play;

namespace OOPChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Encapsulation");
            BankAccount account = new BankAccount(1000);
            account.Deposit(500);
            account.Withdraw(300);
            account.Withdraw(2000);
            Console.WriteLine($"Final Balance: ₹{account.GetBalance():C}");
            Console.ReadLine();

            Console.WriteLine("2. Data Hiding and Properties");
            Student student = new Student("Vinutna", 1000);
            student.DisplayStudentInfo();
            student.Name = "";
            student.RollNo = -50;
            Console.ReadLine();

            Console.WriteLine("3. Library System - Constructor Overloading");
            Book book1 = new Book();
            book1.DisplayBookInfo();
            Book book2 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            book2.DisplayBookInfo();
            Book book3 = new Book("1984", "George Orwell", "978-0451524935");
            book3.DisplayBookInfo();
            Console.ReadLine();

            Shape circle = new Circle(5);
            Console.WriteLine($"4. Circle Area: {circle.CalculateArea()}");
            Shape rectangle = new Rectangle(10, 4);
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.ReadLine();
            Vehicle car = new Car();
            Console.ReadLine();

            Console.WriteLine($"5. Vehicle system overriding");
            car.Start();
            Vehicle bike = new Bike();
            bike.Start();
            Console.ReadLine();
            Console.ReadLine();

            //   Console.WriteLine($"6. Person inheritance");
            // Person student = new Student("Vinutna", 20, 1001);
            // student.GetDetails();
            //Person teacher = new Teacher("Mr. Rao", 40, "Mathematics");
            // teacher.GetDetails();
            // Console.ReadLine(); 

            Console.WriteLine("7. Calculator overloading");
            Calculator calc = new Calculator();
            Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
            Console.WriteLine($"1 + 2 + 3 = {calc.Add(1, 2, 3)}");
            Console.WriteLine($"2.5 + 3.5 = {calc.Add(2.5, 3.5)}");
            Console.ReadLine();

            Console.WriteLine("8. Play interface implementation");
            IPlayable music = new MusicPlayer();
            IPlayable video = new VideoPlayer();
            music.Play();
            video.Play();
            Console.ReadLine();

            Console.WriteLine("9. Multiple inheritance");
            Report report = new Report();
            report.PrintDetails();
            report.SaveToFile();
            Console.ReadLine();

            Console.WriteLine("10. Role-based access system");
            User admin = new Admin("Alice");
            User customer = new Customer("Bob");
            admin.AccessControl();
            customer.AccessControl();
            Console.ReadLine();

            Console.WriteLine("11. Complex Numbers overloading");
            ComplexNumber c1 = new ComplexNumber(2.5, 3.5);
            ComplexNumber c2 = new ComplexNumber(1.5, 4.5);
            ComplexNumber result = c1 + c2;
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();

            Console.WriteLine("12. Shallow copy vs Deep copy");
            Department original = new Department("HR", "Alice");
            Department shallowCopy = original.ShallowCopy();
            Department deepCopy = original.DeepCopy();
            Console.WriteLine("Before Modification:");
            original.Display();
            shallowCopy.Display();
            deepCopy.Display();
            original.Manager.Name = "Bob";
            Console.WriteLine("\nAfter Modifying Original Manager's Name:");
            original.Display();
            shallowCopy.Display();
            deepCopy.Display();
            Console.ReadLine();

            Console.WriteLine("13. Static members");
            Bank acc1 = new Bank("Alice", 1000);
            Bank acc2 = new Bank("Bob", 2000);
            Console.WriteLine("Before Changing Interest Rate:");
            acc1.Display();
            acc2.Display();
            Bank.SetInterestRate(6.5);
            Console.WriteLine("\nAfter Changing Interest Rate:");
            acc1.Display();
            acc2.Display();
            Console.ReadLine();

            Console.WriteLine("14. Sealed class");
            SecuritySystem system = new SecuritySystem();
            system.Authenticate();
            Console.ReadLine();

            Console.WriteLine("15. Delegates from even handling");
            Button btn = new Button();
            btn.OnClick += () => Console.WriteLine("Button Clicked!");
            btn.Click();
            Console.ReadLine();

            Console.WriteLine("16. Object creation");
            IVehicle car1 = VehicleFactory.GetVehicle("car");
            IVehicle bike1 = VehicleFactory.GetVehicle("bike");
            car1.Drive();
            bike1.Drive();
            Console.ReadLine();

            Console.WriteLine("17. Decorator Pattern in Logger System");
            ILogger logger = new FileLogger();
            ILogger timestampedLogger = new TimestampLogger(logger);
            ILogger errorLogger = new ErrorCategoryLogger(timestampedLogger);
            logger.Log("Basic log");
            timestampedLogger.Log("Log with timestamp");
            errorLogger.Log("Critical system failure");
            Console.ReadLine();

            Console.WriteLine("18. Thread-safe singleton pattern");
            Thread t1 = new Thread(() => { ConfigurationManager config1 = ConfigurationManager.GetInstance(); config1.ShowConfig(); });
            Thread t2 = new Thread(() => { ConfigurationManager config2 = ConfigurationManager.GetInstance(); config2.ConfigValue = "Updated Configuration"; config2.ShowConfig(); });
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            ConfigurationManager.GetInstance().ShowConfig();
            Console.ReadLine();

            Console.WriteLine("19. Notification Observer");
            NotificationService service = new NotificationService();
            INotificationObserver email = new EmailNotifier();
            INotificationObserver sms = new SMSNotifier();
            service.Subscribe(email);
            service.Subscribe(sms);
            service.Notify("New message received!");
            service.Unsubscribe(email);
            service.Notify("Another message received!");
            Console.ReadLine();

            Console.WriteLine("20. Dynamic discount calculation");
            ShoppingCart cart = new ShoppingCart(new NoDiscount());
            Console.WriteLine("Total Price with No Discount: " + cart.GetFinalPrice(1000));
            cart.SetDiscountStrategy(new PercentageDiscount(10));
            Console.WriteLine("Total Price with 10% Discount: " + cart.GetFinalPrice(1000));
            cart.SetDiscountStrategy(new FixedAmountDiscount(200));
            Console.WriteLine("Total Price with ₹200 Discount: " + cart.GetFinalPrice(1000));
            Console.ReadLine();

            Console.WriteLine("21. Inheritance hierarchy");
            Car2 car2 = new Car2("Toyota", 180, 4);
            car2.ShowCarDetails();
            Bike2 bike2 = new Bike2("Yamaha", 120, true);
            bike2.ShowBikeDetails();
            Console.ReadLine();

            Console.WriteLine("22. Method Overriding and Base Keyword");
            Overriding car3 = new Car3("Toyota", 180, 4);
            car3.DisplayInfo();
            Overriding bike3 = new Bike3("Yamaha", 120, true);
            bike3.DisplayInfo();
            Console.ReadLine();
        }
    }
}
