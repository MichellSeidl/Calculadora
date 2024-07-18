# Calculadora
Case para Engenharia de Software JR

Você precisa corrigir os seguintes problemas no codigo:
  1. Aplicação só está processando o primeiro item da fila infinitamente.
  
  R: Foi identificado que o elemento não estava sendo retirado da fila e que o laço de repetição continha '>= 0'. Se isso ocorresse, o programa pararia a execução devido à tentativa de acessar um elemento inexistente na fila.
     
  2. Implemente a funcionalidade de divisão.
     R: Funcionalidade implementada na classe Calculadora
  3. Aplicação não está calculando a penultima operação corretamente.
     
     	Saída esperada no console:
     
     		14 - 8 = 6
     
     		5 * 6 = 30
     
     		2147483647 + 2 = 2147483649
     
     		18 / 3 = 6
      R: Foi identificado na classe Operacoes que as variaves valorA e valorB são do tipo inteiro, sendo assim na penultima operação o valor estoura e é preciso fazer a alteração para um tipo de dado de maior capacidade (Long).
  4. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.
      R: Funcionalidade implementada na classe Operacoes
  5. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final
      R: Pilha implementada na classe Program 

Não existe resposta certa ou errada, o objetivo do case é avaliar a linha de raciocínio de cada candidato.
Você é livre para fazer na linguagem de sua preferência, desde que aplique as mesmas funcionalidades e tarefas deste case.
Dica: Utilize Visual Code ou Visual Studio Community para realizar as tarefas.
