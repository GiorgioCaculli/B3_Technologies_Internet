namespace EInheritance
{
    public abstract class Document
    {
        public string Name { get; set; }
        public int NbPages { get; set; }

        public Document(string name, int nbPages)
        {
            Name = name;
            NbPages = nbPages;
        }

        public abstract int Read();

        public override string ToString()
        {
            string output = "";
            output += "Name: " + Name + " ";
            output += "Number of Pages: " + NbPages;
            return output;
        }
    }
}
