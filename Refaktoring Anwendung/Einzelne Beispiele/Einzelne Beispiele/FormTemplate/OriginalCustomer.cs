using System;

namespace EinzelneBeispiele.FormTemplate
{

    /// <summary>
    /// Schritte
    /// 1 Klassen Textstement und HtmlStatement erzeugen
    /// 2 Gemeinsamkeinten und Unterschiede heraustellen
    /// 3 Pull UP
    /// </summary>
    public class OriginalCustomer
    {
        private String Name;

        public void doText()
        {
            Console.WriteLine(HtmlStatement() + Statement());
        }

        public string HtmlStatement()
        {
            string header = "<title>" + Name + "</title>";
            string body = "Du bist der Auserwählte";
            return header + body;
        }

        public string Statement()
        {
            string text = "das sagt" + Name + "gerne";
            return text;
        }
    }
}