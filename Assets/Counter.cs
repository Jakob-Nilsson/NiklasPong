using UnityEngine;
using TMPro;   // Remove if not using TextMeshPro

public class TopWallHitCounter : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI counterText1; // Or UnityEngine.UI.Text
    [SerializeField] private TextMeshProUGUI counterText2;

    private int hitCountP1 = 0;
    private int hitCountP2 = 0;

    private void Start()
    {
        UpdateUI();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("TopWall"))
        {
            hitCountP1++;
            UpdateUI();
        }
        if (collision.collider.CompareTag("BottomWall"))
        {
            hitCountP2++;
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        if (counterText1 != null)
            counterText1.text = "Score: " + hitCountP1;
        if (counterText2 != null)
            counterText2.text = "Score: " + hitCountP2;
    
    }
}