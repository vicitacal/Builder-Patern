namespace Builder_Patern;

public enum LayerType
{
    TopBread, BottomBread, Cotlet, Cheece, Becone, Salad, Tomat
}

public class Ingredient
{
    public int Cost = 0;
    public LayerType Type;
    public string Name = "";
    public string Image = "";

    public Ingredient(int cost, LayerType type, string name, string image)
    {
        Cost = cost;
        Type = type;
        Name = name;
        Image = image;
    }

    public override string ToString()
    {
        string result = "";
        result = Image + "  <--" + Name + "\n";
        return result;
    }
}
