
    public class Chocolate : Ingredient 
{
    public override int Id => 4;
    public override string Name => "Chocolate";
    public override string PreparationInstructrions =>
        $" Mealt in a water bath. {base.PreparationInstructrions}";
}

