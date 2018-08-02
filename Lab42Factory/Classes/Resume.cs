using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42Factory.Classes
{
    public class Resume : Document
    {
        public override Document CreateDocument()
        {
            Resume resume = new Resume();
            Console.WriteLine("Collecting pages for your Resume");
            Pages.Add(new CoverLetter());
            Pages.Add(new EducationHistory());
            Pages.Add(new WorkHistory());
            Pages.Add(new References());
            return resume;
        }
    }
}
