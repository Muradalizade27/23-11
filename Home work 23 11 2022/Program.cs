

using Class_Home_Work;
using System.Xml;

Console.WriteLine("UserName daxil edin :");

string UserName = Console.ReadLine();

Console.WriteLine("Password daxil edin :");

string Password = Console.ReadLine();

Console.WriteLine("Ugurla daxil oldunuz :");

USER user = new USER(UserName, Password );

admin admin = new admin(true, "Confirmed");

Console.WriteLine("IsSuperAdmin:" + admin.Admin);

Console.WriteLine("Section :" + admin.Section);

Console.WriteLine("Adminin butun datalari :" + admin.Return());
