namespace AbstractClasses
{
    public abstract class Shape
    {
        public Shape() {
            Console.WriteLine("Shape Cons");
        }
        protected Shape(string pa)
        {
            Console.WriteLine("Protected Shape Cons {0}",pa);
        } 
        public abstract void Draw();

        public void Select()
        {

        }
    }
}