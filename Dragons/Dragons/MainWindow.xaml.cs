using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using static Dragons.Character;

namespace Dragons
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window, INotifyPropertyChanged
  {
    public int mNameTextSize = 18;

    List<Race> mRaces = new List<Race>();
    List<Class> mClasses = new List<Class>();
    List<Ability> mAbilities = new List<Ability>();
    List<Character> mCharacters = new List<Character>();

    Character mSelectedCharacter;

    public Character SelectedCharacter
    {
      get { return mSelectedCharacter; }
      set 
      {
        mSelectedCharacter = value;
        OnPropertyChanged(new PropertyChangedEventArgs("SelectedCharacter"));
        OnPropertyChanged(new PropertyChangedEventArgs("PrimeStatString"));
        OnPropertyChanged(new PropertyChangedEventArgs("GoldString"));
        OnPropertyChanged(new PropertyChangedEventArgs("HPString"));
      }
    }

    public int NameTextSize
    {
      get { return mNameTextSize; }
    }
    public List<Character> Characters
    {
      get { return mCharacters; }
    }

    public string GoldString
    {
      get { return SelectedCharacter != null ? $"GOLD: {SelectedCharacter.Gold}" : ""; }
    }

    public string HPString
    {
      get { return SelectedCharacter != null ? $"HP: {SelectedCharacter.HP}" : ""; }
    }

    public string PrimeStatString
    {
      get { return SelectedCharacter != null ? $"Prime Stat: {SelectedCharacter.Class.PrimeStat.ShortName}" : ""; }
    }

    public MainWindow()
    {
      InitializeCharacterData();

      DataContext = this;
      InitializeComponent();

      CharacterList.SelectedIndex = 0;

      UpdateLayout();
    }

    void InitializeCharacterData()
    {
      // Races
      mRaces.Add(new Race(Race.Type.Dwarf, "Dwarf", "Intravision"));
      mRaces.Add(new Race(Race.Type.Elf, "Elf", "Detect Secret Doors"));
      mRaces.Add(new Race(Race.Type.Gnome, "Gnome", "Initiative Bonus"));
      mRaces.Add(new Race(Race.Type.Halfling, "Halfling", "Defensive Bonus"));
      mRaces.Add(new Race(Race.Type.Human, "Human", "None"));

      // Abilities
      mAbilities.Add(new Ability(AbilityTypes.Type.STR));
      mAbilities.Add(new Ability(AbilityTypes.Type.INT));
      mAbilities.Add(new Ability(AbilityTypes.Type.WIS));
      mAbilities.Add(new Ability(AbilityTypes.Type.DEX));
      mAbilities.Add(new Ability(AbilityTypes.Type.CON));
      mAbilities.Add(new Ability(AbilityTypes.Type.CHA));

      // Classes
      mClasses.Add(new Class(Class.Type.Bard, "Bard", GetAbility(AbilityTypes.Type.CHA)));
      mClasses.Add(new Class(Class.Type.Cleric, "Cleric", GetAbility(AbilityTypes.Type.WIS)));
      mClasses.Add(new Class(Class.Type.Druid, "Druid", GetAbility(AbilityTypes.Type.WIS)));
      mClasses.Add(new Class(Class.Type.Fighter, "Fighter", GetAbility(AbilityTypes.Type.STR)));
      mClasses.Add(new Class(Class.Type.Ranger, "Ranger", GetAbility(AbilityTypes.Type.STR)));
      mClasses.Add(new Class(Class.Type.Thief, "Thief", GetAbility(AbilityTypes.Type.DEX)));
      mClasses.Add(new Class(Class.Type.Wizard, "Wizard", GetAbility(AbilityTypes.Type.INT)));

      // Characters
      mCharacters.Add(new Character("Olga", 
        GetRace(Race.Type.Dwarf), 
        GetClass(Class.Type.Fighter), 
        new List<AbilityScore>
        {
          new Character.AbilityScore(GetAbility(AbilityTypes.Type.STR), 12, 12),
          new Character.AbilityScore(GetAbility(AbilityTypes.Type.INT), 11, 11),
          new Character.AbilityScore(GetAbility(AbilityTypes.Type.WIS), 11, 11),
          new Character.AbilityScore(GetAbility(AbilityTypes.Type.DEX), 15, 15),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 11, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 14, 13)
        }, 6, 70));

      mCharacters.Add(new Character("Bardsbain",
        GetRace(Race.Type.Dwarf),
        GetClass(Class.Type.Bard),
        new List<AbilityScore>
        {
          new AbilityScore(GetAbility(AbilityTypes.Type.STR), 9, 9),
          new AbilityScore(GetAbility(AbilityTypes.Type.INT), 12, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.WIS), 9, 9),
          new AbilityScore(GetAbility(AbilityTypes.Type.DEX), 13, 13),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 9, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 16, 15)
        }, 1, 90));

      mCharacters.Add(new Character("Aldorf",
        GetRace(Race.Type.Dwarf),
        GetClass(Class.Type.Cleric),
        new List<AbilityScore>
        {
          new AbilityScore(GetAbility(AbilityTypes.Type.STR), 10, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.INT), 6, 6),
          new AbilityScore(GetAbility(AbilityTypes.Type.WIS), 11, 11),
          new AbilityScore(GetAbility(AbilityTypes.Type.DEX), 8, 8),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 9, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 12, 11)
        }, 4, 80));

      mCharacters.Add(new Character("Thorin",
        GetRace(Race.Type.Dwarf),
        GetClass(Class.Type.Thief),
        new List<AbilityScore>
        {
          new AbilityScore(GetAbility(AbilityTypes.Type.STR), 10, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.INT), 10, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.WIS), 12, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.DEX), 9, 9),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 9, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 13, 12)
          }, 4, 170));

      mCharacters.Add(new Character("Elfwyn",
        GetRace(Race.Type.Elf), GetClass(Class.Type.Druid),
        new List<AbilityScore>
        {
          new AbilityScore(GetAbility(AbilityTypes.Type.STR), 8, 8),
          new AbilityScore(GetAbility(AbilityTypes.Type.INT), 10, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.WIS), 11, 11),
          new AbilityScore(GetAbility(AbilityTypes.Type.DEX), 7, 8),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 10, 9),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 12, 12)
          }, 2, 120));

      mCharacters.Add(new Character("Rocko",
        GetRace(Race.Type.Gnome),
        GetClass(Class.Type.Wizard),
        new List<AbilityScore>
        {
          new AbilityScore(GetAbility(AbilityTypes.Type.STR), 13, 13),
          new AbilityScore(GetAbility(AbilityTypes.Type.INT), 12, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.WIS), 12, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.DEX), 9, 9),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 9, 9),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 10, 10)
          }, 1, 120));

      mCharacters.Add(new Character("Frodine",
        GetRace(Race.Type.Halfling),
        GetClass(Class.Type.Fighter),
        new List<AbilityScore>
        {
          new AbilityScore(GetAbility(AbilityTypes.Type.STR), 12, 11),
          new AbilityScore(GetAbility(AbilityTypes.Type.INT), 15, 15),
          new AbilityScore(GetAbility(AbilityTypes.Type.WIS), 15, 15),
          new AbilityScore(GetAbility(AbilityTypes.Type.DEX), 11, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 10, 10),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 10, 10)
        }, 2, 90));

      mCharacters.Add(new Character("Bob",
        GetRace(Race.Type.Human),
        GetClass(Class.Type.Ranger),
        new List<AbilityScore>
        {
          new AbilityScore(GetAbility(AbilityTypes.Type.STR), 12, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.INT), 12, 12),
          new AbilityScore(GetAbility(AbilityTypes.Type.WIS), 11, 11),
          new AbilityScore(GetAbility(AbilityTypes.Type.DEX), 11, 11),
          new AbilityScore(GetAbility(AbilityTypes.Type.CON), 5, 5),
          new AbilityScore(GetAbility(AbilityTypes.Type.CHA), 14, 14)
          }, 3, 110));
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, e);
      }
    }

    private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      int index = CharacterList.SelectedIndex;
      SelectedCharacter = Characters[index];
    }

    private void PlayButton_Click(object sender, RoutedEventArgs e)
    {
      //TODO: This would open the game with your selected character
    }

    private Race GetRace(Race.Type type)
    {
      foreach (var race in mRaces)
      {
        if (race.RaceType == type)
        {
          return race;
        }
      }

      return mRaces[0];
    }

    private Class GetClass(Class.Type type)
    {
      foreach (var classItem in mClasses)
      {
        if (classItem.ClassType == type)
        {
          return classItem;
        }
      }

      return mClasses[0];
    }

    private Ability GetAbility(AbilityTypes.Type type)
    {
      foreach (var ability in mAbilities)
      {
        if (ability.Type == type)
        {
          return ability;
        }
      }

      return mAbilities[0];
    }
  }
}