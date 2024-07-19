namespace MyApp
{
    public class ElectronicDetails
    {
       public string brand;
       public double price;

       public ElectronicDetails(string brand , double price)
       {
        this.brand = brand;
        this.price = price;

       }

       public override string ToString()
       {
        return $"Brand:{brand}  Price:{price}" ; 
       }

    }
}
