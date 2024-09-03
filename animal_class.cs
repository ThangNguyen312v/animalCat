namespace dongvat{
    public abstract class animal{
        protected string Weight { get; set; }
        protected string Height { get; set; }

        public animal(string weight, string height){
            this.Weight = weight;
            this.Height = height;
        }
        public abstract void PrintInfo();
    }
}