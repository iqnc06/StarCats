using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 3;
    private int MAX_HEALTH = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

public void Damage(int amount){
    if(amount < 0){
        throw new System.ArgumentOutOfRangeException("Cannot have negative damage");
    }
    this.health -= amount;
    if(health <=0){
        Die();
    }
}

public void Heal(int amount){
    if(amount < 0){
        throw new System.ArgumentOutOfRangeException("Healing cant be neg");
    }

    if(health+amount > MAX_HEALTH){
        health = MAX_HEALTH;
    }else{
        health+= amount;
    }
}

private void Die(){
    Debug.Log("I am dead :/");
    Destroy(gameObject);
}

public void SetHealth(int mHlth, int hlth){
    this.MAX_HEALTH = mHlth;
    this.health = hlth;
}

}