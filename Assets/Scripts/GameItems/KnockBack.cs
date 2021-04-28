using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    public float thrust;
    public float knockTime;
    public float damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("breakable") && this.gameObject.CompareTag("Sword") /*|| this.gameObject.CompareTag("Arrow")*/)
        {
            other.GetComponent<Pot>().Smash();
        }

        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Player"))
        {
            Rigidbody2D hit = other.GetComponent<Rigidbody2D>();
            if (hit != null)
            {
                //hit.isKinematic = false;
                Vector2 difference = hit.transform.position - transform.position;
                difference = difference.normalized * thrust;
                hit.AddForce(difference, ForceMode2D.Impulse);
                //hit.isKinematic = true;

                if (other.gameObject.CompareTag("Enemy")) //come back to figure out coroutine issue (video 22)
                {
                    hit.GetComponent<Enemy>().currentState = EnemyState.stagger;
                    other.GetComponent<Enemy>().Knock(hit, knockTime, damage);

                }
                if(other.gameObject.CompareTag("Player"))
                {
                    /*
                    if (other.GetComponent<PlayerMovement>().currentState != PlayerState.stagger)
                    {
                        hit.GetComponent<PlayerMovement>().currentState = PlayerState.stagger;
                        other.GetComponent<PlayerMovement>().Knock(knockTime, damage);
                    }*/
                    hit.GetComponent<PlayerMovement>().currentState = PlayerState.stagger;
                    other.GetComponent<PlayerMovement>().Knock(knockTime, damage);
                }
                
              
            }
        }
    }
    /*
    private IEnumerator KnockCo(Rigidbody2D Enemy)
    {
        /
        Vector2 forceDirection = enemy.transform.position - transform.position;
        Vector2 force = forceDirection.normalized * thrust;
        enemy.velocity = force;
        yield return new WaitForSeconds(.3f);
        enemy.velocity = new Vector2();
        
      
    }*/
}
