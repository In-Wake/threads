using Test;

//2
//var pingPongRun = new RunPingPong();
//pingPongRun.Run(10);

//3
var standartDeviation = new StandartDeviation();
Console.WriteLine($" SD = {
        //sequence form wiki
        standartDeviation.Run(new List<double> { 2, 4, 4, 4, 5, 5, 7, 9 })}");

