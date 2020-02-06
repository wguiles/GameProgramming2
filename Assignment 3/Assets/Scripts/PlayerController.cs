using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private int direction = 1;

    public float fireRate;
    private float currentTimer;

    public GameObject bullet;

    public float playerHealth;

    public Image playerHealthBar;

    public GameObject DefeatPanel;

    // Update is called once per frame
    void Update()
    {
        Move();
        Shooting();
    }

    public void Move()
    {
        transform.Translate(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime);
    }

    public void Shooting()
    {
        if (Input.GetAxisRaw("FireAxisX") != 0
        ||  Input.GetAxisRaw("FireAxisY") != 0)
        {
            currentTimer += Time.deltaTime;

            if (currentTimer >= fireRate)
            {
                GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                BulletScript bulletScript = newBullet.GetComponent<BulletScript>();
                bulletScript.direction = new Vector2(Input.GetAxisRaw("FireAxisX"), Input.GetAxis("FireAxisY"));
                currentTimer = 0f;
            }
        }
    }

    public void TakeDamage(int damageToTake)
    {
        StartCoroutine(DamageFlash());

        playerHealth -= damageToTake;
        UpdateHealth();

        if (playerHealth <= 0)
        {
            Death();
        }
    }

    private IEnumerator DamageFlash()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
        yield return new WaitForSeconds(0.09f);
        GetComponent<SpriteRenderer>().color = Color.white;
    }

    public void Death()
    {
        Debug.Log("Player is Dead!");
        DefeatPanel.SetActive(true);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
        else if (other.gameObject.tag == "EnemyBullet")
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }

    public void UpdateHealth()
    {
        playerHealthBar.fillAmount = ((float)playerHealth / 10f);
    }
}
