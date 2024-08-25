# A) A partir dos dados é possível concluir que o perceptron de camada simples funciona? Justifique sua resposta.
## Resposta: 
### O perceptron de camada simples funciona bem apenas se os dados forem linearmente separáveis. Isso significa que, se for possível traçar uma linha reta que separe as duas classes (por exemplo, laranjas e maçãs), o perceptron conseguirá aprender a fazer essa distinção corretamente após o treinamento.
### Se os dados forem linearmente separáveis: O perceptron simples conseguirá aprender a separar as classes corretamente, ajustando os pesos durante o treinamento.
### Se os dados não forem linearmente separáveis: O perceptron simples não conseguirá classificar os dados corretamente, porque ele não consegue lidar com padrões complexos que exigem uma separação não linear.
### Em resumo, se os dados podem ser separados por uma linha reta, o perceptron funciona. Se não podem, ele falhará.
# B) Usando a planilha que fizemos na aula ao vivo, faça os cálculos passando por cada etapa das 6 de treinamento.
## Resposta: 
### Feito via Excel
# C) Implementação do Algoritmo:
## Resposta:
### Feito via C#
# D) Descreva porque devemos fazer muitos treinamentos para ter uma melhor RNA em problemas complexos.
## Resposta: 
### Em problemas complexos, onde há uma grande variação nas características dos dados, é necessário um número maior de iterações de treinamento para que a RNA consiga aprender e generalizar adequadamente. O treinamento contínuo permite que a rede ajuste seus pesos de forma a reduzir o erro e melhorar a precisão na classificação. Mais treinos permitem que a RNA capture padrões complexos e responda de maneira mais robusta a novas entradas.
