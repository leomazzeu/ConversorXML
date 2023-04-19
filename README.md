## Conversor de XML
O objetivo desse script foi para resolver uma demanda de trabalho. No cenário estávamos com um cliente que havia trocado seu sistema de nota fiscal e ao perder acesso ao antigo sistema, não conseguia mais exportar as notas em XML. Dessa forma foi necessário fazer a exportação do banco de dados onde retornou várias linhas com o código XML em formato de string.

O script basicamente pega essas informações do banco e cria uma arquivo XML para cada nota, sendo assim possível enviar as notas para a contabilidade da maneira correta.

Ao ser executado o script armazena em uma lista todas as informações do banco e em seguida faz uma varredura nessa lista criando um arquivo para cada item, no final temos o arquivo XML completo.
