# Projeto E-Shop

## Descrição do Projeto

A **E-Shop** é um sistema completo de e-commerce voltado para a venda de artigos de moda, acessórios e itens para casa.  
Ele contempla uma área pública para clientes e um painel administrativo para gestão eficiente dos produtos, vendas, clientes, promoções e relatórios.  
O desenvolvimento será realizado utilizando a metodologia **SCRUM**, onde o aluno atuará como **Product Owner (P.O.)**.


## 1. Contexto

Aumentar a presença digital da loja, oferecendo uma plataforma online robusta, escalável e segura para o comércio eletrônico, garantindo uma ótima experiência de compra e gestão.


## 2. Stakeholders

- **Cliente (E-Shop):** Proprietário do negócio, responsável pela definição das necessidades.
- **Equipe Administrativa:** Gerencia o catálogo, estoque, pedidos, clientes e promoções.
- **Clientes:** Usuários finais que realizam compras.
- **Equipe Financeira:** Processa os pagamentos.
- **Equipe de Suporte/Logística:** Responsável pelo envio e atendimento pós-venda.
- **Product Owner (Estudante):** Representa o cliente, prioriza o backlog e intermedia a comunicação.


## 3. Objetivos do Sistema

- Facilitar vendas online por meio de catálogo, carrinho e checkout.
- Prover painel administrativo para controle total da operação.
- Gerar relatórios para tomada de decisão.
- Garantir segurança, usabilidade e responsividade.
- Integrar múltiplos meios de pagamento.
- Oferecer arquitetura escalável e de fácil manutenção.


## 4. Escopo Mínimo (MVP)

### Área Pública

- Catálogo com busca e filtros.
- Páginas de produtos detalhadas.
- Carrinho de compras.
- Checkout simplificado.
- Cadastro e login de clientes.

### Painel Administrativo

- CRUD de produtos (com imagens, categorias e controle de estoque).
- Gestão de clientes (visualização, edição e bloqueio).
- Gestão de pedidos (status e histórico).
- Gestão de promoções e cupons.
- Relatórios básicos (vendas, produtos mais vendidos).

### Funcionalidades Adicionais

- Integração com gateway de pagamento simulado.
- Controle simplificado de estoque e frete.
- Aplicação de regras de cupons.
- Responsividade para desktop e dispositivos móveis.


## 5. Requisitos Não Funcionais

- Segurança robusta: HTTPS, hashes para senhas, proteção contra ataques comuns (XSS, CSRF, SQL Injection).
- Performance otimizada: carregamento do catálogo em até 2 segundos.
- Disponibilidade para pelo menos 50 usuários simultâneos.
- Arquitetura modular com separação frontend/backend.
- Código padronizado, documentado e testado.
- Acessibilidade com contraste e navegação por teclado (mínimo WCAG AA).
- Compatibilidade com navegadores modernos e dispositivos móveis.
- Política de privacidade e conformidade com boas práticas de dados.
- Suporte a internacionalização (pt-BR e possibilidade para multilínguas).


## 6. Regras de Negócio

- Reserva de estoque durante o checkout (ou após confirmação do pagamento - decisão a ser documentada).
- Cupons podem ser acumuláveis ou não, conforme regra definida.
- Alteração do status do pedido para “Enviado” via ação manual.
- Liberação do estoque se o pagamento for recusado.
- Descontos não podem gerar valores negativos na compra.


## 7. Integrações

- **Obrigatória:** Gateway de pagamento simulado.
- **Opcionais:** API para cálculo de frete, envio automático de e-mails, importação/exportação CSV.


## 8. Entregáveis

- Product Backlog priorizado com épicos e histórias.
- Protótipos e wireframes das principais telas.
- Modelagem detalhada (casos de uso, diagramas ER, diagramas de classes e componentes).
- Documentação da API (Swagger/OpenAPI).
- MVP funcional com frontend e backend.
- Testes automatizados e manuais.
- Documentação para deploy (Docker ou scripts).
- Relatório final e apresentação do projeto.


## 9. Critérios de Avaliação

- Completo atendimento ao MVP.
- Qualidade da experiência do usuário e design.
- Clareza, detalhamento e completude da modelagem.
- Organização, qualidade e legibilidade do código.
- Cobertura e qualidade dos testes.
- Criatividade e diferenciais implementados.
- Robustez, segurança e desempenho.
- Qualidade da apresentação final.


## 10. Desafios Extras (Opcional)

- Programa de fidelidade para clientes.
- Sistema de recomendação de produtos.
- Login via redes sociais.
- Painel analítico avançado com métricas detalhadas.


## 11. Tecnologias Utilizadas (sugestão)

- Backend: ASP.NET Core MVC, Entity Framework Core
- Frontend: HTML5, CSS3, JavaScript, Bootstrap
- Banco de Dados: SQL Server / PostgreSQL
- Controle de Versão: Git
- Testes: xUnit / NUnit
- Documentação da API: Swagger/OpenAPI
- Containerização: Docker (opcional)


## 12. Como Rodar o Projeto

1. Clonar o repositório:

   ```bash
   git clone https://github.com/profAndreSouza/Ecommerce.git
   cd ecommerce
   ```

2. Configurar variáveis de ambiente (exemplo `.env`).

3. Restaurar pacotes e construir o projeto:

   ```bash
   dotnet restore
   dotnet build
   ```

4. Aplicar migrations e atualizar banco:

   ```bash
   dotnet ef database update
   ```

5. Executar o projeto:

   ```bash
   dotnet run
   ```

6. Acessar `https://localhost:5001` no navegador.


## 13. Como Contribuir

* Fork do repositório.
* Criar branch com a feature ou correção: `git checkout -b minha-feature`.
* Commitar suas mudanças: `git commit -m "Descrição da feature"`.
* Enviar pull request.
* Garantir que todos os testes estejam passando.


## 14. Licença

Este projeto está licenciado sob a [MIT License](LICENSE).

## Observações para o Product Owner (P.O.)

* Priorizar histórias pequenas, claras e testáveis.
* Definir critérios de aceitação objetivos para cada história.
* Usar protótipos e wireframes para alinhamento antes da implementação.
* Registrar todas as decisões importantes sobre arquitetura, segurança e tecnologias escolhidas.
* Manter a comunicação contínua com a equipe de desenvolvimento.


# Obrigado por acompanhar o projeto E-Shop!