namespace Testing;

using FermatProgram;
using NUnit.Framework;


public class Tests
{
    [Test]
    public void IsFermatSatisfied_Pyth_pow2()
    {
        // 3^2 + 4^2 = 25
        bool result = ProgramF.IsFermatSatisfied(3, 4, 5, 2);
        Assert.That(result == true);
    }

    [Test]
    public void IsFermatSatisfied_Pyth_pow3()
    {
        // 3^3 + 4^3 = 91 != 125
        bool result = ProgramF.IsFermatSatisfied(3, 4, 5, 3);
        Assert.That(result == false);
    }

    [Test]
    public void IsFermatSatisfied_EqualPositive_pow1()
    {
        // 2^1 + 2^1 = 4
        bool result = ProgramF.IsFermatSatisfied(2, 2, 4, 1);
        Assert.That(result == true);
    }

    [Test]
    public void IsFermatSatisfied_Zero_pow5()
    {
        // 0^5 + 0^5 = 0 != 1
        bool result = ProgramF.IsFermatSatisfied(0, 0, 1, 5);
        Assert.That(result == false);
    }

    [Test]
    public void IsFermatSatisfied_WithNegative_pow2()
    {
        // (-3)^2 + (-4)^2 = 25
        bool result = ProgramF.IsFermatSatisfied(-3, -4, 5, 2);
        Assert.That(result == true);
    }
}

