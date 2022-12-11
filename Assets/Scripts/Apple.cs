using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI yazi_txt;
    public TMPro.TextMeshProUGUI skor_txt;

    int skor = 0;
    int artis_degeri = 100;

    void Start()
    {
        InvokeRepeating("Kontrol", 0, 5.0f);
    }

    void kontol()
    {
        float x = Random.Range(1.84f, 6.8f);
        float z = Random.Range(11.86f, 11.86f);

        int rastgele = Random.Range(1, 5);

        if (rastgele == 4) 
        {
            yazi_txt.gameObject.SetActive(true);
        }
        else 
        {
            yazi_txt.gameObject.SetActive(false);
        }
        Vector3 koordinat= new Vector3(x,0,z); 
        transform.position = koordinat;

        private void OnTriggerEnter(Collider nesne)
    {
            if (nesne.gameObject.tag == "Player") 
            {
                CancelInvoke();
                InvokeRepeating("Kontrol", 0f, 5.0f);

                if (yazi_txt.gameObject.activeSelf == true) 
                {
                    Skore += (artis_degeri);

                }
                skor_txt.text = "Skore" + skor;
            }

            if (nesne.gameObject.tag == "Tail") 
            {
                CancelInvoke();
                InvokeRepeating("Kontrol", 0f, 5.0f);
            }
    }
}
}
