using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityAnimations : MonoBehaviour
{
    public ParticleSystem[] ability1;
    public ParticleSystem[] ability2;

    public AudioSource ability_1;
    public AudioSource ability_2;

    [SerializeField]
    public int currentSpell = 0;

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            currentSpell = 1;
        }
        if (Input.GetKeyDown("2"))
        {
            currentSpell = 2;
        }

        if ((currentSpell == 1) && Input.GetButtonDown("AbilityUse"))
        {
            ability_1.Play(0);
            ability1[0].Emit(20);
            ability1[1].Emit(5);
            ability1[2].Emit(1);
        }
        if((currentSpell == 2) && Input.GetButtonDown("AbilityUse"))
        {
            ability_2.Play(0);
            ability2[0].Emit(20);
            ability2[1].Emit(5);
            ability2[2].Emit(1);
        }
    }
}
