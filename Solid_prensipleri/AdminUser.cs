using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_prensipleri
{
    internal class AdminUser : User
    {

        public string AdminCode { get; set; }

        public AdminUser(string firstName, string lastName, string email, string adminCode)
            : base(firstName, lastName, email)
        {
            AdminCode = adminCode;
        }

        // Admin kullanıcı bilgilerini görüntülemek için metodu geçersiz kılıyoruz
        public override void DisplayUserInfo()
        {
            base.DisplayUserInfo();
            Console.WriteLine($"Admin Code: {AdminCode}");
        }

    }
}

// Bu düzenlemeyle, AdminUser sınıfının, User sınıfının bir alt sınıfı olarak davranabildiğini ve User nesnelerinin
// kullanılabileceği her yerde kullanılabileceğini gösterdik. Böylece, Liskov Substitution Principle (LSP)'ye uygun bir yapı elde ettik.