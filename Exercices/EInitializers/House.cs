namespace EInitializers
{
    public class House
    {
        public string Street { get; set; }
       public int Number { get; set; }

       public override string ToString()
       {
           return base.ToString() + ": Street = " + Street + ", Number = " + Number;
       }
    }
}