using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_prensipleri
{
    public class UserRepository : IUserRepository
    {

        public void SaveUserToFile(User user)
        {
            string filePath = "user.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Name: {user.FirstName} {user.LastName}");
                writer.WriteLine($"Email: {user.Email}");
                if (user is AdminUser adminUser)
                {
                    writer.WriteLine($"Admin Code: {adminUser.AdminCode}");
                }
            }
            Console.WriteLine("Kullanıcı bilgileri başarıyla dosyaya kaydedildi.");
        }

        public void PrintUserInfo(User user)
        {
            Console.WriteLine("Kullanıcı Bilgileri:");
            user.DisplayUserInfo();
        }

    }
}
