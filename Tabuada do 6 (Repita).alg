Algoritmo "Tabuada do 6"
// 
//  
// Descrição   : Tabuada do 6 (Repita)
// Autor(a)    : Guilherme Matos de Oliveira e Bryan Henrique Gomes Rocha
// Data atual  : 26/03/2023
Var
// Seção de Declarações das variáveis 
x, r: real
i: inteiro

Inicio
escreva ("Digite o número 6: ")
leia (r)
i:= 2
    repita
          x:= r*i
          escreva (x)
       i:= i+1
    ate (x>=60)
Fimalgoritmo