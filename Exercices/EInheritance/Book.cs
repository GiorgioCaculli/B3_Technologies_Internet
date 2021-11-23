namespace EInheritance
{
    public class Book : Document
    {
        public string Author { get; set; }
        public Book(string name, int nbPages, string author) : base(name, nbPages)
        {
            Author = author;
        }

        public override int Read()
        {
            return 20;
        }

        public override string ToString()
        {
            string output = base.ToString() + " ";
            output += "Author: " + Author;
            return output;
        }
    }
}
