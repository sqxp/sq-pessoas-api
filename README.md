# sq-pessoas-api
### Api GraphQl de pessoas para uso em provas de seleção da Squadra.
* Quando a API sobe ela cria um playground que pode ser utilizado para testar as consultas
  * Path do playground na API: **/ui/playground**
* Obs: A Api expõe atualmente apenas um método de consulta que sana as necessidades da prova atual.
## Documentação
1.Listar pessoas
  * Este método lista todas as pessoas existentes no storage da api.
```graphql
query{
  pessoas{
    id,
    nome,
    dataNascimento,
    regiao,
    pontuacao
  }
}
```
