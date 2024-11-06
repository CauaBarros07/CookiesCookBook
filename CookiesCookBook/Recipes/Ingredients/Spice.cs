
    public abstract class Spice : Ingredient 
    {
        public override string PreparationInstructrions =>
         $" Take Half a teaspoon. {base.PreparationInstructrions}";
    }

