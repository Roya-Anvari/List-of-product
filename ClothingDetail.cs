namespace MyApp
{
    public class ClothingDetail
    {
        public string size; 
        public string  material;

        public ClothingDetail(string size , string material)
        {
            this.size = size;
            this.material = material;
        }   

        public override string ToString()
        {
            return $"Size:{size}  Material:{material}";
        }  
    } 

   
    
}