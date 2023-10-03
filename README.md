# Onion_Architecture
Apresentando a Onion Architecture
A Onion Architecture é um padrão de arquitetura que propõe que o software deve ser feito em camadas, cada camada com sua própria preocupação ou responsabilidade, e, foi proposta por Jeffrey Pallermo em seu site.

A regra de ouro da arquitetura é:  "Nada em um círculo interno pode saber absolutamente nada sobre algo em um círculo externo. Isso inclui métodos, classes, variáveis ou qualquer outra entidade de software nomeada."  Robert C. Martin

Obs:Essa regra também existe em outras arquiteturas semelhantes, como Arquitetura Limpa (Clean Architecture).

Esta regra depende da injeção de dependência para fazer sua abstração das camadas, para que você possa isolar suas regras de negócios de seu código de infraestrutura, como repositórios e views.
A Onion Architecture propõe três camadas diferentes:

    A Camada de Domínio (Domain Layer)
    A Camada de Aplicação (Application Layer)
    A Camada de infraestrutura (Infrastructure Layer)
