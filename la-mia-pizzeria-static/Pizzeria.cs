namespace la_mia_pizzeria_static
{
    public class Pizzeria
    {
        public string Name { get; set; }
        public List<Pizza> pizzas { get; set; }

        public Pizzeria(string name) 
        {
            Name = name;
        }
    }
}
