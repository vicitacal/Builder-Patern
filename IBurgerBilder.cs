namespace Builder_Patern;
public interface IBurgerBilder
{

    IBurgerBilder AddTopBread();

    IBurgerBilder AddMidFilling(LayerType type);

    IBurgerBilder AddCutlet();

    IBurgerBilder AddBottomBread();

    Burger GetBurger();

}

