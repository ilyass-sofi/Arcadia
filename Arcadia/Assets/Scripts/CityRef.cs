using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityRef : MonoBehaviour
{

    public City city;

    
    private void Start()
    {
        for (int i = 0; i < ProductLoader.productLoader.products.Length; i++)
        {
            city.products.Add(ProductLoader.productLoader.products[i], Random.Range(0,11));
        }
        
    }

}
