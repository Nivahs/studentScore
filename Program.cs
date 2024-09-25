using System;

// Inicializa o número de exames 
int examAssignments = 5;  // número de exames

// Matriz de pontuação
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

// Matriz de nomes dos alunos
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// Matriz para armazenar as notas do aluno e em seguida somar no loop foreach
int[] studentScores = new int[10];

// Variável para atribuir uma letra, exemplo: A, B ou C
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("__________________________________");

// Loop foreach, percorre a matriz de estudantes
foreach (string name in studentNames)
{
    string currentStudent = name;

    // Atribui a matriz de pontuações correta com base no nome do aluno
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    // Inicializa a soma das notas das tarefas/exames
    int sumAssignmentScores = 0;

    // Inicializa a média atual do aluno
    decimal currentStudentGrade = 0;

    // Inicializa ou reseta o contador de tarefas avaliadas
    int gradedAssignments = 0;

    // Loop para somar as notas do aluno
    foreach (int score in studentScores)
    {
        // Incrementa o contador de tarefas/exames
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // Adiciona a pontuação do exame à soma
            sumAssignmentScores += score;
        else
            // Adiciona os pontos de crédito extra - bônus igual a 10% da pontuação do exame
            sumAssignmentScores += score / 10;
    }

    // Calcula a média do aluno
    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    // Atribui a letra correspondente à nota com base na média
    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    // Exibe o nome do aluno, a média e a letra correspondente à nota
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
