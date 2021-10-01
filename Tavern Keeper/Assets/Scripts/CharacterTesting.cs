using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is a test script to display the character in-game
/// This script is temporary and will be refactored in a later build
/// </summary>

public class CharacterTesting : MonoBehaviour
{
    public Characters Elder;

    void Start()
    {
        Elder = CharacterManager.instance.GetCharacter("Elder");
    }
}
