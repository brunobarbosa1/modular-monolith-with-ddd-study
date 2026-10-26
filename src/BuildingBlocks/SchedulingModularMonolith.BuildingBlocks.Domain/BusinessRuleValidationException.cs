namespace SchedulingModularMonolith.BuildingBlocks.Domain;

public sealed class BusinessRuleValidationException : Exception
{
    public IBusinessRule BrokenRule { get; }
    
    public BusinessRuleValidationException(IBusinessRule brokenRule)
        : base(brokenRule.Message)
    {
        BrokenRule = brokenRule;
    }
    
    public override string ToString() => 
        $"{BrokenRule.GetType().Name}: {BrokenRule.Message}";
}