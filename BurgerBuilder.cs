namespace Builder_Patern;

public class BurgerBuilder : IBurgerBilder
{
    private Burger _buildingBurger;
    private List<Ingredient> _avaliableLayers;
    private bool _isTopLayerReached = false;
    private bool _isBottomLayerReached = false;

    public BurgerBuilder(List<Ingredient> avaliableLayers)
    {
        _avaliableLayers = avaliableLayers;
        _buildingBurger = new Burger();
    }

    public IBurgerBilder AddBottomBread()
    {
        if (_isBottomLayerReached || _isTopLayerReached) return this;
        Ingredient? layer = _avaliableLayers.Find(lay => lay.Type == LayerType.BottomBread);
        if (layer != null)
        {
            _buildingBurger.BurgerLayers.Add(layer);
            _buildingBurger.price += layer.Cost;
            _isBottomLayerReached = true;
        }
        return this;
    }

    public IBurgerBilder AddCutlet()
    {
        if (!_isBottomLayerReached || _isTopLayerReached) return this;
        Ingredient? layer = _avaliableLayers.Find(lay => lay.Type == LayerType.Cotlet);
        if (layer != null)
        {
            _buildingBurger.BurgerLayers.Add(layer);
            _buildingBurger.price += layer.Cost;
        }
        return this;
    }

    public IBurgerBilder AddMidFilling(LayerType type)
    {
        if (!_isBottomLayerReached || _isTopLayerReached) return this;
        Ingredient? layer = _avaliableLayers.Find(lay => lay.Type == type);

        if (layer != null)
        {
            _buildingBurger.BurgerLayers.Add(layer);
            _buildingBurger.price += layer.Cost;
        }
        return this;
    }

    public IBurgerBilder AddTopBread()
    {
        if (_isTopLayerReached || !_isBottomLayerReached) return this;
        Ingredient? layer = _avaliableLayers.Find(lay => lay.Type == LayerType.TopBread);
        if (layer != null)
        {
            _buildingBurger.BurgerLayers.Add(layer);
            _buildingBurger.price += layer.Cost;
            _isTopLayerReached = true;
        }
        return this;
    }

    public Burger GetBurger()
    {
        _buildingBurger.BurgerLayers.Reverse();
        Burger newBurger = _buildingBurger;
        _buildingBurger = new Burger();
        _isBottomLayerReached = false;
        _isTopLayerReached = false;
        return newBurger;
    }
}