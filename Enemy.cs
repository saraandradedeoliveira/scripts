using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Enemy : MonoBehaviour
{
    // velocidade
        public float speed;
      
    //target do inimigo
         public Transform target;

    //pontos de dano no ataque
        public int playerDamage=2;

   void Update()
    {
        //altere a posicão do NPC a cada novo frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed*Time.deltaTime);

        //rode NPC a cada frame para se direcionar para o target (jogador)
        transform.LookAt(target.position);
    }
    
    // quando um inimigo colide com o jogador, é feito um dano a esse jogador
   private void OnTriggerEnter (Collider other)
    {
       Player player= other.GetComponent<Player>();
       player.TakeDamage(playerDamage);
   }
}
