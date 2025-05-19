using Estudoprova;
Hospital hospital = new Hospital();

Paciente p1 = new Internado("João", 45, "Ortopedia", 102);
Paciente p2 = new Ambulatorial("Maria", 30, "Dermatologia");
Paciente p3 = new Emergencia("Carlos", 60, "Infarto", true);
Paciente p4 = new Emergencia("Carlos", 60, "Infarto", true);

hospital.AdmitirPaciente(p1);
hospital.AdmitirPaciente(p2);
hospital.AdmitirPaciente(p3);
hospital.AdmitirPaciente(p4);

List<Paciente> pacientesCarlos = hospital.BuscarPaciente("Carlos");
Console.WriteLine("Pacientes chamados Carlos: " + pacientesCarlos.Count);

List<Paciente> pacientesInfartoGrave = hospital.BuscarPaciente("Infarto", true);
Console.WriteLine("Pacientes com infarto grave: " + pacientesInfartoGrave.Count);

hospital.DarAlta(p4);
hospital.DarAlta(p2);

hospital.Descrever();