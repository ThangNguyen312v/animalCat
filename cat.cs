namespace dongvat{
   public class Cat : animal
    {
        private string Name{ get; set; }
        public Cat(string weight, string height, string name) : base(weight, height){
            this.Name = name;
        }
        public override void PrintInfo()
        {
            Console.WriteLine("weight: {0} " + "height: {1} " + "name: {2} ",this.Weight,this.Height,this.Name);
            
        }
    }
}