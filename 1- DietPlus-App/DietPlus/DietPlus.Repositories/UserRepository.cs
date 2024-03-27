using DietPlus.Core.Enum;
using DietPlus.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietPlus.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        User _user;

        public UserRepository(User user)
        {
            _user = user;
        }
        public UserRepository()
        {

        }
        public bool AuthenticateUser(string email, string password)
        {
            // Kullanıcıyı e-posta adresine göre bul
            User user = this.GetAll().Where(x => x.Email == email).FirstOrDefault();

            // Kullanıcı var mı ve şifre doğru mu kontrol et
            if (user != null && VerifyPassword(password, user.Password))
            {
                // Oturum açma işlemi başarılı
                return true;
            }

            // Oturum açma işlemi başarısız
            return false;
        }
        public bool AuthenticateUserForCreaate(string email)
        {
            // Kullanıcıyı e-posta adresine göre bul
            User user = this.GetAll().Where(x => x.Email == email).FirstOrDefault();

            // Kullanıcı var mı ve şifre doğru mu kontrol et
            if (user != null)
            {
                // Oturum açma işlemi başarılı
                return false;
            }

            // Oturum açma işlemi başarısız
            return true;
        }
        private bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            // Şifre karşılaştırma mantığı burada gerçekleştirilir
            // Örneğin, hashedPassword == HashFunction(enteredPassword)
            // Bu fonksiyonun gerçek implementasyonu, güvenli bir şifreleme algoritması kullanmalıdır.
            return enteredPassword == hashedPassword;
        }
        public bool IsEmailExists(string email)
        {
            // E-posta adresini kontrol et
            return this.GetAll().Any(u => u.Email == email);
        }
        public void CreateNewAccount(string email, string name, string pasword, double height, double weight, Gender selectedGender, WeightStatus selectedWeightStatus, DateTime selectedDate)
        {
            User newUser = new User(); // Her çağrıda yeni bir User örneği oluşturun
            newUser.UserName = name;
            newUser.Email = email;
            newUser.Password = pasword;
            newUser.Status = Status.Active;
            this.Add(newUser); // Bu metodunuz kullanıcıyı veritabanına eklesin

            // Kullanıcının ID'sini almak için
            int userId = this.GetAll().Where(u => u.UserName == name && u.Email == email).Select(u => u.Id).FirstOrDefault();

            UserDetailRepository userDetailRepository = new UserDetailRepository();

            UserDetail newuserDetail = new UserDetail();
            newuserDetail.UserId = userId;
            newuserDetail.Weight = weight;
            newuserDetail.BirthDate = selectedDate;
            newuserDetail.Height = height;
            newuserDetail.Status = Status.Active;
            newuserDetail.Gender = selectedGender;
            newuserDetail.WeightStatus = selectedWeightStatus;

            userDetailRepository.Add(newuserDetail);



        }

        public void UpdateAccount(User user, UserDetail userDetail)
        {
            this.Update(user);

            UserDetailRepository newuserDetailRepository = new UserDetailRepository();
            newuserDetailRepository.Update(userDetail);
        }

        public void DeleteAccount(User user, UserDetail userDetail)
        {
            UserDetailRepository newuserDetailRepository = new UserDetailRepository();
            newuserDetailRepository.Delete(userDetail);

            this.Delete(user);

        }


    }
}
