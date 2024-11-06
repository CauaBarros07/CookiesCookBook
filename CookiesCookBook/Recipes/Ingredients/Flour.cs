public abstract class Flour : Ingredient
{
    public override string PreparationInstructrions =>
        $" Sieve. {base.PreparationInstructrions}";
}

