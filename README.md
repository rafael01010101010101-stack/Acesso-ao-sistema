# Sistema de Autenticação em C# com Persistência em MySQL 🔐

Este é o meu primeiro projeto prático focado na integração entre desenvolvimento de software e gerenciamento de banco de dados. A aplicação consiste em um sistema de controle de acesso (login e autenticação) via terminal, totalmente integrado a um banco de dados relacional.

O objetivo principal foi compreender como uma aplicação em C# (.NET) se conecta, envia comandos e manipula dados em um servidor de banco de dados real.

---

## 🚀 Recursos e Funcionalidades
- **Processamento de Autenticação:** Sistema interativo de login e validação de credenciais de usuários em tempo real.
- **Persistência de Dados Direta:** Comunicação ativa com o banco de dados para consulta e armazenamento seguro de informações.
- **Validação de Segurança:** Tratamento de entradas via console para garantir a integridade das queries executadas no banco.

## 🛠️ Arquitetura e Tecnologias Utilizadas
- **Linguagem de Programação:** C# (.NET) em ambiente de console application.
- **Banco de Dados Relacional:** MySQL para o armazenamento e estruturação dos dados dos usuários.
- **Driver de Conexão:** Utilização do Driver/Conector oficial do MySQL para estabelecer o canal de comunicação entre a aplicação e o servidor.

---

## 📈 Aprendizados Consolidados
Desenvolver este projeto foi um marco importante para conectar os estudos de desenvolvimento com os de infraestrutura, consolidando conceitos como:
1. **Strings de Conexão (Connection Strings):** Configuração de parâmetros de rede (IP, porta, usuário, senha e catálogo) para conectar o software ao banco.
2. **Execução de Comandos SQL via Código:** Implementação prática de instruções como `SELECT` e `INSERT` de dentro da lógica do C#.
3. **Manipulação de Ponteiros e Leitores de Dados:** Tratamento dos resultados retornados pelo banco de dados através da aplicação de terminal.
