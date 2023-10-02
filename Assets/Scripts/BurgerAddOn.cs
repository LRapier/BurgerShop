using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWeaponAttachment",
        menuName = "Weapon/Attachment", order = 1)]
public class BurgerAddOn : ScriptableObject, IAddOn
{
    [Tooltip("Cheese")]
    [SerializeField] public GameObject cheese;

    [Tooltip("Lettuce")]
    [SerializeField] public GameObject lettuce;

    [Tooltip("Tomato")]
    [SerializeField] public GameObject tomato;

    [Tooltip("Pickles")]
    [SerializeField] public GameObject pickles;

    [Tooltip("Sauce")]
    [SerializeField] public GameObject sauce;

    public GameObject addOnObject;

    public GameObject Cheese
    {
        get { return cheese; }
    }

    public GameObject Lettuce
    {
        get { return lettuce; }
    }

    public GameObject Tomato
    {
        get { return tomato; }
    }

    public GameObject Pickles
    {
        get { return pickles; }
    }

    public GameObject Sauce
    {
        get { return sauce; }
    }
}
