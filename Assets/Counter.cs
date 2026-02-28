using UnityEngine;
using TMPro;   // Remove if not using TextMeshPro

public class TopWallHitCounter : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI counterText; // Or UnityEngine.UI.Text

    private int hitCount = 0;

    private void Start()
    {
        UpdateUI();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("TopWall"))
        {
            hitCount++;
            UpdateUI();
        }
    }

    private void UpdateUI()
    {
        if (counterText != null)
            counterText.text = "Top Hits: " + hitCount;
    }
}