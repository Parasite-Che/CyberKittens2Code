using System;
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour, IPlayer
{
    [SerializeField] private SpriteRenderer shield;
    [SerializeField][Range(0,3)]private int _health;
    [SerializeField] private GameObject particles;
    [SerializeField] private AudioClip punch;
    [SerializeField]private float _maxSpeed;
    [SerializeField]private float _direction;
    private MovementController _mc;
    private bool _isShieldActive = false;
    private bool _isImmortal;
    

    private void Start()
    {
        _mc = GetComponent<MovementController>();
        Math.Clamp(_health, 0, 3);
        _isShieldActive = false;
        shield.enabled = false;
        Events.onAddLife += AddLife;
        Events.onActivateShield += ActivateShield;
        Events.onSpeedUp += () => StartCoroutine(SpeedUp());
    }

    public void TakeDamage(int damageSize)
    {
        if (!_isShieldActive & !(_isImmortal||_mc.isDashing))
        {
            StartCoroutine(Punch());
            StartCoroutine(ImmortalMode());
            if(_health>0)_health -= damageSize;
            Events.onChangeInterHealth(_health);
            if(_health<=0) Events.onPlayerDeath?.Invoke();
        }
        else if(_isShieldActive & !(_isImmortal||_mc.isDashing))
        {
            _isShieldActive = false;
            shield.enabled = false;
        }
    }

    void AddLife()
    {
        if(_health<3)_health += 1;
        Events.onChangeInterHealth(_health);
    }

    void ActivateShield()
    {
        _isShieldActive = true;
        shield.enabled = true;
    }

    IEnumerator SpeedUp()
    {
        _mc.speedMultiplier = 1.5f;
        yield return new WaitForSeconds(5.0f);
        _mc.speedMultiplier = 1.0f;
    }

    IEnumerator ImmortalMode()
    {
        _isImmortal = true;
        yield return new WaitForSeconds(2.0f);
        _isImmortal = false;
    }

    public void SpeedDown()
    {
        _mc.speedMultiplier = 0.5f;
    }

    public void RestoreSpeed()
    {
        _mc.speedMultiplier = 1.0f;
    }

    public void FullHealth()
    {
        _health = 3;
        Events.onChangeInterHealth(_health);
    }

    IEnumerator Punch()
    {
        Events.onEffectPlay?.Invoke(punch);
        ParticleSystem ps = Instantiate(particles, transform.position, transform.rotation).GetComponent<ParticleSystem>();
        ps.Play();
        yield return new WaitForSeconds(1.0f);
        ps.Stop();
        Destroy(ps.gameObject);
    }
}
