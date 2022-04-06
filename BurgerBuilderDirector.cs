namespace Builder_Patern;

public class BurgerBuilderDirector
{
    private readonly IBurgerBilder _builder;

    public BurgerBuilderDirector(IBurgerBilder burgerBilder)
    {
        _builder = burgerBilder;
    }

    public Burger buildVopper()
    {
        return _builder.
                 AddBottomBread().
                 AddCutlet().
                 AddMidFilling(LayerType.Salad).
                 AddTopBread().
                 GetBurger();
    }

    public Burger buildCheeceburger()
    {
        return _builder.
                 AddBottomBread().
                 AddMidFilling(LayerType.Tomat).
                 AddCutlet().
                 AddMidFilling(LayerType.Cheece).
                 AddMidFilling(LayerType.Tomat).
                 AddMidFilling(LayerType.Salad).
                 AddTopBread().
                 GetBurger();
    }
}

