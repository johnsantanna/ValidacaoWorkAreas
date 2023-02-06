# Projeto C# em FORMS para validação de planilha Excel

Este é um pequeno projeto criado por mim para validação dos campos de uma planilha Excel.
Neste projeto utilizei boa partes dos conceitos de programação C# aprendidos no cursos até o momento deste projeto.

Tela inicial do programa<BR>
![image](https://user-images.githubusercontent.com/52610303/217041354-bca7e017-d735-48c6-ab80-441718617c9b.png)

Os passos programados neste projeto foram:

  1. Iniciar o programa executavel utilizando `Windows Forms`
  2. Selecionar o arquivo para validar utilando uma `dialog-box`
  3. Clicar no botão "VALIDAR"
    - Neste momento será realizado uma validação do layout da planilha, formato do arquivo etc.. Em caso positivo, proximo passo...
    - Caso negativo, o programa irá informar o usuário através de uma `msg-box` e irá reiniciar o formulário.
  4. Apos clicar no botão validar, será realizado em backgroud a validação de todos os campos da planilha, e por fim será gerado um arquivo xls com os campos validados
    - Validação OK, será informado via `msg-box` que a planilha não possui erros de validação do layout.
    - Validação NOK, serão pintados com a cor amarelo as celulas com inconsistencias e o cabeçalho referente a celula em questão terá a cor vermelho.
    
Obs: após a validação, o arquivo original não sofrerá alterações, foi foi aberto como somente leitura.
