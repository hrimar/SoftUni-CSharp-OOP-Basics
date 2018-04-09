public class Animal
{
    public string Name { get; protected set; }

    public string FavouriteFood { get; protected set; }

    public Animal(string name, string favoriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favoriteFood;
    }

    //private string name;
    //private string favouriteFood;

    //public string Name
    //{
    //    get { return name; }
    //   protected set { name = value; }
    //}
    //public string FavouriteFood
    //{
    //    get { return favouriteFood; }
    //    protected set { favouriteFood = value; }
    //}

    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
    }
}
