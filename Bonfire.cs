using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float lifeTime = 15;
    public float heatPower = 0.1f;

    void Update()
    {
        lifeTime = Time.deltaTime;
        if (lifeTime <= 0 )
        {
            gameObject.SetActive( false );
        }
        {
        void OnTriggerStay(Collider other);
        {
            if (other.GetComponent<Temperature>() != null)
            {
               Temperature temperature = other.GetComponent<Temperature>();

                    if (temperature.temperatureCurrect < temperature.temperatureNormal)
                    {
                        temperature.temperatureCurrect += heatPower * Time.deltaTime;
                    }
            }
        }


        }

    }
}
