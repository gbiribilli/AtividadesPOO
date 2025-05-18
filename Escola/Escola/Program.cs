Aluno aluno1 = new Aluno("Biri", "10113");
Aluno aluno2 = new Aluno("Biribilli", "10113");

Exatas exatas = new Exatas();

aluno1.matricular(exatas);
aluno2.matricular(exatas);

exatas.CalcularNotas();
exatas.ListarNotas();
