# ex001

Alguns números de quatro algarismos possuem uma característica particular. Se separamos 
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrado 
é exatamente igual ao número fornecido anteriormente. Veja o exemplo:
Número = 3025 
Separando o número em dois grupos de dois algarismos temos o 30 e o 25 . 
A soma de 30 com 25 é igual a 55
O Quadrado de 55 é igual a 3025.
Faça um programa que mostre os números de 1000 a 9999 que possuem essa característica.</br>


Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-Smartucheli/tree/main/codigo/lab1.0/ex001).

Usei a logica de dividir o número e depois somar os dois, e com o número encontrado fiz a raiz quadrada

## imagem do resultado
![image](https://user-images.githubusercontent.com/98031438/187095284-4e9add9d-a6dc-458d-8b05-255cb26d6f3a.png)



# ex002

Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras 
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é 
Primo. Um Número é dito Perfeito se a soma de seus divisores menores que ele é igual a ele. Por 
exemplo, o número 6 possui os  divisores 1, 2 e 3, cuja soma é igual a 6. Faça um programa que liste os números perfeitos de 1 a 1000.

Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-Smartucheli/tree/main/codigo/lab1.0/ex002) e [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-Smartucheli/tree/main/codigo/lab1.0/ex002.1).

Primeiro fiz um teste para saber se o número era ou não primo fazendo uma função, depois testei se ele era ou não primo 
A segunda parte dos números perfeitos fiz um for para verificar se ele era ou não perfeito

## primeira parte 
![image](https://user-images.githubusercontent.com/98031438/187095382-fe144f59-4ca4-4561-bab3-3c4967ad9bbd.png)

## parte dois

![image](https://user-images.githubusercontent.com/98031438/187095424-48ebf207-e5a5-40d2-93ff-855f02f89216.png)



# ex003

Faça um programa que receba os elementos de dois vetores, A e B, cada um com 5 posições. 
Considere que nenhum dos vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-Smartucheli/tree/main/codigo/lab1.0/ex003)

primeiramente fiz uma função que lê todos os elementos dos vetores depois usei a logica de comparação para ver quais estavam presentes nos dois vetores
e depois fiz a diferença para ver quais os elementos não estavam em nenhum dos vetores 


## imagem do resultado

![image](https://user-images.githubusercontent.com/98031438/187095463-96054446-35a7-4040-bd23-baf94f7dda0c.png)


# ex004

Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas. 
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-Smartucheli/tree/main/codigo/lab1.0/ex004)

Nesse exercicio usei uma logica onde percorri todo o vetor e depois somei todas as linhas e todas as colunas

## imagem do resultado
![image](https://user-images.githubusercontent.com/98031438/190237995-aff38057-5f3b-4376-b6ed-9d637029a02a.png)



# ex005

Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro.

Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-Smartucheli/tree/main/codigo/lab1.0/ex005)

Nesse exercicio utilizei o metodo de recurssividade onde a minha parada é o numero 2, sabendo disso chamei a função dentro da função e fui desempilhando para 
descobri o fatorial

## imagem do resultado

![image](https://user-images.githubusercontent.com/98031438/187095592-d5605fcd-cd3a-47e7-9b2e-b473a91f82a4.png)


# ex006

faça um programa que chame uma função capaz de calcular xy, sendo x e y inteiros. utilize passagem de pârametros por referencia

Você pode acessar os arquivos do projeto clicando[aqui](https://github.com/AED-PCO/lab-aed-pco-2022-2-Smartucheli/tree/main/codigo/lab1.0/ex006)

Nesse exercicio utilizei duas passagens por referencia e uma retornando o valor da conta, dentro da função usei o math.pow que calucla potencia
e na principal imprimi o resultado 


## imagem do resultado 

![image](https://user-images.githubusercontent.com/98031438/187095619-6505a896-a4e5-4c05-9018-8310f16e8aef.png)
