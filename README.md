# AspNetCore_PagesRazor
Páginas Web utilizado o Razor

Aplicativo Web com :

Busca simples e integrada,

Atualização automatica do Banco de Dados, caso sejam deletadas as linhas, ressalto que os dados atualizados, serão os que estao na Classe SeedData,

Validaçao dos Campos.

Para rodar a aplicação precisa instalar no  PMC, conforme abaixo:
Install-Package Microsoft.EntityFrameworkCore.SqlServer
E executar os comandos abaixo:
Add-Migration InitialCreate and
Update-Databas
