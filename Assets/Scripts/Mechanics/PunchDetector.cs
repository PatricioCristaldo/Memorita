using UnityEngine;

public class PunchDetector : MonoBehaviour
{
    
    public Collider2D punchCollider;
    public void Punch(bool pegar)
    {
        punchCollider.enabled = pegar;
    }

   void OnTriggerEnter2D(Collider2D objetoColisionado){
    if(objetoColisionado.gameObject.tag == "Destruible") 
    {
        Destroy(objetoColisionado.gameObject);
    }
   }
   void Update ()
   {
    
   }
   
}
