using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Enums;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.Tests;

public class ISRCalculatorService
{

    [Test] //Level 1.
    public void ProcessIsr_WhenGrossSalaryAreInLevel1()
    {
        //arrage
        var expectedType = ISR_Range.Level1;
        var person = new Person{ GrossSalary = (float)6500};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 2.
    public void ProcessIsr_WhenGrossSalaryAreInLevel2()
    {
        //arrage
        var expectedType = ISR_Range.Level2;
        var person = new Person{ GrossSalary = (float)13500};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 3.
    public void ProcessIsr_WhenGrossSalaryAreInLevel3()
    {
        //arrage
        var expectedType = ISR_Range.Level3;
        var person = new Person{ GrossSalary = (float)80000.05};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 4.
    public void ProcessIsr_WhenGrossSalaryAreInLevel4()
    {
        //arrage
        var expectedType = ISR_Range.Level4;
        var person = new Person{ GrossSalary = (float)125000.8};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 5.
    public void ProcessIsr_WhenGrossSalaryAreInLevel5()
    {
        //arrage
        var expectedType = ISR_Range.Level5;
        var person = new Person{ GrossSalary = (float)148000.01};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 6.
    public void ProcessIsr_WhenGrossSalaryAreInLevel6()
    {
        //arrage
        var expectedType = ISR_Range.Level6;
        var person = new Person{ GrossSalary = (float)200500.11};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 7.
    public void ProcessIsr_WhenGrossSalaryAreInLevel7()
    {
        //arrage
        var expectedType = ISR_Range.Level7;
        var person = new Person{ GrossSalary = (float)420980.2};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 8.
    public void ProcessIsr_WhenGrossSalaryAreInLevel8()
    {
        //arrage
        var expectedType = ISR_Range.Level8;
        var person = new Person{ GrossSalary = (float)950123.09};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 9.
    public void ProcessIsr_WhenGrossSalaryAreInLevel9()
    {
        //arrage
        var expectedType = ISR_Range.Level9;
        var person = new Person{ GrossSalary = (float)1234567.89};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 10.
    public void ProcessIsr_WhenGrossSalaryAreInLevel10()
    {
        //arrage
        var expectedType = ISR_Range.Level10;
        var person = new Person{ GrossSalary = (float)2000000.5};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }
    
    [Test] //Level 11.
    public void ProcessIsr_WhenGrossSalaryAreInLevel11()
    {
        //arrage
        var expectedType = ISR_Range.Level11;
        var person = new Person{ GrossSalary = (float)5000000};
        var sut = new IsrService();
        
        //act
        var result = sut.ProcessIsr(person);
        
        //assert
        Assert.AreEqual(expectedType, result.ISR_Range);
    }

}