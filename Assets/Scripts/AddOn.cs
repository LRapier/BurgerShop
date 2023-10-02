using UnityEngine;

public class AddOn
{
    public GameObject Cheese
    {
        get { return _addOn.Cheese; }
    }

    public GameObject Lettuce
    {
        get { return _addOn.Lettuce; }
    }

    public GameObject Tomato
    {
        get { return _addOn.Tomato; }
    }

    public GameObject Pickles
    {
        get { return _addOn.Pickles; }
    }

    public GameObject Sauce
    {
        get { return _addOn.Sauce; }
    }

    private readonly BurgerAddOn _addOn;

    public AddOn(BurgerAddOn burgerAddOn)
    {
        _addOn = burgerAddOn;
    }
}