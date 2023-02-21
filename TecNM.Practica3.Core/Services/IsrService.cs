using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Enums;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Services;

public class IsrService: IIsrService {

    public ISR ProcessIsr(Person person) {

        var isr = new ISR();
        
        //Nivel 1
        if (person.GrossSalary >= 0.01 && person.GrossSalary <= 7735.0) {
            
            isr.ISR_Range = ISR_Range.Level1;
            isr.LowerLimitAmount = (float)0.01;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(1.92 / 100);
            isr.FixedFee = (float)0.0;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 2
        if (person.GrossSalary >= 7735.01 && person.GrossSalary <= 65651.07) {
            
            isr.ISR_Range = ISR_Range.Level2;
            isr.LowerLimitAmount = (float)7735.01;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(6.40 / 100);
            isr.FixedFee = (float)148.51;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 3
        if (person.GrossSalary >= 65651.08 && person.GrossSalary <= 115375.90) {
            
            isr.ISR_Range = ISR_Range.Level3;
            isr.LowerLimitAmount = (float)65651.08;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(10.88 / 100);
            isr.FixedFee = (float)3855.14;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 4
        if (person.GrossSalary >= 115375.91 && person.GrossSalary <= 134119.41) {
            
            isr.ISR_Range = ISR_Range.Level4;
            isr.LowerLimitAmount = (float)115375.91;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(16.0 / 100);
            isr.FixedFee = (float)9265.20;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 5
        if (person.GrossSalary >= 134119.42 && person.GrossSalary <= 160577.65) {
            
            isr.ISR_Range = ISR_Range.Level5;
            isr.LowerLimitAmount = (float)134119.42;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(17.92 / 100);
            isr.FixedFee = (float)12264.16;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 6
        if (person.GrossSalary >= 160577.66 && person.GrossSalary <= 323862.0) {
            
            isr.ISR_Range = ISR_Range.Level6;
            isr.LowerLimitAmount = (float)160577.66;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(21.36 / 100);
            isr.FixedFee = (float)17005.47;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 7
        if (person.GrossSalary >= 323862.1 && person.GrossSalary <= 510451.0) {
            
            isr.ISR_Range = ISR_Range.Level7;
            isr.LowerLimitAmount = (float)323862.1;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(23.52 / 100);
            isr.FixedFee = (float)51883.01;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 8
        if (person.GrossSalary >= 510451.1 && person.GrossSalary <= 974535.03) {
            
            isr.ISR_Range = ISR_Range.Level8;
            isr.LowerLimitAmount = (float)510451.1;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(30.0 / 100);
            isr.FixedFee = (float)95768.74;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 9
        if (person.GrossSalary >= 974535.04 && person.GrossSalary <= 1299380.04) {
            
            isr.ISR_Range = ISR_Range.Level9;
            isr.LowerLimitAmount = (float)974535.04;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(32.0 / 100);
            isr.FixedFee = (float)234993.95;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 10
        if (person.GrossSalary >= 1299380.05 && person.GrossSalary <= 3898140.12) {
            
            isr.ISR_Range = ISR_Range.Level10;
            isr.LowerLimitAmount = (float)1299380.05;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(34.0 / 100);
            isr.FixedFee = (float)338944.34;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }
        
        //Nivel 11
        if (person.GrossSalary >= 3898140.13) {
            
            isr.ISR_Range = ISR_Range.Level11;
            isr.LowerLimitAmount = (float)3898140.13;
            isr.PercentageOverExcessOfTheLowerLimit = (float)(35.0 / 100);
            isr.FixedFee = (float)1222522.76;
            
            isr.Base = person.GrossSalary - isr.LowerLimitAmount;
            isr.Result = isr.Base * isr.PercentageOverExcessOfTheLowerLimit;
            isr.IsrResult = isr.Result + isr.FixedFee;

        }

        return isr;

    }
    
}