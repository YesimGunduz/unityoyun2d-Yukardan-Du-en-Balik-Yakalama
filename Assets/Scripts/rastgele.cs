using System.Collections;
using UnityEngine;
using TMPro;

public class Rastgele : MonoBehaviour
{
    public float arttir = 0;
    public GameObject al; // Score display
    public GameObject[] prefabs;

    void Start()
    {
        if (al != null)
        {
            al.GetComponent<TextMeshProUGUI>().text = "0";
        }
        InvokeRepeating("Olustur", 0.1f, 1f); 
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            arttir += 100;
            if (al != null)
            {
                al.GetComponent<TextMeshProUGUI>().text = arttir.ToString();
            }
        }
    }

    void Olustur()
    {
        if (prefabs.Length > 0) 
        {
            int salla = Random.Range(0, prefabs.Length);

            float leftLimit = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
            float rightLimit = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
            Vector2 position = new Vector2(Random.Range(leftLimit, rightLimit), 18);

            Instantiate(prefabs[salla], position, Quaternion.identity);
        }
    }
}
