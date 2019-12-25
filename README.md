# ChangeManager

Aplicação desenvolvida como parte da analise curricular para o processo de contratação da compuletra. 

Desenvolver uma aplicação que deve atender aos requisitos abaixo:

 
Requisitos Técnicos:

1.  Desenvolvimento com C#

2.  Deve ter algum tipo de interface para tanto vizualização como inputar dados

3.  De preferência, subir em seu GitHub e disponibilizar o link. Caso não seja possível, enviar o projeto (.zip ou .rar) por e-mail ou link do Google Drive para download.

4.  Demais Requisitos Técnicos estão livres para sua escolha.

 

 

Requisitos de Negócio:

1.  Máquina de Troco

  a.  Nossos usuários precisam de uma aplicação para calcular a quantidade de moedas para o troco de suas compras

  b.  Deve haver uma opção de abastecimento de moedas no caixa com valor e quantidade de cada uma.

    i.  Será a única forma de alimentar o caixa com moedas

    ii. O caixa inicia zerado

    iii.  A cada novo abastecimento as novas quantidades de moedas devem ser somadas as anteriores

    iv. Deve ser informado o valor da moeda e quantidades.

  c.  Deve haver uma opção para sangria de moedas do caixa.

    i.  A sangria será feita por quantidade de moedas de cada valor

    ii. Não pode haver caixa negativo

  d.  Deve haver uma opção para geração de trocos

    i.  Ao gerar novo troco as quantidades de moedas saem do caixa

    ii. Deve gerar o troco baseado na menor quantidade de moedas possível

    iii.  Caso falte moeda deve exibir uma mensagem e bloquear a operação.

  e.  Deve ter persistência de dados
  
  
  Aplicação desenvolvida em c\# usando aps.net mvc como frontend. Foi usado mysql como banco de dados principal e migration para realzar a constução do banco de dados. 
