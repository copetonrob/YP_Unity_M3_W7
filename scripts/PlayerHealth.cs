using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float MaxValue = 100;
    public Slider Healthbar;

    float _currentValue;

    void Start()
    {
		//В начале игры задаем текущее здоровье максимальным значением
        //_currentValue = ???;
        UpdateHealthbar();
    }

    public void TakeDamage(float damage)
    {
		//отнять урон от текущего значения здоровья
        //_currentValue = ???;
		
		//проверить, что здоровья не осталось
        //if (???)
        {
            Destroy(gameObject);
        }
        UpdateHealthbar();
    }

    void UpdateHealthbar()
    {
		//обновить Healthbar.value текущим значением здоровья (от 0 до 1)
        //Healthbar.value = ???;
    }
}
