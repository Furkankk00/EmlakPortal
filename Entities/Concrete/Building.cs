using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Building : BaseEntity
    {
        public int LocationId { get; set; }
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public int Price { get; set; }
        public string SquareMeter { get; set; }
    }
}
