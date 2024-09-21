using System;
using System.Reflection;

// Inicializa o número de exames
int exam = 5;

// Inicializa as variáveis para armazenar as somas das notas dos alunos
decimal sophiaScore = 0;
decimal andrewScore = 0;
decimal emmaScore = 0;
decimal loganScore = 0;

// Declaração dos nomes dos alunos
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

// Declaração das notas de cada aluno
int[] sophia = new int[] { 90, 86, 87, 98, 100 };
int[] andrew = new int[] { 92, 89, 81, 96, 90 };
int[] emma = new int[] { 90, 85, 87, 98, 68 };
int[] logan = new int[] { 90, 95, 87, 88, 96 };

// armazenar as médias finais dos alunos
decimal[] totalScore = new decimal[4];

// Calcula as somas das notas e as médias
foreach (string i in studentNames) {
    if (i == "Sophia") {
        foreach (int n in sophia) {
            sophiaScore += n;
            totalScore[0] = (decimal)sophiaScore / exam; // Calcula média
        }
    }
    else if (i == "Andrew") {
        foreach (int n in andrew) {
            andrewScore += n;
            totalScore[1] = (decimal)andrewScore / exam; // Calcula média
        }
    }
    else if (i == "Emma") {
        foreach (int n in emma) {
            emmaScore += n;
            totalScore[2] = (decimal)emmaScore / exam; // Calcula média
        }
    }
    else if (i == "Logan") {
        foreach (int n in logan) {
            loganScore += n;
            totalScore[3] = (decimal)loganScore / exam; // Calcula média
        }
    }
}

// Impressão do cabeçalho
Console.WriteLine("Student         Grade");
Console.WriteLine("");

// Impressão das médias e notas finais dos alunos
foreach (string n in studentNames) {
    int index = Array.IndexOf(studentNames, n);
    
    // Exibe o nome do aluno e sua média formatada
    Console.Write($"{n}\t\t{totalScore[index]:F1}\t");
    
    // Determina a nota correspondente com base na média
    if (totalScore[index] >= 97)
        Console.WriteLine("A+");
    else if (totalScore[index] >= 93 && totalScore[index] < 97)
        Console.WriteLine("A");
    else if (totalScore[index] >= 90 && totalScore[index] < 93)
        Console.WriteLine("A-");
    else if (totalScore[index] >= 87 && totalScore[index] < 90)
        Console.WriteLine("B+");
    else if (totalScore[index] >= 83 && totalScore[index] < 87)
        Console.WriteLine("B");
    else if (totalScore[index] >= 80 && totalScore[index] < 83)
        Console.WriteLine("B-");
    else if (totalScore[index] >= 77 && totalScore[index] < 80)
        Console.WriteLine("C+");
    else if (totalScore[index] >= 73 && totalScore[index] < 77)
        Console.WriteLine("C");
    else if (totalScore[index] >= 70 && totalScore[index] < 73)
        Console.WriteLine("C-");
    else if (totalScore[index] >= 67 && totalScore[index] < 70)
        Console.WriteLine("D+");
    else
        Console.WriteLine("F");
}

// Mensagem para continuar
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
