-- Escreva um comando SQL que seja capaz de consultar os fornecedores localizados na cidade de nome
-- “VITORIA” que fornecem a peca de código “MOTOR” para o carro de código “KOMBI”, com os respectivos
-- preços.

SELECT 
	FORN.NOME_FORNECEDOR,
	PECA.PRECO
FROM FORNECEDOR AS FORN
JOIN FORNECIMENTO ON FORNECIMENTO.CODIGO_FORNECEDOR = FORN.CODIGO_FORNECEDOR
JOIN PECA ON PECA.CODIGO_PEÇA = FORNECIMENTO.CODIGO_PECA
WHERE FORN.CIDADE = 'VITORIA' AND CODIGO_CARRO = 'KOMBI'