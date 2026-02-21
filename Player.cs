using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    // Variável pública para guardar o prefab da fireball
    // Como é pública, aparece no Inspector
    // Aqui vais arrastar o prefab Fireball
    public  GameObject fireballPrefab;

    // Variável pública que guarda o ponto de onde a fireball sai
    // Também aparece no Inspector
    // Aqui vais arrastar o objeto AttackPoint
    public Transform attackPoint;

    // Player Health - saude do jogador
    private int health=10;
        public void TakeDamage(int damage)
    {
        health -= damage;
       print ("Player's health: "+ health); 
    }

void Update()
    {
        if (Input.GetMouseButtonDown(0))  // Detecta quando o botão esquerdo do rato é pressionado
{
      Instantiate(fireballPrefab, 
attackPoint.
position, attackPoint.
rotation);
}

    }
 
}
