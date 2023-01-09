using OOP.Classes.typesofclasses.Abstract;
using OOP.Classes.typesofclasses.Concrete;
using OOP.Classes.typesofclasses.Sealed;
using OOP.Classes.typesofclasses.Static;
using OOP.Encapsulation;
using OOP.Polymorphism.ArchiverHandling;
using OOP.Polymorphism.PaymentProcessor;
using OOP.Polymorphism.ProductHandling;
using OOP.Polymorphism.UserHandling;
using OOP.SOLID.LiskovSubstitutionProblem.Problem;
using OOP.SOLID.LiskovSubstitutionProblem.Solution;
using OOP.SOLID.OpenClosePrinciple.Problem;
using OOP.SOLID.OpenClosePrinciple.Solution;
using OOP.SOLID.SingleResponsibilirtPrinciple.Problem;
using OOP.SOLID.SingleResponsibilirtPrinciple.Solution;

// using concrete classes
Person hashan = new("Hashan", "Eranga", 25);
Person ishini = new("Ishini", "Amasha", 21);
Console.WriteLine(hashan.ToString());
Console.WriteLine(ishini.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// static class demo 
double answer = MathUtil.CalculateCircleArea(12.9);
Console.WriteLine($"Answer for the area of the circle {answer}");

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// abstract class demo
MasterProduct masterItem_1 = new MasterProduct("MasterItem01", 100, true);
MasterProduct masterItem_2 = new MasterProduct("MasterItem02", 200, true);
Console.WriteLine(masterItem_1.ToString());
Console.WriteLine(masterItem_2.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// using sealed class demo
Mobile Nokia = new("Nokia", "Nokia Description");
Mobile Samsung = new("Samsung", "Samsung Description");
Console.WriteLine(Nokia.ToString());
Console.WriteLine(Samsung.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// using encapsulation in c#
Student stuHashan = new("Hashan", "Eranga", 25, 23, 3.1);
Student stuIshini= new("Ishini", "Amasha", 21, 54, 3.6);
Console.WriteLine(stuHashan.ToString());
Console.WriteLine(stuIshini.ToString());

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// polymorphism abstract classes
OOP.Polymorphism.UserHandling.User contentManager = new ContentManager();
OOP.Polymorphism.UserHandling.User admin = new AdminUser();

contentManager.ValidateAccessRights();
admin.ValidateAccessRights();

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

contentManager.getProfileInformation(new UserProfile());

// Polimorphism Interfaces
IArchiver zipArchiver = new ZipArchiver();
IArchiver rarArchiver = new RarArchiver();

zipArchiver.ArchiveFiles();
rarArchiver.ArchiveFiles();

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// Interfacing 
Client client = new Client();
ChasePaymentProcessor chPay = new();

client.SetPaymentProcessor(chPay);


PaymentData pData = new();
chPay.ValidatePayment();
client.CheckOut(pData);

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

PaypalPaymentProcessor palPay = new();
client.SetPaymentProcessor(palPay);
client.CheckOut(pData);

// inheritance example
Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

ProductItem item = new Phone("Samsung");
item.Name = "Samsung M10";
Console.WriteLine($"Product Name : {item.Name}");
Console.WriteLine($"Remaining Amounts in stock : {item.CalculateRemainingAmount()}");

Phone nokia = new("Nokia 1100");
nokia.Ring();

Phone samsung = (Phone)item;
samsung.Ring();

Console.WriteLine("");
Console.WriteLine("==================");
Console.WriteLine("");

// SOLID Principles 
Console.WriteLine("SOLID Principles");

// 01 Single Responsibility Principle
// A class should have only one reason to change
Console.WriteLine("Single Responsibility Problem");

// Problem Setup
Console.WriteLine("Problem");
PMailBoxSettingsService settingsService = new();
PMailUser user = new("abc@def.com", "pqr@efg.com", PRole.ADMIN);

// Responsibility 01
settingsService.ChangePrimaryEmail(user, "qwe@ert.com");

// Responsibility 02 
if (settingsService.HasAccess(user)) user.SendMoney(new PMailUser("uio@abc.com", "rty@mnb.com", PRole.ADMIN), 1000);

// Solution Setup
Console.WriteLine("Solution");
MailBoxSettingsService serviceSettings = new();
MailUser newUser = new("abc@def.com", "pqr@efg.com", Role.ADMIN);

serviceSettings.ChangePrimaryEmail(newUser, "ccmrhe@gmail.com");
SecurityService serviceSecurity = new();

if (serviceSecurity.HasAccess(newUser))
{
    newUser.SendMoney(new MailUser("e16275@eng.pdn.ac.lk", "hashaneranga@ieee.org", Role.MANAGER), 1000);
}

// 02 Open/ Close Principle
// Software entities open for extension and close for modification
Console.WriteLine("Open Close Principle");

// Problem Set 
Console.WriteLine("Problem");
PLoanHandler loanHandler = new();
PUser person = new();
loanHandler.ApprovePersonalLoan(person);
loanHandler.ApproveMortage(person);

// Solution
Console.WriteLine("Solution");
PersonalLoanHandler HandlesLoan = new PersonalLoanHandler(new PersonalLoanValidator());
OOP.SOLID.OpenClosePrinciple.Solution.User userNew = new();
HandlesLoan.ApproveLoan(userNew);

MortageHandler HandlesLoanNew = new MortageHandler(new MortageLoanValidator());
HandlesLoanNew.ApproveLoan(userNew);

// 03 Liskov Substitution Problem
// Objects in a program should be replacable with instances of their subtyles wothout altering the correctness of that program.
Console.WriteLine("Liskov Substitution Principle");

// Problem
Console.WriteLine("Problem");
Bird[] birds = new Bird[]
{
    new Crow(), new Sparrow(), new Ostrich()
};

foreach (var bird in birds)
{
    bird.Fly();
}

// Solution
Console.WriteLine("Solution");
Creature[] newBirds = new Creature[]
{
    new CrowBird(), new SparrowBird(), new OstrichBird()
};

foreach (var bird in newBirds)
{
    bird.Eat();
}

FlyingCreature[] newFlyingBirds = new FlyingCreature[]
{
    new CrowBird(), new SparrowBird()
};

foreach (var bird in newFlyingBirds)
{
    bird.Fly();
}

Console.ReadLine();