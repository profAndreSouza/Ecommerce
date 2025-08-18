

# Diagrama de Classes (UML)

* **Categoria** pode conter outras **Categorias** (herança/autoassociação).
* **Produto** pode ter várias **Variações**.
* **Produto** pode estar em múltiplas **Categorias** (associação N-N).


```mermaid
classDiagram
    class Categoria {
        +int id
        +string nome
        +Categoria? categoriaPai
    }

    class Produto {
        +int id
        +string nome
        +string descricao
        +decimal precoBase
        +List<Variacao> variacoes
        +List<Categoria> categorias
    }

    class Variacao {
        +int id
        +string nome
        +string valor
        +decimal preco
    }

    Categoria "1" <|-- "0..*" Categoria : subcategorias
    Produto "1" --> "0..*" Variacao : possui
    Produto "0..*" --> "0..*" Categoria : classificado_em
```

