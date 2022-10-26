# Challenge


## Parte 1 – Matemática e Lógica

A explicação dos desaftios Parte 1 – Matemática e Lógica estão em Draft.jpeg

1 - 18 pessoas

2 - Ela chegou na hora

3 - (d) "Leve quatro e pague três"

4 - 24

## Parte 2 – Programação

Projeto feito usando .net 6.0

1 - Rodar teste unitário do projeto PalindromaTeste

2 - Rodar teste unitário do projeto BinarySearch

3 - A solução estará em Query.SQL. Para recriar o banco no docker, usar Create_Db_Schema.sql e rodar comando docker compose up no arquivo docker-compose.yml

```sql
SELECT 
	FORN.NOME_FORNECEDOR,
	PECA.PRECO
FROM FORNECEDOR AS FORN
JOIN FORNECIMENTO ON FORNECIMENTO.CODIGO_FORNECEDOR = FORN.CODIGO_FORNECEDOR 
JOIN PECA ON PECA.CODIGO_PEÇA = FORNECIMENTO.CODIGO_PECA AND PECA.CODIGO_PEÇA = 'MOTOR'
WHERE FORN.CIDADE = 'VITORIA' AND FORNECIMENTO.CODIGO_CARRO = 'KOMBI'
```

Nota: O exercício está estranho. CODIGO_PEÇA 'MOTOR'? sendo o CODIGO_PEÇA o identificador do registro da tabela PEÇA, como pode ter diferentes peças com mesmo id 'MOTOR' com preços diferentes? 

Podemos ver o problema pelo exemplo dado na questão 3

4 - Rodar projeto console MS-Paint

```
Tela inicial
. # # # . .
. # . . # .
. # # # . .
. # . . . .

Pixel(0, 1) e nova cor 'o'
. o o o . .
. o . . # .
. o o o . .
. o . . . .

Pixel (1,3) e nova cor 'o'
. # # # . .
. # o o # .
. # # # . .
. # . . . .

Pixel (1,3) e nova cor '#'
. # # # . .
. # # # # .
. # # # . .
. # . . . .
```

