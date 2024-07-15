using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
    }

    public class Model
    {
        public int ModelID { get; set; }
        public int ProductID { get; set; }
        public int GroupAttributeID { get; set; }
        public decimal Price { get; set; }
        public Product Product { get; set; }
        public GroupAttribute GroupAttribute { get; set; }
    }

    public class GroupAttribute
    {
        public int GroupAttributeID { get; set; }
        public string GroupAttributeName { get; set; }
        public ICollection<Model> Models { get; set; }
        public ICollection<Attribute> Attributes { get; set; }
    }

    public class Attribute
    {
        public int AttributeID { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public int GroupAttributeID { get; set; }
        public GroupAttribute GroupAttribute { get; set; }
    }

}
