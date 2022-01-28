
using UnityEngine;
using UnityEngine.UI;

public class NormalAttack : MonoBehaviour
{
    public GameObject AttackBox;
    public GameObject Player;
    public float AttackDuration;
    public Image CooldownImage;
    public bool OnCooldown;
    private float timer;
    public Animator anim;
    
    public float Delay;
    // Start is called before the first frame update
    private void Start()
    {
        AttackBox.SetActive(false);
    }

    private void Update()
    {
        AttackBox.transform.position = transform.position;
        AttackBox.transform.rotation = Player.transform.rotation;
        if (OnCooldown)
        {
            timer += Time.deltaTime;
            CooldownImage.fillAmount = timer/Delay;
            if (timer >= Delay)
            {
                OnCooldown = false;
            }
        }
    }

    void OnSimpleAttack()
    {
        if(!OnCooldown)
        {
            anim.SetTrigger("Attack");
            //specialAttack.InAttack = true;
            AttackBox.SetActive(true);
            timer = 0;
            OnCooldown = true;
            Invoke("DestroyBox", AttackDuration);

        }
    }

    void DestroyBox()
    {
        AttackBox.SetActive(false);
        specialAttack.InAttack = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.LogWarning("j'aimerai un void dead pour détruire l'énnemi pls");
            GameObject enemy = GameObject.FindWithTag("Enemy");
        }
    }
}