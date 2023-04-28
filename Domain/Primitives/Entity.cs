using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Primitives
{
    public abstract class Entity : IEquatable<Entity>
    {
        protected Entity(Guid id) => Id = id;

        protected Entity() { }

        //
        // Summary:
        //     once entity is created and it has an id assigned to it ,
        //     we cannot change this id throughout the lifetime of the entity's existance to
        //     to implement this constraint, change property setter instead of set use init keyword (only set the value once at ehpoint in time the object is initialized) 
        public Guid Id { get; private init; }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            if (obj is not Entity entity)
            {
                return false;
            }

            return entity.Id == Id;
        }
        //
        // Summary:
        //      its useful when creating a collection of entity type 
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Equals(Entity? other)
        {
            if (other is null)
            {
                return false;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return other.Id == Id;
        }

        public static bool operator ==(Entity? first, Entity? second)
        {
            return first is not null && second is not null && first.Equals(second);
        }
        public static bool operator !=(Entity? first, Entity? second)
        {
            return !(first == second);
        }
    }
}
