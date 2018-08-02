using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42Factory.Classes
{
    public abstract class Document
    {
        public List<Page> Pages { get; set; } = new List<Page>();

        public abstract Document CreateDocument();
    }
}
