# Onion_Architecture
Apresentando a Onion Architecture
A Onion Architecture é um padrão de arquitetura que propõe que o software deve ser feito em camadas, cada camada com sua própria preocupação ou responsabilidade, e, foi proposta por Jeffrey Pallermo em seu site.

A regra de ouro da arquitetura é:  "Nada em um círculo interno pode saber absolutamente nada sobre algo em um círculo externo. Isso inclui métodos, classes, variáveis ou qualquer outra entidade de software nomeada."  Robert C. Martin

Obs:Essa regra também existe em outras arquiteturas semelhantes, como Arquitetura Limpa (Clean Architecture).

Esta regra depende da injeção de dependência para fazer sua abstração das camadas, para que você possa isolar suas regras de negócios de seu código de infraestrutura, como repositórios e views.

 As camadas de arquitetura de cebola

A Onion Architecture usa o conceito de camadas, mas são diferentes das camadas da arquitetura de três e n-camadas. Vamos ver o que cada uma dessas camadas representa e o que deve conter.

1- Camada de Domínio (a camada mais interna)

A camada de domínio reside na parte central da arquitetura Onion, e representa os objetos de negócios e o comportamento. A idéia é ter todos os seus objetos de domínio nesse núcleo. Ele contém todos os objetos de domínio do aplicativo. Além dos objetos de domínio, você também pode ter interfaces de domínio. Essas entidades de domínio não têm dependências. Objetos de domínio também são simples como deveriam ser, sem nenhum código pesado ou dependências. (Se um aplicativo for desenvolvido usando um ORM como o Entity Framework,  essa camada conterá classes POCO.)

2- Camada de Repositório (Repository Layer)

Essa camada cria uma abstração entre as entidades do domínio e a lógica de negócios do aplicativo. Nesta camada, geralmente adicionamos interfaces que fornecem o comportamento de salvar e recuperar objetos, geralmente envolvendo um banco de dados. Essa camada consiste no padrão de acesso a dados, que é uma abordagem mais fracamente acoplada ao acesso a dados. Também criamos um repositório genérico e adicionamos consultas para recuperar dados da fonte, mapear os dados da fonte de dados para uma entidade comercial e persistir alterações na entidade comercial na fonte de dados.

3- Camada de Serviços (Service Layer)

A camada de serviços mantém interfaces com operações comuns, como Adicionar, Salvar, Editar e Excluir. Além disso, essa camada é usada para se comunicar com a camada da interface do usuário e a camada do repositório. A camada de serviço também pode conter lógica de negócios para uma entidade. Nesta camada, as interfaces de serviço são mantidas separadas de sua implementação, tendo em mente o acoplamento e a separação de responsabilidades.

4- Camada de Interface do Usuário (UI Layer)

É a camada mais externa e mantém responsabilidades periféricas como interface do usuário e testes. Pode ser uma aplicação Web, uma API, um projeto de Testes, etc. Essa camada possui uma implementação do padrão da injeção de dependência, para que o aplicativo construa uma estrutura fracamente acoplada e possa se comunicar com a camada interna por meio de interfaces.
