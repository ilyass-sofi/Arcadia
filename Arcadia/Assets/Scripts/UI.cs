using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public GameObject market;
    private GameObject marketGrid;
    private GameObject itemPrefab;

    private void Awake()
    {
        itemPrefab = Resources.Load("Item") as GameObject;
        marketGrid = market.transform.GetChild(0).GetChild(0).gameObject;
    }

    public void SelectCity(City city)
    {
        market.SetActive(true);

        for (int i = 0; i < marketGrid.transform.childCount; i++)
        {
            Destroy(marketGrid.transform.GetChild(i).gameObject);
        }

        foreach (KeyValuePair<Product, int> product in city.products)
        {
            GameObject itemCreated = Instantiate(itemPrefab, marketGrid.transform);
            itemCreated.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = product.Key.sprite;
            itemCreated.transform.GetChild(1).GetComponent<Text>().text = product.Key.productName;
            itemCreated.transform.GetChild(2).GetComponent<Text>().text = product.Value+" unit(s)";
        }


    }

   
}
