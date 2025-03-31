# ProjetoRobo_2025

![]( https://imgur.com/rozsGBp.gif )
## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2025

## Entradas 
**Solicitação da posição inicial:** O programa solicita que o usuário informe a posição atual do robô, inserindo um número por vez.

**Validação da posição:** Caso as informações sejam válidas, o programa prossegue para a próxima etapa.

**Solicitação da orientação inicial:** O usuário deve informar para qual direção o robô está olhando inicialmente (Norte, Sul, Leste ou Oeste).

**Solicitação dos comandos:** O programa pede que o usuário insira a sequência de comandos para movimentar o robô:

* M: Avança uma posição na direção em que está orientado.

* E: Gira 90 graus para a esquerda.

* D: Gira 90 graus para a direita.

## Detalhes 

Este projeto envolve dois robôs que se movimentam em uma área de 5x5 
seguindo instruções específicas.



## funcionalidades 

**Solicitação de entrada de dados do usuário:** O programa solicita ao usuário que informe as coordenadas iniciais do robô e a orientação para a qual ele estará voltado.

**Realização de validação de dados do usuário:** O programa verifica se as entradas do usuário são válidas. Caso ele digite um comando inicial que posicione o robô fora da área permitida (5x5), o programa exibirá uma mensagem em vermelho informando que o robô está fora dos parâmetros e que a posição deve estar dentro dos limites da grade 5x5.

**Atualização da posição dos robôs:** O programa valida as entradas do usuário e atualiza a posição do robô conforme os comandos inseridos. Por exemplo, se o robô estiver na posição x0, y0 voltado para o norte e receber o comando M, sua posição y será atualizada para 1, resultando na nova posição x0, y1.

**Verificação de posicionamento final do robô:** O programa verifica se o robô permanece dentro da área válida de 5x5 após a execução dos comandos. Caso o robô ultrapasse os limites, o usuário será informado e deverá fornecer novas coordenadas para reposicioná-lo dentro da área permitida.

**Feedback de retorno:** O programa fornece um feedback textual sobre o posicionamento do robô diretamente no terminal após a execução dos comandos principais. Ao finalizar as instruções do primeiro robô, o usuário receberá a posição final exibida no terminal. Em seguida, o processo se repetirá para o segundo robô, que só iniciará após todas as etapas do primeiro terem sido concluídas.

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
---
## Como Usar

#### Clone o Repositório
```
https://github.com/LeandroJader/ProjetoRobo_2025
```

#### Navegue até a pasta raiz da solução
```
cd ProjetoRobo_2025_
```

#### Restaure as dependências
```
dotnet restore
```

#### Navegue até a pasta do projeto
```
cd cd ProjetoRobo_2025_
```

#### Execute o projeto
```
dotnet run
```
