using UnityEngine;
using TMPro;

public class PlayerKontroler : MonoBehaviour
{
    public float hiz;
    public float skor;
    public GameObject al; // Current score display
    public GameObject maxSkorYaz; // Max score display
    public GameObject[] efect2;
    public AudioClip bom;

    void Start()
    {
        skor = 0;
        UpdateScoreDisplay();
        maxSkorYaz.GetComponent<TextMeshProUGUI>().text = "Max Skor:" + PlayerPrefs.GetFloat("rekor", 0).ToString();
    }

    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 kendiPos = new Vector3(transform.position.x, transform.position.y, 0);
        transform.position = Vector3.MoveTowards(kendiPos, new Vector3(mousePosition.x, transform.position.y, 0), Time.deltaTime * hiz);

        var pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -6f, 6f);
        transform.position = pos;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        AudioSource.PlayClipAtPoint(bom, coll.transform.position);

        if (coll.gameObject.CompareTag("TuruncuBalık") || coll.gameObject.CompareTag("TuruncuBalık2"))
        {
            skor += 100;
            Instantiate(efect2[1], coll.transform.position, Quaternion.identity);
        }
        else if (coll.gameObject.CompareTag("NormalBalık"))
        {
            skor += 100; 
            Instantiate(efect2[0], coll.transform.position, Quaternion.identity);
        }
        else if (coll.gameObject.CompareTag("Para") || coll.gameObject.CompareTag("Para2"))
        {
            skor += 500;
            Instantiate(efect2[2], coll.transform.position, Quaternion.identity);
        }

        Destroy(coll.gameObject);
        UpdateScoreDisplay();

        
        if (skor > PlayerPrefs.GetFloat("rekor", 0))
        {
            PlayerPrefs.SetFloat("rekor", skor);
            maxSkorYaz.GetComponent<TextMeshProUGUI>().text = "Max Skor:" + skor.ToString();
        }
    }

    void UpdateScoreDisplay()
    {
        al.GetComponent<TextMeshProUGUI>().text = skor.ToString();
    }
}
