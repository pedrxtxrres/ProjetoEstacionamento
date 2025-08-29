# 🚗 Sistema de Estacionamento

Um sistema simples de gerenciamento de estacionamento desenvolvido em C# para iniciantes. Este projeto permite registrar veículos, listar os veículos estacionados e remover veículos calculando o valor final a ser pago.

## 📋 Funcionalidades

- ✅ **Registrar novo veículo**: Cadastra um veículo no estacionamento com placa
- ✅ **Listar veículos**: Exibe todos os veículos atualmente estacionados
- ✅ **Remover veículo**: Remove um veículo do estacionamento e calcula o valor final

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C#
- **Framework**: .NET Console Application
- **IDE Recomendada**: Visual Studio ou Visual Studio Code

## 📁 Estrutura do Projeto

```
SistemaEstacionamento/
├── Models/
│   └── Estacionamento.cs    # Classe com métodos do estacionamento
├── Program.cs               # Arquivo principal com menu
└── README.md
```

## 🚀 Como Executar

1. **Clone o repositório**:
   ```bash
   git clone https://github.com/pedrxtxrres/ProjetoEstacionamento
   cd ProjetoEstacionamento
   ```

2. **Compile e execute**:
   ```bash
   dotnet run
   ```

3. **Use o menu interativo** para navegar pelas opções disponíveis.

## 💡 Como Usar

## Primeiro ele abrirá os campos de valor fixo e valor variável para as horas de permanência.

### 💰 Cálculo de Preços

- **Preço inicial**: R$ 5
- **Preço por hora adicional**: R$ 2
- **Exemplo**: 4 horas = R$ 5,00 + (4 × R$ 2,00) = R$ 13,00

### Menu Principal
```
=== SISTEMA DE ESTACIONAMENTO ===
1. Registrar novo veículo
2. Listar veículos estacionados
3. Remover veículo
4. Sair
```

### 1. Registrar Veículo
- Digite a placa do veículo (formato: ABC-1234)

### 2. Listar Veículos
- Exibe todos os veículos

### 3. Remover Veículo
- Digite a placa do veículo a ser removido
- O sistema calcula automaticamente o valor a ser pago baseado nas horas informadas e remove o veículo da lista



## 🎯 Objetivos de Aprendizado

Este projeto foi desenvolvido para praticar:

- **Programação Orientada a Objetos** (Classes, Propriedades, Métodos)
- **Coleções** (Listas em C#)
- **Estruturas de Controle** (if/else, switch, loops)
- **Entrada e Saída no Console** (Console.WriteLine, Console.ReadLine)
- **Validação de Dados** (Formato de placa, dados obrigatórios)

## 🔧 Possíveis Melhorias

Para expandir seus conhecimentos, considere implementar:

- [ ] Persistência de dados (arquivo JSON/XML ou banco de dados)
- [ ] Diferentes tipos de veículos (carro, moto, caminhão) com preços distintos
- [ ] Sistema de desconto para permanência longa
- [ ] Relatórios de faturamento
- [ ] Interface gráfica (Windows Forms ou WPF)
- [ ] Validação mais robusta de placas
- [ ] Sistema de usuários e permissões

## 🤝 Contribuindo

1. Faça um Fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 👨‍💻 Autor

**Pedro Torres**
- GitHub: [pedrxtxrres](https://github.com/pedrxtxrres)
- LinkedIn: [Pedro Torres](https://www.linkedin.com/in/pedro-torres-15389a185/)

---

⭐ Se este projeto te ajudou, considere dar uma estrela no repositório!
