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

    PRODUTO_CATEGORIA {
        int produto_id
        int categoria_id
    }

    CATEGORIA ||--o{ CATEGORIA : "subcategorias"
    PRODUTO ||--o{ VARIACAO : "possui"
    PRODUTO ||--o{ PRODUTO_CATEGORIA : "classificado"
    CATEGORIA ||--o{ PRODUTO_CATEGORIA : "contém"
```
