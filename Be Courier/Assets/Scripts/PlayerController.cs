using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hareketHizi = 20f; // aracın hızı
    public float donmeHizi = 50f; // aracın dönüş hızı
    
    private float yatayHareket; // sol-sağ hareket girdisi
    private float dikeyHareket; // ileri-geri hareket girdisi

  
    void Update()
    {
        yatayHareket = SimpleInput.GetAxis("Horizontal"); // sol-sağ girdisini al
        dikeyHareket = SimpleInput.GetAxis("Vertical"); // ileri-geri girdisini al

        // aracı hareket ettir
        transform.Translate(Vector3.forward * dikeyHareket * hareketHizi * Time.deltaTime);
        transform.Rotate(Vector3.up * yatayHareket * donmeHizi * Time.deltaTime);
    }
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag.Equals("Wall"))
    //    {
            
    //    }
    //}
}
