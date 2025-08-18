# Diagrama de Entidade-Relacionamento (DER)

* **CATEGORIA** pode ter **subcategorias** (auto-relacionamento).
* **PRODUTO** pode estar em **uma ou mais categorias** (tabela intermediária `PRODUTO_CATEGORIA`).
* **VARIACAO** pertence a um **PRODUTO** e pode sobrescrever o preço.

```mermaid
erDiagram
    CATEGORIA {
        int id
        string nome
        int categoria_pai_id
    }

    PRODUTO {
        int id
        string nome
        string descricao
        decimal preco_base
    }

    VARIACAO {
        int id
        string nome
        string valor
        decimal preco
        int produto_id
    }

    DESCONTO {
        int id
        string tipo
        decimal valor
        string descricao
    }

    PRODUTO_CATEGORIA {
        int produto_id
        int categoria_id
    }

    DESCONTO_PRODUTO {
        int desconto_id
        int produto_id
    }

    DESCONTO_VARIACAO {
        int desconto_id
        int variacao_id
    }

    DESCONTO_CATEGORIA {
        int desconto_id
        int categoria_id
    }

    %% Relacionamentos principais
    CATEGORIA ||--o{ CATEGORIA : "subcategorias"
    PRODUTO ||--o{ VARIACAO : "possui"
    PRODUTO ||--o{ PRODUTO_CATEGORIA : "classificado"
    CATEGORIA ||--o{ PRODUTO_CATEGORIA : "contém"

    %% Relacionamentos de descontos
    PRODUTO ||--o{ DESCONTO_PRODUTO : "pode_ter"
    DESCONTO ||--o{ DESCONTO_PRODUTO : "aplicado_a"

    VARIACAO ||--o{ DESCONTO_VARIACAO : "pode_ter"
    DESCONTO ||--o{ DESCONTO_VARIACAO : "aplicado_a"

    CATEGORIA ||--o{ DESCONTO_CATEGORIA : "pode_ter"
    DESCONTO ||--o{ DESCONTO_CATEGORIA : "aplicado_a"

```





# Diagrama de Classes (UML)

* **Categoria** pode conter outras **Categorias** (herança/autoassociação).
* **Produto** pode ter várias **Variações**.
* **Produto** pode estar em múltiplas **Categorias** (associação N-N).


```mermaid
classDiagram
    class Categoria {
        +int id
        +string nome
        +int categoriaPaiId
        +List<Desconto> descontos
    }

    class Produto {
        +int id
        +string nome
        +string descricao
        +decimal precoBase
        +List<Variacao> variacoes
        +List<Categoria> categorias
        +List<Desconto> descontos
        +decimal calcularPreco()
    }

    class Variacao {
        +int id
        +string nome
        +string valor
        +decimal preco
        +List<Desconto> descontos
        +decimal calcularPreco()
    }

    class Desconto {
        +int id
        +string tipo
        +decimal valor
        +string descricao
        +decimal aplicar(decimal preco)
    }

    %% Relacionamentos
    Categoria "1" <|-- "0..*" Categoria : subcategorias
    Produto "1" --> "0..*" Variacao : possui
    Produto "0..*" --> "0..*" Categoria : classificado_em
    Produto "0..*" --> "0..*" Desconto : pode_ter
    Variacao "0..*" --> "0..*" Desconto : pode_ter
    Categoria "0..*" --> "0..*" Desconto : pode_ter

    note for Categoria "Promoções globais podem ser aplicadas em toda a categoria e impactam seus produtos e variações"
    note for Produto "calcularPreco(): aplica desconto do produto e da categoria, exceto se a variação tiver desconto próprio"
    note for Variacao "Desconto da variação tem prioridade sobre os do produto/categoria"

```

