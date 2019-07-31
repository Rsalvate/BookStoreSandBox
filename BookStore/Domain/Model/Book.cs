using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Book
    {
        public virtual int Id { get; set; }
        public virtual int Isbn { get; set; }
        public virtual string Name { get; set; }
        public virtual string Autor { get; set; }
        public virtual double Price { get; set; }
        public DateTime DatePublished { get; set; }
        //public byte[] FrontImage { get; set; }
    }
}
