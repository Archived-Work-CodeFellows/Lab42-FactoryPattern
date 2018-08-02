using System;
using System.Collections.Generic;
using System.Text;

namespace Lab42Factory.Classes
{
    public class Thesis : Document
    {
        public override Document CreateDocument()
        {
            Thesis thesis = new Thesis();
            Console.WriteLine("Collecting pages for your thesis");
            Pages.Add(new Introduction());
            Pages.Add(new TableOfContents());
            Pages.Add(new Research());
            Pages.Add(new Research());
            Pages.Add(new Research());
            Pages.Add(new TechnicalSpecs());
            Pages.Add(new Research());
            Pages.Add(new Research());
            Pages.Add(new Research());
            Pages.Add(new TechnicalSpecs());
            Pages.Add(new TechnicalSpecs());

            return thesis;
        }
    }
}
