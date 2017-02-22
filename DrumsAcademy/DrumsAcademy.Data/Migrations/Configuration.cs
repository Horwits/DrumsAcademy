using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

using DrumsAcademy.Common.Enums;
using DrumsAcademy.Models;

namespace DrumsAcademy.Data.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<DrumsAcademyContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DrumsAcademyContext context)
        {
            if (context.Categories.Any())
            {
                return;
            }

            IList<Category> categories = new List<Category>()
                                             {
                                                 new Category()
                                                     {
                                                         Id = Guid.NewGuid(),
                                                         Type = CategoryType.Hand
                                                     },
                                                 new Category()
                                                     {
                                                         Id = Guid.NewGuid(),
                                                         Type = CategoryType.Feet
                                                     },
                                                 new Category()
                                                     {
                                                         Id = Guid.NewGuid(),
                                                         Type = CategoryType.Theory
                                                     },
                                                 new Category()
                                                     {
                                                         Id = Guid.NewGuid(),
                                                         Type = CategoryType.QnA
                                                     }
                                             };

            IList<Resource> resources = new List<Resource>()
                                            {
                                                new Resource()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        Type = ResourceType.Video,
                                                        Title =
                                                            "First drum lesson expectations",
                                                        Description =
                                                            "What you should expect from your first lesson.",
                                                        Level = LevelType.Basic,
                                                        Category = categories[3],
                                                        Url =
                                                            "https://www.youtube.com/watch?v=B8sBX5xvSz8"
                                                    },
                                                new Resource()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        Type = ResourceType.Video,
                                                        Title =
                                                            "How to play 7/8 on drums and be musical",
                                                        Description =
                                                            "Easing into odd time signature. In this case 7/8. It\'s important to make your odd time drumming pattern sound musical with a strong pulse.",
                                                        Level = LevelType.Intermediate,
                                                        Category = categories[2],
                                                        Url =
                                                            "https://www.youtube.com/watch?v=k_ip7fiRGeU"
                                                    },
                                                new Resource()
                                                    {
                                                        Id = Guid.NewGuid(),
                                                        Type = ResourceType.Video,
                                                        Title = "6/8th Note Blast Beats!",
                                                        Description =
                                                            "Triplet Blast Beats! In this video I play blast beats in a 6/8th note pattern at 210 bpm, also some fill ins, some double bass,Enjoy!",
                                                        Level = LevelType.Advanced,
                                                        Category = categories[2],
                                                        Url =
                                                            "https://www.youtube.com/watch?v=Yi1VHNTl8U8"
                                                    }
                                            };

            context.Resources.AddOrUpdate(resources.ToArray());
        }
    }
}