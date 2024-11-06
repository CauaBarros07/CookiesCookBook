
    public class Butter : Ingredient 
{
    public override int Id => 3;
    public override string Name => "Butter ";
    public override string PreparationInstructrions =>
        $" Mealt in low heat. {base.PreparationInstructrions}";
}

