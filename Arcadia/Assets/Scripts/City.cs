using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "City", fileName = "City Generic Name")]
public class City : ScriptableObject
{

    public string cityName;

    
    public Dictionary<Product, int> products = new Dictionary<Product, int>();


}
