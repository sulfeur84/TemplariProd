
using UnityEngine;
using UnityEngine.UI;

public class SpecialAttack : MonoBehaviour
{
    public GameObject specialAttackBox;
    public GameObject Player;
    public float AttackDuration;
    public  bool InAttack;
    public bool specialCooldown;
    public Image CooldownImage;
    public bool OnCooldown;
    private float timer;
    public Animator anim;
    public float Delay;

    public ParticleSystem Particule;
    // Start is called before the first frame update
    private void Start()
    {
        specialAttackBox.SetActive(false);
    }

    private void Update()
    {
        specialAttackBox.transform.position = Player.transform.position;
        specialAttackBox.transform.rotation = Player.transform.rotation;
        if (OnCooldown)
        {
            timer += Time.deltaTime;
            CooldownImage.fillAmount = timer/Delay;
            if (timer >= Delay)
            {
                OnCooldown = false;
                specialCooldown = false;
            }
        }
    }

    void OnSpecialAttack()
    {
        if(InAttack == false && specialCooldown == false)
        {
            Particule.Play();
            anim.SetTrigger("Special");
            InAttack = true;
            specialCooldown = true;
            specialAttackBox.SetActive(true);
            timer = 0;
            OnCooldown = true;
            Invoke("DestroyBox", AttackDuration);
        }
    }

    void DestroyBox()
    {
        specialAttackBox.SetActive(false);
        InAttack = false;
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