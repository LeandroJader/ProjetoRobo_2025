# ProjetoRobo_2025

![]( https://imgur.com/rozsGBp.gif )
## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

## Entradas 
**Solicita��o da posi��o inicial:** O programa solicita que o usu�rio informe a posi��o atual do rob�, inserindo um n�mero por vez.

**Valida��o da posi��o:** Caso as informa��es sejam v�lidas, o programa prossegue para a pr�xima etapa.

**Solicita��o da orienta��o inicial:** O usu�rio deve informar para qual dire��o o rob� est� olhando inicialmente (Norte, Sul, Leste ou Oeste).

**Solicita��o dos comandos:** O programa pede que o usu�rio insira a sequ�ncia de comandos para movimentar o rob�:

* M: Avan�a uma posi��o na dire��o em que est� orientado.

* E: Gira 90 graus para a esquerda.

* D: Gira 90 graus para a direita.

## Detalhes 

Este projeto envolve dois rob�s que se movimentam em uma �rea de 5x5 
seguindo instru��es espec�ficas. Cada rob� pode receber diferentes comandos que os 



## funcionalidades 

**Solicita��o de entrada de dados do usu�rio:** O programa solicita ao usu�rio que informe as coordenadas iniciais do rob� e a orienta��o para a qual ele estar� voltado.

**Realiza��o de valida��o de dados do usu�rio:** O programa verifica se as entradas do usu�rio s�o v�lidas. Caso ele digite um comando inicial que posicione o rob� fora da �rea permitida (5x5), o programa exibir� uma mensagem em vermelho informando que o rob� est� fora dos par�metros e que a posi��o deve estar dentro dos limites da grade 5x5.

**Atualiza��o da posi��o dos rob�s:** O programa valida as entradas do usu�rio e atualiza a posi��o do rob� conforme os comandos inseridos. Por exemplo, se o rob� estiver na posi��o x0, y0 voltado para o norte e receber o comando M, sua posi��o y ser� atualizada para 1, resultando na nova posi��o x0, y1.

**Verifica��o de posicionamento final do rob�:** O programa verifica se o rob� permanece dentro da �rea v�lida de 5x5 ap�s a execu��o dos comandos. Caso o rob� ultrapasse os limites, o usu�rio ser� informado e dever� fornecer novas coordenadas para reposicion�-lo dentro da �rea permitida.

**Feedback de retorno:** O programa fornece um feedback textual sobre o posicionamento do rob� diretamente no terminal ap�s a execu��o dos comandos principais. Ao finalizar as instru��es do primeiro rob�, o usu�rio receber� a posi��o final exibida no terminal. Em seguida, o processo se repetir� para o segundo rob�, que s� iniciar� ap�s todas as etapas do primeiro terem sido conclu�das.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.
---
## Como Usar

#### Clone o Reposit�rio
```
https://github.com/LeandroJader/ProjetoRobo_2025
```

#### Navegue at� a pasta raiz da solu��o
```
cd ProjetoRobo_2025_
```

#### Restaure as depend�ncias
```
dotnet restore
```

#### Navegue at� a pasta do projeto
```
cd cd ProjetoRobo_2025_
```

#### Execute o projeto
```
dotnet run
```