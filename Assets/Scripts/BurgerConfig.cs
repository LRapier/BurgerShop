using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBurgerConfig",
        menuName = "Burger/Config", order = 1)]

public class BurgerConfig : MonoBehaviour
{
    [Tooltip("Add On 1")]
    [SerializeField] private GameObject addOn1;

    [Tooltip("Add On 2")]
    [SerializeField] private GameObject addOn2;

    [Tooltip("Add On 3")]
    [SerializeField] private GameObject addOn3;

    public GameObject burgerObject;

    public GameObject AddOn1
    {
        get { return addOn1; }
    }

    public GameObject AddOn2
    {
        get { return addOn2; }
    }

    public GameObject AddOn3
    {
        get { return addOn3; }
    }
}
