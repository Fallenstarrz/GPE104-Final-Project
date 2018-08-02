using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int scoreToAdd;
    public AudioClip pickUp;
    public GameObject popupText;
    public GameObject popup;

    // when player enters trigger add points to gameManager and play sound
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == GameManager.instance.player.gameObject)
        {
            GameManager.instance.score += scoreToAdd;
            AudioSource.PlayClipAtPoint(pickUp, transform.position, 2);
            // Make popup & set its text to the score it is worth
            popup = Instantiate(popupText, transform.position, transform.rotation);
            popup.GetComponent<TextMesh>().text = scoreToAdd.ToString();
            Destroy(this.gameObject);
        }
    }
}
