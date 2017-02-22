using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using Moq;

namespace DrumsAcademy.Services.Tests.Mocks
{
    public class QueryableDbSetMock
    {
        public static IDbSet<T> GetQueryableMockDbSet<T>(IEnumerable<T> sourceList) where T : class
        {
            return GetQueryableMockDbSetFromArray(sourceList.ToArray());
        }

        public static IDbSet<T> GetQueryableMockDbSetFromArray<T>(params T[] sourceList) where T : class
        {
            var queryable = sourceList.AsQueryable();

            var dbSet = new Mock<IDbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());

            return dbSet.Object;
        }

        public static IDbSet<T> GetQueryableMockDbSetFromList<T>(IList<T> sourceList) where T : class
        {
            var queryable = sourceList.AsQueryable();

            var dbSet = new Mock<IDbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(queryable.GetEnumerator());

            dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>((s) => sourceList.Add(s));
            dbSet.Setup(d => d.Remove(It.IsAny<T>())).Callback<T>((s) => sourceList.Remove(s));
            dbSet.Setup(d => d.Find(It.IsAny<T>())).Callback(() => sourceList.FirstOrDefault());

            return dbSet.Object;
        }
    }
}
