# DESAFIO 1/3 CONCLUÍDO COM SUCESSO! 💛
Esse desafio tem por objetivo atender a um dos requisitos do Bootcamp DecolaTech 2024, que foi promovido pela parceria da AVANADE com a DIO.

## Estudos utilizados nesse desafio 📝
Utilizei os operadores lógicos para realizar o cálculo do valor total gasto no estacionamento, inclui as variáves necessárias para que pudessem ser utilizadas para o cadastro das placas dos carros e para listar a quantidade de carros estacionados utilizei o foreach para percorrer toda a lista de carro. Foi implementado um serviço de lava-rápido onde ao adicionar o veículo na lista de carros, o cliente tenha a opção desse serviço, agregando melhorias no sistema de Estacionamento. 

Em breve quero desenvolver melhor esse projeto e implementar uma página web com identidade visual para uma melhor experiência de usuário e a impressão de um ticket de estacionamento.

Para isso já foi criado a logomarca do estacionamento e futuramente será desenvolvido todo o restante visual como também análise do código necessário para essa conclusão.

![Logomarca Decolas Park](DesafioFundamentos/Img/DecolasPark.jpg)


## Como clonar esse projeto:

Certifique-se de ter o Node.js e .NET 8.0 instalado em sua máquina.

Acima da lista de arquivos, clique em <>Code.

Copie a URL do repositório como desejar

Abra Git Bash.

Altere o diretório de trabalho atual para o local em que deseja ter o diretório clonado.

Digite git clone e cole a URL já copiada.

Pressione ENTER para criar seu clone local.

Para executar, utilize o comando: dotnet run no terminal.



## 🚀 Tecnologias utilizadas

O projeto foi desenvolvido utilizando as seguintes tecnologias:

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Vscode](https://img.shields.io/badge/VSCode-0078D4?style=for-the-badge&logo=visual%20studio%20code&logoColor=white)


---


# README ORIGINAL DO PROJETO FEITO PELA DIO:

# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.
