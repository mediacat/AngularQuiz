using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularQuiz.Models
{
   public class TriviaContext : DbContext
    {
        public TriviaContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<TriviaQuestion> TriviaQuestions { get; set; }
        public DbSet<TriviaOption> TriviaOptions { get; set; }
        public DbSet<TriviaAnswer> TriviaAnswers { get; set; }
    }

   public class TriviaDatabaseInitializer : CreateDatabaseIfNotExists<TriviaContext>
   {
       protected override void Seed(TriviaContext context)
       {
           base.Seed(context);

           var questions = new List<TriviaQuestion>();

           questions.Add(new TriviaQuestion
           {
               Title = "Roughly how many islands make up Japan?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "6", IsCorrect= false },
                    new TriviaOption { Title= "1000", IsCorrect= false },
                    new TriviaOption { Title= "7000", IsCorrect= true },
                    new TriviaOption { Title= "2000", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "To the nearest Million what is the population of Japan",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "100", IsCorrect= false },
                    new TriviaOption { Title= "127", IsCorrect= true },
                    new TriviaOption { Title= "156", IsCorrect= false },
                    new TriviaOption { Title= "200", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "The most northern area of Japan is?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Kansai", IsCorrect= false },
                    new TriviaOption { Title= "Kanto", IsCorrect= false },
                    new TriviaOption { Title= "Kyuushu", IsCorrect= false },
                    new TriviaOption { Title= "Hokkaido", IsCorrect= true}
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "Not a Japanese Company?",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "Sony", IsCorrect= false },
                    new TriviaOption { Title= "Toyota", IsCorrect= false },
                    new TriviaOption { Title= "Daewoo", IsCorrect= true },
                    new TriviaOption { Title= "Mazda", IsCorrect= false }
                }).ToList()
           });

           questions.Add(new TriviaQuestion
           {
               Title = "When was the original Playstation one released",
               Options = (new TriviaOption[]
                {
                    new TriviaOption { Title= "1994", IsCorrect= true },
                    new TriviaOption { Title= "1995", IsCorrect= false },
                    new TriviaOption { Title= "1996", IsCorrect= false },
                    new TriviaOption { Title= "1997", IsCorrect= false }
                }).ToList()
           });


           questions.ForEach(q => context.TriviaQuestions.Add(q));

           context.SaveChanges();
       }
   }
}