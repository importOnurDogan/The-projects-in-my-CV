using DietPlus.Core.Enum;
using DietPlus.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DietPlus.Repositories
{
    public class MealRepository : BaseRepository<Meal>
    {
        Meal _meal;
        FoodRepository foodRepository = new FoodRepository();
        MealFoodRelationRepository mealFoodrelationshipRepository = new MealFoodRelationRepository();
        UserMealRepository userMealRepository = new UserMealRepository();
        UserRepository userRepository = new UserRepository();
        FoodCategoryRepository foodCategoryRepository = new FoodCategoryRepository();
        public MealRepository(Meal meal)
        {

            _meal = meal;

        }
        public MealRepository()
        {

        }
        public void AddFoodToMeal(Food food, MealName mealName, User user, DateTime date)
        {
            Meal meal = new Meal
            {
                MealName = mealName,
                Status = Status.Active,
                CreateDate = date
            };

            // MealFoodRelationship oluştur
            MealFoodRelationship mealFoodRelationship = new MealFoodRelationship
            {
                FoodId = food.Id,
                MealId = meal.Id,
                Status = Status.Active,
                CreateDate = date
            };

            //UserMeal ilişkisi icin
            UserMeal userMeal = new UserMeal
            {
                UserId = user.Id,
                MealId = meal.Id,
                Status = Status.Active,
                CreateDate = date
            };
            // MealUser listesine ekleyin
            meal.UserMeals = new List<UserMeal> { userMeal };

            // MealFoods listesine ekleyin
            meal.MealFoods = new List<MealFoodRelationship> { mealFoodRelationship };

            this.Add(meal);

        }
        // Belirli bir tarih, öğün adı ve kullanıcı için yemeklere ait gıdaları getiren metot
        public List<Food> GetFoodsForMeal(DateTime createDate, MealName mealName, int userId)
        {
            var query = from f in foodRepository.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on f.Id equals mf.FoodId
                        join m in this.GetAll() on mf.MealId equals m.Id
                        join um in userMealRepository.GetAll() on m.Id equals um.MealId
                        where m.CreateDate.ToShortDateString() == createDate.ToShortDateString() && m.MealName == mealName &&
                          um.UserId == userId
                        select f;

            return query.ToList();
        }
        public Meal GetMealsForUser(DateTime createDate, MealName mealName, int userId, int foodId)
        {
            var result = from m in this.GetAll()
                         join um in userMealRepository.GetAll() on m.Id equals um.MealId
                         join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                         where m.CreateDate.ToShortDateString() == createDate.ToShortDateString() && m.MealName == mealName &&
                          um.UserId == userId &&
                          mf.FoodId == foodId
                         select m;

            return result.FirstOrDefault();
        }
        public void RemoveFoodFromMeal(int foodId, DateTime createDate, MealName mealName, int userId)
        {
            // Meale ait olan foodları getir
            List<Food> foods = GetFoodsForMeal(createDate, mealName, userId);
            // Verilen foodId'ye sahip olan Food'u bul
            Food foodToRemove = foods.FirstOrDefault(f => f.Id == foodId);

            Meal meal = GetMealsForUser(createDate, mealName, userId, foodToRemove.Id);

            if (foodToRemove != null)
            {
                // Food meale aittir, ilişkiyi kaldır
                var mealFoodRelationship = mealFoodrelationshipRepository
                    .GetAll()
                    .FirstOrDefault(mf => mf.MealId == meal.Id && mf.FoodId == foodToRemove.Id);

                if (mealFoodRelationship != null)
                {
                    // MealFoodRelationship'ı kaldır
                    mealFoodrelationshipRepository.Delete(mealFoodRelationship);
                }
                else
                {
                    // Belki ilişki bulunamadı, uygun bir şekilde işlem yapabilirsiniz.
                }

                // User meale aittir, ilişkiyi kaldır
                var mealUserRelationship = userMealRepository
                    .GetAll()
                    .FirstOrDefault(mu => mu.MealId == meal.Id && mu.UserId == userId);

                if (mealUserRelationship != null)
                {

                    userMealRepository.Delete(mealUserRelationship);
                }
                else
                {
                    // Belki ilişki bulunamadı, uygun bir şekilde işlem yapabilirsiniz.
                }
                this.Delete(meal);
            }
            else
            {
                // Belki Food bulunamadı, uygun bir şekilde işlem yapabilirsiniz.
            }
        }
        public void RemoveMealAndAllFood(DateTime createDate, MealName mealName, int userId)
        {
            List<Meal> meals = GetAllMealByDateAndUser(createDate, mealName, userId);

            if (meals != null)
            {
                foreach (var meal in meals)
                {


                    // Food meale aittir, ilişkiyi kaldır
                    var mealFoodRelationship = mealFoodrelationshipRepository
                        .GetAll().Where(x => x.MealId == meal.Id);

                    if (mealFoodRelationship != null)
                    {
                        // MealFoodRelationship'ı kaldır
                        mealFoodrelationshipRepository.Delete(mealFoodRelationship.FirstOrDefault());
                    }
                    else
                    {
                        // Belki ilişki bulunamadı, uygun bir şekilde işlem yapabilirsiniz.
                    }
                    // User meale aittir, ilişkiyi kaldır
                    var mealUserRelationship = userMealRepository
                        .GetAll().Where(x => x.MealId == meal.Id);

                    if (mealUserRelationship != null)
                    {

                        userMealRepository.Delete(mealUserRelationship.FirstOrDefault());
                    }
                    else
                    {
                        // Belki ilişki bulunamadı, uygun bir şekilde işlem yapabilirsiniz.
                    }
                    this.Delete(meal);
                }

            }
            else
            {
                // Belki Food bulunamadı, uygun bir şekilde işlem yapabilirsiniz.
            }
        }

        private List<Meal> GetAllMealByDateAndUser(DateTime createDate, MealName mealName, int userId)
        {

            var result = from m in this.GetAll()
                         join um in userMealRepository.GetAll() on m.Id equals um.MealId
                         where m.CreateDate.ToShortDateString() == createDate.ToShortDateString() && m.MealName == mealName &&
                          um.UserId == userId
                         select m;

            return result.ToList();
        }
        public List<TotalCaloriesPerMealResult> GetTotalCaloriesForUserAndDate(DateTime createDate, int userId)
        {
            var query = from m in this.GetAll()
                        join um in userMealRepository.GetAll() on m.Id equals um.MealId
                        join u in userRepository.GetAll() on um.UserId equals u.Id
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        where m.CreateDate.ToShortDateString() == createDate.ToShortDateString() && u.Id == userId
                        group f by m.MealName into g
                        select new TotalCaloriesPerMealResult
                        {
                            MealName = g.Key,
                            TotalCaloriesPerMeal = g.Sum(f => f.Calories)
                        };

            return query.ToList();
        }
        public List<TotalCaloriesPerMealResult> GetTotalCaloriesForAllUser()
        {
            var query = from m in this.GetAll()
                            // join um in userMealRepository.GetAll() on m.Id equals um.MealId
                            //  join u in userRepository.GetAll() on um.UserId equals u.Id
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        group f by m.MealName into g
                        select new TotalCaloriesPerMealResult
                        {
                            MealName = g.Key,
                            TotalCaloriesPerMeal = g.Sum(f => f.Calories)
                        };

            return query.ToList();
        }
        public List<TotalCaloriesPerMealResult> GetTotalCaloriesForAllUserWeek(DateTime date)
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        where m.CreateDate.Date <= date.Date && m.CreateDate.Date >= date.Date.AddDays(-7)
                        group f by m.MealName into g
                        select new TotalCaloriesPerMealResult
                        {
                            MealName = g.Key,
                            TotalCaloriesPerMeal = g.Sum(f => f.Calories)
                        };

            return query.ToList();
        }
        public List<TotalCaloriesPerMealResult> GetTotalCaloriesForAllUserMonth(DateTime date)
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        where m.CreateDate.Date <= date.Date && m.CreateDate.Date >= date.Date.AddMonths(-1)
                        group f by m.MealName into g
                        select new TotalCaloriesPerMealResult
                        {
                            MealName = g.Key,
                            TotalCaloriesPerMeal = g.Sum(f => f.Calories)
                        };

            return query.ToList();
        }
        public List<TotalCaloriesPerCategoryResult> GetTotalCaloriesPerCategory()
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        join fc in foodCategoryRepository.GetAll() on f.FoodCategoryId equals fc.Id
                        group f by fc.CategoryName into g
                        select new TotalCaloriesPerCategoryResult
                        {
                            CategoryName = g.Key,
                            TotalCaloriesPerCategory = g.Sum(f => f.Calories)
                        };

            return query.ToList();
        }
        public List<TotalCaloriesPerCategoryResult> GetTotalCaloriesPerCategoryWeek(DateTime date)
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        join fc in foodCategoryRepository.GetAll() on f.FoodCategoryId equals fc.Id
                        where m.CreateDate.Date <= date.Date && m.CreateDate.Date >= date.Date.AddDays(-7)
                        group f by fc.CategoryName into g
                        select new TotalCaloriesPerCategoryResult
                        {
                            CategoryName = g.Key,
                            TotalCaloriesPerCategory = g.Sum(f => f.Calories)
                        };

            return query.ToList();
        }
        public List<TotalCaloriesPerCategoryResult> GetTotalCaloriesPerCategoryMonth(DateTime date)
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        join fc in foodCategoryRepository.GetAll() on f.FoodCategoryId equals fc.Id
                        where m.CreateDate.Date <= date.Date && m.CreateDate.Date >= date.Date.AddMonths(-1)
                        group f by fc.CategoryName into g
                        select new TotalCaloriesPerCategoryResult
                        {
                            CategoryName = g.Key,
                            TotalCaloriesPerCategory = g.Sum(f => f.Calories)
                        };

            return query.ToList();
        }
        public List<MostEatFoodResult> GetMosteatFood()
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        join fc in foodCategoryRepository.GetAll() on f.FoodCategoryId equals fc.Id
                        group f by new { f.FoodName, m.MealName } into g
                        orderby g.Sum(f => f.PortionQuantity) descending // Porsiyon miktarına göre sıralama
                        select new MostEatFoodResult
                        {
                            FoodName = g.Key.FoodName,
                            MealName = g.Key.MealName,
                            TotalPortion = g.Sum(f => f.PortionQuantity)
                        };

            return query.ToList();


        }
        public List<MostEatFoodResult> GetMosteatFoodWeek(DateTime date)
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        join fc in foodCategoryRepository.GetAll() on f.FoodCategoryId equals fc.Id
                        where m.CreateDate.Date <= date.Date && m.CreateDate.Date >= date.Date.AddDays(-7)
                        group f by new { f.FoodName, m.MealName } into g
                        select new MostEatFoodResult
                        {
                            FoodName = g.Key.FoodName,
                            MealName = g.Key.MealName,
                            TotalPortion = g.Sum(f => f.PortionQuantity)
                        };

            return query.ToList();
        }
        public List<MostEatFoodResult> GetMosteatFoodMonth(DateTime date)
        {
            var query = from m in this.GetAll()
                        join mf in mealFoodrelationshipRepository.GetAll() on m.Id equals mf.MealId
                        join f in foodRepository.GetAll() on mf.FoodId equals f.Id
                        join fc in foodCategoryRepository.GetAll() on f.FoodCategoryId equals fc.Id
                        where m.CreateDate.Date <= date.Date && m.CreateDate.Date >= date.Date.AddMonths(-1)
                        group f by new { f.FoodName, m.MealName } into g
                        select new MostEatFoodResult
                        {
                            FoodName = g.Key.FoodName,
                            MealName = g.Key.MealName,
                            TotalPortion = g.Sum(f => f.PortionQuantity)
                        };

            return query.ToList();
        }

        public class MostEatFoodResult
        {
            public string FoodName { get; set; }
            public MealName MealName { get; set; } // Örneğin, MealName enum'u

            // Dönüştürülmüş string değeri sağlayan bir property
            public string MealNameStringRepresentation => MealName.ToString();
            public decimal TotalPortion { get; set; }
        }

        public class TotalCaloriesPerCategoryResult
        {
            public string CategoryName { get; set; }
            public decimal TotalCaloriesPerCategory { get; set; }
        }
        public class TotalCaloriesPerMealResult
        {
            public MealName MealName { get; set; } // Örneğin, MealName enum'u

            // Dönüştürülmüş string değeri sağlayan bir property
            public string MealNameStringRepresentation => MealName.ToString();
            public decimal TotalCaloriesPerMeal { get; set; }
        }
    }
}
