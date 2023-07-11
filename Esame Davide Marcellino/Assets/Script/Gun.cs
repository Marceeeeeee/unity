
using UnityEngine;
using TMPro;

public class Gun : MonoBehaviour
{
    public float damage = 50f;
    public float range = 100f;
    public TMP_Text textScore;
    public int score = 0;

    public Camera fpsCamera;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        RaycastHit hit;
        if (Physics.Raycast(fpsCamera.transform.position, fpsCamera.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);
            EnemyBehaviour target = hit.transform.GetComponent<EnemyBehaviour>();
            TankBehaviour tank = hit.transform.GetComponent<TankBehaviour>();
            if(target != null){
                if(hit.transform.name == "Cylinder"){
                tank.TakeDamage(damage);
                }else
                {
                target.TakeDamage(damage);
                score += 50;
                textScore.text = "Score: " + score;
                }
            }
        }

    }
}
