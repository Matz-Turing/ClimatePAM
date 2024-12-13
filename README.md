# Descrição da Funcionalidade do Código

<img src="https://user-images.githubusercontent.com/74038190/212284115-f47cd8ff-2ffb-4b04-b5bf-4d1c14c0247f.gif" width="1000">

Este código representa a implementação do **ViewModel** para a aplicação de previsão do tempo, utilizando o padrão **MVVM** (Model-View-ViewModel). Ele contém a lógica necessária para buscar e exibir as previsões climáticas de uma cidade específica.

## Principais Funcionalidades

### 1. **Propriedades Observáveis**
O ViewModel contém várias propriedades observáveis que armazenam informações sobre a previsão do tempo e a cidade pesquisada:

- **`cidade`**: Nome da cidade.
- **`estado`**: Estado onde a cidade está localizada.
- **`data`**: Data da previsão do tempo.
- **`condicao`**: Condição climática da cidade (ex: ensolarado, chuvoso, etc.).
- **`min`**: Temperatura mínima prevista para o dia.
- **`max`**: Temperatura máxima prevista para o dia.
- **`indice_uv`**: Índice UV da cidade.
- **`cidade_pesquisada`**: Nome da cidade que o usuário deseja pesquisar.
- **`id_pesquisado`**: ID da cidade que está sendo pesquisada.
- **`proximosDias`**: Lista com as previsões do tempo para os próximos dias.
- **`cidades`**: Lista de cidades retornadas pela busca.

### 2. **Comandos**
O ViewModel também contém dois comandos para buscar informações específicas:

- **`BuscarPrevisaoCommand`**: Comando que chama o método `BuscarPrevisao` para buscar a previsão do tempo para uma cidade específica.
- **`BuscarCidadesCommand`**: Comando que chama o método `BuscarCidades` para buscar cidades com base no nome fornecido.

### 3. **Métodos**
Os métodos principais do ViewModel são:

- **`BuscarPrevisao(int id)`**: Este método busca a previsão do tempo para a cidade identificada pelo `id`. Ele faz uma chamada assíncrona ao serviço `PrevisaoService` e preenche as propriedades do ViewModel com os dados recebidos, como a cidade, estado, temperatura mínima e máxima, condições climáticas e índice UV. Além disso, busca a previsão para os próximos dias e preenche a lista `proximosDias` com essas informações.

- **`BuscarCidades()`**: Este método busca cidades com base no nome fornecido pelo usuário (armazenado em `cidade_pesquisada`). Ele chama o serviço `CidadeService` e preenche a lista `cidades` com as cidades encontradas.

## Resumo
A aplicação permite ao usuário pesquisar o clima de uma cidade, exibindo informações detalhadas sobre a previsão do tempo atual, como temperatura, condições climáticas e índice UV. Além disso, ela oferece previsões para os próximos dias e a possibilidade de pesquisar cidades por nome.

## Créditos

Desenvolvido por Mateus S.  
GitHub: [Matz-Turing](https://github.com/Matz-Turing)
