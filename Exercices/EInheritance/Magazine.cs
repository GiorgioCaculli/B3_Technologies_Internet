namespace EInheritance
{
    public class Magazine : Document
    {
        public int PublishInDaysFrequency { get; set; }

        public Magazine(string name, int nbPages, int freq) : base(name, nbPages)
        {
            PublishInDaysFrequency = freq;
        }

        public override int Read()
        {
            return 30;
        }

        public override string ToString()
        {
            string output = base.ToString() + " ";
            output += "Publish in days (frequency): " + PublishInDaysFrequency;
            return output;
        }
    }
}
