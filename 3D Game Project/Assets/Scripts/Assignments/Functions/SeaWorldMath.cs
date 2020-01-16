using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaWorldMath : MonoBehaviour
{

    public int walrus;
    public int seaLion;
    public int whale;
    public int sharks;

    // Start is called before the first frame update
    void Start()
    {
        seaCreatures(walrus, seaLion, whale);
        sharkBait(walrus, seaLion, whale, sharks);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void seaCreatures(int walrus, int seaLion, int whale)
    {
        int total;
        total = walrus + seaLion + whale;
        print("there are" + total + "Sea Creatures in the ocean");

        int count;
        count = walrus * whale - seaLion;
        print("there are" + count + "Sea Creatures");
    }

    void sharkBait(int walrus, int sealion, int whale, int sharks)
    {
        int food;
        food = (walrus + seaLion + whale)/sharks;
        print(food + "sea animals per shark to eat");
    }

    
}
