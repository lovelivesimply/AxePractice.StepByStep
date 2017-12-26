using System;
using System.Collections.Generic;
using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Mapping;

namespace Orm.Practice.Entities
{
    public class Parent
    {
        public virtual Guid ParentId { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<Child> Children { get; set; }
        public virtual bool IsForQuery { get; set; }
    }

    public class ParentMap : ClassMap<Parent>
    {
        public ParentMap()
        {
            #region Please modify the code to pass the test

            Id(m => m.ParentId).GeneratedBy.GuidComb();
            Map(m => m.Name);
            HasMany(x => x.Children)
                .Inverse()
                .Cascade.All();
            Map(m => m.IsForQuery);
            Table("parent");
            #endregion
        }
    }
}