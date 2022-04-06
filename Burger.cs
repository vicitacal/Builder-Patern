namespace Builder_Patern;

public class Burger
{
    public int price;
    public List<Ingredient> BurgerLayers = new List<Ingredient>();

    public override string ToString()
    {
        string result = "";
        foreach (Ingredient layer in BurgerLayers)
        {
            result += layer.ToString();
        }
        result += "\n--------------------------------\n";
        result += $"Prise: {price}\n\n";
        return result;
    }

}

