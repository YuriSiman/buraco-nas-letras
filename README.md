<h1 align="center">Buraco nas Letras</h1>

<p align="center">Projeto Buraco nas Letras implementado para teste da HMB Tecnologia.</p>

---

### :dart: Objetivo

Eu decidi fazer um projeto distribuído entre camadas, sendo que a Web Api e o Web App utilizam as validações para o número de buracos no texto que constam na Console Application, com isso, elas possuem uma referência direta com a aplicação em console.

O projeto consiste em aplicações desenvolvidas em .NET 5:

- Console Application
- ASP.NET Core Web Api
- ASP.NET Core Web App (Model-View-Controller)
- Class Library (Camada Business e Data)

Utilizei boas práticas de programação como Injeção de Dependências, arquitetura distribuída, classes e métodos com responsabilidades 
únicas, código desacoplado e de fácil manutenção. Utilizei Design Patterns como o Repository, para que eu não precisasse de chamar meu 
contexto direto na controller.

Aplicação Web MVC que solicita ao usuário o texto e em seguida mostra o mesmo na tela, assim como as demais informações solicitadas. Para a parte seguinte implementei a persistência de dados com o EntityFramework, utilizando um contexto de dados e mapeando a entidade com Fluent API. Implementei uma chamada para um banco de dados local utilizando Sql Server e gerei Migrations para o versionamento do banco. Com isso, eu consigo mostrar os textos inseridos na tela do usuário. Para a última implementação (Web Service REST) criei uma API para executar um método POST passando apenas o texto e retornando um JSON com as informações solicitadas. Documentei a API com o Swagger para fácil visualização e execução do mesmo.

### Clone

Clone este repositório em sua máquina local usando:

```
git clone https://github.com/YuriSiman/buraco-nas-letras.git
```

### :dart: Teste

Se você pensar em um papel como um plano e uma letra como uma marcação neste plano, então estas letras dividem o plano em regiões. Por exemplo, as letras “A”, “D” e “O” dividem o plano em 2 pois possuem um espaço confinado em seu desenho, ou um “buraco”. Outras letras como B possuem 2 buracos e letras como “C” e “E” não possuem buracos.

Deste modo podemos considerar que o número de buracos em um texto é igual à soma dos buracos nas palavras dele.

### Console Application

Desenvolva um programa que dado um texto qualquer, retorne a quantidade de buracos nele.

Requisitos da Missão:

- A solução deve ser escrita em C#

- A solução deve conter um projeto Console que receba um texto qualquer e imprima:
  - Texto inserido
  - Tamanho do texto
  - Total de palavras
  - Total de buracos no texto
  
- Considere que não haverá acentuação nas palavras

- Lembre-se de considerar letras maiúsculas, minúsculas e números


### Aplicação Web

Crie uma aplicação Web básica que utilize o código da missão principal. O usuário deve ser capaz de:

- Inserir um texto qualquer
- Visualizar o tamanho do texto
- Visualizar o total de palavras no texto
- Visualizar o total de buracos no texto


### API REST

Crie uma API REST simples, com um único método que utilize o código da missão principal. Ele deve receber um texto qualquer através de uma requisição POST e retornar um JSON no formato abaixo:

```
{  
   "texto":"TEXTO ENVIADO NA REQUISICAO",
   "tamanho": 27,
   "totalDePalavras": 4,
   "totalDeBuracos": 8
}
```

---

## :thinking: Contribuindo

> Para começar...

### Passo 1

* :fork_and_knife: Fork este repositório!

### Passo 2

* :dancers: Clone este repositório para sua máquina local usando `git clone https://github.com/YuriSiman/buraco-nas-letras.git`

### Passo 3

* :trident: Crie sua feature branch usando `git checkout -b minha-feature`

### Passo 4

* :white_check_mark: Commit suas mudanças usando `git commit -m "feat: Minha nova feature"`

### Passo 5

* :pushpin: Dê um push usando `git push -u origin minha-feature`

### Passo 6

* :arrows_clockwise: Crie um novo pull request

Depois que seu pull request for mesclado, você pode excluir sua feature branch  

> Caso tenha dúvidas, confira este guia de como [contribuir no GitHub](https://github.com/firstcontributions/first-contributions)  

---

## :speech_balloon: Suporte

> Entre em contato comigo...  

* Me chame pelo [Linkedin](https://www.linkedin.com/in/yurisiman/)  
* Me mande um e-mail [contato@yurisiman.com.br](mailto:contato@yurisiman.com.br)  

[![Github](https://img.shields.io/badge/github-profile-%237159c1?style=for-the-badge&logo=github)](https://github.com/YuriSiman)  
[![Curriculum](https://img.shields.io/badge/site-curriculum-%23563D7C?style=for-the-badge&logo=bootstrap)](https://yurisiman.com.br)  

---

## :pencil: Licença

[![License](https://img.shields.io/badge/license-mit-%23A6CE39?style=for-the-badge&logo=github)](https://github.com/YuriSiman/buraco-nas-letras/blob/master/LICENSE)   

---

Code your life...
