# Projeto de Estudo de Clean Architecture com C#, .NET, e Princípios de MVC, Padrão Repository, CQRS, DDD, Injeção de Dependência e Inversão de Dependência (Curso Clean Architecture Fundamentos - Prof. Macoratti)

## Descrição
Este projeto é uma solução em C# no ambiente .NET que foi desenvolvida com o objetivo de estudar e aplicar os principais conceitos da Clean Architecture, bem como integrar diversos outros padrões e princípios de design de software. A Clean Architecture promove a construção de sistemas bem estruturados e altamente testáveis, garantindo a separação de preocupações e a manutenibilidade do código.

### Principais Conceitos e Padrões
- **Clean Architecture**: A arquitetura é organizada em camadas concêntricas, com uma ênfase na independência das camadas e na separação das responsabilidades. As camadas são: `Domain`, `Application`, `Infraestructure`, e `WebUI`.

- **MVC (Model-View-Controller)**: A camada de apresentação segue o padrão MVC, onde o `Model` representa os dados e a lógica de negócios, a `View` é responsável pela apresentação e a `Controller` lida com a interação do usuário.

- **Padrão Repository**: A camada `Persistence` utiliza o padrão Repository para abstrair o acesso aos dados e promover a separação das operações de persistência.

- **CQRS (Command Query Responsibility Segregation)**: A aplicação adota o princípio de CQRS, que separa as operações de leitura (Query) das operações de escrita (Command), para otimização e escalabilidade.

- **DDD (Domain-Driven Design)**: O projeto segue os princípios do DDD, com uma clara separação das entidades de domínio, agregados, e serviços de aplicação.

- **Injeção de Dependência e Inversão de Dependência**: A inversão de dependência é implementada para permitir a injeção de dependências em todo o projeto, facilitando a troca de implementações e testabilidade.

## Estrutura do Projeto
A estrutura do projeto segue a organização da Clean Architecture:

- **Domain**: A camada de domínio que contém as entidades, agregados e regras de negócio.

- **Application**: A camada de aplicação que lida com casos de uso e contém serviços de aplicação.

- **Infraestructure**: A camada de persistência que cuida do acesso a bancos de dados ou outras formas de armazenamento de dados.

- **WebUI**: A camada de apresentação, onde a interação com o usuário é tratada.

## Requisitos
- Visual Studio 2019 ou superior
- .NET 5.0 ou superior

## Configuração
1. Clone este repositório em seu ambiente de desenvolvimento.
2. Abra a solução no Visual Studio.
3. Certifique-se de que a camada `Infraestructure` esteja configurada corretamente para se conectar ao seu banco de dados.
4. Execute o projeto da camada `WebUI`.

## Utilização
O projeto é um exemplo em branco, mas você pode adicionar suas próprias entidades, casos de uso e controladores para implementar sua lógica de negócios. Certifique-se de seguir os princípios da Clean Architecture, DDD e outros padrões discutidos neste projeto.

## Testes
O projeto inclui uma estrutura de testes, usando bibliotecas como xUnit e Moq. Você pode escrever testes para validar a funcionalidade do seu código e garantir a qualidade do software.

## Contribuição
Sinta-se à vontade para contribuir para este projeto. Você pode adicionar novas funcionalidades, corrigir bugs ou melhorar a estrutura do projeto. Siga as práticas de desenvolvimento de software e os padrões utilizados neste projeto.

## Autor
Jonathan de Carvalho Matos
carvalhomatos.jonathan@gmail.com

## Licença
None
