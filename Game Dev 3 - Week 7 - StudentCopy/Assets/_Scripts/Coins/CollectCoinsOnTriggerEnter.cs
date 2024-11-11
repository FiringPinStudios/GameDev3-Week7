using GameDevWithMarco.Managers;
using GameDevWithMarco.ObserverPattern;
using GameDevWithMarco.RandomStuff;
using UnityEngine;

namespace GameDevWithMarco.Player
{
    public class CollectCoinsOnTriggerEnter : MonoBehaviour
    {

        [SerializeField] GameEvent coinCollected;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "Coin")
            {
                //Gets the value from the coin
                int coinValue = collision.GetComponent<Coin>().CoinValue;

                //add score
                GameManager.Instance.AddToScore(coinValue);

                //Destroy item
                Destroy(collision.gameObject);

                coinCollected.Raise();
            }
        }
    }
}
