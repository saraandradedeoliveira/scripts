using UnityEngine;

public class Missile : MonoBehaviour
{
   // Velocidade da fireball (visível no Inspector)
    public float speed = 10f;

    void Start()
    {
          // Destrói a fireball após 3 segundos
        Destroy(gameObject, 3);
    }

    void Update()  // Move a fireball para a frente
    {
        transform.position += 
        transform.forward *
        speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); // Destrói o objeto com o qual a fireball colidiu
    }
     
}