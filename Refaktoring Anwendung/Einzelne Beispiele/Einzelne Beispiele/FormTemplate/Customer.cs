using System;

namespace EinzelneBeispiele.FormTemplate
{

    public  abstract  class Statement{
    
    }

    public class TextStatement : Statement
    {
        private Customer _customer;

        public TextStatement(Customer customer)
        {
            _customer = customer;
        }

        public string Value()
        {
            string text = GetHeader() + GetBody() + "gerne";
            return text;
        }

        private string GetBody()
        {
            return _customer.Name;
        }

        protected string GetHeader()
        {
            return "das sagt";
        }
    }

    public class HtmlStatement : Statement
    {
        private Customer _customer;

        public HtmlStatement(Customer customer)
        {
            _customer = customer;
        }

        public string Value()
        {
            string header = GetHeader();
            string body = GetBody();
            return header + body;
        }

        protected string GetBody()
        {
            return "Du bist der Auserwählte";
        }

        protected string GetHeader()
        {
            return _customer.Name;
        }
    }

    public class Customer
    {
        public String Name;
        private readonly TextStatement _textStatement;
        private readonly HtmlStatement _htmlStatement;

        public Customer()
        {
            _textStatement = new TextStatement(this);
            _htmlStatement = new HtmlStatement(this);
        }

        public void doText()
        {
            Console.WriteLine(HtmlStatement()+Statement());
        }

        public string HtmlStatement()
        {
            return _htmlStatement.Value();
        }

        public string Statement()
        {
            return _textStatement.Value();
        }
    }
}