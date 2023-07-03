

interface IHealthManager
{
    float MaxHealth { get; set; }
    float CurrentHealth { get; set; }

    bool IsDead { get; }

    void TakeDamage(float amount);
}