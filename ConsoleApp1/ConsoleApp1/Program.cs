Banco banco = new Banco();
Cliente mario = new Cliente();
mario.cpf = "12345678910";

banco.CriarConta(mario.cpf);
mario.Depositar(50, banco);
mario.Sacar(20, banco);
mario.Sacar(1000000, banco);