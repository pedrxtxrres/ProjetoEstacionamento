# 🚗 Sistema de Estacionamento

Um sistema completo de gerenciamento de estacionamento desenvolvido em C# com funcionalidades avançadas de controle de entrada, saída e cobrança automática.

## Sobre o Projeto

Este sistema oferece uma solução completa para gerenciamento de estacionamentos, incluindo controle automático de tempo, cálculo de valores e histórico detalhado de movimentações.

## Funcionalidades

### Funcionalidades Principais
- ✅ **Entrada de Veículos**: Registro automático com data/hora de entrada
- ✅ **Cálculo Automático**: Valor calculado automaticamente baseado no tempo de permanência
- ✅ **Lista de Veículos Ativos**: Visualização em tempo real dos veículos no estacionamento
- ✅ **Busca no Histórico**: Consulta do histórico completo por veículo específico
- ✅ **Saída de Veículos**: Processo de saída com cobrança automática

### Recursos Avançados
- 🕒 Controle automático de horários (entrada/saída)
- 💰 Sistema de cobrança com valores configuráveis
- 📝 Histórico completo de movimentações
- 🔍 Sistema de busca por placa
- 📋 Relatórios de veículos em tempo real

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET Console Application
- **IDE Recomendada**: Visual Studio ou Visual Studio Code

## 📁 Estrutura do Projeto

```
ProjetoEstacionamento/
├── Models/
│   └── Estacionamento.cs    # Classe principal com lógica do sistema
├── Program.cs               # Arquivo principal com menu interativo
└── README.md               # Documentação do projeto
```

## Como Executar

### Pré-requisitos
- .NET SDK instalado
- Git (para clonar o repositório)

### Instalação

1. **Clone o repositório:**
```bash
git clone https://github.com/pedrxtxrres/ProjetoEstacionamento
cd ProjetoEstacionamento
```

2. **Compile e execute:**
```bash
dotnet run
```

3. **Use o menu interativo** para navegar pelas funcionalidades.

## 💰 Sistema de Cobrança

O sistema utiliza uma tabela de preços fixa:

- **Preço inicial**: R$ 5,00 (primeira hora ou fração)
- **Preço por hora adicional**: R$ 2,00

### Exemplo de Cálculo
- **4 horas**: R$ 5,00 + (3 × R$ 2,00) = **R$ 11,00**
- **1 hora e 30 min**: R$ 5,00 + (1 × R$ 2,00) = **R$ 7,00**

## 🖥️ Interface do Sistema

```
=== SISTEMA DE ESTACIONAMENTO ===
1. Cadastrar entrada de veículo
2. Listas veículos em aberto
3. Listas histórico por placa
4. Cadastrar saída de veículo
5. Sair
```

### 📝 Fluxo de Uso

1. **Cadastrar entrada de veículo**
   - Digite a placa do veículo (formato: ABC-1234)
   - Digite o dia e hora que o veículo entrou(dd/MM/yyyy HH:mm)

2. **Listas veículos em aberto**
   - Exibe todos os veículos atualmente no estacionamento
   - Mostra placa e horário de entrada

3. **Buscar Histórico**
   - Digite a placa para consultar histórico completo
   - Visualiza todas as movimentações anteriores do veículo

4. **Saída de Veículo**
   - Digite a placa do veículo
   - Digite o dia e hora que o veículo vai sair(dd/MM/yyyy HH:mm)
   - Sistema calcula automaticamente o valor baseado no tempo de permanência
   - Remove o veículo da lista ativa


## 🎯 Objetivos de Aprendizado

Este projeto foi desenvolvido para praticar conceitos fundamentais de programação:

- **Programação Orientada a Objetos**: Classes, Propriedades, Métodos
- **Coleções**: Manipulação de Listas em C#
- **Estruturas de Controle**: if/else, switch, loops
- **Entrada/Saída**: Console.WriteLine, Console.ReadLine
- **Validação de Dados**: Formato de placa, validações de entrada
- **Manipulação de Data/Hora**: DateTime para controle de tempo
- **Cálculos Automáticos**: Lógica de cobrança por tempo

## 🔮 Próximas Melhorias

Considere implementar estas funcionalidades para expandir o projeto:

- 💾 **Persistência de dados** (JSON, XML ou banco de dados)
- 🚙 **Tipos de veículos** (carro, moto, caminhão) com preços diferenciados
- 🎟️ **Sistema de desconto** para permanência longa
- 📊 **Relatórios de faturamento** diário/mensal
- 🖼️ **Interface gráfica** (Windows Forms ou WPF)
- 🔒 **Validação robusta** de placas (Mercosul, antiga)
- 👥 **Sistema de usuários** e permissões
- 🏷️ **Tickets de estacionamento** com código de barras

## 🤝 Como Contribuir

1. Faça um Fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/NovaFuncionalidade`)
3. Commit suas mudanças (`git commit -m 'Adiciona nova funcionalidade'`)
4. Push para a branch (`git push origin feature/NovaFuncionalidade`)
5. Abra um Pull Request

## 👨‍💻 Autor

**Pedro Torres**
- GitHub: [@pedrxtxrres](https://github.com/pedrxtxrres)
- LinkedIn: [Pedro Torres](https://www.linkedin.com/in/pedro-torres-15389a185/)

---

⭐ **Se este projeto te ajudou, considere dar uma estrela no repositório!**

## 📄 Licença

Este projeto é de código aberto e está disponível para fins educacionais.