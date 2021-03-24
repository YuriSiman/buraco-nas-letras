Projeto Buraco nas Letras implementado para o teste da HMB Tecnologia.

O projeto consiste em aplicações desenvolvidas em .NET 5:

- Console Application
- ASP.NET Core Web Api
- ASP.NET Core Web App (Model-View-Controller)
- Class Library (Camada Business e Data)

Eu decidi fazer um projeto distribuído entre camadas, sendo que a Web Api e o Web App utilizam as validações para o número de 
buracos no texto que constam na Console Application, com isso, elas possuem uma referência direta com a aplicação em console.

A primeira prática (Missão Principal) foi executada exatamente conforme pedido no teste. Para a segunda parte (Aplicação Desktop) 
resolvi implementar um aplicação Web MVC para que eu pudesse solicitar ao usuário o texto e em seguida mostrar o mesmo na tela, assim 
como as demais informações solicitadas. Decidi implementar dessa forma pois não tenho muito conhecimento em aplicações para Desktop, venho estudando 
e mantendo o foco em aplicações Web. Para a parte seguinte (Leitura e Escrita de Arquivo) também achei melhor, conforme meus conhecimentos, 
em implementar uma persistência dos dados com o EntityFramework, utilizando um contexto de dados e mapeando a entidade com Fluent API. 
Implementei uma chamada para um banco de dados local utilizando Sql Server e gerei Migrations para o versionamento do banco. Com isso, 
eu consigo mostrar os textos inseridos na tela do usuário. Eu poderia ter implementar os demais métodos para exclusão, alteração... entre outros,
mas para simplificar, decidi apenas inserir e buscar os mesmos na base. Para a última implementação (Web Service REST) implementei 
exatamente conforme solicitado, criei uma API para executar um método POST passando apenas o texto e retornando um JSON com as informações 
solicitadas. Documentei a API com o Swagger para fácil visualização e execução do mesmo.

Utilizei boas práticas de programação como Injeção de Dependências, arquitetura distribuída, classes e métodos com responsabilidades 
únicas, código desacoplado e de fácil manutenção. Utilizei Design Patterns como o Repository, para que eu não precisasse de chamar meu 
contexto direto na controller.

Espero ter atendido às expectativas do teste e espero muito ter conseguido mostrar com minhas implementações que sou um desenvolvedor muito organizado 
e preocupado com padrõe de projetos, boas práticas de programação. 

Muito obrigado pela oportunidade! Muito ansioso por essa vaga! Abraços!

Yuri Siman Nogueira

Contatos:
contato@yurisiman.com.br
(31) 9 96658647


