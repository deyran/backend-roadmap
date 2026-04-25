# The MVVM Partten
## ViewModel - MP

### Responsabilidades Principais

- Coordenação: Atua como mediadora entre a View e o Model.
- Preparação de Dados: Converte dados do Model em formatos que a View consome facilmente.
- Define funcionalidade: Implementa propriedades e comandos (Commands) que definem o que a UI pode fazer.
- Pode expor classes Model para o View se model suportar Data Binding.

# CH03 Model-View-ViewModel MVVM
## The MVVM Partten
### ViewModel
#### Comunicação e Data Binding

- Propriedades e Comandos: Elementos fundamentais aos quais a View se conecta.
- Notificação de Mudanças

	- INotifyPropertyChanged
	- PropertyChanged: Atualiza View em tempo real.
	- ObservableCollection<T>: Mudanças em lista.

* **Coleções:** Uso de `ObservableCollection<T>` para notificar mudanças em listas sem esforço manual.





# CH03 Model-View-ViewModel MVVM
## The MVVM Partten
### ViewModel

### 3. Performance e UX
* **Operações Assíncronas:** Uso de métodos assíncronos para operações de I/O para manter a UI responsiva.
* **Notificações Assíncronas:** Disparo de eventos para notificar a View sobre mudanças de estado sem travar a thread principal.






# CH03 Model-View-ViewModel MVVM
## The MVVM Partten
### ViewModel

### 4. Camada de Conversão
* **Conversão Interna:** Realizada na própria ViewModel (ex: combinar dois campos de texto).
* **Conversores Externos (Value Converters):** Camada separada entre View e ViewModel para formatações específicas que não pertencem à lógica de negócio da ViewModel.