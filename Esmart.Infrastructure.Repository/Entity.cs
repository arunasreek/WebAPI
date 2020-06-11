using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.RepositoryContract;

namespace Esmart.Infrastructure.Repository
{
    public class Entity<T> : IEntity<T>
    {
        dynamic Item { get; }
        string PropertyName { get; }
        public Entity(dynamic element, string propertyName)
        {
            Item = element;
            PropertyName = propertyName;
        }
        public T Id
        {
            get
            {
                return (T)Item.GetType().GetProperty(PropertyName).GetValue(Item, null);
            }
        }
    }
}
