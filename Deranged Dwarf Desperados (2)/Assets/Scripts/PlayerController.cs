using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {

    public int score;
    public float bulletReloadTime = 1.8f;
    public float bulletRecoilTime = 0.4f;
    public int lives = 3;

    [HideInInspector]
    private float accuracy;

    private int bulletsFired = 0;
    private int bulletsMissed = 0;

    [HideInInspector]
    public int bulletClipCount = 8;

    public Image gunReticle;
    public Image bulletHole;
    public ParticleSystem environmentParticle;
    public ParticleSystem enemyParticle;
    public ParticleSystem muzzleFlash;
    
    public Camera mainCamera;

    private AudioSource gunshot;
    private AudioSource reload;

    private float reloadCopy;
    private int bulletCountCopy;
    private float recoilCopy;

	// Use this for initialization
	void Start () {
        gunshot = GetComponent<AudioSource>();
        Cursor.visible = false;
        reloadCopy = bulletReloadTime;
        recoilCopy = bulletRecoilTime;
        accuracy = 100.0f;
        bulletCountCopy = bulletClipCount;
  //      bulletReloadTime = 0f;
        bulletRecoilTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (bulletsMissed != 0)
        {
            accuracy = bulletsFired / bulletsMissed;
        }

        bulletRecoilTime -= Time.deltaTime;

        if (bulletClipCount == 0)
        {
            bulletReloadTime -= Time.deltaTime;
        }
        gunReticle.transform.position = Input.mousePosition;

        if (bulletRecoilTime < 0 && bulletClipCount > 0)
        {
            fire();
        }
 
        if (bulletReloadTime < 0)
        {
            bulletClipCount = bulletCountCopy;
            bulletReloadTime = reloadCopy;
        }


    }

    void fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            bulletClipCount--;
            gunshot.Play();
            bulletRecoilTime = recoilCopy;
            RaycastHit rayhit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out rayhit))
            {
                bulletsFired++;
                Debug.Log(rayhit.transform.name);
                if (rayhit.transform.tag == "Enemy")
                {
                    score += 50;

                    Destroy(rayhit.transform.gameObject);
                }
                else
                {
                    bulletsMissed++;
                }
               
            }
        }
    }
}
