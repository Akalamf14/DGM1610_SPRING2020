using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMath : MonoBehaviour
{
    public float money;
    public float cost;
    public float discount;


    public float jacketAmount;
    public float pantsAmount;
    public float hatAmount;
    float jacketCost = 19.99f;
    float pantsCost = 12.99f;
    float hatCost = 6.89f;
    
    // Start is called before the first frame update
    void Start()
    {
        shoes(money, cost, discount);
        newWardrobe(jacketAmount, pantsAmount, hatAmount, jacketCost, pantsCost, hatCost, money, discount);

      
    }

    void shoes(float money, float cost, float discount)
    {
        float total;
        total = money - (cost - (cost * discount));
        print (total);
    }

    void newWardrobe(float jacketAmount, float pantsAmount, float hatAmount, float jacketCost, float pantsCost, float hatCost, float money, float discount)
    {
        float outfitTotal;
        outfitTotal = money - (((jacketAmount * jacketCost) + (pantsAmount * pantsCost) + (hatAmount * hatCost)) - ((jacketAmount * jacketCost) + (pantsAmount * pantsCost) + (hatAmount * hatCost))* discount);
        print (outfitTotal);

    }
}
