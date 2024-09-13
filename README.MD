##
<h1 align="center">
Teste Desafio Desenvolvedor
</h1>

### Projeto
O código desenvolvido propõe retirar as perguntas feitas pelo processo é torná-las escopo de código,
foi possível desenvolver os itens **1, 2, 3, 4** com código o item  **5** foi projetado aqui no documento

## 🥷 Tecnologias

- Linguagem: C#(Sdk8.0) 
- Biblioteca LINK *desempenho O(n)*


## 
<h1>Respostas</h1>

<details>
    <summary><b>Caso 1</b></summary>
<h2>Resposta: 77</h2>
</details>

<details>
    <summary><b>Caso 2</b></summary>
<h2><p>
    Resposta:<p>
    Próximo elemento de a): 9<p>
    Próximo elemento de b): 128<p>
    Próximo elemento de c): 49<p>
    Próximo elemento de d): 100<p>
    Próximo elemento de e): 13<p>
    Próximo elemento de f): 20
</h2>
</details> 

<details>
    <summary><b>Caso 3</b></summary>
<h2><p>
    Resposta:<p>
    Menor faturamento do ano: 1500<p>
    Maior faturamento do ano: 2500<p>
    Número de dias com faturamento acima da média anual: 4
</h2>
</details>

<details>
    <summary><b>Caso 4</b></summary>

<h2>Modelo lógico Banco de dados:</h2>

    +--------------------------------------------------------------------+
       Clientes      Telefones       TiposTelefone      Estados
    +-----------+  +------------+   +--------------+   +--------+
    | PK id     |  | PK id      |   | PK id        |   | PK id  |
    | nome      |  | numero     |   | descricao    |   | sigla  |
    | estado_id |  | tipo_id    |   |              |   | nome   |
    +-----------+  | cliente_id |   |              |   +--------+
                   +------------+   +--------------+       
    +--------------------------------------------------------------------+

<h2>Relacionamentos</h2>

    Clientes -< Telefones -- Clientes tem um relacionamento de um para muitos com Telefones
    (Um cliente pode ter vários telefones)

    Telefones >- TiposTelefone -- Telefones tem um relacionamento de muitos para um com TiposTelefone 
    (Cada telefone tem um tipo de telefone)

    Clientes >- Estados -- Clientes tem um relacionamento de muitos para um com Estados
    (Cada cliente está associado a um estado)

<h2>SQL</h2>
 buscar o código, razão social (nome) e os telefones de todos os clientes do estado de São Paulo (código “SP”):
    
    SELECT 
    c.id_cliente, 
    c.nome_cliente, 
    t.numero AS telefone

    FROM 
        Clientes c
    JOIN 
        Telefones t ON c.id_cliente = t.id_cliente
    JOIN 
        Estados e ON c.estado_id = e.id_estado
    WHERE 
        e.sigla_estado = 'SP';

</details>

<details>
    <summary><b>Caso 5</b></summary>
    
<h2><p>
    Resposta:<p>
    Tempo de encontro sem pedágio: 0.74 horas<p>
    Tempo de atraso total do carro devido aos pedágios: 0.25 horas<p>
    Tempo total de viagem do carro até o ponto de encontro: 0.99 horas<p>
    Distância percorrida pelo carro até o ponto de encontro: 66.18 km<p>
    Distância percorrida pelo caminhão até o ponto de encontro: 58.82 km
</h2>
</details>

##

## ⚒️ Configuração
Pré-requisito: Dotnet sdk8.0
1. Clone o repositório
2. Execute os casos via Console > **dotnet run**

## 👩‍💻 Autor
Inacio Oliveira
https://www.linkedin.com/in/InacioCarvalho/