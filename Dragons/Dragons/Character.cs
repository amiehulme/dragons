using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragons
{

  public static class AbilityTypes
  {
    public enum Type : byte
    {
      STR,
      INT,
      WIS,
      DEX,
      CON,
      CHA
    }

    public static List<string> Names = new List<string> { "Strength", "Intelligence", "Wisdom", "Dexterity", "Constitution", "Charisma" };
    public static List<string> ShortNames = new List<string> { "STR", "INT", "WIS", "DEX", "CON", "CHA" };

  }

  public class Ability
  {
    AbilityTypes.Type mType;

    public string Name
    {
      get { return AbilityTypes.Names[(int)mType]; }
    }

    public string ShortName
    {
      get { return AbilityTypes.ShortNames[(int)mType]; }
    }

    public AbilityTypes.Type Type
    {
      get { return mType; }
    }

    public Ability(AbilityTypes.Type type)
    {
      mType = type;
    }
  }

  public class Race
  {
    public enum Type : byte
    {
      Dwarf,
      Elf,
      Gnome,
      Halfling,
      Human
    }

    Type mType;
    string mName = "";
    string mAttribute = "";

    public string Name
    {
      get { return mName; }
    }

    public string Attribute
    {
      get { return mAttribute; }
    }

    public Type RaceType
    {
      get { return mType; }
    }

    public Race(Type type, string name, string attribute)
    {
      mType = type;
      mName = name;
      mAttribute = attribute;
    }
  }

  public class Class
  {
    public enum Type : byte
    {
      Bard,
      Cleric,
      Druid,
      Fighter,
      Ranger,
      Thief,
      Wizard
    }

    Type mType;
    string mName = "";
    Ability mPrimeStat;

    public string Name
    {
      get { return mName; }
    }

    public Type ClassType
    {
      get { return mType; }
    }

    public Ability PrimeStat
    {
      get { return mPrimeStat; }
    }

    public Class(Type type, string name, Ability primeStat)
    {
      mType = type;
      mName = name;
      mPrimeStat = primeStat;
    }
  }

  public class Character
  {
    public class AbilityScore
    {
      Ability mAbility;
      int mBaseValue;
      int mModifiedValue;

      public Ability Ability
      {
        get { return mAbility; }
      }

      public int BaseValue
      {
        get { return mBaseValue; }
      }

      public int ModifiedValue
      {
        get { return mModifiedValue; }
      }

      public int RaceModifier
      {
        get { return ModifiedValue - BaseValue; }
      }

      public string DisplayString
      {
        get 
        {
          if (RaceModifier != 0)
          {
            return $"{Ability.Name} ({Ability.ShortName}): {ModifiedValue} (Base: {BaseValue}, Race Modifier: {RaceModifier})";
          }
          else
          {
            return $"{Ability.Name} ({Ability.ShortName}): {ModifiedValue}";
          }
        }
        //get { return $"{Ability.Name} ({Ability.ShortName}): Base {BaseValue}, Race Modifier {RaceModifier}, Final {ModifiedValue}"; }
      }

      public AbilityScore(Ability ability, int baseVal, int modifiedVal)
      {
        mAbility = ability;
        mBaseValue = baseVal;
        mModifiedValue = modifiedVal;
      }
    }

    public static string mDefaultPortrait = "\u263A";

    string mName;
    Race mRace;
    Class mClass;
    List<AbilityScore> mScores = new List<AbilityScore>();
    int mHP;
    int mGold;

    public string DefaultPortrait
    {
      get { return  mDefaultPortrait; }
    }

    public List<AbilityScore> Scores
    {
      get { return mScores; }
    }

    public string Name
    {
      get { return mName; }
    }

    public Race Race
    {
      get { return mRace; }
    }

    public Class Class
    {
      get { return mClass; }
    }

    public int HP
    {
      get { return mHP; }
    }

    public int Gold
    {
      get { return mGold; }
    }

    public Character(string name, Race race, Class classtype, List<AbilityScore> scores, int health, int gold)
    {
      mRace = race;
      mClass = classtype;
      mName = name;
      mScores = scores;
      mHP = health;
      mGold = gold;
    }
  }
}
