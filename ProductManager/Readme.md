1.Para o desenvolvimento do projeto, utilizei dois princ�pios do SOLID:

	Princ�pio da Responsabilidade �nica (Single Responsibility Principle - SRP):
	
	Este princ�pio afirma que uma classe deve ter apenas uma �nica responsabilidade ou motivo para mudar. Em outras palavras, cada classe deve ser respons�vel por uma �nica parte da funcionalidade fornecida pelo software.
	A aplica��o deste princ�pio ajuda a manter o c�digo mais organizado, facilitando a manuten��o e evolu��o do sistema ao longo do tempo.
	Princ�pio da Invers�o de Depend�ncia (Dependency Inversion Principle - DIP):
	
	Este princ�pio sugere que m�dulos de alto n�vel n�o devem depender de m�dulos de baixo n�vel, mas ambos devem depender de abstra��es. Al�m disso, as abstra��es n�o devem depender de detalhes, mas os detalhes devem depender das abstra��es.
	A ado��o do DIP melhora a flexibilidade e a testabilidade do c�digo, uma vez que reduz o acoplamento entre componentes e promove a inje��o de depend�ncias.
	Escolhi esses dois princ�pios porque s�o os que estou mais familiarizado e utilizo frequentemente no meu dia a dia no trabalho. A aplica��o consistente desses princ�pios tem demonstrado ser eficaz na cria��o de c�digo robusto e sustent�vel.

2.Para futuras melhorias no projeto, proponho duas mudan�as importantes:

	Substitui��o do banco de dados por um banco n�o relacional na nuvem:
	
	Considerando a escalabilidade e a flexibilidade, um banco de dados n�o relacional (NoSQL) na nuvem pode ser mais adequado. Bancos de dados NoSQL, como MongoDB ou Cassandra, s�o projetados para lidar com grandes volumes de dados e oferecem maior velocidade e efici�ncia em certas opera��es, especialmente em cen�rios de alta disponibilidade e escalabilidade horizontal.
	Troca do ORM de Entity Framework para Linq2Db:
	
	O Linq2Db � uma biblioteca leve e de alto desempenho para acesso a dados. Ao substituir o Entity Framework pelo Linq2Db, podemos obter uma melhoria significativa em termos de velocidade e efici�ncia nas opera��es de banco de dados, o que � essencial para aplica��es que demandam alta performance.

3.Para instanciar o novo banco de dados:

	Basta substituir a string de conex�o (ConnectionStrings) presente no arquivo appsettings.json. Esta altera��o permitir� que a aplica��o se conecte ao novo banco de dados de maneira transparente, sem a necessidade de modifica��es adicionais no c�digo.