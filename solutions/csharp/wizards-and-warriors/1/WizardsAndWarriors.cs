abstract class Character
{
    public string characterType{ get; set; }
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => characterType == "Wizard";

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target) => (target.Vulnerable()) ? 10 : 6;
}

class Wizard : Character
{
    private bool check = true;
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target) => (check) ? 3 : 12;

    public override bool Vulnerable() => check;

    public void PrepareSpell()
    {
        check = false;
    }
}
