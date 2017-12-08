using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ProductLoader : MonoBehaviour
{

    public static ProductLoader productLoader;

    public Product[] products;

    private void Awake()
    {
        if (productLoader == null)
            productLoader = this;

        else if (productLoader != this)
            Destroy(productLoader);

        DontDestroyOnLoad(this);

        products = Resources.LoadAll("Products", typeof(Product)).Cast<Product>().ToArray();
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
