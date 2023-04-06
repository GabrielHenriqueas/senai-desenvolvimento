﻿// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

    int simCont = 0;
    int naoCont = 0;
    int homemCont = 0;
    int mulherCont = 0;
    int mulherSim = 0;
    int homemNao = 0;

for (int cont = 1 ; cont <= 10; cont++)
{
    
    Console.WriteLine($"Qual é o seu gênero? H/M");
    string sexo = Console.ReadLine()!.ToUpper();
    
    while(sexo != "H" && sexo != "M")
    {
        Console.WriteLine($"Opção inválida, tente novamente");
        sexo = Console.ReadLine()!.ToUpper();
    }

    if(sexo == "H")
    {
        homemCont++;
    }
    else
    {
        mulherCont++;
    }
    
    Console.WriteLine($"Você gostou do produto? S/N");
    string poruduto = Console.ReadLine()!.ToUpper();
    
    while(poruduto != "S" && poruduto != "N")
    {
        Console.WriteLine($"Opção inválida, tente novamente");
        poruduto = Console.ReadLine()!.ToUpper();
    }
    
    if(poruduto == "S")
    {
       if(sexo == "M") 
       simCont++;
       mulherSim++;
    }
    else
    {
        naoCont++;
        homemNao++;
    }


}

Console.WriteLine($"O número de pessoas que responderam sim é: {simCont}");
Console.WriteLine($"O número de pessoas que responderam não é: {naoCont}");
Console.WriteLine($"O número de mulheres que responderam sim é: {mulherSim}");
Console.WriteLine($"O número de homens que responderam não é: {homemNao * 10}%");