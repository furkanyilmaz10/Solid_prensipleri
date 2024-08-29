using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_prensipleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcı oluşturma
            String ad = Console.ReadLine();
            String soyad = Console.ReadLine();
            string e_mail = Console.ReadLine();
            User user = new User(ad, soyad, e_mail);
            //admin kullanıcı oluşturma
            String adminad = Console.ReadLine();
            string adminsoyad = Console.ReadLine();
            String admin_mail = Console.ReadLine();
            string admin_code = Console.ReadLine();
            AdminUser adminUser = new AdminUser(adminad, adminsoyad, admin_mail, admin_code);


            UserRepository userRepository = new UserRepository();

            // Normal kullanıcı bilgilerini kaydetme ve yazdırma
            userRepository.SaveUserToFile(user);
            userRepository.PrintUserInfo(user);

            Console.WriteLine("*******************************************************");

            // Admin kullanıcı bilgilerini kaydetme ve yazdırma (LSP örneği)
            userRepository.SaveUserToFile(adminUser);
            userRepository.PrintUserInfo(adminUser);




            Console.ReadKey();
        }
    }
}
