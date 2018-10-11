using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    //When we change playable character to our own version, we will need to change Characterrobotboy to player

    public GameObject currentCheckpoint;

    private Platformer2DUserControl CharacterRobotBoy;

    public GameObject deathParticle;
    public GameObject respawnParticle;

    public float respawnDelay;

    public HealthManager healthManager;

	// Use this for initialization
	void Start () {
        CharacterRobotBoy = FindObjectOfType<Platformer2DUserControl>();

        healthManager = FindObjectOfType<HealthManager>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo ()
    {
        Instantiate(deathParticle, CharacterRobotBoy.transform.position, CharacterRobotBoy.transform.rotation);
        CharacterRobotBoy.enabled = false;
        CharacterRobotBoy.GetComponent<Renderer>().enabled = false;
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
        CharacterRobotBoy.transform.position = currentCheckpoint.transform.position;
        CharacterRobotBoy.enabled = true;
        CharacterRobotBoy.GetComponent<Renderer>().enabled = true;
        healthManager.isDead = false;
        healthManager.FullHealth();
        Instantiate(respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
    }
}


