

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

