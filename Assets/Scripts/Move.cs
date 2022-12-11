using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Tail;

    List<GameObject> Tails;
    Vector3 eski_pozisyon;
    GameObject çýkarýlan_kuyruk;

    float hiz = 15.0f;

    private void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "Apple") 
        {
            GameObject yeni_kuyruk = Instantiate(Tail, eski_pozisyon, Quaternion.identity);
            Tails.Add(yeni_kuyruk);
        }
        if (nesne.gameObject.tag == "Tail" || nesne.gameObject.tag == "Fence") ;
        {
            SceneManager.LoadScene("Scene/SAmpleScene");
        }
    }
    void hareket_et()
    {
        eski_pozisyon=transform.position;
        transform.Translate(0, 0, hiz * Time.deltaTime);

        if (Tails.Count > 0) 
        {
            Tails[0].transform.position = eski_pozisyon;

            çýkarýlan_kuyruk = Tails[0];
            Tails.RemoveAt(0);
            Tails.Add(çýkarýlan_kuyruk);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow));
        {
            transform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            transform.Rotate(0, -90, 0);
        }
    }
}
