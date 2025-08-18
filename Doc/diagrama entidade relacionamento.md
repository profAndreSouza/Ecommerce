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
