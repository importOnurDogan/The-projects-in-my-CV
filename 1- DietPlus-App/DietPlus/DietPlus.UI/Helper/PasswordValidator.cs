using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.UI.Helper
{
    public class PasswordValidator
    {
        public bool IsPasswordValid(string password,string email, out string errorMessage)
        {
            errorMessage = null;

            // Şifrenin null veya boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                errorMessage = "Şifre boş olamaz.";
                return false;
            }
            // Mail "@" ve ".com" içerip içermediğini kontrol et
            if (!email.Contains("@") || !email.Contains(".com"))
            {
                errorMessage = "Mail içinde '@' ve '.com' bulunmalıdır.";
                return false;
            }
            // Şifrenin en az 8 karakter içerip içermediğini kontrol et
            if (password.Length < 8)
            {
                errorMessage = "Şifre en az 8 karakter içermelidir.";
                return false;
            }

            // Şifrenin en az bir büyük harf içerip içermediğini kontrol et
            if (!password.Any(char.IsUpper))
            {
                errorMessage = "Şifre en az bir büyük harf içermelidir.";
                return false;
            }

            // Şifrenin en az bir noktalama işareti içerip içermediğini kontrol et
            if (!password.Any(char.IsPunctuation))
            {
                errorMessage = "Şifre en az bir noktalama işareti içermelidir.";
                return false;
            }

            // Şifrenin en az bir sayı içerip içermediğini kontrol et
            if (!password.Any(char.IsDigit))
            {
                errorMessage = "Şifre en az bir sayı içermelidir.";
                return false;
            }
            // Şifre tüm kontrolleri geçtiyse geçerli kabul edilir
            return true;
        }
        public bool AreStringsEqual(string str1, string str2)
        {
            // StringComparison.Ordinal kullanarak büyük/küçük harf duyarlılığını koruyan karşılaştırma yapar.
            return string.Equals(str1, str2, StringComparison.Ordinal);
        }
    }

}
