using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace Solid_prensipleri
{
    
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        // Kullanıcı bilgilerini görüntülemek için metod
        public virtual void DisplayUserInfo()
        {
            Console.WriteLine($"Name: {FirstName}");
            Console.WriteLine($"LastName: {LastName}");
            Console.WriteLine($"Email: {Email}");
        }
    }

    // Kullanıcı bilgilerini kaydetmek için bir arayüz oluşturduk (DIP uygulaması)
    public interface IUserRepository
    {
        void SaveUserToFile(User user);
        void PrintUserInfo(User user);
    }




}


// 1.işlem bu uygulamada her bir sınıfın farklı bir görevi vardır buda okunabilirliği arttırır...
// 2.işlem UserRepository sınıfı içerisine sınıfı değiştirmeden sınıfı gelştiren bir metod ekledik...
// 3.işlem Bu düzenlemeyle, AdminUser sınıfının, User sınıfının bir alt sınıfı olarak davranabildiğini ve User nesnelerinin
// kullanılabileceği her yerde kullanılabileceğini gösterdik. Böylece, Liskov Substitution Principle (LSP)'ye uygun bir yapı elde ettik.
// 4. işlemde DIP'yi uygulayarak kodumuzu daha esnek, modüler ve sürdürülebilir hale getirdik. Bu sayede, kullanıcı bilgilerini yönetmek
// için farklı sınıflar eklemeyi ve sistemin diğer parçalarını değiştirmeden yeni işlevler eklemeyi kolaylaştırdık.