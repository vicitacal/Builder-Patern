using Builder_Patern;

List<Ingredient> ingredients = new List<Ingredient>()
{
    new Ingredient(15, LayerType.BottomBread, "БулкаХлеба", "--------\n|_____|"),
    new Ingredient(20, LayerType.TopBread, "Макушка", "  -o--  \n --o--- \no-----o-"),
    new Ingredient(12, LayerType.Cheece, "Сырок", "/------/"),
    new Ingredient(40, LayerType.Cotlet, "Говяжинка", "(000000)"),
    new Ingredient(18, LayerType.Becone, "Свинья", "~~~~~~~~"),
    new Ingredient(21, LayerType.Tomat, "Помидорка", "<======>"),
    new Ingredient(17, LayerType.Salad, "Капустина", "%%~^^~%%")
};

BurgerBuilder builder = new BurgerBuilder(ingredients);
BurgerBuilderDirector director = new BurgerBuilderDirector(builder);

Console.WriteLine(director.buildCheeceburger().ToString());
Console.WriteLine(director.buildVopper().ToString());
Console.ReadKey();