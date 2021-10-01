using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;
    public RectTransform characterPanel;
    public List<Characters> characters = new List<Characters>();
    public Dictionary<string, int> characterDictionary = new Dictionary<string, int>();

    void Awake()
    {
        instance = this;
    }

    public Characters GetCharacter(string characterName, bool createCharacterIfDoesNotExist = true)
    {
        int index = -1;
        if (characterDictionary.TryGetValue (characterName, out index))
        {
            return characters[index];
        }
        else if (createCharacterIfDoesNotExist)
        {
            return CreateCharacters(characterName);
        }
        return null;
    }

    public Characters CreateCharacters(string characterName)
    {
        Characters newCharacter = new Characters(characterName);
        characters.Add(newCharacter);
        return newCharacter;
    }
}
