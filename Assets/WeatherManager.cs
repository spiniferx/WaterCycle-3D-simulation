using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{

    public GameObject rain;
    public GameObject evaporation;
    public GameObject condensation;

    // Start is called before the first frame update
    void Start()
    {
        rain.SetActive(false);
        evaporation.SetActive(false);
        condensation.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.E))
        {
            rain.SetActive(false);
            condensation.SetActive(false);
            evaporation.SetActive(true);
        }
        if(Input.GetKey(KeyCode.C))
        {
            evaporation.SetActive(true);
            condensation.SetActive(true);
            rain.SetActive(false);
        }
        if(Input.GetKey(KeyCode.R))
        {
            rain.SetActive(true);
            condensation.SetActive(true);
            evaporation.SetActive(false);
        }
        
    }
    public void Rain()
    {
        rain.SetActive(true);
        condensation.SetActive(true);
        evaporation.SetActive(false);
    }
    
    
    public void Evaporation()
    {
        rain.SetActive(false);
        condensation.SetActive(false);
        evaporation.SetActive(true);
    }
    public void Condensation()
    {
        evaporation.SetActive(true);
        condensation.SetActive(true);
        rain.SetActive(false);
    }
}
