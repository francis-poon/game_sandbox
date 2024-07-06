using UnityEngine;

using game_00;
public class Player : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "OutOfBounds")
        {
            GameManager.Instance.OnGameOver();
        }
    }
}
