1.Para o desenvolvimento do projeto, utilizei dois princípios do SOLID:

	Princípio da Responsabilidade Única (Single Responsibility Principle - SRP):
	
	Este princípio afirma que uma classe deve ter apenas uma única responsabilidade ou motivo para mudar. Em outras palavras, cada classe deve ser responsável por uma única parte da funcionalidade fornecida pelo software.
	A aplicação deste princípio ajuda a manter o código mais organizado, facilitando a manutenção e evolução do sistema ao longo do tempo.
	Princípio da Inversão de Dependência (Dependency Inversion Principle - DIP):
	
	Este princípio sugere que módulos de alto nível não devem depender de módulos de baixo nível, mas ambos devem depender de abstrações. Além disso, as abstrações não devem depender de detalhes, mas os detalhes devem depender das abstrações.
	A adoção do DIP melhora a flexibilidade e a testabilidade do código, uma vez que reduz o acoplamento entre componentes e promove a injeção de dependências.
	Escolhi esses dois princípios porque são os que estou mais familiarizado e utilizo frequentemente no meu dia a dia no trabalho. A aplicação consistente desses princípios tem demonstrado ser eficaz na criação de código robusto e sustentável.

2.Para futuras melhorias no projeto, proponho duas mudanças importantes:

	Substituição do banco de dados por um banco não relacional na nuvem:
	
	Considerando a escalabilidade e a flexibilidade, um banco de dados não relacional (NoSQL) na nuvem pode ser mais adequado. Bancos de dados NoSQL, como MongoDB ou Cassandra, são projetados para lidar com grandes volumes de dados e oferecem maior velocidade e eficiência em certas operações, especialmente em cenários de alta disponibilidade e escalabilidade horizontal.
	Troca do ORM de Entity Framework para Linq2Db:
	
	O Linq2Db é uma biblioteca leve e de alto desempenho para acesso a dados. Ao substituir o Entity Framework pelo Linq2Db, podemos obter uma melhoria significativa em termos de velocidade e eficiência nas operações de banco de dados, o que é essencial para aplicações que demandam alta performance.

3.Para instanciar o novo banco de dados:

	Basta substituir a string de conexão (ConnectionStrings) presente no arquivo appsettings.json. Esta alteração permitirá que a aplicação se conecte ao novo banco de dados de maneira transparente, sem a necessidade de modificações adicionais no código.