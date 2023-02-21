using TecNM.Practica3.Core.Enums;

namespace TecNM.Practica3.Core.Entities;

public class ISR {
    public float Base {get; set;}
    public float LowerLimitAmount {get; set;}
    public float UpperLimitAmount {get; set;}
    public float Result {get; set;}
    public float PercentageOverExcessOfTheLowerLimit {get; set;}
    public float IsrResult {get; set;}
    public float FixedFee {get; set;}
    
    public ISR_Range ISR_Range {get; set;}
    
}